namespace GaussSchoolManagement.Forms
{
    partial class ParentsList
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
            this.dtgParentsDataGrid = new System.Windows.Forms.DataGridView();
            this.prinderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveParents = new System.Windows.Forms.Button();
            this.prindIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prinderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgParentsDataGrid
            // 
            this.dtgParentsDataGrid.AutoGenerateColumns = false;
            this.dtgParentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prindIdDataGridViewTextBoxColumn,
            this.personIdDataGridViewTextBoxColumn});
            this.dtgParentsDataGrid.DataSource = this.prinderBindingSource;
            this.dtgParentsDataGrid.Location = new System.Drawing.Point(108, 29);
            this.dtgParentsDataGrid.Name = "dtgParentsDataGrid";
            this.dtgParentsDataGrid.Size = new System.Drawing.Size(485, 150);
            this.dtgParentsDataGrid.TabIndex = 0;
            // 
            // prinderBindingSource
            // 
            this.prinderBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Prinder);
            // 
            // btnSaveParents
            // 
            this.btnSaveParents.Location = new System.Drawing.Point(173, 222);
            this.btnSaveParents.Name = "btnSaveParents";
            this.btnSaveParents.Size = new System.Drawing.Size(75, 23);
            this.btnSaveParents.TabIndex = 1;
            this.btnSaveParents.Text = "Save";
            this.btnSaveParents.UseVisualStyleBackColor = true;
            this.btnSaveParents.Click += new System.EventHandler(this.BtnSaveParents_Click);
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
            // ParentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveParents);
            this.Controls.Add(this.dtgParentsDataGrid);
            this.Name = "ParentsList";
            this.Text = "ParentsList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgParentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prinderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource prinderBindingSource;
        private System.Windows.Forms.Button btnSaveParents;
        private System.Windows.Forms.DataGridViewTextBoxColumn prindIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dtgParentsDataGrid;
    }
}