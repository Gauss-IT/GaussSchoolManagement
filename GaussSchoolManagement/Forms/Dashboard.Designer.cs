namespace GaussSchoolManagement.Forms
{
    partial class Dashboard
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
            this.btnStudentOverview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInstructorOverview = new System.Windows.Forms.Button();
            this.btnCourseOverview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentOverview
            // 
            this.btnStudentOverview.Location = new System.Drawing.Point(57, 42);
            this.btnStudentOverview.Name = "btnStudentOverview";
            this.btnStudentOverview.Size = new System.Drawing.Size(114, 64);
            this.btnStudentOverview.TabIndex = 7;
            this.btnStudentOverview.Text = "Student overview";
            this.btnStudentOverview.UseVisualStyleBackColor = true;
            this.btnStudentOverview.Click += new System.EventHandler(this.BtnEditPerson_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "EntryForm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnInstructorOverview
            // 
            this.btnInstructorOverview.Location = new System.Drawing.Point(57, 135);
            this.btnInstructorOverview.Name = "btnInstructorOverview";
            this.btnInstructorOverview.Size = new System.Drawing.Size(114, 64);
            this.btnInstructorOverview.TabIndex = 7;
            this.btnInstructorOverview.Text = "Instructor overview";
            this.btnInstructorOverview.UseVisualStyleBackColor = true;
            this.btnInstructorOverview.Click += new System.EventHandler(this.BtnInstructorOverview_Click);
            // 
            // btnCourseOverview
            // 
            this.btnCourseOverview.Location = new System.Drawing.Point(57, 228);
            this.btnCourseOverview.Name = "btnCourseOverview";
            this.btnCourseOverview.Size = new System.Drawing.Size(114, 64);
            this.btnCourseOverview.TabIndex = 7;
            this.btnCourseOverview.Text = "Course overview";
            this.btnCourseOverview.UseVisualStyleBackColor = true;
            this.btnCourseOverview.Click += new System.EventHandler(this.BtnCourseOverview_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCourseOverview);
            this.Controls.Add(this.btnInstructorOverview);
            this.Controls.Add(this.btnStudentOverview);
            this.Name = "Dashboard";
            this.Text = "Gauss School Management";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStudentOverview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInstructorOverview;
        private System.Windows.Forms.Button btnCourseOverview;
    }
}

