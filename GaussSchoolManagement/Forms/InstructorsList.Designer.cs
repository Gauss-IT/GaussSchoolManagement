namespace GaussSchoolManagement.Forms
{
    partial class InstructorsList
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
            this.dtgInstructorsDataGrid = new System.Windows.Forms.DataGridView();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnInstructorOverview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInstructorsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInstructorsDataGrid
            // 
            this.dtgInstructorsDataGrid.AllowUserToAddRows = false;
            this.dtgInstructorsDataGrid.AllowUserToDeleteRows = false;
            this.dtgInstructorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInstructorsDataGrid.Location = new System.Drawing.Point(35, 73);
            this.dtgInstructorsDataGrid.MultiSelect = false;
            this.dtgInstructorsDataGrid.Name = "dtgInstructorsDataGrid";
            this.dtgInstructorsDataGrid.ReadOnly = true;
            this.dtgInstructorsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInstructorsDataGrid.Size = new System.Drawing.Size(560, 184);
            this.dtgInstructorsDataGrid.TabIndex = 0;
            this.dtgInstructorsDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgInstructorsDataGrid_CellMouseDoubleClick);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(143, 47);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 7;
            this.txtSurname.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(35, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(102, 20);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Course";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(249, 47);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 7;
            this.txtCourse.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Birth year";
            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Location = new System.Drawing.Point(355, 47);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(100, 20);
            this.txtBirthYear.TabIndex = 7;
            this.txtBirthYear.TextChanged += new System.EventHandler(this.OnInputChanged);
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
            // btnInstructorOverview
            // 
            this.btnInstructorOverview.Location = new System.Drawing.Point(35, 289);
            this.btnInstructorOverview.Name = "btnInstructorOverview";
            this.btnInstructorOverview.Size = new System.Drawing.Size(140, 23);
            this.btnInstructorOverview.TabIndex = 1;
            this.btnInstructorOverview.Text = "Select Instructor";
            this.btnInstructorOverview.UseVisualStyleBackColor = true;
            this.btnInstructorOverview.Click += new System.EventHandler(this.BtnInstructorOverview_Click);
            // 
            // InstructorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 350);
            this.Controls.Add(this.txtBirthYear);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnInstructorOverview);
            this.Controls.Add(this.dtgInstructorsDataGrid);
            this.Name = "InstructorsList";
            this.Text = "Instructors List";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInstructorsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dtgInstructorsDataGrid;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnInstructorOverview;
    }
}