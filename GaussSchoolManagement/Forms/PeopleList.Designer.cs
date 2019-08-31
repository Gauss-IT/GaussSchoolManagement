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
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbiemriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLindjesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAdresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instruktoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prindersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPeopleDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPeopleDataGrid
            // 
            this.dtgPeopleDataGrid.AutoGenerateColumns = false;
            this.dtgPeopleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPeopleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIdDataGridViewTextBoxColumn,
            this.emriDataGridViewTextBoxColumn,
            this.mbiemriDataGridViewTextBoxColumn,
            this.dataLindjesDataGridViewTextBoxColumn,
            this.emailAdresaDataGridViewTextBoxColumn,
            this.telefoniDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.instruktoresDataGridViewTextBoxColumn,
            this.nxenesDataGridViewTextBoxColumn,
            this.prindersDataGridViewTextBoxColumn});
            this.dtgPeopleDataGrid.DataSource = this.personaBindingSource;
            this.dtgPeopleDataGrid.Location = new System.Drawing.Point(2, 12);
            this.dtgPeopleDataGrid.Name = "dtgPeopleDataGrid";
            this.dtgPeopleDataGrid.Size = new System.Drawing.Size(881, 150);
            this.dtgPeopleDataGrid.TabIndex = 0;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            // 
            // emriDataGridViewTextBoxColumn
            // 
            this.emriDataGridViewTextBoxColumn.DataPropertyName = "Emri";
            this.emriDataGridViewTextBoxColumn.HeaderText = "Emri";
            this.emriDataGridViewTextBoxColumn.Name = "emriDataGridViewTextBoxColumn";
            // 
            // mbiemriDataGridViewTextBoxColumn
            // 
            this.mbiemriDataGridViewTextBoxColumn.DataPropertyName = "Mbiemri";
            this.mbiemriDataGridViewTextBoxColumn.HeaderText = "Mbiemri";
            this.mbiemriDataGridViewTextBoxColumn.Name = "mbiemriDataGridViewTextBoxColumn";
            // 
            // dataLindjesDataGridViewTextBoxColumn
            // 
            this.dataLindjesDataGridViewTextBoxColumn.DataPropertyName = "DataLindjes";
            this.dataLindjesDataGridViewTextBoxColumn.HeaderText = "DataLindjes";
            this.dataLindjesDataGridViewTextBoxColumn.Name = "dataLindjesDataGridViewTextBoxColumn";
            // 
            // emailAdresaDataGridViewTextBoxColumn
            // 
            this.emailAdresaDataGridViewTextBoxColumn.DataPropertyName = "EmailAdresa";
            this.emailAdresaDataGridViewTextBoxColumn.HeaderText = "EmailAdresa";
            this.emailAdresaDataGridViewTextBoxColumn.Name = "emailAdresaDataGridViewTextBoxColumn";
            // 
            // telefoniDataGridViewTextBoxColumn
            // 
            this.telefoniDataGridViewTextBoxColumn.DataPropertyName = "Telefoni";
            this.telefoniDataGridViewTextBoxColumn.HeaderText = "Telefoni";
            this.telefoniDataGridViewTextBoxColumn.Name = "telefoniDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // instruktoresDataGridViewTextBoxColumn
            // 
            this.instruktoresDataGridViewTextBoxColumn.DataPropertyName = "Instruktores";
            this.instruktoresDataGridViewTextBoxColumn.HeaderText = "Instruktores";
            this.instruktoresDataGridViewTextBoxColumn.Name = "instruktoresDataGridViewTextBoxColumn";
            // 
            // nxenesDataGridViewTextBoxColumn
            // 
            this.nxenesDataGridViewTextBoxColumn.DataPropertyName = "Nxenes";
            this.nxenesDataGridViewTextBoxColumn.HeaderText = "Nxenes";
            this.nxenesDataGridViewTextBoxColumn.Name = "nxenesDataGridViewTextBoxColumn";
            // 
            // prindersDataGridViewTextBoxColumn
            // 
            this.prindersDataGridViewTextBoxColumn.DataPropertyName = "Prinders";
            this.prindersDataGridViewTextBoxColumn.HeaderText = "Prinders";
            this.prindersDataGridViewTextBoxColumn.Name = "prindersDataGridViewTextBoxColumn";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbiemriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLindjesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAdresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instruktoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prindersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personaBindingSource;
        public System.Windows.Forms.DataGridView dtgPeopleDataGrid;
        private System.Windows.Forms.Button btnSave;
    }
}