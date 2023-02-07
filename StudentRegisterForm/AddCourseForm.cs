using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegisterForm {
    internal partial class AddCourseForm : Form {
        private string studentId;
        private StudentRegister studentRegister;
        private Course[] courses;

        public AddCourseForm(string studentId, StudentRegister studentRegister) {
            InitializeComponent();
            this.studentId = studentId;
            this.studentRegister = studentRegister;
            courses = studentRegister.GetCourses();
            courseList.DataSource = courses;
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            studentRegister.AddStudentCourse(studentId, courses[courseList.SelectedIndex].Id);
        }
    }
}
