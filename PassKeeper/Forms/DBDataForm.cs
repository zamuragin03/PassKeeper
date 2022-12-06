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
    public partial class DBDataForm : Form
    {
        private WorkingWithDB DB;
        private int user_id;
        public DBDataForm(int user_id)
        {
            this.user_id = user_id;
            InitializeComponent();

             DB= new(user_id);
             UpdateListView();
            
        }

        private void UpdateListView()
        {
            List<string[]> list = DB.GetEncryptedDataData();
            DataListView.Items.Clear();

            foreach (string[] el in list)
            {
                var item = new ListViewItem(el);
                DataListView.Items.Add(item);
            }
        }
    }
}
