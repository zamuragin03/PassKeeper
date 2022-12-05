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
            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();
            this.user_id = user_id;
            c = new();
        }

        public void AddData(DataStructure data)
        {

            string Key = GenerateEncryptKey();


            command = new SQLiteCommand(
                "insert into Data(Data_id,user_id,Login,Password,EncryptKey,Description) values " +
                "(@Data_id,@user_id,@Login,@Password,@EncryptKey,@Description)", db);

            command.Parameters.AddWithValue("@Data_id", null);
            command.Parameters.AddWithValue("@user_id", user_id);
            command.Parameters.AddWithValue("@Login", c.Encrypt(data.Login, Key));
            command.Parameters.AddWithValue("@Password", c.Encrypt(data.Password, Key));
            command.Parameters.AddWithValue("@EncryptKey", Key);
            command.Parameters.AddWithValue("@Description", c.Encrypt(data.Description, Key));
            command.ExecuteNonQuery();

        }

        public List<string[]> GetData()
        {
            List<string[]> arr = new();
            command = new SQLiteCommand($"select distinct Login,Password,Description,EncryptKey from Data where user_id = {user_id}", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                string[] tmp =
                {
                    c.Decrypt(el["Login"].ToString(),el["EncryptKey"].ToString()),
                    c.Decrypt(el["Password"].ToString(),el["EncryptKey"].ToString()),
                    c.Decrypt(el["Description"].ToString(),el["EncryptKey"].ToString())
                };
                arr.Add(tmp);
            }

            return arr;
        }

        public void DeleteData(DataStructure data)
        {
            List<string> keys = new List<string>();

            command = new SQLiteCommand($"select EncryptKey from Data", db);
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                keys.Add(row["EncryptKey"].ToString());

            }


            foreach (var key in keys)
            {

                var command3 = new SQLiteCommand($"select Data_id from Data where  Login='{c.Decrypt(data.Login, key)}'" +
                                                 $" and  Password='{c.Decrypt(data.Password, key)}'" +
                                                 $" and  Description='{c.Decrypt(data.Description, key)}' limit 1", db);


                SQLiteDataAdapter da3 = new SQLiteDataAdapter(command3);
                DataTable dt2 = new DataTable();
                da3.Fill(dt2);

                foreach (DataRow row in dt.Rows)
                {
                    if (row is not null)
                    {
                        var command2 = new SQLiteCommand(
                            $"delete from Data where Login='{c.Decrypt(data.Login, key)}' and EncryptKey='{key}'",
                            db
                        );
                        command2.ExecuteNonQuery();
                        
                    }
                }
            }
        }

        private string GenerateEncryptKey()
        {
            Random rnd = new();
            return rnd.Next(1000).ToString();
        }

    }

}
