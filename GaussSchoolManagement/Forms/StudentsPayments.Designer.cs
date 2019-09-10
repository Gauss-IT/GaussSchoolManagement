namespace GaussSchoolManagement.Forms
{
    partial class StudentsPayments
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
            this.dtgStudentsPayments = new System.Windows.Forms.DataGridView();
            this.btnAddStudentsPayments = new System.Windows.Forms.Button();
            this.btnRemoveStudentPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbPayments = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentsPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStudentsPayments
            // 
            this.dtgStudentsPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentsPayments.Location = new System.Drawing.Point(12, 12);
            this.dtgStudentsPayments.Name = "dtgStudentsPayments";
            this.dtgStudentsPayments.Size = new System.Drawing.Size(747, 150);
            this.dtgStudentsPayments.TabIndex = 0;
            // 
            // btnAddStudentsPayments
            // 
            this.btnAddStudentsPayments.Location = new System.Drawing.Point(12, 195);
            this.btnAddStudentsPayments.Name = "btnAddStudentsPayments";
            this.btnAddStudentsPayments.Size = new System.Drawing.Size(152, 23);
            this.btnAddStudentsPayments.TabIndex = 1;
            this.btnAddStudentsPayments.Text = "Add new Student Payment";
            this.btnAddStudentsPayments.UseVisualStyleBackColor = true;
            this.btnAddStudentsPayments.Click += new System.EventHandler(this.BtnAddStudentsPayments_Click);
            // 
            // btnRemoveStudentPayment
            // 
            this.btnRemoveStudentPayment.Location = new System.Drawing.Point(597, 195);
            this.btnRemoveStudentPayment.Name = "btnRemoveStudentPayment";
            this.btnRemoveStudentPayment.Size = new System.Drawing.Size(152, 23);
            this.btnRemoveStudentPayment.TabIndex = 1;
            this.btnRemoveStudentPayment.Text = "Remove Student Payment";
            this.btnRemoveStudentPayment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payments";
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(35, 284);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(121, 21);
            this.cmbStudents.TabIndex = 3;
            // 
            // cmbPayments
            // 
            this.cmbPayments.FormattingEnabled = true;
            this.cmbPayments.Location = new System.Drawing.Point(230, 284);
            this.cmbPayments.Name = "cmbPayments";
            this.cmbPayments.Size = new System.Drawing.Size(121, 21);
            this.cmbPayments.TabIndex = 3;
            // 
            // StudentsPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbPayments);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveStudentPayment);
            this.Controls.Add(this.btnAddStudentsPayments);
            this.Controls.Add(this.dtgStudentsPayments);
            this.Name = "StudentsPayments";
            this.Text = "StudentsPayments";
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentsPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgStudentsPayments;
        private System.Windows.Forms.Button btnAddStudentsPayments;
        private System.Windows.Forms.Button btnRemoveStudentPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbPayments;
    }
}