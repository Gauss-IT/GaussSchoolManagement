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
            this.btnSaveInstructors = new System.Windows.Forms.Button();
            this.instruktoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instruktorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInstructorsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInstructorsDataGrid
            // 
            this.dtgInstructorsDataGrid.AutoGenerateColumns = false;
            this.dtgInstructorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInstructorsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instruktorIdDataGridViewTextBoxColumn,
            this.personIdDataGridViewTextBoxColumn});
            this.dtgInstructorsDataGrid.DataSource = this.instruktoreBindingSource;
            this.dtgInstructorsDataGrid.Location = new System.Drawing.Point(99, 27);
            this.dtgInstructorsDataGrid.Name = "dtgInstructorsDataGrid";
            this.dtgInstructorsDataGrid.Size = new System.Drawing.Size(451, 150);
            this.dtgInstructorsDataGrid.TabIndex = 0;
            // 
            // btnSaveInstructors
            // 
            this.btnSaveInstructors.Location = new System.Drawing.Point(248, 241);
            this.btnSaveInstructors.Name = "btnSaveInstructors";
            this.btnSaveInstructors.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInstructors.TabIndex = 1;
            this.btnSaveInstructors.Text = "Save";
            this.btnSaveInstructors.UseVisualStyleBackColor = true;
            this.btnSaveInstructors.Click += new System.EventHandler(this.BtnSaveInstructors_Click);
            // 
            // instruktoreBindingSource
            // 
            this.instruktoreBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Instruktore);
            // 
            // instruktorIdDataGridViewTextBoxColumn
            // 
            this.instruktorIdDataGridViewTextBoxColumn.DataPropertyName = "InstruktorId";
            this.instruktorIdDataGridViewTextBoxColumn.HeaderText = "InstruktorId";
            this.instruktorIdDataGridViewTextBoxColumn.Name = "instruktorIdDataGridViewTextBoxColumn";
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            // 
            // InstructorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveInstructors);
            this.Controls.Add(this.dtgInstructorsDataGrid);
            this.Name = "InstructorsList";
            this.Text = "InstructorsList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInstructorsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveInstructors;
        private System.Windows.Forms.DataGridViewTextBoxColumn instruktorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource instruktoreBindingSource;
        public System.Windows.Forms.DataGridView dtgInstructorsDataGrid;
    }
}