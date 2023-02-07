namespace StudentRegisterForm {
    partial class ManageCoursesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.courseList = new System.Windows.Forms.ListBox();
            this.controlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.renameButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.ListBox();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseList
            // 
            this.courseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseList.FormattingEnabled = true;
            this.courseList.ItemHeight = 15;
            this.courseList.Location = new System.Drawing.Point(12, 12);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(288, 319);
            this.courseList.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.controlPanel.ColumnCount = 3;
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.controlPanel.Controls.Add(this.renameButton, 1, 0);
            this.controlPanel.Controls.Add(this.addButton, 0, 0);
            this.controlPanel.Controls.Add(this.deleteButton, 2, 0);
            this.controlPanel.Location = new System.Drawing.Point(12, 337);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RowCount = 1;
            this.controlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlPanel.Size = new System.Drawing.Size(288, 39);
            this.controlPanel.TabIndex = 1;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(98, 3);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(89, 33);
            this.renameButton.TabIndex = 5;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 33);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(193, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 33);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // studentList
            // 
            this.studentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 15;
            this.studentList.Location = new System.Drawing.Point(306, 12);
            this.studentList.Name = "studentList";
            this.studentList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.studentList.Size = new System.Drawing.Size(136, 364);
            this.studentList.TabIndex = 3;
            // 
            // ManageCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 387);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.courseList);
            this.Name = "ManageCoursesForm";
            this.Text = "Manage Courses";
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox courseList;
        private TableLayoutPanel controlPanel;
        private ListBox studentList;
        private Button deleteButton;
        private Button addButton;
        private Button renameButton;
    }
}