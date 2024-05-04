namespace assignment
{
    partial class Dashboard
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
            dataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dashboard_id = new TextBox();
            dashboard_name = new TextBox();
            dashboard_address = new TextBox();
            dashboard_number = new TextBox();
            dashboard_email = new TextBox();
            dashboard_insert = new Button();
            dashboard_update = new Button();
            dashboard_delete = new Button();
            dashboard_reset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(34, 295);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(642, 188);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 33);
            label1.Name = "label1";
            label1.Size = new Size(25, 19);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Location = new Point(53, 78);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Location = new Point(55, 129);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Location = new Point(35, 184);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 4;
            label4.Text = "Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Location = new Point(32, 234);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // dashboard_id
            // 
            dashboard_id.Location = new Point(145, 25);
            dashboard_id.Name = "dashboard_id";
            dashboard_id.Size = new Size(349, 27);
            dashboard_id.TabIndex = 6;
            dashboard_id.TextChanged += textBox1_TextChanged;
            // 
            // dashboard_name
            // 
            dashboard_name.Location = new Point(145, 70);
            dashboard_name.Name = "dashboard_name";
            dashboard_name.Size = new Size(349, 27);
            dashboard_name.TabIndex = 7;
            // 
            // dashboard_address
            // 
            dashboard_address.Location = new Point(145, 226);
            dashboard_address.Name = "dashboard_address";
            dashboard_address.Size = new Size(349, 27);
            dashboard_address.TabIndex = 8;
            // 
            // dashboard_number
            // 
            dashboard_number.Location = new Point(145, 176);
            dashboard_number.Name = "dashboard_number";
            dashboard_number.Size = new Size(349, 27);
            dashboard_number.TabIndex = 9;
            // 
            // dashboard_email
            // 
            dashboard_email.Location = new Point(145, 121);
            dashboard_email.Name = "dashboard_email";
            dashboard_email.Size = new Size(349, 27);
            dashboard_email.TabIndex = 10;
            // 
            // dashboard_insert
            // 
            dashboard_insert.BackColor = SystemColors.HotTrack;
            dashboard_insert.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_insert.Location = new Point(580, 25);
            dashboard_insert.Name = "dashboard_insert";
            dashboard_insert.Size = new Size(94, 33);
            dashboard_insert.TabIndex = 11;
            dashboard_insert.Text = "Insert";
            dashboard_insert.UseVisualStyleBackColor = false;
            dashboard_insert.Click += dashboard_insert_Click;
            // 
            // dashboard_update
            // 
            dashboard_update.BackColor = SystemColors.HotTrack;
            dashboard_update.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_update.Location = new Point(580, 90);
            dashboard_update.Name = "dashboard_update";
            dashboard_update.Size = new Size(94, 29);
            dashboard_update.TabIndex = 12;
            dashboard_update.Text = "Update";
            dashboard_update.UseVisualStyleBackColor = false;
            dashboard_update.Click += dashboard_update_Click;
            // 
            // dashboard_delete
            // 
            dashboard_delete.BackColor = SystemColors.HotTrack;
            dashboard_delete.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_delete.Location = new Point(580, 156);
            dashboard_delete.Name = "dashboard_delete";
            dashboard_delete.Size = new Size(94, 29);
            dashboard_delete.TabIndex = 13;
            dashboard_delete.Text = "Delete";
            dashboard_delete.UseVisualStyleBackColor = false;
            dashboard_delete.Click += dashboard_delete_Click;
            // 
            // dashboard_reset
            // 
            dashboard_reset.BackColor = SystemColors.HotTrack;
            dashboard_reset.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_reset.Location = new Point(580, 224);
            dashboard_reset.Name = "dashboard_reset";
            dashboard_reset.Size = new Size(94, 29);
            dashboard_reset.TabIndex = 14;
            dashboard_reset.Text = "Reset";
            dashboard_reset.UseVisualStyleBackColor = false;
            dashboard_reset.Click += dashboard_reset_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(798, 512);
            Controls.Add(dashboard_reset);
            Controls.Add(dashboard_delete);
            Controls.Add(dashboard_update);
            Controls.Add(dashboard_insert);
            Controls.Add(dashboard_email);
            Controls.Add(dashboard_number);
            Controls.Add(dashboard_address);
            Controls.Add(dashboard_name);
            Controls.Add(dashboard_id);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox dashboard_id;
        private TextBox dashboard_name;
        private TextBox dashboard_address;
        private TextBox dashboard_number;
        private TextBox dashboard_email;
        private Button dashboard_insert;
        private Button dashboard_update;
        private Button dashboard_delete;
        private Button dashboard_reset;
    }
}