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
            this.nxeneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nxeneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStudentsDataGrid
            // 
            this.dtgStudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentsDataGrid.Location = new System.Drawing.Point(90, 34);
            this.dtgStudentsDataGrid.Name = "dtgStudentsDataGrid";
            this.dtgStudentsDataGrid.Size = new System.Drawing.Size(1050, 212);
            this.dtgStudentsDataGrid.TabIndex = 0;
            // 
            // nxeneBindingSource
            // 
            this.nxeneBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Nxene);
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
    }
}