using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class RegisterForm : Form
    {
        private SQLiteConnection db;
        SQLiteCommand command;
        public RegisterForm()
        {
            InitializeComponent();
            db = new SQLiteConnection("Data Source = MyDB.db;");
            db.Open();
            passbox.UseSystemPasswordChar = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization auth = new()
            {
                Login = loginbox.Text,
                Password = passbox.Text
            };
            if (loginbox.Text.Trim()=="" || passbox.Text.Trim()=="")
            {
                MessageBox.Show("Поля не должны быть пустыми");
                return;
            }
            if (auth.CheckConstraint())
            {
                auth.AddNewProfile();
                passbox.Text = "";
                loginbox.Text = "";

                return;
            }

            MessageBox.Show("Пользователь с данным логином уже есть в системе");


        }   
        private void CheckPassBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassBox.Checked)
            {
                passbox.UseSystemPasswordChar = false;
                return;
            }

            passbox.UseSystemPasswordChar = true;
        }
    }
}
