namespace assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Button();
            login_checkBox = new CheckBox();
            username = new Label();
            password = new Label();
            text_username = new TextBox();
            text_password = new TextBox();
            label3 = new Label();
            label1 = new Label();
            login_singup = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = Color.RoyalBlue;
            login.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.Location = new Point(286, 278);
            login.Name = "login";
            login.Size = new Size(87, 36);
            login.TabIndex = 0;
            login.Text = "Log In";
            login.UseVisualStyleBackColor = false;
            login.Click += button1_Click;
            // 
            // login_checkBox
            // 
            login_checkBox.AutoSize = true;
            login_checkBox.BackColor = SystemColors.AppWorkspace;
            login_checkBox.Location = new Point(397, 244);
            login_checkBox.Name = "login_checkBox";
            login_checkBox.Size = new Size(132, 24);
            login_checkBox.TabIndex = 1;
            login_checkBox.Text = "Show Password";
            login_checkBox.UseVisualStyleBackColor = false;
            login_checkBox.CheckedChanged += login_checkBox_CheckedChanged;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(136, 115);
            username.Name = "username";
            username.Size = new Size(116, 28);
            username.TabIndex = 2;
            username.Text = "User Name";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.Location = new Point(151, 199);
            password.Name = "password";
            password.Size = new Size(101, 28);
            password.TabIndex = 3;
            password.Text = "Password";
            // 
            // text_username
            // 
            text_username.Location = new Point(286, 116);
            text_username.Name = "text_username";
            text_username.Size = new Size(236, 27);
            text_username.TabIndex = 4;
            // 
            // text_password
            // 
            text_password.Location = new Point(286, 199);
            text_password.Name = "text_password";
            text_password.Size = new Size(236, 27);
            text_password.TabIndex = 5;
            text_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 42);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 6;
            label3.Text = "Welcome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(261, 398);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 7;
            label1.Text = "Don't have account?";
            label1.Click += label1_Click;
            // 
            // login_singup
            // 
            login_singup.AutoSize = true;
            login_singup.BackColor = SystemColors.ActiveBorder;
            login_singup.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_singup.ForeColor = SystemColors.HotTrack;
            login_singup.Location = new Point(455, 395);
            login_singup.Name = "login_singup";
            login_singup.Size = new Size(67, 23);
            login_singup.TabIndex = 8;
            login_singup.Text = "register";
            login_singup.Click += login_singup_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(655, 448);
            Controls.Add(login_singup);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(text_password);
            Controls.Add(text_username);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(login_checkBox);
            Controls.Add(login);
            Name = "Form1";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private CheckBox login_checkBox;
        private Label username;
        private Label password;
        private TextBox text_username;
        private TextBox text_password;
        private Label label3;
        private Label label1;
        private Label login_singup;
    }
}
