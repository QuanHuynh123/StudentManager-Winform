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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel_studentlist2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_studentlist2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Student().Show();
        }
    }
}
