namespace GaussSchoolManagement.Forms
{
    partial class CoursesList
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
            this.components = new System.ComponentModel.Container();
            this.dtgCoursesDatagrid = new System.Windows.Forms.DataGridView();
            this.kurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveCourses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCoursesDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCoursesDatagrid
            // 
            this.dtgCoursesDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCoursesDatagrid.Location = new System.Drawing.Point(0, 0);
            this.dtgCoursesDatagrid.Name = "dtgCoursesDatagrid";
            this.dtgCoursesDatagrid.Size = new System.Drawing.Size(942, 150);
            this.dtgCoursesDatagrid.TabIndex = 0;
            // 
            // kurseBindingSource
            // 
            this.kurseBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Kurse);
            // 
            // btnSaveCourses
            // 
            this.btnSaveCourses.Location = new System.Drawing.Point(383, 206);
            this.btnSaveCourses.Name = "btnSaveCourses";
            this.btnSaveCourses.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCourses.TabIndex = 1;
            this.btnSaveCourses.Text = "Save";
            this.btnSaveCourses.UseVisualStyleBackColor = true;
            this.btnSaveCourses.Click += new System.EventHandler(this.BtnSaveCourses_Click);
            // 
            // CoursesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.btnSaveCourses);
            this.Controls.Add(this.dtgCoursesDatagrid);
            this.Name = "CoursesList";
            this.Text = "CoursesList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCoursesDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource kurseBindingSource;
        public System.Windows.Forms.DataGridView dtgCoursesDatagrid;
        private System.Windows.Forms.Button btnSaveCourses;
    }
}