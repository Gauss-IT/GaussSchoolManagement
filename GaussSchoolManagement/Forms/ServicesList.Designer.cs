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
            this.sherbimetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveServices = new System.Windows.Forms.Button();
            this.sherbimetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sherbimetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgServicesDataGrid
            // 
            this.dtgServicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServicesDataGrid.Location = new System.Drawing.Point(12, 12);
            this.dtgServicesDataGrid.Name = "dtgServicesDataGrid";
            this.dtgServicesDataGrid.Size = new System.Drawing.Size(654, 150);
            this.dtgServicesDataGrid.TabIndex = 0;
            // 
            // sherbimetBindingSource
            // 
            this.sherbimetBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Sherbimet);
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
            // sherbimetBindingSource1
            // 
            this.sherbimetBindingSource1.DataSource = typeof(GaussSchoolManagement.DataModel.Sherbimet);
            // 
            // ServicesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveServices);
            this.Controls.Add(this.dtgServicesDataGrid);
            this.Name = "ServicesList";
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
    }
}