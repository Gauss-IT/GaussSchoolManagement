using GaussSchoolManagement.DataModel;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            DatabaseModel.Instance.Personas.Load();
           
        }
        
        private void BtnEditPerson_Click(object sender, EventArgs e)
        {
            var form = new StudentOverview();
            form.Show();
        }
        private void BtnInstructorOverview_Click(object sender, EventArgs e)
        {
            var form = new InstructorOverview();
            form.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var form = new EntryForm();
            form.Show();
        }

        private void BtnCourseOverview_Click(object sender, EventArgs e)
        {
            var form = new CourseOverview();
            form.Show();
        }
    }
}
