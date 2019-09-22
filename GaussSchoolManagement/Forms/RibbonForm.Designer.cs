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
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
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
            this.ribbon1.Size = new System.Drawing.Size(881, 182);
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
            // 
            // rbnBtnCourses
            // 
            this.rbnBtnCourses.Image = ((System.Drawing.Image)(resources.GetObject("rbnBtnCourses.Image")));
            this.rbnBtnCourses.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnCourses.LargeImage")));
            this.rbnBtnCourses.Name = "rbnBtnCourses";
            this.rbnBtnCourses.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnCourses.SmallImage")));
            this.rbnBtnCourses.Text = "Courses";
            // 
            // rbnBtnInstructors
            // 
            this.rbnBtnInstructors.Image = ((System.Drawing.Image)(resources.GetObject("rbnBtnInstructors.Image")));
            this.rbnBtnInstructors.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnInstructors.LargeImage")));
            this.rbnBtnInstructors.Name = "rbnBtnInstructors";
            this.rbnBtnInstructors.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnBtnInstructors.SmallImage")));
            this.rbnBtnInstructors.Text = "Instructors";
            // 
            // RibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 485);
            this.Controls.Add(this.ribbon1);
            this.KeyPreview = true;
            this.Name = "RibbonForm";
            this.Text = "RibbonForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab rbnTabHome;
        private System.Windows.Forms.RibbonPanel rbnPnlActivities;
        private System.Windows.Forms.RibbonButton rbnBtnStudents;
        private System.Windows.Forms.RibbonButton rbnBtnCourses;
        private System.Windows.Forms.RibbonButton rbnBtnInstructors;
    }
}