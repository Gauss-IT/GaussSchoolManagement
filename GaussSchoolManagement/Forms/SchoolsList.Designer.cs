namespace GaussSchoolManagement.Forms
{
    partial class SchoolsList
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
            this.dtgShoolsDataGrid = new System.Windows.Forms.DataGridView();
            this.shkollaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shkollaEmriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shkollaTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shkollaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgShoolsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shkollaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgShoolsDataGrid
            // 
            this.dtgShoolsDataGrid.AutoGenerateColumns = false;
            this.dtgShoolsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgShoolsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shkollaIdDataGridViewTextBoxColumn,
            this.shkollaEmriDataGridViewTextBoxColumn,
            this.shkollaTipiDataGridViewTextBoxColumn});
            this.dtgShoolsDataGrid.DataSource = this.shkollaBindingSource;
            this.dtgShoolsDataGrid.Location = new System.Drawing.Point(66, 182);
            this.dtgShoolsDataGrid.Name = "dtgShoolsDataGrid";
            this.dtgShoolsDataGrid.Size = new System.Drawing.Size(444, 150);
            this.dtgShoolsDataGrid.TabIndex = 0;
            // 
            // shkollaIdDataGridViewTextBoxColumn
            // 
            this.shkollaIdDataGridViewTextBoxColumn.DataPropertyName = "ShkollaId";
            this.shkollaIdDataGridViewTextBoxColumn.HeaderText = "ShkollaId";
            this.shkollaIdDataGridViewTextBoxColumn.Name = "shkollaIdDataGridViewTextBoxColumn";
            // 
            // shkollaEmriDataGridViewTextBoxColumn
            // 
            this.shkollaEmriDataGridViewTextBoxColumn.DataPropertyName = "ShkollaEmri";
            this.shkollaEmriDataGridViewTextBoxColumn.HeaderText = "ShkollaEmri";
            this.shkollaEmriDataGridViewTextBoxColumn.Name = "shkollaEmriDataGridViewTextBoxColumn";
            // 
            // shkollaTipiDataGridViewTextBoxColumn
            // 
            this.shkollaTipiDataGridViewTextBoxColumn.DataPropertyName = "ShkollaTipi";
            this.shkollaTipiDataGridViewTextBoxColumn.HeaderText = "ShkollaTipi";
            this.shkollaTipiDataGridViewTextBoxColumn.Name = "shkollaTipiDataGridViewTextBoxColumn";
            // 
            // shkollaBindingSource
            // 
            this.shkollaBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Shkolla);
            // 
            // SchoolsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgShoolsDataGrid);
            this.Name = "SchoolsList";
            this.Text = "SchoolsList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgShoolsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shkollaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn shkollaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shkollaEmriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shkollaTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shkollaBindingSource;
        public System.Windows.Forms.DataGridView dtgShoolsDataGrid;
    }
}