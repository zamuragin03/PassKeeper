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
    public partial class EditDataForm : Form
    {
        private WorkingWithDB DB;
        private int user_id;
        public EditDataForm(int user_id, DataStructure data)
        {
            this.user_id = user_id;
            InitializeComponent();
            idlabel.Text= data.Data_id.ToString();
            DescTextBox.Text = data.Description;
            PasswordTextBox.Text = data.Password;
            LoginTextBox.Text = data.Login;
            DB = new WorkingWithDB(user_id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataStructure temp = new()
            {
                Data_id = int.Parse( idlabel.Text),
                Password = PasswordTextBox.Text,
                Login = LoginTextBox.Text,
                Description = DescTextBox.Text,
            };
            DB.EditData(temp);

            Hide();
            Dispose();
            DataForm f = new(user_id);
            f.Show();
        }
    }
}
