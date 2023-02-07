namespace StudentRegisterForm {
    partial class StudentRegisterForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.studentList = new System.Windows.Forms.ListBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.GroupBox();
            this.dateBox = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.TextBox();
            this.coursesList = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.studentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.studentInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.coursesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.manageCoursesButton = new System.Windows.Forms.Button();
            this.removeCourseButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.coursesBox = new System.Windows.Forms.GroupBox();
            this.studentsBox = new System.Windows.Forms.GroupBox();
            this.studentsControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.nameBox.SuspendLayout();
            this.dateBox.SuspendLayout();
            this.studentPanel.SuspendLayout();
            this.studentInfoPanel.SuspendLayout();
            this.coursesPanel.SuspendLayout();
            this.coursesBox.SuspendLayout();
            this.studentsBox.SuspendLayout();
            this.studentsControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 15;
            this.studentList.Location = new System.Drawing.Point(6, 22);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(128, 349);
            this.studentList.TabIndex = 0;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // firstName
            // 
            this.firstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.firstName.Location = new System.Drawing.Point(6, 22);
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderText = "First";
            this.firstName.ReadOnly = true;
            this.firstName.Size = new System.Drawing.Size(73, 23);
            this.firstName.TabIndex = 2;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastName
            // 
            this.lastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName.Location = new System.Drawing.Point(85, 22);
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderText = "Last";
            this.lastName.ReadOnly = true;
            this.lastName.Size = new System.Drawing.Size(118, 23);
            this.lastName.TabIndex = 3;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Controls.Add(this.lastName);
            this.nameBox.Controls.Add(this.firstName);
            this.nameBox.Location = new System.Drawing.Point(3, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(209, 55);
            this.nameBox.TabIndex = 4;
            this.nameBox.TabStop = false;
            this.nameBox.Text = "Name";
            // 
            // dateBox
            // 
            this.dateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateBox.Controls.Add(this.date);
            this.dateBox.Location = new System.Drawing.Point(218, 3);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(109, 55);
            this.dateBox.TabIndex = 5;
            this.dateBox.TabStop = false;
            this.dateBox.Text = "Date of birth";
            // 
            // date
            // 
            this.date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date.Location = new System.Drawing.Point(6, 22);
            this.date.Name = "date";
            this.date.PlaceholderText = "Date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(97, 23);
            this.date.TabIndex = 2;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coursesList
            // 
            this.coursesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coursesList.FormattingEnabled = true;
            this.coursesList.ItemHeight = 15;
            this.coursesList.Location = new System.Drawing.Point(6, 22);
            this.coursesList.Name = "coursesList";
            this.coursesList.Size = new System.Drawing.Size(318, 214);
            this.coursesList.TabIndex = 6;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(168, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(159, 35);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(159, 35);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // studentPanel
            // 
            this.studentPanel.ColumnCount = 2;
            this.studentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentPanel.Controls.Add(this.saveButton, 0, 0);
            this.studentPanel.Controls.Add(this.editButton, 1, 0);
            this.studentPanel.Location = new System.Drawing.Point(158, 76);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.RowCount = 1;
            this.studentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.studentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.studentPanel.Size = new System.Drawing.Size(330, 41);
            this.studentPanel.TabIndex = 9;
            // 
            // studentInfoPanel
            // 
            this.studentInfoPanel.ColumnCount = 2;
            this.studentInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.studentInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.studentInfoPanel.Controls.Add(this.nameBox, 0, 0);
            this.studentInfoPanel.Controls.Add(this.dateBox, 1, 0);
            this.studentInfoPanel.Location = new System.Drawing.Point(158, 12);
            this.studentInfoPanel.Name = "studentInfoPanel";
            this.studentInfoPanel.RowCount = 1;
            this.studentInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.studentInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.studentInfoPanel.Size = new System.Drawing.Size(330, 61);
            this.studentInfoPanel.TabIndex = 10;
            // 
            // coursesPanel
            // 
            this.coursesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coursesPanel.ColumnCount = 3;
            this.coursesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.coursesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.coursesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.coursesPanel.Controls.Add(this.manageCoursesButton, 2, 0);
            this.coursesPanel.Controls.Add(this.removeCourseButton, 1, 0);
            this.coursesPanel.Controls.Add(this.addCourseButton, 0, 0);
            this.coursesPanel.Location = new System.Drawing.Point(6, 255);
            this.coursesPanel.Name = "coursesPanel";
            this.coursesPanel.RowCount = 1;
            this.coursesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.coursesPanel.Size = new System.Drawing.Size(318, 41);
            this.coursesPanel.TabIndex = 12;
            // 
            // manageCoursesButton
            // 
            this.manageCoursesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageCoursesButton.Location = new System.Drawing.Point(215, 3);
            this.manageCoursesButton.Name = "manageCoursesButton";
            this.manageCoursesButton.Size = new System.Drawing.Size(100, 35);
            this.manageCoursesButton.TabIndex = 13;
            this.manageCoursesButton.Text = "Manage";
            this.manageCoursesButton.UseVisualStyleBackColor = true;
            this.manageCoursesButton.Click += new System.EventHandler(this.ManageCoursesButton_Click);
            // 
            // removeCourseButton
            // 
            this.removeCourseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeCourseButton.Location = new System.Drawing.Point(109, 3);
            this.removeCourseButton.Name = "removeCourseButton";
            this.removeCourseButton.Size = new System.Drawing.Size(100, 35);
            this.removeCourseButton.TabIndex = 13;
            this.removeCourseButton.Text = "Remove";
            this.removeCourseButton.UseVisualStyleBackColor = true;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCourseButton.Location = new System.Drawing.Point(3, 3);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(100, 35);
            this.addCourseButton.TabIndex = 0;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // coursesBox
            // 
            this.coursesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coursesBox.Controls.Add(this.coursesPanel);
            this.coursesBox.Controls.Add(this.coursesList);
            this.coursesBox.Location = new System.Drawing.Point(158, 123);
            this.coursesBox.Name = "coursesBox";
            this.coursesBox.Size = new System.Drawing.Size(330, 302);
            this.coursesBox.TabIndex = 13;
            this.coursesBox.TabStop = false;
            this.coursesBox.Text = "Courses";
            // 
            // studentsBox
            // 
            this.studentsBox.Controls.Add(this.studentsControlPanel);
            this.studentsBox.Controls.Add(this.studentList);
            this.studentsBox.Location = new System.Drawing.Point(12, 12);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(140, 413);
            this.studentsBox.TabIndex = 14;
            this.studentsBox.TabStop = false;
            this.studentsBox.Text = "Students";
            // 
            // studentsControlPanel
            // 
            this.studentsControlPanel.ColumnCount = 2;
            this.studentsControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsControlPanel.Controls.Add(this.addStudentButton, 0, 0);
            this.studentsControlPanel.Controls.Add(this.deleteStudentButton, 1, 0);
            this.studentsControlPanel.Location = new System.Drawing.Point(6, 377);
            this.studentsControlPanel.Name = "studentsControlPanel";
            this.studentsControlPanel.RowCount = 1;
            this.studentsControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.studentsControlPanel.Size = new System.Drawing.Size(128, 30);
            this.studentsControlPanel.TabIndex = 1;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(3, 3);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(58, 24);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(67, 3);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(58, 24);
            this.deleteStudentButton.TabIndex = 1;
            this.deleteStudentButton.Text = "Delete";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            // 
            // StudentRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 437);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.studentInfoPanel);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.coursesBox);
            this.Name = "StudentRegisterForm";
            this.Text = "Student Register";
            this.nameBox.ResumeLayout(false);
            this.nameBox.PerformLayout();
            this.dateBox.ResumeLayout(false);
            this.dateBox.PerformLayout();
            this.studentPanel.ResumeLayout(false);
            this.studentInfoPanel.ResumeLayout(false);
            this.coursesPanel.ResumeLayout(false);
            this.coursesBox.ResumeLayout(false);
            this.studentsBox.ResumeLayout(false);
            this.studentsControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox studentList;
        private TextBox firstName;
        private TextBox lastName;
        private GroupBox nameBox;
        private GroupBox dateBox;
        private TextBox date;
        private ListBox coursesList;
        private Button editButton;
        private Button saveButton;
        private TableLayoutPanel studentPanel;
        private TableLayoutPanel studentInfoPanel;
        private TableLayoutPanel coursesPanel;
        private Button addCourseButton;
        private Button manageCoursesButton;
        private Button removeCourseButton;
        private GroupBox coursesBox;
        private GroupBox studentsBox;
        private TableLayoutPanel studentsControlPanel;
        private Button addStudentButton;
        private Button deleteStudentButton;
    }
}