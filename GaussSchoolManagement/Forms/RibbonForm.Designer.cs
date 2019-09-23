namespace GaussSchoolManagement.Forms
{
    partial class RibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonForm));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.rbnTabHome = new System.Windows.Forms.RibbonTab();
            this.rbnPnlActivities = new System.Windows.Forms.RibbonPanel();
            this.rbnBtnStudents = new System.Windows.Forms.RibbonButton();
            this.rbnBtnCourses = new System.Windows.Forms.RibbonButton();
            this.rbnBtnInstructors = new System.Windows.Forms.RibbonButton();
            this.rbnBtnEntryForm = new System.Windows.Forms.RibbonButton();
            this.btnEntryForm = new System.Windows.Forms.Button();
            this.rbnBtnPayments = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(661, 148);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.rbnTabHome);
            this.ribbon1.Text = "ribbon1";
            // 
            // rbnTabHome
            // 
            this.rbnTabHome.Name = "rbnTabHome";
            this.rbnTabHome.Panels.Add(this.rbnPnlActivities);
            this.rbnTabHome.Text = "Home";
            // 
            // rbnPnlActivities
            // 
            this.rbnPnlActivities.Items.Add(this.rbnBtnStudents);
            this.rbnPnlActivities.Items.Add(this.rbnBtnCourses);
            this.rbnPnlActivities.Items.Add(this.rbnBtnInstructors);
            this.rbnPnlActivities.Items.Add(this.rbnBtnPayments);
            this.rbnPnlActivities.Items.Add(this.rbnBtnEntryForm);
            this.rbnPnlActivities.Name = "rbnPnlActivities";
            this.rbnPnlActivities.Text = "Activities";
            // 
            // rbnBtnStudents
            // 
            this.rbnBtnStudents.Image = ((System.Drawing.Image)(resources.GetObject("rbnBtnStudents.Image")));
            this.rbnBtnStudents.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnStudents.LargeImage")));
            this.rbnBtnStudents.Name = "rbnBtnStudents";
            this.rbnBtnStudents.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnStudents.SmallImage")));
            this.rbnBtnStudents.Text = "Students";
            this.rbnBtnStudents.Click += new System.EventHandler(this.RbnBtnStudents_Click);
            // 
            // rbnBtnCourses
            // 
            this.rbnBtnCourses.Image = ((System.Drawing.Image)(resources.GetObject("rbnBtnCourses.Image")));
            this.rbnBtnCourses.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnCourses.LargeImage")));
            this.rbnBtnCourses.Name = "rbnBtnCourses";
            this.rbnBtnCourses.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnCourses.SmallImage")));
            this.rbnBtnCourses.Text = "Courses";
            this.rbnBtnCourses.Click += new System.EventHandler(this.RbnBtnCourses_Click);
            // 
            // rbnBtnInstructors
            // 
            this.rbnBtnInstructors.Image = ((System.Drawing.Image)(resources.GetObject("rbnBtnInstructors.Image")));
            this.rbnBtnInstructors.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnInstructors.LargeImage")));
            this.rbnBtnInstructors.Name = "rbnBtnInstructors";
            this.rbnBtnInstructors.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnInstructors.SmallImage")));
            this.rbnBtnInstructors.Text = "Instructors";
            this.rbnBtnInstructors.Click += new System.EventHandler(this.RbnBtnInstructors_Click);
            // 
            // rbnBtnEntryForm
            // 
            this.rbnBtnEntryForm.Image = ((System.Drawing.Image)(resources.GetObject("rbnBtnEntryForm.Image")));
            this.rbnBtnEntryForm.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnEntryForm.LargeImage")));
            this.rbnBtnEntryForm.Name = "rbnBtnEntryForm";
            this.rbnBtnEntryForm.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnEntryForm.SmallImage")));
            this.rbnBtnEntryForm.Text = "EntryForm";
            this.rbnBtnEntryForm.Click += new System.EventHandler(this.RbnBtnEntryForm_Click);
            // 
            // btnEntryForm
            // 
            this.btnEntryForm.Location = new System.Drawing.Point(0, 0);
            this.btnEntryForm.Name = "btnEntryForm";
            this.btnEntryForm.Size = new System.Drawing.Size(75, 23);
            this.btnEntryForm.TabIndex = 0;
            // 
            // rbnBtnPayments
            // 
            this.rbnBtnPayments.Image = ((System.Drawing.Image)(resources.GetObject("rbnBtnPayments.Image")));
            this.rbnBtnPayments.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnPayments.LargeImage")));
            this.rbnBtnPayments.Name = "rbnBtnPayments";
            this.rbnBtnPayments.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnPayments.SmallImage")));
            this.rbnBtnPayments.Text = "Payments";
            this.rbnBtnPayments.Click += new System.EventHandler(this.RbnBtnPayments_Click);
            // 
            // RibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 394);
            this.Controls.Add(this.btnEntryForm);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RibbonForm";
            this.Text = "RibbonForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab rbnTabHome;
        private System.Windows.Forms.RibbonPanel rbnPnlActivities;
        private System.Windows.Forms.RibbonButton rbnBtnStudents;
        private System.Windows.Forms.RibbonButton rbnBtnCourses;
        private System.Windows.Forms.RibbonButton rbnBtnInstructors;
        private System.Windows.Forms.Button btnEntryForm;
        private System.Windows.Forms.RibbonButton rbnBtnEntryForm;
        private System.Windows.Forms.RibbonButton rbnBtnPayments;
    }
}