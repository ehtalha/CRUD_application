namespace assignment
{
    partial class Registration
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
            singup = new Button();
            singup_checkBox = new CheckBox();
            s_email = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            singup_email = new TextBox();
            singup_username = new TextBox();
            singup_password = new TextBox();
            label1 = new Label();
            singup_login = new Label();
            singup_conpassword = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // singup
            // 
            singup.BackColor = SystemColors.HotTrack;
            singup.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            singup.Location = new Point(341, 376);
            singup.Name = "singup";
            singup.Size = new Size(108, 47);
            singup.TabIndex = 0;
            singup.Text = "Sing Up";
            singup.UseVisualStyleBackColor = false;
            singup.Click += singup_Click;
            // 
            // singup_checkBox
            // 
            singup_checkBox.AutoSize = true;
            singup_checkBox.BackColor = SystemColors.AppWorkspace;
            singup_checkBox.Location = new Point(472, 335);
            singup_checkBox.Name = "singup_checkBox";
            singup_checkBox.Size = new Size(151, 27);
            singup_checkBox.TabIndex = 1;
            singup_checkBox.Text = "Show password";
            singup_checkBox.UseVisualStyleBackColor = false;
            singup_checkBox.CheckedChanged += singup_checkBox_CheckedChanged;
            // 
            // s_email
            // 
            s_email.AutoSize = true;
            s_email.BackColor = SystemColors.ActiveBorder;
            s_email.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            s_email.Location = new Point(249, 88);
            s_email.Name = "s_email";
            s_email.Size = new Size(52, 24);
            s_email.TabIndex = 2;
            s_email.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 155);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 3;
            label2.Text = "User name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 220);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.OliveDrab;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(341, 24);
            label4.Name = "label4";
            label4.Size = new Size(121, 27);
            label4.TabIndex = 5;
            label4.Text = "Registration";
            // 
            // singup_email
            // 
            singup_email.Location = new Point(341, 86);
            singup_email.Name = "singup_email";
            singup_email.Size = new Size(282, 30);
            singup_email.TabIndex = 6;
            // 
            // singup_username
            // 
            singup_username.Location = new Point(341, 148);
            singup_username.Name = "singup_username";
            singup_username.Size = new Size(282, 30);
            singup_username.TabIndex = 7;
            // 
            // singup_password
            // 
            singup_password.Location = new Point(341, 218);
            singup_password.Name = "singup_password";
            singup_password.Size = new Size(282, 30);
            singup_password.TabIndex = 8;
            singup_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(275, 502);
            label1.Name = "label1";
            label1.Size = new Size(174, 23);
            label1.TabIndex = 9;
            label1.Text = "Already hav account?";
            // 
            // singup_login
            // 
            singup_login.AutoSize = true;
            singup_login.BackColor = SystemColors.ActiveBorder;
            singup_login.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            singup_login.Location = new Point(569, 503);
            singup_login.Name = "singup_login";
            singup_login.Size = new Size(54, 22);
            singup_login.TabIndex = 10;
            singup_login.Text = "Log In";
            singup_login.Click += singup_login_Click;
            // 
            // singup_conpassword
            // 
            singup_conpassword.Location = new Point(341, 278);
            singup_conpassword.Name = "singup_conpassword";
            singup_conpassword.Size = new Size(282, 30);
            singup_conpassword.TabIndex = 11;
            singup_conpassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(148, 280);
            label5.Name = "label5";
            label5.Size = new Size(153, 24);
            label5.TabIndex = 12;
            label5.Text = "Confirm Password";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(832, 534);
            Controls.Add(label5);
            Controls.Add(singup_conpassword);
            Controls.Add(singup_login);
            Controls.Add(label1);
            Controls.Add(singup_password);
            Controls.Add(singup_username);
            Controls.Add(singup_email);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(s_email);
            Controls.Add(singup_checkBox);
            Controls.Add(singup);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button singup;
        private CheckBox singup_checkBox;
        private Label s_email;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox singup_email;
        private TextBox singup_username;
        private TextBox singup_password;
        private Label label1;
        private Label singup_login;
        private TextBox singup_conpassword;
        private Label label5;
    }
}