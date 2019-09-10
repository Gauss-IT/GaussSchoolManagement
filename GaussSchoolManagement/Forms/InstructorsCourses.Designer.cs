namespace GaussSchoolManagement.Forms
{
    partial class InstructorsCourses
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
            this.dtgInstructorsCourses = new System.Windows.Forms.DataGridView();
            this.btnRemoveInstCrs = new System.Windows.Forms.Button();
            this.btnAddInstrCrs = new System.Windows.Forms.Button();
            this.cmbInstructors = new System.Windows.Forms.ComboBox();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInstructorsCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInstructorsCourses
            // 
            this.dtgInstructorsCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInstructorsCourses.Location = new System.Drawing.Point(30, 48);
            this.dtgInstructorsCourses.Name = "dtgInstructorsCourses";
            this.dtgInstructorsCourses.Size = new System.Drawing.Size(707, 150);
            this.dtgInstructorsCourses.TabIndex = 0;
            // 
            // btnRemoveInstCrs
            // 
            this.btnRemoveInstCrs.Location = new System.Drawing.Point(581, 225);
            this.btnRemoveInstCrs.Name = "btnRemoveInstCrs";
            this.btnRemoveInstCrs.Size = new System.Drawing.Size(156, 23);
            this.btnRemoveInstCrs.TabIndex = 1;
            this.btnRemoveInstCrs.Text = "Remove Instructor Course";
            this.btnRemoveInstCrs.UseVisualStyleBackColor = true;
            this.btnRemoveInstCrs.Click += new System.EventHandler(this.BtnRemoveInstCrs_Click);
            // 
            // btnAddInstrCrs
            // 
            this.btnAddInstrCrs.Location = new System.Drawing.Point(30, 225);
            this.btnAddInstrCrs.Name = "btnAddInstrCrs";
            this.btnAddInstrCrs.Size = new System.Drawing.Size(146, 23);
            this.btnAddInstrCrs.TabIndex = 2;
            this.btnAddInstrCrs.Text = "Add new Teacher Course";
            this.btnAddInstrCrs.UseVisualStyleBackColor = true;
            this.btnAddInstrCrs.Click += new System.EventHandler(this.BtnAddInstrCrs_Click);
            // 
            // cmbInstructors
            // 
            this.cmbInstructors.FormattingEnabled = true;
            this.cmbInstructors.Location = new System.Drawing.Point(30, 277);
            this.cmbInstructors.Name = "cmbInstructors";
            this.cmbInstructors.Size = new System.Drawing.Size(146, 21);
            this.cmbInstructors.TabIndex = 3;
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(195, 277);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(146, 21);
            this.cmbCourses.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Instructors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Courses";
            // 
            // InstructorsCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.cmbInstructors);
            this.Controls.Add(this.btnAddInstrCrs);
            this.Controls.Add(this.btnRemoveInstCrs);
            this.Controls.Add(this.dtgInstructorsCourses);
            this.Name = "InstructorsCourses";
            this.Text = "InstructorsCourses";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInstructorsCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgInstructorsCourses;
        private System.Windows.Forms.Button btnRemoveInstCrs;
        private System.Windows.Forms.Button btnAddInstrCrs;
        private System.Windows.Forms.ComboBox cmbInstructors;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}