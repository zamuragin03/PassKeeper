using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class DataForm : Form
    {
        private WorkingWithDB DB;
        private int user_id;

        private SQLiteConnection db;
        SQLiteDataReader reader;
        SQLiteCommand command;

        public DataForm(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            DB = new WorkingWithDB(user_id);

            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();
            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataStructure temp = new()
            {
                Login = addloginbox.Text,
                Password = addpassbox.Text,
                Description = adddesbox.Text
            };
            DB.AddData(temp);
            UpdateListView();
        }

        void UpdateListView()
        {
            List<string[]> list = DB.GetData();
            DataListView.Items.Clear();

            foreach (string[] el in list)
            {
                var item = new ListViewItem(el);
                DataListView.Items.Add(item);
            }
        }

    }
}
