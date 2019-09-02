namespace GaussSchoolManagement.Forms
{
    partial class ServicesList
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
            this.dtgServicesDataGrid = new System.Windows.Forms.DataGridView();
            this.btnSaveServices = new System.Windows.Forms.Button();
            this.sherbimetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sherbimetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sherbimiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pershkrimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgServicesDataGrid
            // 
            this.dtgServicesDataGrid.AutoGenerateColumns = false;
            this.dtgServicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServicesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sherbimiIdDataGridViewTextBoxColumn,
            this.cmimiDataGridViewTextBoxColumn,
            this.pershkrimiDataGridViewTextBoxColumn,
            this.kursIdDataGridViewTextBoxColumn});
            this.dtgServicesDataGrid.DataSource = this.sherbimetBindingSource;
            this.dtgServicesDataGrid.Location = new System.Drawing.Point(12, 12);
            this.dtgServicesDataGrid.Name = "dtgServicesDataGrid";
            this.dtgServicesDataGrid.Size = new System.Drawing.Size(654, 150);
            this.dtgServicesDataGrid.TabIndex = 0;
            // 
            // btnSaveServices
            // 
            this.btnSaveServices.Location = new System.Drawing.Point(150, 193);
            this.btnSaveServices.Name = "btnSaveServices";
            this.btnSaveServices.Size = new System.Drawing.Size(75, 23);
            this.btnSaveServices.TabIndex = 1;
            this.btnSaveServices.Text = "Save";
            this.btnSaveServices.UseVisualStyleBackColor = true;
            this.btnSaveServices.Click += new System.EventHandler(this.BtnSaveServices_Click);
            // 
            // sherbimetBindingSource
            // 
            this.sherbimetBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Sherbimet);
            // 
            // sherbimetBindingSource1
            // 
            this.sherbimetBindingSource1.DataSource = typeof(GaussSchoolManagement.DataModel.Sherbimet);
            // 
            // sherbimiIdDataGridViewTextBoxColumn
            // 
            this.sherbimiIdDataGridViewTextBoxColumn.DataPropertyName = "SherbimiId";
            this.sherbimiIdDataGridViewTextBoxColumn.HeaderText = "SherbimiId";
            this.sherbimiIdDataGridViewTextBoxColumn.Name = "sherbimiIdDataGridViewTextBoxColumn";
            // 
            // cmimiDataGridViewTextBoxColumn
            // 
            this.cmimiDataGridViewTextBoxColumn.DataPropertyName = "Cmimi";
            this.cmimiDataGridViewTextBoxColumn.HeaderText = "Cmimi";
            this.cmimiDataGridViewTextBoxColumn.Name = "cmimiDataGridViewTextBoxColumn";
            // 
            // pershkrimiDataGridViewTextBoxColumn
            // 
            this.pershkrimiDataGridViewTextBoxColumn.DataPropertyName = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.HeaderText = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.Name = "pershkrimiDataGridViewTextBoxColumn";
            // 
            // kursIdDataGridViewTextBoxColumn
            // 
            this.kursIdDataGridViewTextBoxColumn.DataPropertyName = "KursId";
            this.kursIdDataGridViewTextBoxColumn.HeaderText = "KursId";
            this.kursIdDataGridViewTextBoxColumn.Name = "kursIdDataGridViewTextBoxColumn";
            // 
            // ServiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveServices);
            this.Controls.Add(this.dtgServicesDataGrid);
            this.Name = "ServiceList";
            this.Text = "ServiceList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sherbimetBindingSource;
        private System.Windows.Forms.BindingSource sherbimetBindingSource1;
        public System.Windows.Forms.DataGridView dtgServicesDataGrid;
        private System.Windows.Forms.Button btnSaveServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn sherbimiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kursIdDataGridViewTextBoxColumn;
    }
}