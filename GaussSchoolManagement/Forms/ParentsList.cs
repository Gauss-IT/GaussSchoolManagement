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
    public partial class ParentsList : Form
    {
        public ParentsList()
        {
            InitializeComponent();
            PopulateDataGrid();
            PopulateComboBoxes();
        }

        private void BtnAddParent_Click(object sender, EventArgs e)
        {
            var newParent = new Prinder();
            newParent.PersonId = ((dynamic)cmbPeople.SelectedItem).Id;
            DatabaseModel.Instance.Prinders.Add(newParent);
            DatabaseModel.Instance.SaveChanges();
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            DatabaseModel.Instance.Prinders.Load();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Prinders
                .Select(x => x.Persona)
                .ToList()
            };

            dtgParentsDataGrid.DataSource = source;
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
