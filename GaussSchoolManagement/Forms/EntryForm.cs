using GaussSchoolManagement.DataModel;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();            
        }

        private void BtnEditSchools_Click(object sender, EventArgs e)
        {
            var form = new SchoolsList();
            var shkolla = DatabaseModel.Instance.Shkollas;
            shkolla.Load();
            form.dtgShoolsDataGrid.DataSource = shkolla.Local.ToBindingList();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnEditPeople_Click(object sender, EventArgs e)
        {
            var form = new PeopleList();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnEditCourse_Click(object sender, EventArgs e)
        {
            var form = new CoursesList();
            var kurse = DatabaseModel.Instance.Kurses;
            kurse.Load();
            form.dtgCourses.DataSource = kurse.Local.ToBindingList();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnEditPayments_Click(object sender, EventArgs e)
        {
            var form = new PaymentList();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnEditParents_Click(object sender, EventArgs e)
        {
            var form = new ParentsList();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnEditStudents_Click(object sender, EventArgs e)
        {
            var form = new StudentsList();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void btnEditInstructors_Click(object sender, EventArgs e)
        {
            var form = new InstructorsList();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnInstructorsCourses_Click(object sender, EventArgs e)
        {
            var form = new InstructorsCourses();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnStudentCourses_Click(object sender, EventArgs e)
        {
            var form = new StudentsCourses();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new StudentsPayments();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnEditPerson_Click(object sender, EventArgs e)
        {
            var form = new StudentOverview();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnInstructorOverview_Click(object sender, EventArgs e)
        {
            var form = new InstructorOverview();
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnCourseOverview_Click(object sender, EventArgs e)
        {
            var form = new CourseOverview();
            form.MdiParent = this.MdiParent;
            form.Show();
        }
    }
}
