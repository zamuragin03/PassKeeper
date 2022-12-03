using System;
using System.Collections.Generic;
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
        SQLiteDataReader reader;
        SQLiteCommand command;

        public Authorization()
        {
            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();

        }
        public bool CheckAuth()
        {
            command = new SQLiteCommand($"select User_id,Login,Password from User where Login='{Login}' and Password= '{Password}'", db);
            reader = command.ExecuteReader();
            foreach (DbDataRecord el in reader)
            {
                if (el is not null)
                {
                    User_id = int.Parse(el["User_id"].ToString());
                    return true;
                }
            }

            return false;
        }

        public int GetUserId() => User_id;

    }

}
