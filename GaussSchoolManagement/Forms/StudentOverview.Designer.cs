namespace GaussSchoolManagement.Forms
{
    partial class StudentOverview
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
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnRemovePayment = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnDuePayments = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgCourses = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgPayments = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCourses)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPayments)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname";
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
            this.btnPrevious.Location = new System.Drawing.Point(31, 28);
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
            this.btnNext.Location = new System.Drawing.Point(327, 22);
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
            this.label8.Location = new System.Drawing.Point(189, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Student Id";
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(31, 113);
            this.btnFindStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(379, 28);
            this.btnFindStudent.TabIndex = 3;
            this.btnFindStudent.Text = "Find student";
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
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblId.Location = new System.Drawing.Point(203, 28);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(43, 27);
            this.lblId.TabIndex = 0;
            this.lblId.UseMnemonic = false;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(47, 79);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 25);
            this.lblName.TabIndex = 0;
            this.lblName.UseMnemonic = false;
            // 
            // lblSurname
            // 
            this.lblSurname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSurname.Location = new System.Drawing.Point(229, 79);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(151, 25);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.UseMnemonic = false;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(37, 193);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(160, 28);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "Register new";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.BtnAddCourse_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(329, 193);
            this.btnRemoveCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(160, 28);
            this.btnRemoveCourse.TabIndex = 3;
            this.btnRemoveCourse.Text = "Remove";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.BtnRemoveCourse_Click);
            // 
            // btnRemovePayment
            // 
            this.btnRemovePayment.Location = new System.Drawing.Point(209, 212);
            this.btnRemovePayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemovePayment.Name = "btnRemovePayment";
            this.btnRemovePayment.Size = new System.Drawing.Size(111, 28);
            this.btnRemovePayment.TabIndex = 3;
            this.btnRemovePayment.Text = "Remove payment";
            this.btnRemovePayment.UseVisualStyleBackColor = true;
            this.btnRemovePayment.Click += new System.EventHandler(this.BtnRemovePayment_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(37, 212);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(111, 28);
            this.btnAddPayment.TabIndex = 3;
            this.btnAddPayment.Text = "Add";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.BtnAddPayment_Click);
            // 
            // btnDuePayments
            // 
            this.btnDuePayments.Location = new System.Drawing.Point(381, 212);
            this.btnDuePayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDuePayments.Name = "btnDuePayments";
            this.btnDuePayments.Size = new System.Drawing.Size(111, 28);
            this.btnDuePayments.TabIndex = 3;
            this.btnDuePayments.Text = "Due payments";
            this.btnDuePayments.UseVisualStyleBackColor = true;
            this.btnDuePayments.Click += new System.EventHandler(this.BtnDuePayments_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnEditDetails);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Location = new System.Drawing.Point(4, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(536, 246);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student info";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(47, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 0;
            this.label6.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Age";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(229, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 0;
            this.label2.UseMnemonic = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgCourses);
            this.groupBox2.Controls.Add(this.btnAddCourse);
            this.groupBox2.Controls.Add(this.btnRemoveCourse);
            this.groupBox2.Location = new System.Drawing.Point(548, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(536, 246);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Courses";
            // 
            // dtgCourses
            // 
            this.dtgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCourses.Location = new System.Drawing.Point(33, 23);
            this.dtgCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgCourses.Name = "dtgCourses";
            this.dtgCourses.RowHeadersWidth = 51;
            this.dtgCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCourses.Size = new System.Drawing.Size(456, 155);
            this.dtgCourses.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.dtgPayments);
            this.groupBox3.Controls.Add(this.btnAddPayment);
            this.groupBox3.Controls.Add(this.btnDuePayments);
            this.groupBox3.Controls.Add(this.btnRemovePayment);
            this.groupBox3.Location = new System.Drawing.Point(548, 258);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(536, 246);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payments";
            // 
            // dtgPayments
            // 
            this.dtgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPayments.Location = new System.Drawing.Point(37, 23);
            this.dtgPayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgPayments.Name = "dtgPayments";
            this.dtgPayments.RowHeadersWidth = 51;
            this.dtgPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPayments.Size = new System.Drawing.Size(456, 170);
            this.dtgPayments.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnFindStudent);
            this.groupBox4.Controls.Add(this.btnPrevious);
            this.groupBox4.Controls.Add(this.btnNext);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lblId);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(538, 248);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 508);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // StudentOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentOverview";
            this.Text = "Student Overview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCourses)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPayments)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnRemovePayment;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnDuePayments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgCourses;
        private System.Windows.Forms.DataGridView dtgPayments;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}