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
    }
}
