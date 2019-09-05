using GaussSchoolManagement.DataModel;
using System;
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
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Shkollas.ToList()
            };

            form.dtgShoolsDataGrid.DataSource = source;
            form.Show();
        }

        private void BtnEditPeople_Click(object sender, EventArgs e)
        {
            var form = new PeopleList();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Personas.ToList()
            };

            form.dtgPeopleDataGrid.DataSource = source;
            form.Show();
        }

        private void BtnEditCourse_Click(object sender, EventArgs e)
        {
            var form = new CoursesList();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Kurses.ToList()
            };

            form.dtgCoursesDatagrid.DataSource = source;
            form.Show();
        }

        private void BtnEditPayments_Click(object sender, EventArgs e)
        {
            var form = new PaymentList();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Pagesas.ToList()
            };

            form.dtgPaymentsDataGrid.DataSource = source;
            form.Show();
        }

        private void BtnEditServices_Click(object sender, EventArgs e)
        {
            var form = new ServicesList();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Sherbimets.ToList()
            };

            form.dtgServicesDataGrid.DataSource = source;
            form.Show();
        }

        private void BtnEditParents_Click(object sender, EventArgs e)
        {
            var form = new ParentsList();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Prinders.Select(x => x.Persona).ToList()
            };

            form.dtgParentsDataGrid.DataSource = source;
            form.Show();
        }

        private void BtnEditStudents_Click(object sender, EventArgs e)
        {
            var form = new StudentsList();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Nxenes.Select(x => x.Persona).ToList()
            };
            
            form.dtgStudentsDataGrid.DataSource = source;
            form.Show();
        }

        private void btnEditInstructors_Click(object sender, EventArgs e)
        {
            var form = new InstructorsList();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Instruktores.Select(x => x.Persona).ToList()
            };


            form.dtgInstructorsDataGrid.DataSource = source;
            form.Show();
        }
    }
}
