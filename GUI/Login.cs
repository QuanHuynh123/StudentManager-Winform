using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetupForm(); // Gọi phương thức SetupForm để thiết lập form
        }

        private void SetupForm()
        {
            // Đặt kích thước form tiêu chuẩn
            this.Size = new Size(1024, 768);
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Form không thể thay đổi kích thước
            this.StartPosition = FormStartPosition.CenterScreen; // Đặt form xuất hiện giữa màn hình

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\sgu.jpg");
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch; // Kéo dãn hình nền để vừa với form
            }
            else
            {
                MessageBox.Show("Image not found! " + imagePath);
            }
        }
    }
}
