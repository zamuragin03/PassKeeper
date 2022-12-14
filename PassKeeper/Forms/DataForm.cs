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
        private int user_id;
        private DataStructure selectedData;
        private WorkingWithDB DB;
        public DataForm(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            DB = new WorkingWithDB(this.user_id);
            UpdateListView();

            ToolStripMenuItem delete = new ToolStripMenuItem("Удалить");
            delete.Click += delete_selected_click;
            ToolStripMenuItem edit = new ToolStripMenuItem("Измнить");
            edit.Click += edit_selected_click;
            contextMenuStrip1.Items.AddRange(new[] { delete, edit });


        }

        private void edit_selected_click(object sender, EventArgs e)
        {
            
            var text = DataListView.SelectedItems[0];

            selectedData = new()
            {
                Data_id = int.Parse(text.SubItems[0].Text),
                Login = text.SubItems[1].Text,
                Password = text.SubItems[2].Text,
                Description = text.SubItems[3].Text,
            };

            EditDataForm form = new(user_id, selectedData);
            form.Show();
            Hide();
            Dispose();
            UpdateListView();
        }

        private void delete_selected_click(object sender, EventArgs e)
        {


            var text = DataListView.SelectedItems[0];

            selectedData = new()
            {
                Data_id = int.Parse(text.SubItems[0].Text)
            };
            DB.DeleteData(selectedData);
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

        public void UpdateListView()
        {

            List<string[]> list = DB.GetData();
            DataListView.Items.Clear();

            foreach (string[] el in list)
            {
                var item = new ListViewItem(el);
                DataListView.Items.Add(item);
            }
        }

        private void DataListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                var focusedItem = DataListView.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(PointToScreen(e.Location));

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBDataForm f = new(user_id, DB);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnalyzeForm form = new(user_id, DB);
            form.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
    }
}
