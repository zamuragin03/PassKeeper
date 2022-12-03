using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            command = new SQLiteCommand($"select Login,Password,Description,EncryptKey from Data where user_id = {user_id}", db);
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


        string GenerateEncryptKey()
            => Guid.NewGuid().ToString();

    }

}
