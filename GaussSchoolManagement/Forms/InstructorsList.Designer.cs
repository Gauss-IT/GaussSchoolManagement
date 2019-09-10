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
            this.components = new System.ComponentModel.Container();
            this.dtgInstructorsDataGrid = new System.Windows.Forms.DataGridView();
            this.btnAddInstructors = new System.Windows.Forms.Button();
            this.instruktoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRemoveInstructor = new System.Windows.Forms.Button();
            this.lblInstructors = new System.Windows.Forms.Label();
            this.cmbPeople = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInstructorsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInstructorsDataGrid
            // 
            this.dtgInstructorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInstructorsDataGrid.Location = new System.Drawing.Point(99, 27);
            this.dtgInstructorsDataGrid.Name = "dtgInstructorsDataGrid";
            this.dtgInstructorsDataGrid.Size = new System.Drawing.Size(558, 150);
            this.dtgInstructorsDataGrid.TabIndex = 0;
            // 
            // btnAddInstructors
            // 
            this.btnAddInstructors.Location = new System.Drawing.Point(99, 213);
            this.btnAddInstructors.Name = "btnAddInstructors";
            this.btnAddInstructors.Size = new System.Drawing.Size(133, 23);
            this.btnAddInstructors.TabIndex = 1;
            this.btnAddInstructors.Text = "Add new Instructor";
            this.btnAddInstructors.UseVisualStyleBackColor = true;
            this.btnAddInstructors.Click += new System.EventHandler(this.BtnAddInstructors_Click);
            // 
            // instruktoreBindingSource
            // 
            this.instruktoreBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Instruktore);
            // 
            // btnRemoveInstructor
            // 
            this.btnRemoveInstructor.Location = new System.Drawing.Point(524, 213);
            this.btnRemoveInstructor.Name = "btnRemoveInstructor";
            this.btnRemoveInstructor.Size = new System.Drawing.Size(133, 23);
            this.btnRemoveInstructor.TabIndex = 1;
            this.btnRemoveInstructor.Text = "Remove Instructor";
            this.btnRemoveInstructor.UseVisualStyleBackColor = true;
            this.btnRemoveInstructor.Click += new System.EventHandler(this.BtnAddInstructors_Click);
            // 
            // lblInstructors
            // 
            this.lblInstructors.AutoSize = true;
            this.lblInstructors.Location = new System.Drawing.Point(96, 265);
            this.lblInstructors.Name = "lblInstructors";
            this.lblInstructors.Size = new System.Drawing.Size(74, 13);
            this.lblInstructors.TabIndex = 2;
            this.lblInstructors.Text = "Personal Data";
            // 
            // cmbPeople
            // 
            this.cmbPeople.FormattingEnabled = true;
            this.cmbPeople.Location = new System.Drawing.Point(99, 295);
            this.cmbPeople.Name = "cmbPeople";
            this.cmbPeople.Size = new System.Drawing.Size(121, 21);
            this.cmbPeople.TabIndex = 3;
            // 
            // InstructorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbPeople);
            this.Controls.Add(this.lblInstructors);
            this.Controls.Add(this.btnRemoveInstructor);
            this.Controls.Add(this.btnAddInstructors);
            this.Controls.Add(this.dtgInstructorsDataGrid);
            this.Name = "InstructorsList";
            this.Text = "InstructorsList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInstructorsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddInstructors;
        private System.Windows.Forms.BindingSource instruktoreBindingSource;
        public System.Windows.Forms.DataGridView dtgInstructorsDataGrid;
        private System.Windows.Forms.Button btnRemoveInstructor;
        private System.Windows.Forms.Label lblInstructors;
        private System.Windows.Forms.ComboBox cmbPeople;
    }
}