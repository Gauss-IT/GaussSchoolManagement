namespace GaussSchoolManagement.Forms
{
    partial class CourseOverview
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
            this.lblCode1 = new System.Windows.Forms.Label();
            this.lblCourseName1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblLevel1 = new System.Windows.Forms.Label();
            this.lblYear1 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPayments = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode1
            // 
            this.lblCode1.AutoSize = true;
            this.lblCode1.Location = new System.Drawing.Point(43, 48);
            this.lblCode1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode1.Name = "lblCode1";
            this.lblCode1.Size = new System.Drawing.Size(41, 17);
            this.lblCode1.TabIndex = 0;
            this.lblCode1.Text = "Code";
            // 
            // lblCourseName1
            // 
            this.lblCourseName1.AutoSize = true;
            this.lblCourseName1.Location = new System.Drawing.Point(225, 48);
            this.lblCourseName1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseName1.Name = "lblCourseName1";
            this.lblCourseName1.Size = new System.Drawing.Size(45, 17);
            this.lblCourseName1.TabIndex = 0;
            this.lblCourseName1.Text = "Name";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(47, 201);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 28);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New Student";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(280, 201);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(61, 82);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(89, 28);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(357, 76);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 28);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Course ID";
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(61, 167);
            this.btnFindStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(379, 28);
            this.btnFindStudent.TabIndex = 3;
            this.btnFindStudent.Text = "Find course";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.BtnFindStudent_Click);
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(163, 201);
            this.btnEditDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(100, 28);
            this.btnEditDetails.TabIndex = 3;
            this.btnEditDetails.Text = "Edit";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.BtnEditDetails_Click);
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Items.AddRange(new object[] {
            "Zahir Tairi",
            "Art Saiti",
            "Art Limani",
            "Veton Shabani"});
            this.lbStudents.Location = new System.Drawing.Point(33, 34);
            this.lbStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(340, 68);
            this.lbStudents.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(233, 82);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 27);
            this.lblId.TabIndex = 0;
            this.lblId.UseMnemonic = false;
            // 
            // lblCode
            // 
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Location = new System.Drawing.Point(47, 79);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(151, 25);
            this.lblCode.TabIndex = 0;
            this.lblCode.UseMnemonic = false;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(229, 79);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 25);
            this.lblName.TabIndex = 0;
            this.lblName.UseMnemonic = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(33, 126);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(160, 28);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Register new";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(215, 126);
            this.btnRemoveCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(160, 28);
            this.btnRemoveCourse.TabIndex = 3;
            this.btnRemoveCourse.Text = "Remove";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 201);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove payment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 201);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Due payments";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLevel);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.lblLevel1);
            this.groupBox1.Controls.Add(this.lblYear1);
            this.groupBox1.Controls.Add(this.lblCode1);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.lblCourseName1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnEditDetails);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Location = new System.Drawing.Point(61, 271);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(419, 263);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Info";
            // 
            // lblLevel
            // 
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLevel.Location = new System.Drawing.Point(47, 148);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(151, 25);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.UseMnemonic = false;
            // 
            // lblLevel1
            // 
            this.lblLevel1.AutoSize = true;
            this.lblLevel1.Location = new System.Drawing.Point(43, 117);
            this.lblLevel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel1.Name = "lblLevel1";
            this.lblLevel1.Size = new System.Drawing.Size(42, 17);
            this.lblLevel1.TabIndex = 0;
            this.lblLevel1.Text = "Level";
            // 
            // lblYear1
            // 
            this.lblYear1.AutoSize = true;
            this.lblYear1.Location = new System.Drawing.Point(225, 117);
            this.lblYear1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear1.Name = "lblYear1";
            this.lblYear1.Size = new System.Drawing.Size(38, 17);
            this.lblYear1.TabIndex = 0;
            this.lblYear1.Text = "Year";
            // 
            // lblYear
            // 
            this.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYear.Location = new System.Drawing.Point(229, 148);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(151, 25);
            this.lblYear.TabIndex = 0;
            this.lblYear.UseMnemonic = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbStudents);
            this.groupBox2.Controls.Add(this.btnAddStudent);
            this.groupBox2.Controls.Add(this.btnRemoveCourse);
            this.groupBox2.Location = new System.Drawing.Point(556, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(408, 186);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPayments);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(556, 271);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(408, 263);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payments";
            // 
            // lbPayments
            // 
            this.lbPayments.FormattingEnabled = true;
            this.lbPayments.ItemHeight = 16;
            this.lbPayments.Items.AddRange(new object[] {
            "Small Basic",
            "Python"});
            this.lbPayments.Location = new System.Drawing.Point(33, 34);
            this.lbPayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPayments.Name = "lbPayments";
            this.lbPayments.Size = new System.Drawing.Size(340, 148);
            this.lbPayments.TabIndex = 8;
            // 
            // CourseOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 581);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CourseOverview";
            this.Text = "Course Overview";
            this.Load += new System.EventHandler(this.CourseOverview_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode1;
        private System.Windows.Forms.Label lblCourseName1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblLevel1;
        private System.Windows.Forms.Label lblYear1;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbPayments;
    }
}