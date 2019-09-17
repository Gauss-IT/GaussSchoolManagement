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
            this.dtgCourses = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnCourseOverview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCourses
            // 
            this.dtgCourses.AllowUserToAddRows = false;
            this.dtgCourses.AllowUserToDeleteRows = false;
            this.dtgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCourses.Location = new System.Drawing.Point(35, 73);
            this.dtgCourses.MultiSelect = false;
            this.dtgCourses.Name = "dtgCourses";
            this.dtgCourses.ReadOnly = true;
            this.dtgCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCourses.Size = new System.Drawing.Size(560, 184);
            this.dtgCourses.TabIndex = 0;
            this.dtgCourses.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgStudentsDataGrid_CellMouseDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(35, 47);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(102, 20);
            this.txtCode.TabIndex = 8;
            this.txtCode.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Level";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(265, 47);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 7;
            this.txtLevel.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(379, 47);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 7;
            this.txtYear.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(493, 47);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(441, 289);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(154, 23);
            this.btnClearSearch.TabIndex = 1;
            this.btnClearSearch.Text = "Clear search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // btnCourseOverview
            // 
            this.btnCourseOverview.Location = new System.Drawing.Point(35, 289);
            this.btnCourseOverview.Name = "btnCourseOverview";
            this.btnCourseOverview.Size = new System.Drawing.Size(140, 23);
            this.btnCourseOverview.TabIndex = 1;
            this.btnCourseOverview.Text = "Select Course";
            this.btnCourseOverview.UseVisualStyleBackColor = true;
            this.btnCourseOverview.Click += new System.EventHandler(this.BtnStudentOverview_Click);
            // 
            // CoursesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 350);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnCourseOverview);
            this.Controls.Add(this.dtgCourses);
            this.Name = "CoursesList";
            this.Text = "Courses List";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dtgCourses;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnCourseOverview;
    }
}