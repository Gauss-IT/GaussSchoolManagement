namespace GaussSchoolManagement.Forms
{
    partial class PaymentList
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
            this.dtgPaymentsDataGrid = new System.Windows.Forms.DataGridView();
            this.pagesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSavePayments = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nxeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaymentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxeneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPaymentsDataGrid
            // 
            this.dtgPaymentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPaymentsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.dtgPaymentsDataGrid.Name = "dtgPaymentsDataGrid";
            this.dtgPaymentsDataGrid.Size = new System.Drawing.Size(920, 150);
            this.dtgPaymentsDataGrid.TabIndex = 0;
            // 
            // pagesaBindingSource
            // 
            this.pagesaBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Pagesa);
            // 
            // btnSavePayments
            // 
            this.btnSavePayments.Location = new System.Drawing.Point(301, 210);
            this.btnSavePayments.Name = "btnSavePayments";
            this.btnSavePayments.Size = new System.Drawing.Size(75, 23);
            this.btnSavePayments.TabIndex = 1;
            this.btnSavePayments.Text = "Save";
            this.btnSavePayments.UseVisualStyleBackColor = true;
            this.btnSavePayments.Click += new System.EventHandler(this.BtnSavePayments_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nxeneBindingSource;
            this.comboBox1.DisplayMember = "Persona";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // nxeneBindingSource
            // 
            this.nxeneBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Nxene);
            // 
            // PaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSavePayments);
            this.Controls.Add(this.dtgPaymentsDataGrid);
            this.Name = "PaymentList";
            this.Text = "PaymentList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaymentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxeneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pagesaBindingSource;
        public System.Windows.Forms.DataGridView dtgPaymentsDataGrid;
        private System.Windows.Forms.Button btnSavePayments;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource nxeneBindingSource;
    }
}