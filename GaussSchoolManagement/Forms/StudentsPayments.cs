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
    public partial class StudentsPayments : Form
    {
        public StudentsPayments()
        {
            InitializeComponent();
            PopulateDataGrid();
            PopulateComboBoxes();
        }

        private void BtnAddStudentsPayments_Click(object sender, EventArgs e)
        {
            try
            {
                var nxenesPagesa = new NxenesPagesa
                {
                    NxenesId = ((dynamic)cmbStudents.SelectedItem).Id,
                    PageseId = ((dynamic)cmbPayments.SelectedItem).Id
                };
                DatabaseModel.Instance.NxenesPagesas.Add(nxenesPagesa);
                DatabaseModel.Instance.SaveChanges();
                PopulateDataGrid();
            }
            catch
            {
                MessageBox.Show("There was an error");
            }
        }

        private void PopulateDataGrid()
        {
            DatabaseModel.Instance.NxenesPagesas.Load();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.NxenesPagesas
                .Select(x =>
                new {
                    x.Nxene.Persona.Emri,
                    x.Nxene.Persona.Mbiemri,
                    x.Pagesa.FormaPageses,
                    x.Pagesa.ShumaPaguar
                })
                .ToList()
            };
            dtgStudentsPayments.DataSource = source;
        }

        private void PopulateComboBoxes()
        {
            var stdntSource = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Nxenes
               .Select(x => new { Id = x.NxenesId, Value = x.Persona.Emri + " " + x.Persona.Mbiemri })
               .ToList()
            };
            cmbStudents.DataSource = stdntSource;
            cmbStudents.DisplayMember = "Value";
            cmbStudents.ValueMember = "Id";

            var paymentSource = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Pagesas
                .Select(x =>
                new { Id = x.PageseId, Value = x.FormaPageses+ " " + x.ShumaPaguar})
                .ToList()
            };
            cmbPayments.DataSource = paymentSource;
            cmbPayments.DisplayMember = "Value";
            cmbPayments.ValueMember = "Id";
        }
    }
}
