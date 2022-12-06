using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeeper
{
    public partial class LoginForm : Form
    {
        public DataForm form;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization auth = new()
            {
                Login = loginbox.Text,
                Password = passbox.Text
            };

            if (auth.CheckAuth())
            {
                form = new DataForm(auth.GetUserId());
                form.Show();
                Hide();
                return;
            }
            MessageBox.Show("Failed Login or Password");

            passbox.Text = "";
            loginbox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm f = new();
            f.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Dispose();
        }
    }
}
