namespace GUI
{
    partial class Account
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
            lable_email = new Label();
            label4 = new Label();
            textBox_username = new TextBox();
            label3 = new Label();
            textBox_full_name = new TextBox();
            panel_search = new Panel();
            button_search = new Button();
            textBox_search = new TextBox();
            textBox_email = new TextBox();
            panel2 = new Panel();
            textBox_phone_number = new TextBox();
            label2 = new Label();
            columnHeader8 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel6 = new Panel();
            comboBox_department = new ComboBox();
            label6 = new Label();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            textBox_password = new TextBox();
            columnHeader5 = new ColumnHeader();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            panel3 = new Panel();
            button_add = new Button();
            panel7 = new Panel();
            comboBox_role = new ComboBox();
            label7 = new Label();
            panel8 = new Panel();
            comboBox_gender = new ComboBox();
            label8 = new Label();
            listView_account = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel_control = new Panel();
            button_delete = new Button();
            button_edit = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel_search.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel_control.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lable_email
            // 
            lable_email.AutoSize = true;
            lable_email.Font = new Font("Century Gothic", 11F);
            lable_email.ForeColor = SystemColors.ButtonHighlight;
            lable_email.Location = new Point(3, 16);
            lable_email.Name = "lable_email";
            lable_email.Size = new Size(46, 20);
            lable_email.TabIndex = 1;
            lable_email.Text = "Email";
            lable_email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 1;
            label4.Text = "Username";
            // 
            // textBox_username
            // 
            textBox_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_username.BorderStyle = BorderStyle.FixedSingle;
            textBox_username.Location = new Point(118, 13);
            textBox_username.Margin = new Padding(3, 2, 3, 2);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(191, 23);
            textBox_username.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 1;
            label3.Text = "FullName";
            // 
            // textBox_full_name
            // 
            textBox_full_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_full_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_full_name.Location = new Point(118, 14);
            textBox_full_name.Margin = new Padding(3, 2, 3, 2);
            textBox_full_name.Name = "textBox_full_name";
            textBox_full_name.Size = new Size(191, 23);
            textBox_full_name.TabIndex = 0;
            // 
            // panel_search
            // 
            panel_search.Controls.Add(button_search);
            panel_search.Controls.Add(textBox_search);
            panel_search.Dock = DockStyle.Fill;
            panel_search.Location = new Point(3, 2);
            panel_search.Margin = new Padding(3, 2, 3, 2);
            panel_search.Name = "panel_search";
            panel_search.Size = new Size(620, 56);
            panel_search.TabIndex = 0;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(101, 116, 137);
            button_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = SystemColors.ButtonFace;
            button_search.Location = new Point(509, 14);
            button_search.Margin = new Padding(3, 2, 3, 2);
            button_search.MaximumSize = new Size(105, 28);
            button_search.MinimumSize = new Size(105, 28);
            button_search.Name = "button_search";
            button_search.Size = new Size(105, 28);
            button_search.TabIndex = 8;
            button_search.Text = "Tìm kiếm";
            button_search.UseVisualStyleBackColor = false;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_search.BorderStyle = BorderStyle.FixedSingle;
            textBox_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_search.Location = new Point(13, 7);
            textBox_search.Margin = new Padding(3, 2, 3, 2);
            textBox_search.MaximumSize = new Size(1050, 38);
            textBox_search.MinimumSize = new Size(350, 38);
            textBox_search.Name = "textBox_search";
            textBox_search.ShortcutsEnabled = false;
            textBox_search.Size = new Size(490, 38);
            textBox_search.TabIndex = 4;
            // 
            // textBox_email
            // 
            textBox_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_email.BorderStyle = BorderStyle.FixedSingle;
            textBox_email.Location = new Point(118, 13);
            textBox_email.Margin = new Padding(3, 2, 3, 2);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(191, 23);
            textBox_email.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_phone_number);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 159);
            panel2.Margin = new Padding(3, 2, 3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 43);
            panel2.TabIndex = 2;
            // 
            // textBox_phone_number
            // 
            textBox_phone_number.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_phone_number.BorderStyle = BorderStyle.FixedSingle;
            textBox_phone_number.Location = new Point(118, 14);
            textBox_phone_number.Margin = new Padding(3, 2, 3, 2);
            textBox_phone_number.Name = "textBox_phone_number";
            textBox_phone_number.Size = new Size(191, 23);
            textBox_phone_number.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone number";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Email";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Phone number";
            columnHeader2.Width = 120;
            // 
            // panel6
            // 
            panel6.Controls.Add(comboBox_department);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 384);
            panel6.Margin = new Padding(3, 2, 3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(309, 43);
            panel6.TabIndex = 4;
            // 
            // comboBox_department
            // 
            comboBox_department.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_department.FormattingEnabled = true;
            comboBox_department.Location = new Point(118, 12);
            comboBox_department.Margin = new Padding(3, 2, 3, 2);
            comboBox_department.Name = "comboBox_department";
            comboBox_department.Size = new Size(191, 23);
            comboBox_department.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(3, 16);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 1;
            label6.Text = "Department";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "FullName";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Username";
            columnHeader4.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Cambria", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(309, 112);
            label1.TabIndex = 1;
            label1.Text = "TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBox_password);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 339);
            panel5.Margin = new Padding(3, 2, 3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(309, 43);
            panel5.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(3, 16);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 1;
            label5.Text = "Password";
            // 
            // textBox_password
            // 
            textBox_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_password.BorderStyle = BorderStyle.FixedSingle;
            textBox_password.Location = new Point(118, 13);
            textBox_password.Margin = new Padding(3, 2, 3, 2);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(191, 23);
            textBox_password.TabIndex = 0;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Department";
            columnHeader5.Width = 100;
            // 
            // panel1
            // 
            panel1.Controls.Add(lable_email);
            panel1.Controls.Add(textBox_email);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 114);
            panel1.Margin = new Padding(3, 2, 3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 43);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(35, 48, 103);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 2);
            tableLayoutPanel2.Controls.Add(panel6, 0, 7);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel5, 0, 6);
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 5);
            tableLayoutPanel2.Controls.Add(panel3, 0, 3);
            tableLayoutPanel2.Controls.Add(button_add, 0, 9);
            tableLayoutPanel2.Controls.Add(panel7, 0, 8);
            tableLayoutPanel2.Controls.Add(panel8, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(315, 535);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox_username);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 294);
            panel4.Margin = new Padding(3, 2, 3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(309, 43);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox_full_name);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 204);
            panel3.Margin = new Padding(3, 2, 3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 43);
            panel3.TabIndex = 2;
            // 
            // button_add
            // 
            button_add.BackColor = Color.FromArgb(0, 192, 0);
            button_add.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = SystemColors.ControlLightLight;
            button_add.Location = new Point(3, 487);
            button_add.Margin = new Padding(3, 15, 3, 2);
            button_add.Name = "button_add";
            button_add.Size = new Size(303, 30);
            button_add.TabIndex = 6;
            button_add.Text = "Thêm";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(comboBox_role);
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 429);
            panel7.Margin = new Padding(3, 2, 3, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(309, 43);
            panel7.TabIndex = 5;
            // 
            // comboBox_role
            // 
            comboBox_role.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Location = new Point(118, 13);
            comboBox_role.Margin = new Padding(3, 2, 3, 2);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(191, 23);
            comboBox_role.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(3, 16);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 1;
            label7.Text = "Role";
            // 
            // panel8
            // 
            panel8.Controls.Add(comboBox_gender);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(3, 250);
            panel8.Name = "panel8";
            panel8.Size = new Size(309, 39);
            panel8.TabIndex = 7;
            // 
            // comboBox_gender
            // 
            comboBox_gender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_gender.FormattingEnabled = true;
            comboBox_gender.Location = new Point(118, 10);
            comboBox_gender.Margin = new Padding(3, 2, 3, 2);
            comboBox_gender.Name = "comboBox_gender";
            comboBox_gender.Size = new Size(191, 23);
            comboBox_gender.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(3, 10);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 2;
            label8.Text = "Gender";
            // 
            // listView_account
            // 
            listView_account.BackColor = Color.WhiteSmoke;
            listView_account.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader1, columnHeader2, columnHeader3, columnHeader7, columnHeader4, columnHeader5, columnHeader6 });
            listView_account.Dock = DockStyle.Fill;
            listView_account.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView_account.GridLines = true;
            listView_account.Location = new Point(3, 62);
            listView_account.Margin = new Padding(3, 2, 3, 2);
            listView_account.Name = "listView_account";
            listView_account.Size = new Size(620, 401);
            listView_account.TabIndex = 1;
            listView_account.UseCompatibleStateImageBehavior = false;
            listView_account.View = View.Details;
            listView_account.SelectedIndexChanged += listView_account_SelectedIndexChanged;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Gender";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Role";
            columnHeader6.Width = 100;
            // 
            // panel_control
            // 
            panel_control.Controls.Add(button_delete);
            panel_control.Controls.Add(button_edit);
            panel_control.Dock = DockStyle.Right;
            panel_control.Location = new Point(253, 467);
            panel_control.Margin = new Padding(3, 2, 3, 2);
            panel_control.Name = "panel_control";
            panel_control.Size = new Size(370, 66);
            panel_control.TabIndex = 2;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_delete.BackColor = Color.FromArgb(255, 128, 128);
            button_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = SystemColors.ButtonHighlight;
            button_delete.Location = new Point(219, 20);
            button_delete.Margin = new Padding(3, 2, 3, 2);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(146, 30);
            button_delete.TabIndex = 9;
            button_delete.Text = "Xóa";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_edit
            // 
            button_edit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_edit.BackColor = Color.FromArgb(35, 48, 103);
            button_edit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_edit.ForeColor = SystemColors.ButtonHighlight;
            button_edit.Location = new Point(67, 20);
            button_edit.Margin = new Padding(3, 2, 3, 2);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(146, 30);
            button_edit.TabIndex = 7;
            button_edit.Text = "Sửa";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel_search, 0, 0);
            tableLayoutPanel3.Controls.Add(listView_account, 0, 1);
            tableLayoutPanel3.Controls.Add(panel_control, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(324, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 85.471405F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5285931F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(626, 535);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.7711067F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.22889F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(953, 539);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 539);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            panel_search.ResumeLayout(false);
            panel_search.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel_control.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lable_email;
        private Label label4;
        private TextBox textBox_username;
        private Label label3;
        private TextBox textBox_full_name;
        private Panel panel_search;
        private TextBox textBox_search;
        private TextBox textBox_email;
        private Panel panel2;
        private Label label2;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel6;
        private ComboBox comboBox_department;
        private Label label6;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private Panel panel5;
        private Label label5;
        private TextBox textBox_password;
        private ColumnHeader columnHeader5;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private Panel panel3;
        private Button button_add;
        private ListView listView_account;
        private ColumnHeader columnHeader6;
        private Panel panel_control;
        private Button button_delete;
        private Button button_edit;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox_phone_number;
        private Panel panel7;
        private ComboBox comboBox_role;
        private Label label7;
        private Button button_search;
        private Panel panel8;
        private Label label8;
        private ComboBox comboBox_gender;
        private ColumnHeader columnHeader7;
    }
}