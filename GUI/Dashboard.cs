using BLL;
using DocumentFormat.OpenXml.Bibliography;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System.Collections.ObjectModel;
using System.Data;


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
            var enrollmentData = dashBoardBLL.GetEnrollmentStudent();


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

            var years = enrollmentData.Select(data => data.EnrollmentYear).ToArray();
            var studentCounts = enrollmentData.Select(data => data.StudentCount).ToArray();


            // Gán dữ liệu vào Series của CartesianChart
            cartesianChart1.Series = new ObservableCollection<ISeries>
            {
                new ColumnSeries<int>
                {
                    Values = new ObservableCollection<int>(studentCounts) // Dữ liệu từ mảng studentCounts
                }
            };

            // Gán nhãn trục X (các năm) từ mảng years
            cartesianChart1.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = years.Select(year => year.ToString()).ToArray() // Chuyển đổi years thành chuỗi
                }
            };

            // Tùy chỉnh trục Y (số lượng học sinh)
            cartesianChart1.YAxes = new List<Axis>
            {
                new Axis
                {
                    Labeler = value => value.ToString() // Hiển thị giá trị số lượng học sinh trực tiếp
                }
            };

            panel_chart1.Controls.Add(cartesianChart1);
        }

        private void LoadChart2()
        {
            // Lấy dữ liệu từ BLL
            var passFailData = dashBoardBLL.GetPassFailRatioForCurrentYear();

            // Tạo hai mảng cho giá trị và tên
            var values = new[]
            {
                passFailData.ContainsKey(true) ? passFailData[true] : 0,  // Số lượng Đậu
                passFailData.ContainsKey(false) ? passFailData[false] : 0 // Số lượng Rớt
            };

            var names = new[] { "Đạt", "Chưa đạt" }; // Nhãn cho trục X

            // Gán dữ liệu vào Series của CartesianChart
            cartesianChart2.Series = new ObservableCollection<ISeries>
            {
                new ColumnSeries<int>
                {
                    Values = new ObservableCollection<int>(values), // Gán dữ liệu từ mảng values
                    Name = "Tỉ lệ đạt",
                    Fill = new SolidColorPaint(SKColors.Green)
                }
            };

            // Gán nhãn trục X từ mảng names
            cartesianChart2.XAxes = new List<Axis>
            {
                new Axis
                {
                    Labels = names // Gán nhãn từ mảng names
                }
            };

            // Tùy chỉnh trục Y
            cartesianChart2.YAxes = new List<Axis>
            {
                new Axis
                {
                    Labeler = value => value.ToString() // Hiển thị số lượng trực tiếp
                }
            };
            panel_chart2.Controls.Add(cartesianChart2);
        }


    }
}
