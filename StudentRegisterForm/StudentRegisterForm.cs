using System;

namespace StudentRegisterForm {
    public partial class StudentRegisterForm : Form {
        StudentRegister studentRegister;
        Student[] students;
        Course[] studentCourses;
        bool isEditing = false;

        public StudentRegisterForm() {
            InitializeComponent();
            studentRegister = new StudentRegister();
            studentList.DisplayMember = "Id";
            studentList.ValueMember = "Id";
            coursesList.DataSource = studentCourses;
            coursesList.DisplayMember = "Name";
            UpdateStudentList();
        }

        public void UpdateStudentList() {
            SetCurrentStudent(null);
            students = studentRegister.GetStudents();
            studentList.DataSource = students;
        }
        
        public void UpdateCourseList() {
            students = studentRegister.GetStudents();
            studentList.DataSource = students;
        }

        public void SetCurrentStudent(int index) {
            studentList.SelectedIndex = index;
            if (studentList.SelectedIndex < 0) {
                firstName.Clear();
                lastName.Clear();
                date.Clear();
                return;
            }

            Student student = studentRegister.FindId(students[index.Value].Id);
            firstName.Text = student.FirstName;
            lastName.Text = student.LastName;
            date.Text = student.Date;
        }

        public void ToggleEdit() {
            if (isEditing) {
                isEditing = false;
                firstName.ReadOnly = true; lastName.ReadOnly = true; date.ReadOnly = true;
                editButton.Text = "Edit";
                saveButton.Enabled = false;
                SetCurrentStudent(studentList.SelectedIndex);
                studentList.Enabled = true;
            }
            else {
                isEditing = true;
                studentList.Enabled = false;
                firstName.ReadOnly = false; lastName.ReadOnly = false; date.ReadOnly = false;
                editButton.Text = "Cancel";
                saveButton.Enabled = true;
            }
        }

        public void Save() {
            if (!isEditing) return;
            if (studentList.SelectedIndex < 0) return;
            Student student = studentRegister.FindId((string)studentList.SelectedValue);
            student.FirstName = firstName.Text;
            student.LastName = lastName.Text;
            student.Date = date.Text;
            studentRegister.UpdateStudent(student.Id, firstName.Text, lastName.Text, date.Text);
            ToggleEdit();
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e) {
            SetCurrentStudent(studentList.SelectedIndex);
        }

        private void EditButton_Click(object sender, EventArgs e) {
            ToggleEdit();
        }
        
        private void SaveButton_Click(object sender, EventArgs e) {
            Save();
        }

        private void ManageCoursesButton_Click(object sender, EventArgs e) {
            new ManageCoursesForm(studentRegister).Show();
        }

        private void AddCourseButton_Click(object sender, EventArgs e) {
            AddCourseForm addCourseForm = new AddCourseForm((string)studentList.SelectedValue, studentRegister);
            if (addCourseForm.ShowDialog() != DialogResult.Cancel) {
                UpdateCourseList();
            }
        }
    }
}