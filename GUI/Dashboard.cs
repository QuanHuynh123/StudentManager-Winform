using BLL;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
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
        private DashBoardBLL dashBoardBLL;
        public Dashboard()
        {
            InitializeComponent();
            dashBoardBLL = new DashBoardBLL();
            loadHeaderDashboard();
            LoadChart1();
            LoadChart2();
        }

        public void loadHeaderDashboard()
        {
            lblCountStudent.Text = dashBoardBLL.GetTotalStudents().ToString();
            lblCountSubject.Text = dashBoardBLL.GetTotalSubjects().ToString();
            lblCountClass.Text = dashBoardBLL.GetTotalClasses().ToString();
        }

        private void LoadChart1()
        {
            // Lấy dữ liệu từ BLL (Dữ liệu số lượng sinh viên nhập học theo từng năm)
            var enrollmentData = dashBoardBLL.GetEnrollmentDataByDepartment(SessionLogin.LoggedInTeacher.TeacherID);

            CartesianChart cartesianChart1 = new CartesianChart
            {
                Dock = DockStyle.Fill
            };

            // Dữ liệu cho chart: số lượng sinh viên nhập học theo từng năm
            var series = new List<ColumnSeries<int>>();
            foreach (var yearData in enrollmentData)
            {
                series.Add(new ColumnSeries<int>
                {
                    Name = $"Năm {yearData.EnrollmentYear}",
                    Values = new int[] { yearData.StudentCount }
                });
            }

            cartesianChart1.Series = series.ToArray();

            // Biến years để lưu các năm duy nhất
            var years = enrollmentData.Select(x => x.EnrollmentYear.ToString()).Distinct().ToArray();

            // Gắn trục X với các năm
            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Labels = years, // Sử dụng các năm lấy từ enrollmentData
                }
            };

            // Gắn trục Y với số lượng sinh viên
            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = value => value.ToString(), 
                    Name = "Sinh viên nhập học"
        }
            };

            panel_chart1.Controls.Add(cartesianChart1);
        }
        private void LoadChart2()
        {
            // Lấy dữ liệu từ BLL
            var passFailData = dashBoardBLL.GetPassFailRatioForCurrentYear();

            // Khởi tạo CartesianChart
            CartesianChart cartesianChart2 = new CartesianChart
            {
                Dock = DockStyle.Fill
            };

            // Tạo dữ liệu ColumnSeries cho "Đậu" và "Rớt"
            var series = new List<ColumnSeries<int>>
    {
        new ColumnSeries<int>
        {
            Values = new[] { passFailData.ContainsKey(true) ? passFailData[true] : 0 }, // Số lượng Đậu
            Name = "Đạt",
            Fill = new SolidColorPaint(SKColors.Green)
        },
        new ColumnSeries<int>
        {
            Values = new[] { passFailData.ContainsKey(false) ? passFailData[false] : 0 }, // Số lượng Rớt
            Name = "Chưa đạt",
            Fill = new SolidColorPaint(SKColors.Red)
        }
    };

            cartesianChart2.Series = series.ToArray();

            // Đặt trục X (hiển thị các nhãn Đậu, Rớt)
            cartesianChart2.XAxes = new Axis[]
            {
        new Axis
        {
            Labels = new[] { "Đạt", "Chưa Đạt" }, // Các nhãn trục X
            Name = "Kết quả",
            NamePaint = new SolidColorPaint(SKColors.Black),
            LabelsPaint = new SolidColorPaint(SKColors.Black)
        }
            };

            // Đặt trục Y (hiển thị số lượng sinh viên)
            cartesianChart2.YAxes = new Axis[]
            {
        new Axis
        {
            Name = "Sinh viên đạt môn",
            NamePaint = new SolidColorPaint(SKColors.Black),
            Labeler = value => value.ToString(),
        }
            };

            panel_chart2.Controls.Add(cartesianChart2);
        }



    }
}
