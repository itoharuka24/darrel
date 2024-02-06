namespace Sample_user_login
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new Label();
            Password = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = SystemColors.ButtonFace;
            Username.Location = new Point(140, 129);
            Username.Name = "Username";
            Username.Size = new Size(63, 15);
            Username.TabIndex = 0;
            Username.Text = "Username:";
            Username.Click += label1_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = SystemColors.ButtonHighlight;
            Password.Location = new Point(140, 184);
            Password.Name = "Password";
            Password.Size = new Size(60, 15);
            Password.TabIndex = 1;
            Password.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(216, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(153, 23);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(216, 181);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(153, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(160, 262);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(86, 32);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(345, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 32);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ScrollBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(112, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(404, 150);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(638, 352);
            Controls.Add(txtPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtUsername);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnConfirm;
        private Button btnCancel;
        private DataGridView dataGridView1;
    }
}
