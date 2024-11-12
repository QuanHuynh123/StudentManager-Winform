using System.Net.Http.Headers;
using System.Reflection;
using System.Windows.Forms;

namespace GUI
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox = new PictureBox();
            tableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.SkyBlue;
            label1.Location = new Point(136, 355);
            label1.Name = "label1";
            label1.Size = new Size(498, 54);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ SINH VIÊN SGU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.BackgroundImage = (Image)resources.GetObject("pictureBox.BackgroundImage");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Location = new Point(184, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(401, 309);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(label1, 0, 1);
            tableLayoutPanel.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel.Size = new Size(770, 450);
            tableLayoutPanel.TabIndex = 0;
            tableLayoutPanel.Paint += tableLayoutPanel_Paint_1;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(770, 450);
            Controls.Add(tableLayoutPanel);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox;
        private TableLayoutPanel tableLayoutPanel;
    }
}
