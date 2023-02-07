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
    internal partial class ManageCoursesForm : Form {
        private StudentRegister studentRegister;
        private Course[] courses;
        public ManageCoursesForm(StudentRegister studentRegister) {
            InitializeComponent();
            this.studentRegister = studentRegister;
            courseList.DisplayMember = "Name";
            UpdateCourseList();
        }

        public void UpdateCourseList() {
            courses = studentRegister.GetCourses();
            courseList.DataSource = courses;
        }

        private void AddButton_Click(object sender, EventArgs e) {
            StringDialogForm addCourseForm = new StringDialogForm("Add Course", "Name");
            if (addCourseForm.ShowDialog() != DialogResult.Cancel) {
                studentRegister.AddCourse(addCourseForm.returnString);
                UpdateCourseList();
            }
        }

        private void RenameButton_Click(object sender, EventArgs e) {
            StringDialogForm renameCourseForm = new StringDialogForm("Rename Course", "Name");
            if (renameCourseForm.ShowDialog() != DialogResult.Cancel) {
                studentRegister.UpdateCourse(courseList.SelectedIndex, renameCourseForm.returnString);
                courses[courseList.SelectedIndex].Name = renameCourseForm.returnString;
                courseList.DataSource = courses;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            
        }
    }
}
