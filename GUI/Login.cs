using System;
using System.Windows.Forms;
using DTO;
using DAL; 
using BLL; 

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Kích hoạt double buffering
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username")
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Username";
                usernameTextBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Tạo đối tượng AccountDTO
            AccountDTO account = new AccountDTO();

            account.SetUsername(username);
            account.SetPassword(password);

            // Khởi tạo TeacherDAL
            TeacherDAL teacherDAL = new TeacherDAL();

            // Kiểm tra thông tin đăng nhập
            bool isAuthenticated = teacherDAL.CheckTeacherPassword(account);

            // Hiển thị thông báo tương ứng
            if (isAuthenticated)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SessionLogin.LoggedInUsername = username;
                // Mở trang chính sau khi đăng nhập thành công
                home main = new home();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại." + isAuthenticated, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CustomPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            int borderWidth = 4; // Độ dày của viền

            // Tạo Pen màu trắng cho viền
            using (Pen borderPen = new Pen(Color.White, borderWidth))
            {
                Rectangle rect = new Rectangle(borderWidth / 2, borderWidth / 2,
                                               panel.ClientSize.Width - borderWidth,
                                               panel.ClientSize.Height - borderWidth);

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(borderPen, rect);
            }
        }

        private void usernameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void overlay_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
