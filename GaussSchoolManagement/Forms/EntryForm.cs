using System;
using System.Data.Entity;
using System.Windows.Forms;
using GaussSchoolManagement.DataModel;

namespace GaussSchoolManagement.Forms
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditSchools_Click(object sender, EventArgs e)
        {
            var form = new SchoolsList();
            DatabaseModel.Instance.Shkollas.Load();
            form.dtgShoolsDataGrid.DataSource = DatabaseModel.Instance.Shkollas.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditPeople_Click(object sender, EventArgs e)
        {
            var form = new PeopleList();
            DatabaseModel.Instance.Personas.Load();
            form.dtgPeopleDataGrid.DataSource = DatabaseModel.Instance.Personas.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditCourse_Click(object sender, EventArgs e)
        {
            var form = new CoursesList();
            DatabaseModel.Instance.Kurses.Load();
            form.dtgCoursesDatagrid.DataSource = DatabaseModel.Instance.Kurses.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditPayments_Click(object sender, EventArgs e)
        {
            var form = new PaymentList();
            DatabaseModel.Instance.Pagesas.Load();
            form.dtgPaymentsDataGrid.DataSource = DatabaseModel.Instance.Pagesas.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditServices_Click(object sender, EventArgs e)
        {
            var form = new ServicesList();
            DatabaseModel.Instance.Sherbimets.Load();
            form.dtgServicesDataGrid.DataSource = DatabaseModel.Instance.Sherbimets.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditParents_Click(object sender, EventArgs e)
        {
            var form = new ParentsList();
            DatabaseModel.Instance.Prinders.Load();
            form.dtgParentsDataGrid.DataSource = DatabaseModel.Instance.Prinders.Local.ToBindingList();
            form.Show();
        }

        private void BtnEditStudents_Click(object sender, EventArgs e)
        {
            var form = new StudentsList();
            DatabaseModel.Instance.Nxenes.Load();
            form.dtgStudentsDataGrid.DataSource = DatabaseModel.Instance.Nxenes.Local.ToBindingList();
            form.Show();
        }

        private void btnEditInstructors_Click(object sender, EventArgs e)
        {
            var form = new InstructorsList();
            DatabaseModel.Instance.Instruktores.Load();
            form.dtgInstructorsDataGrid.DataSource = DatabaseModel.Instance.Instruktores.Local.ToBindingList();
            form.Show();
        }
    }
}
