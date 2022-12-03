using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper
{
    class WorkingWithDB
    {
        private SQLiteConnection db;
        SQLiteDataReader reader;
        SQLiteCommand command;

        private int user_id;

        public WorkingWithDB(int user_id)
        {
            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();
            this.user_id = user_id;

        }

        public void AddData(DataStructure data)
        {

            int Key = GenerateEncryptKey();
            ScytaleCipher c = new();

            command = new SQLiteCommand(
                "insert into Data(Data_id,user_id,Login,Password,EncryptKey,Description) values " +
                "(@Data_id,@user_id,@Login,@Password,@EncryptKey,@Description)", db);

            command.Parameters.AddWithValue("@Data_id", null);
            command.Parameters.AddWithValue("@user_id", user_id);
            command.Parameters.AddWithValue("@Login",c.Encrypt(data.Login,Key));
            command.Parameters.AddWithValue("@Password", c.Encrypt(data.Password,Key));
            command.Parameters.AddWithValue("@EncryptKey", Key);
            command.Parameters.AddWithValue("@Description", data.Description);
            command.ExecuteNonQuery();
        }

        int GenerateEncryptKey()
        {
            Random rnd = new();
            return rnd.Next(100);
        }
    }

}
