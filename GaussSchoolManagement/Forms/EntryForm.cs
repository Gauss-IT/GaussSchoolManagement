using GaussSchoolManagement.DataModel;
using System;
using System.Data.Entity;
using System.Linq;
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
            DatabaseModel.Instance.Shkollas.Load();
            form.dtgShoolsDataGrid.DataSource = 
                DatabaseModel.Instance.Shkollas.Local.ToBindingList();
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
            DatabaseModel.Instance.Kurses.Load();
            form.dtgCoursesDatagrid.DataSource = 
                DatabaseModel.Instance.Kurses.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditPayments_Click(object sender, EventArgs e)
        {
            var form = new PaymentList();
            DatabaseModel.Instance.Pagesas.Load();
            form.dtgPaymentsDataGrid.DataSource = 
                DatabaseModel.Instance.Pagesas.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditServices_Click(object sender, EventArgs e)
        {
            var form = new ServicesList();
            DatabaseModel.Instance.Sherbimets.Load();
            form.dtgServicesDataGrid.DataSource =
                DatabaseModel.Instance.Sherbimets.Local.ToBindingList();
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
    }
}
