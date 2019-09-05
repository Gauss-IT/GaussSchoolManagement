namespace GaussSchoolManagement.Forms
{
    partial class PeopleList
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
            this.dtgPeopleDataGrid = new System.Windows.Forms.DataGridView();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPeopleDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPeopleDataGrid
            // 
            this.dtgPeopleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPeopleDataGrid.Location = new System.Drawing.Point(2, 12);
            this.dtgPeopleDataGrid.Name = "dtgPeopleDataGrid";
            this.dtgPeopleDataGrid.Size = new System.Drawing.Size(881, 150);
            this.dtgPeopleDataGrid.TabIndex = 0;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(GaussSchoolManagement.DataModel.Persona);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtgPeopleDataGrid);
            this.Name = "PeopleList";
            this.Text = "PeopleList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPeopleDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource personaBindingSource;
        public System.Windows.Forms.DataGridView dtgPeopleDataGrid;
        private System.Windows.Forms.Button btnSave;
    }
}