using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassKeeper.Classes;

namespace PassKeeper
{
    public partial class AnalyzeForm : Form
    {
        private int user_id;
        private WorkingWithDB DB;
        public AnalyzeForm(int user_id, WorkingWithDB DB)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.DB = DB;

            UpdateFields();
            
        }

        void UpdateFields()
        {
            chart1.Titles.Add("Статистика паролей");
            int amount = DB.GetPassAmount();
            label1.Text = "Всего паролей: " + amount;
            var list = DB.GetAllPasses();

            List<Strength> pasStrengths = new();
            foreach (var el in list)
            {
                pasStrengths.Add(Password.PasswordStrength(el));
            }
            

            var q = pasStrengths.GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count);

            int i = 1;

            foreach (var x in q)
            {
                StatLabel.Text = StatLabel.Text + x.Value + " — " + x.Count + "\n";
                chart1.Series["s1"].Points.AddXY(x.Value.ToString(), i);
                i++;
            }
        }



    }
}
