using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    class WorkingWithDB
    {
        private SQLiteConnection db;
        SQLiteDataReader reader;
        SQLiteCommand command;

        private int user_id;

        private XORCipher c;

        public WorkingWithDB(int user_id)
        {
            db = new SQLiteConnection("Data Source = MyDB.db;New = False");
            db.Open();
            this.user_id = user_id;
            c = new();
        }

        public void AddData(DataStructure data)
        {
            //todo проверить на уникальность десрипшона if checkdescconstraint
            string Key = GenerateEncryptKey();


            //command = new SQLiteCommand(
            //    "insert into Data(Data_id,user_id,Login,Password,EncryptKey,Description) values " +
            //    "(@Data_id,@user_id,@Login,@Password,@EncryptKey,@Description)", db);
            try
            {
                using (SQLiteConnection myconnection = new SQLiteConnection(@"Data Source = MyDB.db"))
                {
                    myconnection.Open();
                    using (SQLiteTransaction mytransaction = myconnection.BeginTransaction())
                    {
                        using (SQLiteCommand mycommand = new SQLiteCommand(myconnection))
                        {
                            mycommand.CommandText = "insert into Data(Data_id,user_id,Login,Password,EncryptKey,Description) values " +
                                                    "(@Data_id,@user_id,@Login,@Password,@EncryptKey,@Description)";
                            mycommand.Parameters.AddWithValue("@Data_id", null);
                            mycommand.Parameters.AddWithValue("@user_id", user_id);
                            mycommand.Parameters.AddWithValue("@Login", c.Encrypt(data.Login, Key));
                            mycommand.Parameters.AddWithValue("@Password", c.Encrypt(data.Password, Key));
                            mycommand.Parameters.AddWithValue("@EncryptKey", Key);
                            mycommand.Parameters.AddWithValue("@Description", c.Encrypt(data.Description, Key));
                            mycommand.ExecuteNonQuery();
                        }

                        mytransaction.Commit();
                    }
                }
            }
            catch(SQLiteException ex)
            {

            }


        }

        public void EditData(DataStructure data)
        {
            string Key = GenerateEncryptKey();
            command = new SQLiteCommand($"update Data set Login = '{c.Encrypt(data.Login, Key)}' where Data_id = {data.Data_id}", db);
            command.ExecuteNonQuery();
            command = new SQLiteCommand($"update Data set Password = '{c.Encrypt(data.Password, Key)}' where Data_id = {data.Data_id}", db);
            command.ExecuteNonQuery();
            command = new SQLiteCommand($"update Data set Description = '{ c.Encrypt(data.Description, Key)}' where Data_id = {data.Data_id}", db);
            command.ExecuteNonQuery();
            command = new SQLiteCommand($"update Data set EncryptKey = '{Key}' where Data_id = {data.Data_id}", db);
            command.ExecuteNonQuery();
        }

        public List<string[]> GetEncryptedDataData()
        {
            List<string[]> arr = new();
            command = new SQLiteCommand($"select Data_id, Login,Password,Description,EncryptKey from Data where user_id = {user_id}", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                string[] tmp =
                {
                    el["Data_id"].ToString(),
                    el["Login"].ToString(),
                    el["Password"].ToString(),
                    el["Description"].ToString()
                };
                arr.Add(tmp);
            }

            return arr;
        }

        public List<string[]> GetData()
        {

            List<string[]> arr = new();

            command = new SQLiteCommand($"select Data_id, Login,Password,Description,EncryptKey from Data where user_id = {user_id}", db);
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow el in dt.Rows)
            {
                if (el is not null)
                {
                    string[] tmp =
                    {
                        el["Data_id"].ToString(),
                        c.Decrypt(el["Login"].ToString(),el["EncryptKey"].ToString()),
                        c.Decrypt(el["Password"].ToString(),el["EncryptKey"].ToString()),
                        c.Decrypt(el["Description"].ToString(),el["EncryptKey"].ToString())
                    };
                    arr.Add(tmp);
                }
            }

            return arr;

        }

        public void DeleteData(DataStructure data)
        {
            command = new SQLiteCommand($"delete from Data where Data_id = {data.Data_id}", db);
            reader = command.ExecuteReader();
            command.Dispose();

        }

        private string GenerateEncryptKey()
        {
            Random rnd = new();
            return rnd.Next(1000).ToString();
        }

        public int GetPassAmount()
        {
            command = new SQLiteCommand($"select count(user_id) from Data group by user_id having user_id = {user_id}", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                return int.Parse(el["count(user_id)"].ToString());
            }
            command.Dispose();
            return 0;
        }
        public List<string> GetAllPasses()
        {
            List<string> arr = new();
            command = new SQLiteCommand($"select Password,EncryptKey from Data where user_id = {user_id}", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                arr.Add(c.Decrypt(el["Password"].ToString(),el["EncryptKey"].ToString()));
            }
            command.Dispose();
            return arr;
        }

        public void Dispose()
        {
            db.Close();
            db.Dispose();
            db = null;
        }

    }

}
