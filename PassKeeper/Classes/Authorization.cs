using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper
{
    class Authorization
    {
        public string Login { get; set; }
        public string Password { get; set; }
        private int User_id;

        private SQLiteConnection db;
        SQLiteCommand command;

        public Authorization()
        {
            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();

        }
        public bool CheckAuth()
        {

            command = new SQLiteCommand($"select User_id,Login,Password from User where Login='{Login}' and Password= '{Password}'", db);
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row is not null)
                {
                    User_id = int.Parse(row["User_id"].ToString());
                    return true;

                }
            }

            return false;
        }

        public void AddNewProfile()
        {

            command = new SQLiteCommand(
                "insert into User(User_id,Login,Password) values " +
                "(@User_id,@Login,@Password)", db);

            command.Parameters.AddWithValue("@User_id", null);
            command.Parameters.AddWithValue("@Login", Login);
            command.Parameters.AddWithValue("@Password", Password);
            command.ExecuteNonQuery();


        }

        public bool CheckConstraint()
        {
            command = new SQLiteCommand($"select Login from User where Login='{Login}'", db);
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                if (row is not null)
                {
                    return false;
                }
            }

            return true;
        }

        public int GetUserId() => User_id;

    }

}
