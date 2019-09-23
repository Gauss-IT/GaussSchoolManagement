using System;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class RibbonForm : Form
    {
        public RibbonForm()
        {
            InitializeComponent();
        }

        private void RbnBtnStudents_Click(object sender, EventArgs e)
        {
            var form = new StudentOverview();
            form.MdiParent = this;
            form.Show();
        }

        private void RbnBtnCourses_Click(object sender, EventArgs e)
        {
            var form = new CourseOverview();
            form.MdiParent = this;
            form.Show();
        }

        private void RbnBtnInstructors_Click(object sender, EventArgs e)
        {
            var form = new InstructorOverview();
            form.MdiParent = this;
            form.Show();
        }

        private void RbnBtnEntryForm_Click(object sender, EventArgs e)
        {
            var form = new EntryForm();
            form.MdiParent = this;
            form.Show();
        }

        private void RbnBtnPayments_Click(object sender, EventArgs e)
        {
            var form = new PaymentOverview();
            form.MdiParent = this;
            form.Show();
        }
    }
}
