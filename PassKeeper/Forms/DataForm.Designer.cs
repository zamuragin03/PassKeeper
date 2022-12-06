
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.DataListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // DataListView
            // 
            this.DataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Login,
            this.Password,
            this.Description});
            this.DataListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataListView.HideSelection = false;
            this.DataListView.Location = new System.Drawing.Point(21, 30);
            this.DataListView.MultiSelect = false;
            this.DataListView.Name = "DataListView";
            this.DataListView.Size = new System.Drawing.Size(795, 199);
            this.DataListView.TabIndex = 2;
            this.DataListView.UseCompatibleStateImageBehavior = false;
            this.DataListView.View = System.Windows.Forms.View.Details;
            this.DataListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataListView_MouseClick);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 50;
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
            this.Description.Width = 230;
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
            // 
            // addpassbox
            // 
            this.addpassbox.Location = new System.Drawing.Point(227, 266);
            this.addpassbox.Name = "addpassbox";
            this.addpassbox.Size = new System.Drawing.Size(168, 20);
            this.addpassbox.TabIndex = 6;
            // 
            // adddesbox
            // 
            this.adddesbox.Location = new System.Drawing.Point(518, 266);
            this.adddesbox.Name = "adddesbox";
            this.adddesbox.Size = new System.Drawing.Size(281, 70);
            this.adddesbox.TabIndex = 7;
            this.adddesbox.Text = "";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Посмотреть данные в БД";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(308, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 30);
            this.button3.TabIndex = 12;
            this.button3.Text = "Посмотреть статистику";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adddesbox);
            this.Controls.Add(this.addpassbox);
            this.Controls.Add(this.addloginbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataListView);
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView DataListView;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}