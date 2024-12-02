using GUI.Properties;

namespace GUI
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
            dashboard3 = new Panel();
            lblTotalClass = new Label();
            lblCountClass = new Label();
            dashboard2 = new Panel();
            lblTotalSubject = new Label();
            lblCountSubject = new Label();
            dashboard1 = new Panel();
            lblTotalStudent = new Label();
            lblCountStudent = new Label();
            panel1 = new Panel();
            panel_chart1 = new Panel();
            panel_chart2 = new Panel();
            dashboard3.SuspendLayout();
            dashboard2.SuspendLayout();
            dashboard1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dashboard3
            // 
            dashboard3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dashboard3.BackColor = Color.DarkBlue;
            dashboard3.Controls.Add(lblTotalClass);
            dashboard3.Controls.Add(lblCountClass);
            dashboard3.Location = new Point(762, -2);
            dashboard3.Name = "dashboard3";
            dashboard3.Size = new Size(318, 117);
            dashboard3.TabIndex = 5;
            // 
            // lblTotalClass
            // 
            lblTotalClass.AutoSize = true;
            lblTotalClass.BackColor = Color.Transparent;
            lblTotalClass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalClass.ForeColor = Color.White;
            lblTotalClass.Location = new Point(17, 56);
            lblTotalClass.Name = "lblTotalClass";
            lblTotalClass.Size = new Size(90, 23);
            lblTotalClass.TabIndex = 23;
            lblTotalClass.Text = "Total class";
            // 
            // lblCountClass
            // 
            lblCountClass.AutoSize = true;
            lblCountClass.BackColor = Color.Transparent;
            lblCountClass.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountClass.ForeColor = Color.White;
            lblCountClass.Location = new Point(17, 13);
            lblCountClass.Name = "lblCountClass";
            lblCountClass.Size = new Size(35, 41);
            lblCountClass.TabIndex = 22;
            lblCountClass.Text = "3";
            // 
            // dashboard2
            // 
            dashboard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard2.BackColor = Color.DarkGreen;
            dashboard2.Controls.Add(lblTotalSubject);
            dashboard2.Controls.Add(lblCountSubject);
            dashboard2.Location = new Point(354, -2);
            dashboard2.Name = "dashboard2";
            dashboard2.Size = new Size(335, 117);
            dashboard2.TabIndex = 6;
            // 
            // lblTotalSubject
            // 
            lblTotalSubject.AutoSize = true;
            lblTotalSubject.BackColor = Color.Transparent;
            lblTotalSubject.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSubject.ForeColor = Color.White;
            lblTotalSubject.Location = new Point(12, 56);
            lblTotalSubject.Name = "lblTotalSubject";
            lblTotalSubject.Size = new Size(118, 23);
            lblTotalSubject.TabIndex = 22;
            lblTotalSubject.Text = "Total subjects";
            // 
            // lblCountSubject
            // 
            lblCountSubject.AutoSize = true;
            lblCountSubject.BackColor = Color.Transparent;
            lblCountSubject.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountSubject.ForeColor = Color.White;
            lblCountSubject.Location = new Point(12, 13);
            lblCountSubject.Name = "lblCountSubject";
            lblCountSubject.Size = new Size(35, 41);
            lblCountSubject.TabIndex = 21;
            lblCountSubject.Text = "3";
            // 
            // dashboard1
            // 
            dashboard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dashboard1.BackColor = Color.Chocolate;
            dashboard1.Controls.Add(lblTotalStudent);
            dashboard1.Controls.Add(lblCountStudent);
            dashboard1.Location = new Point(2, -2);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(282, 117);
            dashboard1.TabIndex = 4;
            // 
            // lblTotalStudent
            // 
            lblTotalStudent.AutoSize = true;
            lblTotalStudent.BackColor = Color.Transparent;
            lblTotalStudent.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudent.ForeColor = Color.White;
            lblTotalStudent.Location = new Point(11, 56);
            lblTotalStudent.Name = "lblTotalStudent";
            lblTotalStudent.Size = new Size(122, 23);
            lblTotalStudent.TabIndex = 21;
            lblTotalStudent.Text = "Total students";
            // 
            // lblCountStudent
            // 
            lblCountStudent.AutoSize = true;
            lblCountStudent.BackColor = Color.Transparent;
            lblCountStudent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountStudent.ForeColor = Color.White;
            lblCountStudent.Location = new Point(11, 13);
            lblCountStudent.Name = "lblCountStudent";
            lblCountStudent.Size = new Size(35, 41);
            lblCountStudent.TabIndex = 20;
            lblCountStudent.Text = "3";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel_chart1);
            panel1.Controls.Add(panel_chart2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 647);
            panel1.TabIndex = 7;
            // 
            // panel_chart1
            // 
            panel_chart1.Dock = DockStyle.Left;
            panel_chart1.Location = new Point(0, 0);
            panel_chart1.Name = "panel_chart1";
            panel_chart1.Size = new Size(534, 647);
            panel_chart1.TabIndex = 2;
            // 
            // panel_chart2
            // 
            panel_chart2.Dock = DockStyle.Right;
            panel_chart2.Location = new Point(540, 0);
            panel_chart2.Name = "panel_chart2";
            panel_chart2.Size = new Size(559, 647);
            panel_chart2.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1099, 789);
            Controls.Add(panel1);
            Controls.Add(dashboard3);
            Controls.Add(dashboard2);
            Controls.Add(dashboard1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            dashboard3.ResumeLayout(false);
            dashboard3.PerformLayout();
            dashboard2.ResumeLayout(false);
            dashboard2.PerformLayout();
            dashboard1.ResumeLayout(false);
            dashboard1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel dashboard3;
        private Label lblTotalClass;
        private Label lblCountClass;
        private Panel dashboard2;
        private Label lblTotalSubject;
        private Label lblCountSubject;
        private Panel dashboard1;
        private Label lblTotalStudent;
        private Label lblCountStudent;
        private Panel panel1;
        private Panel panel_chart2;
        private Panel panel_chart1;
    }
}