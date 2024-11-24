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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel_avatar = new Panel();
            pictureBox_avatar = new PictureBox();
            label_name = new Label();
            tableLayoutPanel_form = new TableLayoutPanel();
            button_update = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            comboBox_role = new ComboBox();
            label7 = new Label();
            panel7 = new Panel();
            label6 = new Label();
            textBox_phone = new TextBox();
            panel6 = new Panel();
            label5 = new Label();
            textBox_password = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            textBox_username = new TextBox();
            panel3 = new Panel();
            comboBox_department = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            comboBox_gender = new ComboBox();
            label3 = new Label();
            panel4 = new Panel();
            label_programName = new Label();
            textBox_programName = new TextBox();
            panel10 = new Panel();
            label8 = new Label();
            textBox_email = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel_avatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_avatar).BeginInit();
            tableLayoutPanel_form.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 288F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel_form, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1066, 742);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 48, 103);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(781, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 736);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel_avatar, 0, 0);
            tableLayoutPanel3.Controls.Add(label_name, 0, 1);
            tableLayoutPanel3.Location = new Point(29, 145);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(222, 287);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // panel_avatar
            // 
            panel_avatar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_avatar.BackColor = Color.White;
            panel_avatar.Controls.Add(pictureBox_avatar);
            panel_avatar.Location = new Point(3, 3);
            panel_avatar.Name = "panel_avatar";
            panel_avatar.Size = new Size(216, 244);
            panel_avatar.TabIndex = 21;
            // 
            // pictureBox_avatar
            // 
            pictureBox_avatar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_avatar.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_avatar.Image = Properties.Resources.avatar;
            pictureBox_avatar.Location = new Point(5, 5);
            pictureBox_avatar.Margin = new Padding(5);
            pictureBox_avatar.Name = "pictureBox_avatar";
            pictureBox_avatar.Size = new Size(206, 234);
            pictureBox_avatar.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_avatar.TabIndex = 20;
            pictureBox_avatar.TabStop = false;
            // 
            // label_name
            // 
            label_name.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_name.AutoSize = true;
            label_name.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_name.ForeColor = Color.White;
            label_name.Location = new Point(3, 257);
            label_name.Name = "label_name";
            label_name.Size = new Size(216, 22);
            label_name.TabIndex = 23;
            label_name.Text = "Tên giảng viên";
            label_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_form
            // 
            tableLayoutPanel_form.ColumnCount = 1;
            tableLayoutPanel_form.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_form.Controls.Add(button_update, 0, 2);
            tableLayoutPanel_form.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel_form.Controls.Add(label1, 0, 0);
            tableLayoutPanel_form.Dock = DockStyle.Fill;
            tableLayoutPanel_form.Location = new Point(3, 3);
            tableLayoutPanel_form.Name = "tableLayoutPanel_form";
            tableLayoutPanel_form.RowCount = 3;
            tableLayoutPanel_form.RowStyles.Add(new RowStyle(SizeType.Percent, 35.10204F));
            tableLayoutPanel_form.RowStyles.Add(new RowStyle(SizeType.Percent, 64.89796F));
            tableLayoutPanel_form.RowStyles.Add(new RowStyle(SizeType.Absolute, 302F));
            tableLayoutPanel_form.Size = new Size(772, 736);
            tableLayoutPanel_form.TabIndex = 1;
            tableLayoutPanel_form.Paint += tableLayoutPanel_form_Paint;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_update.BackColor = Color.FromArgb(35, 48, 103);
            button_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_update.ForeColor = SystemColors.ButtonHighlight;
            button_update.Location = new Point(595, 433);
            button_update.Margin = new Padding(3, 0, 10, 3);
            button_update.Name = "button_update";
            button_update.Size = new Size(167, 40);
            button_update.TabIndex = 8;
            button_update.Text = "Sửa";
            button_update.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.91384F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0861626F));
            tableLayoutPanel2.Controls.Add(panel8, 1, 1);
            tableLayoutPanel2.Controls.Add(panel7, 0, 3);
            tableLayoutPanel2.Controls.Add(panel6, 1, 2);
            tableLayoutPanel2.Controls.Add(panel5, 0, 2);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Controls.Add(panel10, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 155);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.916666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.63889F));
            tableLayoutPanel2.Size = new Size(766, 275);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Controls.Add(comboBox_role);
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(393, 66);
            panel8.Margin = new Padding(3, 3, 3, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(370, 58);
            panel8.TabIndex = 4;
            // 
            // comboBox_role
            // 
            comboBox_role.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_role.FormattingEnabled = true;
            comboBox_role.Location = new Point(95, 17);
            comboBox_role.Name = "comboBox_role";
            comboBox_role.Size = new Size(263, 28);
            comboBox_role.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(35, 48, 103);
            label7.Location = new Point(11, 23);
            label7.Name = "label7";
            label7.Size = new Size(48, 22);
            label7.TabIndex = 1;
            label7.Text = "Role";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.Controls.Add(label6);
            panel7.Controls.Add(textBox_phone);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 188);
            panel7.Margin = new Padding(3, 3, 3, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(384, 87);
            panel7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(35, 48, 103);
            label6.Location = new Point(3, 30);
            label6.Name = "label6";
            label6.Size = new Size(117, 22);
            label6.TabIndex = 1;
            label6.Text = "Phone Num.";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_phone.BorderStyle = BorderStyle.FixedSingle;
            textBox_phone.Location = new Point(126, 18);
            textBox_phone.Multiline = true;
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(246, 34);
            textBox_phone.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Controls.Add(textBox_password);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(393, 127);
            panel6.Margin = new Padding(3, 3, 3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(370, 58);
            panel6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(35, 48, 103);
            label5.Location = new Point(11, 23);
            label5.Name = "label5";
            label5.Size = new Size(92, 22);
            label5.TabIndex = 1;
            label5.Text = "Password";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_password
            // 
            textBox_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_password.BorderStyle = BorderStyle.FixedSingle;
            textBox_password.Location = new Point(109, 11);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(249, 34);
            textBox_password.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBox_username);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 127);
            panel5.Margin = new Padding(3, 3, 3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(384, 58);
            panel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(35, 48, 103);
            label4.Location = new Point(3, 23);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 1;
            label4.Text = "Username";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_username
            // 
            textBox_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_username.BorderStyle = BorderStyle.FixedSingle;
            textBox_username.Location = new Point(109, 11);
            textBox_username.Multiline = true;
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(263, 34);
            textBox_username.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox_department);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 66);
            panel3.Margin = new Padding(3, 3, 3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 58);
            panel3.TabIndex = 2;
            // 
            // comboBox_department
            // 
            comboBox_department.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_department.FormattingEnabled = true;
            comboBox_department.Location = new Point(101, 17);
            comboBox_department.Name = "comboBox_department";
            comboBox_department.Size = new Size(271, 28);
            comboBox_department.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(35, 48, 103);
            label2.Location = new Point(3, 23);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 1;
            label2.Text = "Depart.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox_gender);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(393, 3);
            panel2.Margin = new Padding(3, 3, 3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 60);
            panel2.TabIndex = 2;
            // 
            // comboBox_gender
            // 
            comboBox_gender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_gender.FormattingEnabled = true;
            comboBox_gender.Location = new Point(95, 17);
            comboBox_gender.Name = "comboBox_gender";
            comboBox_gender.Size = new Size(263, 28);
            comboBox_gender.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(35, 48, 103);
            label3.Location = new Point(11, 24);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 1;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(label_programName);
            panel4.Controls.Add(textBox_programName);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Margin = new Padding(3, 3, 3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 60);
            panel4.TabIndex = 1;
            // 
            // label_programName
            // 
            label_programName.AutoSize = true;
            label_programName.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_programName.ForeColor = Color.FromArgb(35, 48, 103);
            label_programName.Location = new Point(3, 23);
            label_programName.Name = "label_programName";
            label_programName.Size = new Size(92, 22);
            label_programName.TabIndex = 1;
            label_programName.Text = "FullName";
            label_programName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_programName
            // 
            textBox_programName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_programName.BorderStyle = BorderStyle.FixedSingle;
            textBox_programName.Location = new Point(101, 12);
            textBox_programName.Multiline = true;
            textBox_programName.Name = "textBox_programName";
            textBox_programName.Size = new Size(271, 34);
            textBox_programName.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(label8);
            panel10.Controls.Add(textBox_email);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(393, 188);
            panel10.Margin = new Padding(3, 3, 3, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(370, 87);
            panel10.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(35, 48, 103);
            label8.Location = new Point(11, 27);
            label8.Name = "label8";
            label8.Size = new Size(56, 22);
            label8.TabIndex = 1;
            label8.Text = "Email";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_email
            // 
            textBox_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_email.BorderStyle = BorderStyle.FixedSingle;
            textBox_email.Location = new Point(95, 18);
            textBox_email.Multiline = true;
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(263, 34);
            textBox_email.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(35, 48, 103);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(766, 152);
            label1.TabIndex = 4;
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1066, 742);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel_avatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_avatar).EndInit();
            tableLayoutPanel_form.ResumeLayout(false);
            tableLayoutPanel_form.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel_avatar;
        private PictureBox pictureBox_avatar;
        private TableLayoutPanel tableLayoutPanel_form;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel8;
        private ComboBox comboBox_role;
        private Label label7;
        private Panel panel7;
        private Label label6;
        private TextBox textBox_phone;
        private Panel panel6;
        private Label label5;
        private TextBox textBox_password;
        private Panel panel5;
        private Label label4;
        private TextBox textBox_username;
        private Panel panel3;
        private ComboBox comboBox_department;
        private Label label2;
        private Panel panel2;
        private ComboBox comboBox_gender;
        private Label label3;
        private Panel panel4;
        private Label label_programName;
        private TextBox textBox_programName;
        private Panel panel10;
        private Label label8;
        private TextBox textBox_email;
        private Label label1;
        private Label label_name;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button_update;
    }
}