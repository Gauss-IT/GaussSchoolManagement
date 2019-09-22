namespace GaussSchoolManagement.Forms
{
    partial class InstructorOverview
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFindInstructor = new System.Windows.Forms.Button();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgCourses = new System.Windows.Forms.DataGridView();
            this.dtgPayments = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(35, 163);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New Student";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(210, 163);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(46, 86);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(67, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(268, 81);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Instructor ID";
            // 
            // btnFindInstructor
            // 
            this.btnFindInstructor.Location = new System.Drawing.Point(46, 155);
            this.btnFindInstructor.Name = "btnFindInstructor";
            this.btnFindInstructor.Size = new System.Drawing.Size(284, 23);
            this.btnFindInstructor.TabIndex = 3;
            this.btnFindInstructor.Text = "Find instructor";
            this.btnFindInstructor.UseVisualStyleBackColor = true;
            this.btnFindInstructor.Click += new System.EventHandler(this.BtnFindInstructor_Click);
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(122, 163);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(75, 23);
            this.btnEditDetails.TabIndex = 3;
            this.btnEditDetails.Text = "Edit";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.BtnEditDetails_Click);
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(175, 86);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 22);
            this.lblId.TabIndex = 0;
            this.lblId.UseMnemonic = false;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(35, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 20);
            this.lblName.TabIndex = 0;
            this.lblName.UseMnemonic = false;
            // 
            // lblSurname
            // 
            this.lblSurname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurname.Location = new System.Drawing.Point(172, 64);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(113, 20);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.UseMnemonic = false;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(25, 122);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(120, 23);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "Register new";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(161, 122);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveCourse.TabIndex = 3;
            this.btnRemoveCourse.Text = "Remove";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.BtnRemoveCourse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove payment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Due payments";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnEditDetails);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Location = new System.Drawing.Point(46, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 214);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructor info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgCourses);
            this.groupBox2.Controls.Add(this.btnAddCourse);
            this.groupBox2.Controls.Add(this.btnRemoveCourse);
            this.groupBox2.Location = new System.Drawing.Point(417, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 151);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Courses";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgPayments);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(417, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 214);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payments";
            // 
            // dtgCourses
            // 
            this.dtgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCourses.Location = new System.Drawing.Point(28, 19);
            this.dtgCourses.Name = "dtgCourses";
            this.dtgCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCourses.Size = new System.Drawing.Size(253, 97);
            this.dtgCourses.TabIndex = 4;
            // 
            // dtgPayments
            // 
            this.dtgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPayments.Location = new System.Drawing.Point(28, 19);
            this.dtgPayments.Name = "dtgPayments";
            this.dtgPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPayments.Size = new System.Drawing.Size(253, 138);
            this.dtgPayments.TabIndex = 4;
            // 
            // InstructorOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 472);
            this.Controls.Add(this.btnFindInstructor);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "InstructorOverview";
            this.Text = "Instructor Overview";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFindInstructor;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgCourses;
        private System.Windows.Forms.DataGridView dtgPayments;
    }
}