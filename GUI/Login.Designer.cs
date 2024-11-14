
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanel1 = new TableLayoutPanel();
            customPanel = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            titleLogin = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            forgotPasswordLabel = new Label();
            loginButton = new Button();
            registerLabel = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            customPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pictureBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(customPanel, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1280, 800);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // customPanel
            // 
            customPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel.BackColor = Color.FromArgb(150, 135, 206, 235);
            customPanel.Controls.Add(tableLayoutPanel);
            customPanel.Location = new Point(323, 136);
            customPanel.Name = "customPanel";
            customPanel.Size = new Size(634, 527);
            customPanel.TabIndex = 0;
            customPanel.Paint += CustomPanel_Paint;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(titleLogin, 3, 0);
            tableLayoutPanel.Controls.Add(usernameTextBox, 0, 1);
            tableLayoutPanel.Controls.Add(passwordTextBox, 0, 2);
            tableLayoutPanel.Controls.Add(forgotPasswordLabel, 0, 3);
            tableLayoutPanel.Controls.Add(loginButton, 0, 4);
            tableLayoutPanel.Controls.Add(registerLabel, 0, 5);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel.Size = new Size(634, 527);
            tableLayoutPanel.TabIndex = 0;
            // 
            // titleLogin
            // 
            titleLogin.AutoSize = true;
            titleLogin.Dock = DockStyle.Fill;
            titleLogin.Font = new Font("Arial", 18F, FontStyle.Bold);
            titleLogin.ForeColor = Color.Black;
            titleLogin.Location = new Point(3, 0);
            titleLogin.Name = "titleLogin";
            titleLogin.Size = new Size(628, 171);
            titleLogin.TabIndex = 0;
            titleLogin.Text = "ĐĂNG NHẬP HỆ THỐNG";
            titleLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.Font = new Font("Arial", 14F);
            usernameTextBox.ForeColor = Color.Silver;
            usernameTextBox.Location = new Point(136, 182);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(362, 34);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "Username";
            usernameTextBox.Enter += usernameTextBox_Enter;
            usernameTextBox.Leave += usernameTextBox_Leave;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Font = new Font("Arial", 14F);
            passwordTextBox.ForeColor = Color.Silver;
            passwordTextBox.Location = new Point(135, 239);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(363, 34);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Text = "Password";
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // forgotPasswordLabel
            // 
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.Dock = DockStyle.Fill;
            forgotPasswordLabel.ForeColor = Color.White;
            forgotPasswordLabel.Location = new Point(3, 285);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(628, 57);
            forgotPasswordLabel.TabIndex = 3;
            forgotPasswordLabel.Text = "Quên mật khẩu";
            forgotPasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.BackColor = Color.FromArgb(130, 0, 0, 255);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(216, 378);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(202, 41);
            loginButton.TabIndex = 4;
            loginButton.Text = "ĐĂNG NHẬP";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Dock = DockStyle.Fill;
            registerLabel.Font = new Font("Arial", 10F, FontStyle.Bold);
            registerLabel.ForeColor = Color.Black;
            registerLabel.Location = new Point(3, 456);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(628, 71);
            registerLabel.TabIndex = 5;
            registerLabel.Text = "Chưa có tài khoản? ĐĂNG KÝ";
            registerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Controls.Add(tableLayoutPanel1);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 800);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            ClientSize = new Size(1280, 800);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            customPanel.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pictureBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void SetBackgroundImage(Control control)
        {
            await Task.Run(() =>
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "Resources", "sgu.jpg");

                if (System.IO.File.Exists(imagePath))
                {
                    Image img = Image.FromFile(imagePath);
                    control.Invoke(new Action(() =>
                    {
                        control.BackgroundImage = img;
                        control.BackgroundImageLayout = ImageLayout.Stretch;
                    }));
                }
                else
                {
                    MessageBox.Show("Image not found! " + imagePath);
                }
            });
        }
        private void SetPlaceholder(TextBox usernameTextBox, string v)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel customPanel;
        private TableLayoutPanel tableLayoutPanel;
        private Label titleLogin;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label forgotPasswordLabel;
        private Button loginButton;
        private Label registerLabel;
        private PictureBox pictureBox1;
        //private Panel overlay;
    }
}