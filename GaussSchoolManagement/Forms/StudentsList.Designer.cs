namespace GaussSchoolManagement.Forms
{
    partial class StudentsList
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
            this.dtgStudentsDataGrid = new System.Windows.Forms.DataGridView();
            this.btnSaveStudents = new System.Windows.Forms.Button();
            this.nxeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nxenesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shkollaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prindIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxeneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStudentsDataGrid
            // 
            this.dtgStudentsDataGrid.AutoGenerateColumns = false;
            this.dtgStudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nxenesIdDataGridViewTextBoxColumn,
            this.shkollaIdDataGridViewTextBoxColumn,
            this.klasaDataGridViewTextBoxColumn,
            this.prindIdDataGridViewTextBoxColumn,
            this.personIdDataGridViewTextBoxColumn});
            this.dtgStudentsDataGrid.DataSource = this.nxeneBindingSource;
            this.dtgStudentsDataGrid.Location = new System.Drawing.Point(90, 34);
            this.dtgStudentsDataGrid.Name = "dtgStudentsDataGrid";
            this.dtgStudentsDataGrid.Size = new System.Drawing.Size(1050, 212);
            this.dtgStudentsDataGrid.TabIndex = 0;
            // 
            // btnSaveStudents
            // 
            this.btnSaveStudents.Location = new System.Drawing.Point(314, 285);
            this.btnSaveStudents.Name = "btnSaveStudents";
            this.btnSaveStudents.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStudents.TabIndex = 1;
            this.btnSaveStudents.Text = "Save";
            this.btnSaveStudents.UseVisualStyleBackColor = true;
            this.btnSaveStudents.Click += new System.EventHandler(this.BtnSaveStudents_Click);
            // 
            // nxeneBindingSource
            // 
            this.nxeneBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Nxene);
            // 
            // nxenesIdDataGridViewTextBoxColumn
            // 
            this.nxenesIdDataGridViewTextBoxColumn.DataPropertyName = "NxenesId";
            this.nxenesIdDataGridViewTextBoxColumn.HeaderText = "NxenesId";
            this.nxenesIdDataGridViewTextBoxColumn.Name = "nxenesIdDataGridViewTextBoxColumn";
            // 
            // shkollaIdDataGridViewTextBoxColumn
            // 
            this.shkollaIdDataGridViewTextBoxColumn.DataPropertyName = "ShkollaId";
            this.shkollaIdDataGridViewTextBoxColumn.HeaderText = "ShkollaId";
            this.shkollaIdDataGridViewTextBoxColumn.Name = "shkollaIdDataGridViewTextBoxColumn";
            // 
            // klasaDataGridViewTextBoxColumn
            // 
            this.klasaDataGridViewTextBoxColumn.DataPropertyName = "Klasa";
            this.klasaDataGridViewTextBoxColumn.HeaderText = "Klasa";
            this.klasaDataGridViewTextBoxColumn.Name = "klasaDataGridViewTextBoxColumn";
            // 
            // prindIdDataGridViewTextBoxColumn
            // 
            this.prindIdDataGridViewTextBoxColumn.DataPropertyName = "PrindId";
            this.prindIdDataGridViewTextBoxColumn.HeaderText = "PrindId";
            this.prindIdDataGridViewTextBoxColumn.Name = "prindIdDataGridViewTextBoxColumn";
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 450);
            this.Controls.Add(this.btnSaveStudents);
            this.Controls.Add(this.dtgStudentsDataGrid);
            this.Name = "StudentsList";
            this.Text = "StudentsList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxeneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource nxeneBindingSource;
        public System.Windows.Forms.DataGridView dtgStudentsDataGrid;
        private System.Windows.Forms.Button btnSaveStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxenesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shkollaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prindIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
    }
}