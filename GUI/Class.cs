using BLL;
using DAL.Models;
using DTO;
using DTO.Models;
using Mapster;

namespace GUI
{
    public partial class Class : Form
    {
        private readonly ClassBLL classBLL;
        private readonly TeacherBLL teacherBLL;
        private readonly SubjectBLL subjectBLL;
        private int currentPageIndex;
        private int subjectIdSelected = 0 ;
        private int teacherIdSelected = 0 ;
        private Dictionary<string, Button> controls = [];

        public Class()
        {
            InitializeComponent();
            classBLL = new ClassBLL();
            teacherBLL = new TeacherBLL();
            subjectBLL = new SubjectBLL();
            currentPageIndex = 0;
            InitPage();
        }

        private void InitPage()
        {
            listView_class.FullRowSelect = true;

            button_search.Click += (sender, e) => search_action(sender, e);

            controls.Add(Constants.Add, button_add);
            controls.Add(Constants.Update, button_edit);
            controls.Add(Constants.Delete, button_delete);

            search_action(null, null);
            BindDataToComboBox();

            // Decentralize
            Common.LoadFeatureForUser(controls, Constants.Class);
        }

        private void BindDataToComboBox()
        {
            SearchResponse<TeacherDTO> teacherSearchResponse = teacherBLL.Search(new SearchRequest { PageSize = 9999 });
            SearchResponse<SubjectDTO> subjectSearchResponse = subjectBLL.Search(new SearchRequest { PageSize = 9999 });

            comboBox_teacher.DataSource = teacherSearchResponse.Data.Select(t => new KeyValuePair<int, string>(t.TeacherID, t.FullName)).ToList();
            comboBox_teacher.DisplayMember = "Value";
            comboBox_teacher.ValueMember = "Key";

            comboBox_subject.DataSource = subjectSearchResponse.Data.Select(s => new KeyValuePair<int, string>(s.SubjectID, s.SubjectName)).ToList();
            comboBox_subject.DisplayMember = "Value";
            comboBox_subject.ValueMember = "Key";
        }

        private void ResetPage()
        {
            listView_class.Items.Clear();
        }

        private void search_action(object sender, EventArgs e, int pageIndex = 0, int pageSize = 10)
        {
            var keyword = textBoxSearch.Text;
            SearchRequest searchRequest = new SearchRequest
            {
                KeyWord = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };

            SearchResponse<ClassDTO> result = classBLL.Search(searchRequest);

            ResetPage();

            result.Data.ForEach(x =>
            {
                ListViewItem item = new(x.ClassID.ToString());
                item.SubItems.Add(x.ClassName);
                item.SubItems.Add(x.Room);
                item.SubItems.Add($"{x.SubjectID} - {x.Subject.SubjectName}");
                item.SubItems.Add($"{x.TeacherID} - {x.Teacher.FullName}");
                item.SubItems.Add(x.StartPeriod.ToString());
                item.SubItems.Add(x.EndPeriod.ToString());
                item.SubItems.Add(x.Day.ToString());
                item.SubItems.Add(x.StartDate.ToString());
                item.SubItems.Add(x.EndDate.ToString());

                listView_class.Items.Add(item);
            });

            currentPageIndex = searchRequest.PageIndex;
            page_number.Text = (currentPageIndex + 1).ToString();
            end_page.Text = ((int)Math.Ceiling((double)result.TotalRecord / searchRequest.PageSize)).ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string input = page_number.Text;

            // Check if the text is a valid number
            if (!int.TryParse(input, out _))
            {
                page_number.Text = String.Empty;
            }
            else if (currentPageIndex + 1 != int.Parse(input))
            {
                page_number.SelectionStart = page_number.Text.Length;
                search_action(null, null, int.Parse(input) - 1);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            // Check if we are not on the last page
            if (currentPageIndex > 0)
            {
                search_action(null, null, currentPageIndex - 1);
            }
            else
            {
                MessageBox.Show("Bạn đã ở trang cuối cùng.", "Pagination", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            int lastPage = int.Parse(end_page.Text);

            // Check if we are not on the last page
            if (currentPageIndex < lastPage - 1)
            {
                search_action(null, null, currentPageIndex + 1);
            }
            else
            {
                MessageBox.Show("Bạn đã ở trang cuối cùng.", "Pagination", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox_teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_teacher.SelectedItem is KeyValuePair<int, string> selectedTeacher)
                teacherIdSelected = selectedTeacher.Key;
        }

        private void comboBox_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_subject.SelectedItem is KeyValuePair<int, string> selectedSubject)
                subjectIdSelected = selectedSubject.Key;
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            if (!validateInput())
            {
                return;
            }

            // Get data
            string className = textBox_class_name.Text;
            int subjectID = subjectIdSelected;
            int teacherID = teacherIdSelected;
            string room = textBox_room.Text;
            int startPeriod = int.Parse(textBox_start_period.Text);
            int endPeriod = int.Parse(textBox_end_period.Text);
            int day = int.Parse(textBox_day.Text);
            //DateTime startDate = DateTime.TryParse(dateTimePicker_start_date.Text, out var date1) ? date1 : DateTime.Today;
            //DateTime endDate = DateTime.TryParse(dateTimePicker_end_date.Text, out var date2) ? date2 : DateTime.Today;

            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassDTO classDTO = new ClassDTO
            {
                ClassName = className,
                SubjectID = subjectID,
                TeacherID = teacherID,
                Room = room,
                StartPeriod = startPeriod,
                EndPeriod = endPeriod,
                //StartDate = startDate,
                //EndDate = endDate,
                Day = day
            };

            bool isAdded = classBLL.Create_action(classDTO);
            if (isAdded)
            {
                MessageBox.Show("Tạo thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                search_action(null, null);
                clearData();
                return;
            }
            else
            {
                MessageBox.Show("Tạo thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (listView_class.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 record bất kỳ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!validateInput())
            {
                return;
            }

            ListViewItem selectedItem = listView_class.SelectedItems[0];

            // Get data
            int classID = int.Parse(selectedItem.Text);
            string className = textBox_class_name.Text;
            int subjectID = subjectIdSelected;
            int teacherID = teacherIdSelected;
            string room = textBox_room.Text;
            int startPeriod = int.Parse(textBox_start_period.Text);
            int endPeriod = int.Parse(textBox_end_period.Text);
            int day = int.Parse(textBox_day.Text);
            //DateTime startDate = DateTime.TryParse(dateTimePicker_start_date.Text, out var date1) ? date1 : DateTime.Today;
            //DateTime endDate = DateTime.TryParse(dateTimePicker_end_date.Text, out var date2) ? date2 : DateTime.Today;

            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClassDTO classDTO = new ClassDTO
            {
                ClassID = classID,
                ClassName = className,
                SubjectID = subjectID,
                TeacherID = teacherID,
                Room = room,
                StartPeriod = startPeriod,
                EndPeriod = endPeriod,
                Day = day
            };

            bool isUpdated = classBLL.Update_action(classDTO);
            if (isUpdated)
            {
                MessageBox.Show("Cập nhật thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                search_action(null, null);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listView_class.CheckedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn record bất kì trước khi xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem item in listView_class.CheckedItems)
                {
                    int classID = int.Parse(item.Text);

                    bool isDeleted = classBLL.Delete_action(classID);
                    if (!isDeleted)
                    {
                        MessageBox.Show($"Lớp còn học sinh, giảng viên không được phép xóa !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                search_action(null, null);
            }
        }

        private void listView_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_class.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_class.SelectedItems[0];

                // Show data
                textBox_class_name.Text = selectedItem.SubItems[1].Text;
                textBox_room.Text = selectedItem.SubItems[2].Text;
                comboBox_subject.SelectedValue = int.Parse(selectedItem.SubItems[3].Text.Split(" - ")[0]);
                comboBox_teacher.SelectedValue = int.Parse(selectedItem.SubItems[4].Text.Split(" - ")[0]);
                comboBox_teacher.Enabled = false; 
                textBox_start_period.Text = selectedItem.SubItems[5].Text;
                textBox_end_period.Text = selectedItem.SubItems[6].Text;
                textBox_day.Text = selectedItem.SubItems[7].Text;
                //dateTimePicker_start_date.Value = DateTime.TryParse(selectedItem.SubItems[8].Text, out var startDate) ? startDate : DateTime.Today;
                //dateTimePicker_end_date.Value = DateTime.TryParse(selectedItem.SubItems[9].Text, out var endDate) ? endDate : DateTime.Today;
            }
            else
            {
                comboBox_teacher.Enabled = true;
            }
        }

        private void clearData()
        {
            textBox_class_name.Text = string.Empty;
            textBox_room.Text = string.Empty;
            comboBox_subject.Text = string.Empty;
            comboBox_teacher.Text = string.Empty;
            textBox_start_period.Text = string.Empty;
            textBox_end_period.Text = string.Empty;
            textBox_day.Text = string.Empty;
            //dateTimePicker_start_date.Value = DateTime.Today;
            //dateTimePicker_end_date.Value = DateTime.Today;
        }

        private void page_number_TextChanged(object sender, EventArgs e)
        {
            string input = page_number.Text;

            // Check if the text is a valid number
            if (!int.TryParse(input, out _))
            {
                page_number.Text = String.Empty;
            }
            else if (currentPageIndex + 1 != int.Parse(input))
            {
                page_number.SelectionStart = page_number.Text.Length;
                search_action(null, null, int.Parse(input) - 1);
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            string fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}-class";
            SearchResponse<ClassDTO> classResponse = classBLL.Search(new SearchRequest { PageSize = 9999 });
            List<ClassForExport> data = classResponse.Data.Adapt<List<ClassForExport>>();

            Common.ExportExcel<ClassForExport>(data, fileName);
        }

        private bool validateInput()
        {

            int maxPeriod = 5;
            bool isPassed = false;
            try
            {
                if (string.IsNullOrEmpty(textBox_class_name.Text))
                {
                    MessageBox.Show("Tên lớp không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return isPassed;
                }

                // Validate Subject ID
                if (subjectIdSelected <= 0)
                {
                    MessageBox.Show("Mã môn học không hợp lệ. Vui lòng chọn một môn học hợp lệ.", "Lỗi xác minh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return isPassed;
                }

                // Validate Teacher ID
                if (teacherIdSelected <= 0)
                {
                    MessageBox.Show("Mã giáo viên không hợp lệ. Vui lòng chọn một giáo viên hợp lệ.", "Lỗi xác minh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return isPassed;
                }

                // Validate Room
                if (string.IsNullOrWhiteSpace(textBox_room.Text))
                {
                    MessageBox.Show("Phòng không được để trống. Vui lòng nhập tên phòng hợp lệ.", "Lỗi xác minh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return isPassed;
                }

                // Validate Start Period
                if (!int.TryParse(textBox_start_period.Text, out int startPeriod) || startPeriod <= 0)
                {
                    MessageBox.Show("Tiết bắt đầu không hợp lệ. Vui lòng nhập một số nguyên dương.", "Lỗi xác minh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return isPassed;
                }

                // Validate End Period
                if (!int.TryParse(textBox_end_period.Text, out int endPeriod) || endPeriod <= 0)
                {
                    MessageBox.Show("Tiết kết thúc không hợp lệ. Vui lòng nhập một số nguyên dương.", "Lỗi xác minh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return isPassed;
                }

                // Check if Start Period is less than or equal to End Period
                if (startPeriod > endPeriod)
                {
                    MessageBox.Show("Tiết bắt đầu phải nhỏ hơn hoặc bằng tiết kết thúc.", "Lỗi xác minh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return isPassed;
                }

                // Check if Start Period is less than or equal to End Period
                if (endPeriod - startPeriod > 5)
                {
                    MessageBox.Show("Vượt quá số tiết cho phép.", "Lỗi xác minh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return isPassed;
                }

                // Validate Day
                if (!int.TryParse(textBox_day.Text, out int day) || day < 1 || day > 7)
                {
                    MessageBox.Show("Thứ không hợp lệ. Vui lòng nhập số từ 1 (Thứ Hai) đến 7 (Chủ Nhật).", "Lỗi xác minh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return isPassed;
                }

                // If all validations pass
                MessageBox.Show("Tất cả đầu vào đều hợp lệ!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return !isPassed;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return isPassed;
            }
        }

    }
}
