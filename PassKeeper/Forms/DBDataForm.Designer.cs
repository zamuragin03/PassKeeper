
namespace PassKeeper
{
    partial class DBDataForm
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
            this.DataListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.DataListView.Location = new System.Drawing.Point(3, 26);
            this.DataListView.MultiSelect = false;
            this.DataListView.Name = "DataListView";
            this.DataListView.Size = new System.Drawing.Size(795, 199);
            this.DataListView.TabIndex = 3;
            this.DataListView.UseCompatibleStateImageBehavior = false;
            this.DataListView.View = System.Windows.Forms.View.Details;
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
            // DBDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 236);
            this.Controls.Add(this.DataListView);
            this.Name = "DBDataForm";
            this.Text = "DBDataForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DataListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader Description;
    }
}