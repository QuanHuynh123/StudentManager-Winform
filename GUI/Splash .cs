using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Splash : Form
    {
        private System.Windows.Forms.Timer timer;

        public Splash()
        {
            InitializeComponent();
            // Khởi tạo Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000; // 2000ms = 2 giây
            timer.Tick += Timer_Tick; // Gắn sự kiện cho Timer
            timer.Start(); // Bắt đầu Timer khi Splash form mở
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Dừng Timer
            this.Hide(); // Ẩn Splash screen
            Login loginForm = new Login(); // Tạo form Login
            loginForm.Show(); // Hiển thị form Login
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện ở đây
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
