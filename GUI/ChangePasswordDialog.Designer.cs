namespace GUI
{
    partial class ChangePasswordDialog
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            label1 = new Label();
            textBox_oldPassword = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            textBox_newPassword = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            textBox_confirmPassword = new TextBox();
            panel3 = new Panel();
            button_cancel = new Button();
            button_change = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(316, 191);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(textBox_oldPassword);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(313, 40);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "OldPassword";
            // 
            // textBox_oldPassword
            // 
            textBox_oldPassword.Location = new Point(114, 8);
            textBox_oldPassword.Name = "textBox_oldPassword";
            textBox_oldPassword.Size = new Size(187, 23);
            textBox_oldPassword.TabIndex = 0;
            textBox_oldPassword.Enter += oldPassword_Enter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_newPassword);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 40);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 11);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "New Password";
            // 
            // textBox_newPassword
            // 
            textBox_newPassword.Location = new Point(114, 8);
            textBox_newPassword.Name = "textBox_newPassword";
            textBox_newPassword.Size = new Size(187, 23);
            textBox_newPassword.TabIndex = 1;
            textBox_newPassword.Enter += newPassword_Enter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_confirmPassword);
            panel2.Location = new Point(3, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 40);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 11);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password";
            // 
            // textBox_confirmPassword
            // 
            textBox_confirmPassword.Location = new Point(114, 8);
            textBox_confirmPassword.Name = "textBox_confirmPassword";
            textBox_confirmPassword.Size = new Size(187, 23);
            textBox_confirmPassword.TabIndex = 2;
            textBox_confirmPassword.Enter += confirmPassword_Enter;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_cancel);
            panel3.Controls.Add(button_change);
            panel3.Location = new Point(3, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 40);
            panel3.TabIndex = 2;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.FromArgb(255, 8, 8);
            button_cancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cancel.ForeColor = SystemColors.ControlLightLight;
            button_cancel.Location = new Point(181, 8);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(100, 29);
            button_cancel.TabIndex = 1;
            button_cancel.Text = "Hủy";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_change
            // 
            button_change.BackColor = Color.FromArgb(8, 225, 8);
            button_change.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_change.ForeColor = SystemColors.ControlLightLight;
            button_change.Location = new Point(47, 8);
            button_change.Name = "button_change";
            button_change.Size = new Size(96, 30);
            button_change.TabIndex = 0;
            button_change.Text = "Xác nhận";
            button_change.UseVisualStyleBackColor = false;
            button_change.Click += button_change_Click;
            // 
            // ChangePasswordDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 191);
            Controls.Add(flowLayoutPanel1);
            Name = "ChangePasswordDialog";
            Text = "ChangePasswordDialog";
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private TextBox textBox_oldPassword;
        private Label label2;
        private TextBox textBox_newPassword;
        private Label label3;
        private TextBox textBox_confirmPassword;
        private Button button_cancel;
        private Button button_change;
    }
}