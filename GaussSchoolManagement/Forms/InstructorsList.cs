using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class InstructorsList : Form
    {
        public InstructorsList()
        {
            InitializeComponent();
            PopulateDataGrid();
            PopulateComboBoxes();
        }

        private void BtnAddInstructors_Click(object sender, EventArgs e)
        {
            var newInstructor = new Instruktore();
            newInstructor.PersonId = ((dynamic)cmbPeople.SelectedItem).Id;
            DatabaseModel.Instance.Instruktores.Add(newInstructor);
            DatabaseModel.Instance.SaveChanges();
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            DatabaseModel.Instance.Instruktores.Load();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Instruktores
                .Select(x => x.Persona)
                .ToList()
            };
            dtgInstructorsDataGrid.DataSource = source;
        }

        private void PopulateComboBoxes()
        {
            var peopleSource = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Personas
               .Select(x => new { Id = x.PersonId, Value = x.Emri + " " + x.Mbiemri })
               .ToList()
            };
            cmbPeople.DataSource = peopleSource;
            cmbPeople.DisplayMember = "Value";
            cmbPeople.ValueMember = "Id";
        }
    }
}
