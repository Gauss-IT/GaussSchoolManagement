namespace GaussSchoolManagement.Forms
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEditSchools = new System.Windows.Forms.Button();
            this.btnEditPeople = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnEditPayments = new System.Windows.Forms.Button();
            this.btnEditParents = new System.Windows.Forms.Button();
            this.btnEditStudents = new System.Windows.Forms.Button();
            this.btnEditInstructors = new System.Windows.Forms.Button();
            this.btnInstructorsCourses = new System.Windows.Forms.Button();
            this.btnStudentCourses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStudentOverview = new System.Windows.Forms.Button();
            this.btnInstructorOverview = new System.Windows.Forms.Button();
            this.btnCourseOverview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditSchools
            // 
            this.btnEditSchools.Location = new System.Drawing.Point(302, 92);
            this.btnEditSchools.Name = "btnEditSchools";
            this.btnEditSchools.Size = new System.Drawing.Size(114, 65);
            this.btnEditSchools.TabIndex = 1;
            this.btnEditSchools.Text = "Schools";
            this.btnEditSchools.UseVisualStyleBackColor = true;
            this.btnEditSchools.Click += new System.EventHandler(this.BtnEditSchools_Click);
            // 
            // btnEditPeople
            // 
            this.btnEditPeople.Location = new System.Drawing.Point(302, 21);
            this.btnEditPeople.Name = "btnEditPeople";
            this.btnEditPeople.Size = new System.Drawing.Size(114, 65);
            this.btnEditPeople.TabIndex = 2;
            this.btnEditPeople.Text = "Personal Data";
            this.btnEditPeople.UseVisualStyleBackColor = true;
            this.btnEditPeople.Click += new System.EventHandler(this.BtnEditPeople_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Location = new System.Drawing.Point(168, 21);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(114, 65);
            this.btnEditCourse.TabIndex = 3;
            this.btnEditCourse.Text = "Courses";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.BtnEditCourse_Click);
            // 
            // btnEditPayments
            // 
            this.btnEditPayments.Location = new System.Drawing.Point(168, 162);
            this.btnEditPayments.Name = "btnEditPayments";
            this.btnEditPayments.Size = new System.Drawing.Size(114, 65);
            this.btnEditPayments.TabIndex = 4;
            this.btnEditPayments.Text = "Payments";
            this.btnEditPayments.UseVisualStyleBackColor = true;
            this.btnEditPayments.Click += new System.EventHandler(this.BtnEditPayments_Click);
            // 
            // btnEditParents
            // 
            this.btnEditParents.Location = new System.Drawing.Point(648, 220);
            this.btnEditParents.Name = "btnEditParents";
            this.btnEditParents.Size = new System.Drawing.Size(114, 64);
            this.btnEditParents.TabIndex = 6;
            this.btnEditParents.Text = "Parents";
            this.btnEditParents.UseVisualStyleBackColor = true;
            this.btnEditParents.Click += new System.EventHandler(this.BtnEditParents_Click);
            // 
            // btnEditStudents
            // 
            this.btnEditStudents.Location = new System.Drawing.Point(648, 290);
            this.btnEditStudents.Name = "btnEditStudents";
            this.btnEditStudents.Size = new System.Drawing.Size(114, 64);
            this.btnEditStudents.TabIndex = 7;
            this.btnEditStudents.Text = "Students";
            this.btnEditStudents.UseVisualStyleBackColor = true;
            this.btnEditStudents.Click += new System.EventHandler(this.BtnEditStudents_Click);
            // 
            // btnEditInstructors
            // 
            this.btnEditInstructors.Location = new System.Drawing.Point(648, 149);
            this.btnEditInstructors.Name = "btnEditInstructors";
            this.btnEditInstructors.Size = new System.Drawing.Size(114, 65);
            this.btnEditInstructors.TabIndex = 8;
            this.btnEditInstructors.Text = "Instructors";
            this.btnEditInstructors.UseVisualStyleBackColor = true;
            this.btnEditInstructors.Click += new System.EventHandler(this.btnEditInstructors_Click);
            // 
            // btnInstructorsCourses
            // 
            this.btnInstructorsCourses.Location = new System.Drawing.Point(439, 21);
            this.btnInstructorsCourses.Name = "btnInstructorsCourses";
            this.btnInstructorsCourses.Size = new System.Drawing.Size(114, 65);
            this.btnInstructorsCourses.TabIndex = 1;
            this.btnInstructorsCourses.Text = "Instructors Courses";
            this.btnInstructorsCourses.UseVisualStyleBackColor = true;
            this.btnInstructorsCourses.Click += new System.EventHandler(this.BtnInstructorsCourses_Click);
            // 
            // btnStudentCourses
            // 
            this.btnStudentCourses.Location = new System.Drawing.Point(439, 93);
            this.btnStudentCourses.Name = "btnStudentCourses";
            this.btnStudentCourses.Size = new System.Drawing.Size(114, 64);
            this.btnStudentCourses.TabIndex = 9;
            this.btnStudentCourses.Text = "Students Courses";
            this.btnStudentCourses.UseVisualStyleBackColor = true;
            this.btnStudentCourses.Click += new System.EventHandler(this.BtnStudentCourses_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Students Payments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnStudentOverview
            // 
            this.btnStudentOverview.Location = new System.Drawing.Point(12, 22);
            this.btnStudentOverview.Name = "btnStudentOverview";
            this.btnStudentOverview.Size = new System.Drawing.Size(114, 64);
            this.btnStudentOverview.TabIndex = 7;
            this.btnStudentOverview.Text = "Student overview";
            this.btnStudentOverview.UseVisualStyleBackColor = true;
            this.btnStudentOverview.Click += new System.EventHandler(this.BtnEditPerson_Click);
            // 
            // btnInstructorOverview
            // 
            this.btnInstructorOverview.Location = new System.Drawing.Point(12, 93);
            this.btnInstructorOverview.Name = "btnInstructorOverview";
            this.btnInstructorOverview.Size = new System.Drawing.Size(114, 64);
            this.btnInstructorOverview.TabIndex = 7;
            this.btnInstructorOverview.Text = "Instructor overview";
            this.btnInstructorOverview.UseVisualStyleBackColor = true;
            this.btnInstructorOverview.Click += new System.EventHandler(this.BtnInstructorOverview_Click);
            // 
            // btnCourseOverview
            // 
            this.btnCourseOverview.Location = new System.Drawing.Point(12, 164);
            this.btnCourseOverview.Name = "btnCourseOverview";
            this.btnCourseOverview.Size = new System.Drawing.Size(114, 65);
            this.btnCourseOverview.TabIndex = 3;
            this.btnCourseOverview.Text = "Course Overview";
            this.btnCourseOverview.UseVisualStyleBackColor = true;
            this.btnCourseOverview.Click += new System.EventHandler(this.BtnCourseOverview_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStudentCourses);
            this.Controls.Add(this.btnEditInstructors);
            this.Controls.Add(this.btnInstructorOverview);
            this.Controls.Add(this.btnStudentOverview);
            this.Controls.Add(this.btnEditStudents);
            this.Controls.Add(this.btnEditParents);
            this.Controls.Add(this.btnEditPayments);
            this.Controls.Add(this.btnCourseOverview);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnEditPeople);
            this.Controls.Add(this.btnInstructorsCourses);
            this.Controls.Add(this.btnEditSchools);
            this.Name = "EntryForm";
            this.Text = "Gauss School Management";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditSchools;
        private System.Windows.Forms.Button btnEditPeople;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnEditPayments;
        private System.Windows.Forms.Button btnEditParents;
        private System.Windows.Forms.Button btnEditStudents;
        private System.Windows.Forms.Button btnEditInstructors;
        private System.Windows.Forms.Button btnInstructorsCourses;
        private System.Windows.Forms.Button btnStudentCourses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStudentOverview;
        private System.Windows.Forms.Button btnInstructorOverview;
        private System.Windows.Forms.Button btnCourseOverview;
    }
}

