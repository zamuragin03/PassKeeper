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
    public partial class DataForm : Form
    {
        private WorkingWithDB DB;
        private int user_id;

        public DataForm(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            DB = new WorkingWithDB(user_id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataStructure temp = new()
            {
                Login = addloginbox.Text,
                Password = addloginbox.Text,
                Description = adddesbox.Text
            };
            DB.AddData(temp);
        }
    }
}
