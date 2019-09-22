using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            form.Show();
        }

        private void RbnBtnCourses_Click(object sender, EventArgs e)
        {
            var form = new CourseOverview();
            form.Show();
        }

        private void RbnBtnInstructors_Click(object sender, EventArgs e)
        {
            var form = new InstructorOverview();
            form.Show();
        }

        private void BtnEntryForm_Click(object sender, EventArgs e)
        {
            var form = new EntryForm();
            form.Show();
        }
    }
}
