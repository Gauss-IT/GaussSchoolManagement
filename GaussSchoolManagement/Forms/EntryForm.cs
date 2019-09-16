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
            form.Show();
        }

        private void BtnEditPeople_Click(object sender, EventArgs e)
        {
            var form = new PeopleList();
            form.Show();
        }

        private void BtnEditCourse_Click(object sender, EventArgs e)
        {
            var form = new CoursesList();
            var kurse = DatabaseModel.Instance.Kurses;
            kurse.Load();
            form.dtgCoursesDatagrid.DataSource = kurse.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditPayments_Click(object sender, EventArgs e)
        {
            var form = new PaymentList();
            var pagesa = DatabaseModel.Instance.Pagesas;
            pagesa.Load();
            form.dtgPaymentsDataGrid.DataSource = pagesa.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditServices_Click(object sender, EventArgs e)
        {
            var form = new ServicesList();
            var sherbimet = DatabaseModel.Instance.Sherbimets;
            sherbimet.Load();
            form.dtgServicesDataGrid.DataSource = sherbimet.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditParents_Click(object sender, EventArgs e)
        {
            var form = new ParentsList();
            form.Show();
        }

        private void BtnEditStudents_Click(object sender, EventArgs e)
        {
            var form = new StudentsList();
            form.Show();
        }

        private void btnEditInstructors_Click(object sender, EventArgs e)
        {
            var form = new InstructorsList();
            form.Show();
        }

        private void BtnInstructorsCourses_Click(object sender, EventArgs e)
        {
            var form = new InstructorsCourses();
            form.Show();
        }

        private void BtnStudentCourses_Click(object sender, EventArgs e)
        {
            var form = new StudentsCourses();
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new StudentsPayments();
            form.Show();
        }

        private void BtnEditPerson_Click(object sender, EventArgs e)
        {
            var form = new StudentOverview();
            form.Show();
        }

        private void BtnInstructorOverview_Click(object sender, EventArgs e)
        {
            //var form = new InstructorOverview();
            //form.Show();
        }
    }
}
