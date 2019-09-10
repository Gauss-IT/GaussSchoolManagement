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
            this.dtgParentsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPeople = new System.Windows.Forms.ComboBox();
            this.btnAddParent = new System.Windows.Forms.Button();
            this.btnRemoveParent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgParentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgParentsDataGrid
            // 
            this.dtgParentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgParentsDataGrid.Location = new System.Drawing.Point(108, 29);
            this.dtgParentsDataGrid.Name = "dtgParentsDataGrid";
            this.dtgParentsDataGrid.Size = new System.Drawing.Size(485, 150);
            this.dtgParentsDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personal Data";
            // 
            // cmbPeople
            // 
            this.cmbPeople.FormattingEnabled = true;
            this.cmbPeople.Location = new System.Drawing.Point(101, 292);
            this.cmbPeople.Name = "cmbPeople";
            this.cmbPeople.Size = new System.Drawing.Size(121, 21);
            this.cmbPeople.TabIndex = 3;
            // 
            // btnAddParent
            // 
            this.btnAddParent.Location = new System.Drawing.Point(108, 204);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(163, 23);
            this.btnAddParent.TabIndex = 4;
            this.btnAddParent.Text = "Add new Parent";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.BtnAddParent_Click);
            // 
            // btnRemoveParent
            // 
            this.btnRemoveParent.Location = new System.Drawing.Point(430, 204);
            this.btnRemoveParent.Name = "btnRemoveParent";
            this.btnRemoveParent.Size = new System.Drawing.Size(163, 23);
            this.btnRemoveParent.TabIndex = 4;
            this.btnRemoveParent.Text = "Remove Parent";
            this.btnRemoveParent.UseVisualStyleBackColor = true;
            // 
            // ParentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveParent);
            this.Controls.Add(this.btnAddParent);
            this.Controls.Add(this.cmbPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgParentsDataGrid);
            this.Name = "ParentsList";
            this.Text = "ParentsList";
            ((System.ComponentModel.ISupportInitialize)(this.dtgParentsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dtgParentsDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPeople;
        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnRemoveParent;
    }
}