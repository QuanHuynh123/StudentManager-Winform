using BLL;
using DAL;
using DAL.Models;
using DTO;
using DTO.Models;
using Mapster;
using System.Text.RegularExpressions;


namespace GUI
{
    public partial class Student : Form
    {
        private StudentBLL studentBLL;
        private TrainingProgramBLL trainingProgramBLL;
        private DepartmentBLL departmentBLL;
        private bool check = false;
        public Student()
        {
            InitializeComponent();
            studentBLL = new StudentBLL();
            trainingProgramBLL = new TrainingProgramBLL();
            departmentBLL = new DepartmentBLL();
            comboBox_gender.Items.Clear();
            comboBox_gender.Items.Add("Nam");
            comboBox_gender.Items.Add("Nữ");
            loadStudentOfTeacher();
            hideButton();
            loadComboBoxProgram();
        }

        public void loadListStudent(List<StudentDTO> students)
        {
            listView_student.Items.Clear();
            listView_student.FullRowSelect = true;
            foreach (var student in students)
            {
                // Tạo một item mới cho mỗi phòng ban
                ListViewItem item = new ListViewItem(student.StudentID.ToString());
                item.SubItems.Add(student.FullName);
                item.SubItems.Add(student.Age.ToString());
                item.SubItems.Add(student.Email.ToString());
                item.SubItems.Add(student.PhoneNumber.ToString());
                if (student.Gender)
                    item.SubItems.Add("Nam");
                else item.SubItems.Add("Nữ");
                TrainingProgramDTO trainingProgram = trainingProgramBLL.FindByIdTrainingProgram(student.ProgramID);
                item.SubItems.Add(trainingProgram.ProgramName.ToString());
                item.SubItems.Add(student.EnrollmentDate.ToString());
                item.SubItems.Add(student.PermanentAddress.ToString());
                item.SubItems.Add(student.Hometown.ToString());

                // Thêm item vào ListView
                listView_student.Items.Add(item);
            }
        }

        private void hideButton()
        {
            if (SessionLogin.LoggedInTeacher.RoleID != Constants.HEAD_OF_DEPARTMENT & SessionLogin.LoggedInTeacher.RoleID != Constants.Principal)
            {
                button_departmentList.Enabled = false;
                button_departmentList.BackColor = Color.Gray;
                button_add.Enabled = false;
                button_add.BackColor = Color.Gray;
            }
        }

        private void button_departmentList_Click(object sender, EventArgs e)
        {
            loadStudentOfDepartment();
        }

        public void loadStudentOfDepartment()
        {
            List<StudentDTO> students = studentBLL.GetStudentByIdDepartment(SessionLogin.LoggedInTeacher.DepartmentID);
            loadListStudent(students);
            check = true;
        }

        private void button_classList_Click(object sender, EventArgs e)
        {
            loadStudentOfTeacher();
        }

        public void loadStudentOfTeacher()
        {
            List<StudentDTO> students = studentBLL.GetStudentFromHomeroom(SessionLogin.LoggedInTeacher.TeacherID);
            loadListStudent(students);
            check = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var fullName = textBox_name.Text;
            var email = textBox_email.Text;
            var phone = textBox_phone.Text;
            var gender = comboBox_gender.SelectedIndex == 0;  // Nam if index is 0
            var address = textBox_address.Text;
            var hometown = textBox_hometown.Text;
            var selectedTrainingProgram = (TrainingProgramDTO)comboBox_program.SelectedItem;
            var programID = selectedTrainingProgram?.ProgramID;
            var enrollmentDate = dateTimePicker_enrollmentDate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Tên không được để trống.");
                return;  // Dừng lại nếu có lỗi
            }

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.");
                return;  // Dừng lại nếu có lỗi
            }

            if (string.IsNullOrWhiteSpace(phone) || !IsValidPhoneNumber(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                return;  // Dừng lại nếu có lỗi
            }

            if (programID != null)
            {

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm học sinh này?",
                                                      "Xác nhận",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    var newStudent = new StudentDTO
                    {
                        FullName = fullName,
                        Email = email,
                        PhoneNumber = phone,
                        Gender = gender,
                        PermanentAddress = address,
                        Hometown = hometown,
                        ProgramID = programID.Value,
                        DepartmentID = SessionLogin.LoggedInTeacher.DepartmentID,
                        EnrollmentDate = DateTime.Parse(enrollmentDate)
                    };

                    bool isAdded = studentBLL.AddStudent(newStudent);
                    if (isAdded)
                    {
                        MessageBox.Show("Thêm học sinh thành công.");
                        loadListStudent(studentBLL.GetStudentByIdDepartment(SessionLogin.LoggedInTeacher.DepartmentID));
                    }
                    else
                    {
                        MessageBox.Show("Thêm học sinh thất bại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn chương trình đào tạo.");
            }
        }




        public void loadComboBoxProgram()
        {
            // Lấy danh sách các chương trình đào tạo
            comboBox_program.Items.Clear();
            List<TrainingProgramDTO> trainingPrograms = trainingProgramBLL.GetTrainingProgramsByDepartmentID(SessionLogin.LoggedInTeacher.DepartmentID);

            comboBox_program.DisplayMember = "ProgramName";  // Hiển thị tên chương trình
            comboBox_program.ValueMember = "ProgramID";       // Giá trị thực tế là ProgramID

            // Thêm các chương trình vào comboBox
            comboBox_program.DataSource = trainingPrograms;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listView_student.SelectedItems.Count > 0)
            {
                var selectedItem = listView_student.SelectedItems[0];
                int studentID = int.Parse(selectedItem.Text);

                // Xác nhận người dùng có muốn xóa không
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa học sinh này?",
                                                     "Xác nhận",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    bool isDeleted = studentBLL.DeleteStudent(studentID);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa học sinh thành công.");
                        loadListStudent(studentBLL.GetStudentFromHomeroom(SessionLogin.LoggedInTeacher.TeacherID));
                    }
                    else
                    {
                        MessageBox.Show("Xóa học sinh thất bại.");
                    }
                }
            }
        }

        private void listView_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (listView_student.SelectedItems.Count > 0)
            {
                // Lấy dòng đã chọn
                ListViewItem selectedItem = listView_student.SelectedItems[0];

                // Gán dữ liệu từ các SubItems vào các trường input
                textBox_name.Text = selectedItem.SubItems[1].Text;  // Tên học sinh
                textBox_email.Text = selectedItem.SubItems[3].Text;  // Email
                textBox_age.Text = selectedItem.SubItems[2].Text;
                textBox_phone.Text = selectedItem.SubItems[4].Text;  // Số điện thoại
                comboBox_gender.SelectedIndex = selectedItem.SubItems[5].Text == "Nam" ? 0 : 1;  // Giới tính
                textBox_address.Text = selectedItem.SubItems[8].Text; // Địa chỉ
                textBox_hometown.Text = selectedItem.SubItems[9].Text; // Quê quán
                comboBox_program.SelectedItem = selectedItem.SubItems[6].Text; // Chương trình đào tạo
                dateTimePicker_enrollmentDate.Value = DateTime.Parse(selectedItem.SubItems[7].Text);  // Ngày nhập học
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            var searchName = textBox_search.Text?.Trim(); // Loại bỏ khoảng trắng thừa và tránh null
            List<StudentDTO> students;

            if (string.IsNullOrEmpty(searchName))
            {
                if (check)
                    loadStudentOfDepartment();
                else loadStudentOfTeacher();
            }
            else
            {
                if (check)
                    students = studentBLL.SearchStudentsByNameOfDepartment(searchName, SessionLogin.LoggedInTeacher.DepartmentID);
                else
                    students = studentBLL.SearchStudentsByNameOfMyStudent(searchName, SessionLogin.LoggedInTeacher.TeacherID);
                loadListStudent(students);
            }
        }


        private void comboBox_program_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy ProgramID từ SelectedValue của comboBox
            int selectedProgramID = (int)comboBox_program.SelectedValue;
        }
        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Hàm kiểm tra định dạng số điện thoại
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            var phonePattern = @"^\d{10}$";  // Giả sử số điện thoại là 10 chữ số
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (listView_student.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một học sinh để cập nhật", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy dòng đã chọn
            ListViewItem selectedItem = listView_student.SelectedItems[0];
            int studentID = int.Parse(selectedItem.Text); // Lấy ID học sinh
            string fullName = textBox_name.Text; // Lấy tên học sinh
            string email = textBox_email.Text; // Lấy email
            string phone = textBox_phone.Text; // Lấy số điện thoại
            int age = int.Parse(textBox_age.Text);
            bool gender = comboBox_gender.SelectedIndex == 0; // Giới tính
            string address = textBox_address.Text; // Địa chỉ
            string hometown = textBox_hometown.Text; // Quê quán
            int programID = ((TrainingProgramDTO)comboBox_program.SelectedItem)?.ProgramID ?? 0; // ID chương trình đào tạo
            DateTime enrollmentDate = dateTimePicker_enrollmentDate.Value; // Ngày nhập học

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng học sinh mới
            StudentDTO updatedStudent = new StudentDTO
            {
                StudentID = studentID,
                FullName = fullName,
                Email = email,
                PhoneNumber = phone,
                Age = age,
                Gender = gender,
                PermanentAddress = address,
                Hometown = hometown,
                ProgramID = programID,
                EnrollmentDate = enrollmentDate
            };

            // Cập nhật thông tin học sinh
            bool isUpdated = studentBLL.UpdateStudent(updatedStudent);
            if (isUpdated)
            {
                MessageBox.Show("Cập nhật học sinh thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadListStudent(studentBLL.GetStudentFromHomeroom(SessionLogin.LoggedInTeacher.TeacherID)); // Tải lại danh sách học sinh
            }
            else
            {
                MessageBox.Show("Cập nhật học sinh thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listView_student_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)  // Kiểm tra nếu là click chuột phải
            {
                DialogResult result = MessageBox.Show("Xem chi tiết", "Thông báo", MessageBoxButtons.OKCancel);

                // Kiểm tra nếu người dùng nhấn OK
                if (result == DialogResult.OK)
                {
                    // Lấy dòng đã chọn
                    ListViewItem selectedItem = listView_student.SelectedItems[0];
                    int studentID = int.Parse(selectedItem.Text);
                    StudentDetail studentDetailForm = new StudentDetail(studentID);
                    studentDetailForm.Show();
                }
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            try
            {
                int roleID = SessionLogin.LoggedInTeacher.RoleID;
                if (roleID == Constants.TEACHER)
                {
                    string fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}-student-homeroom";
                    int teacherID = SessionLogin.LoggedInTeacher.TeacherID;
                    List<StudentDTO> studentResponse = studentBLL.GetStudentFromHomeroom(teacherID);
                    List<StudentForExport> data = studentResponse.Adapt<List<StudentForExport>>();

                    Common.ExportExcel<StudentForExport>(data, fileName);
                }

                if (roleID == Constants.HEAD_OF_DEPARTMENT)
                {
                    string fileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}-student-department";
                    int departmentID = SessionLogin.LoggedInTeacher.DepartmentID;
                    List<StudentDTO> studentResponse = studentBLL.GetStudentByIdDepartment(departmentID);
                    List<StudentForExport> data = studentResponse.Adapt<List<StudentForExport>>();

                    Common.ExportExcel<StudentForExport>(data, fileName);
                }

                MessageBox.Show("Export thành công", "Success");
            } catch
            {
                MessageBox.Show("Export thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
