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
            this.btnSavePayments = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalPaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaymentForm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelectPayment = new System.Windows.Forms.Button();
            this.pagesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nxeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaymentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxeneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPaymentsDataGrid
            // 
            this.dtgPaymentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPaymentsDataGrid.Location = new System.Drawing.Point(52, 99);
            this.dtgPaymentsDataGrid.Name = "dtgPaymentsDataGrid";
            this.dtgPaymentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPaymentsDataGrid.Size = new System.Drawing.Size(563, 150);
            this.dtgPaymentsDataGrid.TabIndex = 0;
            this.dtgPaymentsDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgPaymentsDataGrid_CellMouseDoubleClick);
            // 
            // btnSavePayments
            // 
            this.btnSavePayments.Location = new System.Drawing.Point(301, 272);
            this.btnSavePayments.Name = "btnSavePayments";
            this.btnSavePayments.Size = new System.Drawing.Size(75, 23);
            this.btnSavePayments.TabIndex = 1;
            this.btnSavePayments.Text = "Save";
            this.btnSavePayments.UseVisualStyleBackColor = true;
            this.btnSavePayments.Click += new System.EventHandler(this.BtnSavePayments_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(478, 58);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 14;
            this.txtDiscount.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // txtTotalPaid
            // 
            this.txtTotalPaid.Location = new System.Drawing.Point(372, 58);
            this.txtTotalPaid.Name = "txtTotalPaid";
            this.txtTotalPaid.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPaid.TabIndex = 15;
            this.txtTotalPaid.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Discount";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(266, 58);
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(100, 20);
            this.txtServiceDescription.TabIndex = 16;
            this.txtServiceDescription.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total paid";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(160, 58);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 17;
            this.txtDate.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Service description";
            // 
            // txtPaymentForm
            // 
            this.txtPaymentForm.Location = new System.Drawing.Point(52, 58);
            this.txtPaymentForm.Name = "txtPaymentForm";
            this.txtPaymentForm.Size = new System.Drawing.Size(102, 20);
            this.txtPaymentForm.TabIndex = 18;
            this.txtPaymentForm.TextChanged += new System.EventHandler(this.OnInputChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Payment Form";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(461, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear search";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSelectPayment
            // 
            this.btnSelectPayment.Location = new System.Drawing.Point(55, 272);
            this.btnSelectPayment.Name = "btnSelectPayment";
            this.btnSelectPayment.Size = new System.Drawing.Size(140, 23);
            this.btnSelectPayment.TabIndex = 1;
            this.btnSelectPayment.Text = "Select Payment";
            this.btnSelectPayment.UseVisualStyleBackColor = true;
            this.btnSelectPayment.Click += new System.EventHandler(this.BtnSelectPayment_Click);
            // 
            // pagesaBindingSource
            // 
            this.pagesaBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Pagesa);
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
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtTotalPaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPaymentForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelectPayment);
            this.Controls.Add(this.btnSavePayments);
            this.Controls.Add(this.dtgPaymentsDataGrid);
            this.Name = "PaymentList";
            this.Text = "PaymentList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaymentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxeneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pagesaBindingSource;
        public System.Windows.Forms.DataGridView dtgPaymentsDataGrid;
        private System.Windows.Forms.Button btnSavePayments;
        private System.Windows.Forms.BindingSource nxeneBindingSource;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotalPaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaymentForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelectPayment;
    }
}