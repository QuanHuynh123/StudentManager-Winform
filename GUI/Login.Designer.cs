namespace GUI
{
    partial class Login
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
            button1 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            fontDialog1 = new FontDialog();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(197, 123);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "abc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(197, 68);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "cc";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 532);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        private FontDialog fontDialog1;
        private Button button2;
    }
}