namespace GaussSchoolManagement.Forms
{
    partial class EntryForm
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
            this.btnCreateEntity = new System.Windows.Forms.Button();
            this.btnEditSchools = new System.Windows.Forms.Button();
            this.btnEditPeople = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnEditPayments = new System.Windows.Forms.Button();
            this.btnEditServices = new System.Windows.Forms.Button();
            this.btnEditParents = new System.Windows.Forms.Button();
            this.btnEditStudents = new System.Windows.Forms.Button();
            this.btnEditInstructors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateEntity
            // 
            this.btnCreateEntity.Location = new System.Drawing.Point(59, 32);
            this.btnCreateEntity.Name = "btnCreateEntity";
            this.btnCreateEntity.Size = new System.Drawing.Size(114, 65);
            this.btnCreateEntity.TabIndex = 0;
            this.btnCreateEntity.Text = "Create entity";
            this.btnCreateEntity.UseVisualStyleBackColor = true;
            this.btnCreateEntity.Click += new System.EventHandler(this.btnCreateEntity_Click);
            // 
            // btnEditSchools
            // 
            this.btnEditSchools.Location = new System.Drawing.Point(199, 32);
            this.btnEditSchools.Name = "btnEditSchools";
            this.btnEditSchools.Size = new System.Drawing.Size(114, 65);
            this.btnEditSchools.TabIndex = 1;
            this.btnEditSchools.Text = "Edit schools";
            this.btnEditSchools.UseVisualStyleBackColor = true;
            this.btnEditSchools.Click += new System.EventHandler(this.BtnEditSchools_Click);
            // 
            // btnEditPeople
            // 
            this.btnEditPeople.Location = new System.Drawing.Point(339, 32);
            this.btnEditPeople.Name = "btnEditPeople";
            this.btnEditPeople.Size = new System.Drawing.Size(114, 65);
            this.btnEditPeople.TabIndex = 2;
            this.btnEditPeople.Text = "Edit People";
            this.btnEditPeople.UseVisualStyleBackColor = true;
            this.btnEditPeople.Click += new System.EventHandler(this.BtnEditPeople_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Location = new System.Drawing.Point(484, 32);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(114, 65);
            this.btnEditCourse.TabIndex = 3;
            this.btnEditCourse.Text = "Edit Course";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.BtnEditCourse_Click);
            // 
            // btnEditPayments
            // 
            this.btnEditPayments.Location = new System.Drawing.Point(625, 32);
            this.btnEditPayments.Name = "btnEditPayments";
            this.btnEditPayments.Size = new System.Drawing.Size(114, 65);
            this.btnEditPayments.TabIndex = 4;
            this.btnEditPayments.Text = "Edit Payments";
            this.btnEditPayments.UseVisualStyleBackColor = true;
            this.btnEditPayments.Click += new System.EventHandler(this.BtnEditPayments_Click);
            // 
            // btnEditServices
            // 
            this.btnEditServices.Location = new System.Drawing.Point(59, 120);
            this.btnEditServices.Name = "btnEditServices";
            this.btnEditServices.Size = new System.Drawing.Size(114, 65);
            this.btnEditServices.TabIndex = 5;
            this.btnEditServices.Text = "Edit Services";
            this.btnEditServices.UseVisualStyleBackColor = true;
            this.btnEditServices.Click += new System.EventHandler(this.BtnEditServices_Click);
            // 
            // btnEditParents
            // 
            this.btnEditParents.Location = new System.Drawing.Point(199, 120);
            this.btnEditParents.Name = "btnEditParents";
            this.btnEditParents.Size = new System.Drawing.Size(114, 64);
            this.btnEditParents.TabIndex = 6;
            this.btnEditParents.Text = "Edit Parents";
            this.btnEditParents.UseVisualStyleBackColor = true;
            this.btnEditParents.Click += new System.EventHandler(this.BtnEditParents_Click);
            // 
            // btnEditStudents
            // 
            this.btnEditStudents.Location = new System.Drawing.Point(339, 120);
            this.btnEditStudents.Name = "btnEditStudents";
            this.btnEditStudents.Size = new System.Drawing.Size(114, 64);
            this.btnEditStudents.TabIndex = 7;
            this.btnEditStudents.Text = "Edit Students";
            this.btnEditStudents.UseVisualStyleBackColor = true;
            this.btnEditStudents.Click += new System.EventHandler(this.BtnEditStudents_Click);
            // 
            // btnEditInstructors
            // 
            this.btnEditInstructors.Location = new System.Drawing.Point(484, 120);
            this.btnEditInstructors.Name = "btnEditInstructors";
            this.btnEditInstructors.Size = new System.Drawing.Size(114, 65);
            this.btnEditInstructors.TabIndex = 8;
            this.btnEditInstructors.Text = "Edit Instructors";
            this.btnEditInstructors.UseVisualStyleBackColor = true;
            this.btnEditInstructors.Click += new System.EventHandler(this.btnEditInstructors_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditInstructors);
            this.Controls.Add(this.btnEditStudents);
            this.Controls.Add(this.btnEditParents);
            this.Controls.Add(this.btnEditServices);
            this.Controls.Add(this.btnEditPayments);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnEditPeople);
            this.Controls.Add(this.btnEditSchools);
            this.Controls.Add(this.btnCreateEntity);
            this.Name = "EntryForm";
            this.Text = "Gauss School Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEntity;
        private System.Windows.Forms.Button btnEditSchools;
        private System.Windows.Forms.Button btnEditPeople;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnEditPayments;
        private System.Windows.Forms.Button btnEditServices;
        private System.Windows.Forms.Button btnEditParents;
        private System.Windows.Forms.Button btnEditStudents;
        private System.Windows.Forms.Button btnEditInstructors;
    }
}

