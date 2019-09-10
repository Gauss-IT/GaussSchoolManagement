namespace GaussSchoolManagement.Forms
{
    partial class StudentsCourses
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
            this.dtgStudentsCourses = new System.Windows.Forms.DataGridView();
            this.btnAddStdntCrs = new System.Windows.Forms.Button();
            this.btnRemoveStdntCrs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentsCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStudentsCourses
            // 
            this.dtgStudentsCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentsCourses.Location = new System.Drawing.Point(28, 24);
            this.dtgStudentsCourses.Name = "dtgStudentsCourses";
            this.dtgStudentsCourses.Size = new System.Drawing.Size(673, 150);
            this.dtgStudentsCourses.TabIndex = 0;
            // 
            // btnAddStdntCrs
            // 
            this.btnAddStdntCrs.Location = new System.Drawing.Point(28, 208);
            this.btnAddStdntCrs.Name = "btnAddStdntCrs";
            this.btnAddStdntCrs.Size = new System.Drawing.Size(159, 23);
            this.btnAddStdntCrs.TabIndex = 1;
            this.btnAddStdntCrs.Text = "Add new Student Course";
            this.btnAddStdntCrs.UseVisualStyleBackColor = true;
            this.btnAddStdntCrs.Click += new System.EventHandler(this.BtnAddStdntCrs_Click);
            // 
            // btnRemoveStdntCrs
            // 
            this.btnRemoveStdntCrs.Location = new System.Drawing.Point(527, 208);
            this.btnRemoveStdntCrs.Name = "btnRemoveStdntCrs";
            this.btnRemoveStdntCrs.Size = new System.Drawing.Size(174, 23);
            this.btnRemoveStdntCrs.TabIndex = 2;
            this.btnRemoveStdntCrs.Text = "Remove Student Course";
            this.btnRemoveStdntCrs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Courses";
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(31, 287);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(121, 21);
            this.cmbStudents.TabIndex = 4;
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(236, 287);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(121, 21);
            this.cmbCourses.TabIndex = 4;
            // 
            // StudentCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveStdntCrs);
            this.Controls.Add(this.btnAddStdntCrs);
            this.Controls.Add(this.dtgStudentsCourses);
            this.Name = "StudentCourses";
            this.Text = "StudentCourses";
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentsCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStudentsCourses;
        private System.Windows.Forms.Button btnAddStdntCrs;
        private System.Windows.Forms.Button btnRemoveStdntCrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbCourses;
    }
}