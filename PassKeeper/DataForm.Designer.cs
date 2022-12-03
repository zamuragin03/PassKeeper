
namespace PassKeeper
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.addloginbox = new System.Windows.Forms.TextBox();
            this.addpassbox = new System.Windows.Forms.TextBox();
            this.adddesbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Login,
            this.Password,
            this.Description});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(795, 199);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Login
            // 
            this.Login.Text = "Login";
            this.Login.Width = 250;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.Width = 250;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 280;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(705, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addloginbox
            // 
            this.addloginbox.Location = new System.Drawing.Point(40, 266);
            this.addloginbox.Name = "addloginbox";
            this.addloginbox.Size = new System.Drawing.Size(147, 20);
            this.addloginbox.TabIndex = 5;
            this.addloginbox.Text = "SomeLogin";
            // 
            // addpassbox
            // 
            this.addpassbox.Location = new System.Drawing.Point(227, 266);
            this.addpassbox.Name = "addpassbox";
            this.addpassbox.Size = new System.Drawing.Size(168, 20);
            this.addpassbox.TabIndex = 6;
            this.addpassbox.Text = "SomePass";
            // 
            // adddesbox
            // 
            this.adddesbox.Location = new System.Drawing.Point(518, 266);
            this.adddesbox.Name = "adddesbox";
            this.adddesbox.Size = new System.Drawing.Size(281, 70);
            this.adddesbox.TabIndex = 7;
            this.adddesbox.Text = "SomeText";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(224, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(515, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adddesbox);
            this.Controls.Add(this.addpassbox);
            this.Controls.Add(this.addloginbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addloginbox;
        private System.Windows.Forms.TextBox addpassbox;
        private System.Windows.Forms.RichTextBox adddesbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}