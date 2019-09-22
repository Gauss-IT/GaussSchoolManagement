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
    public partial class StudentsCourses : Form
    {
        public StudentsCourses()
        {
            InitializeComponent();
            PopulateDataGrid();
            PopulateComboBoxes();
        }

        private void BtnAddStdntCrs_Click(object sender, EventArgs e)
        {
            try
            {
                var nxenesKurse = new NxenesKurse
                {
                    NxenesId = ((dynamic)cmbStudents.SelectedItem).Id,
                    KursId = ((dynamic)cmbCourses.SelectedItem).Id
                };
                DatabaseModel.Instance.NxenesKurses.Add(nxenesKurse);
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
            DatabaseModel.Instance.NxenesKurses.Load();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.NxenesKurses
                .Select(x =>
                new {
                    x.Nxene.Persona.Emri,
                    x.Nxene.Persona.Mbiemri,
                    x.Kurse.EmriKursit,
                    x.Kurse.Pershkrimi
                })
                .ToList()
            };
            dtgStudentsCourses.DataSource = source;
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

            var courseSource = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Kurses
                .Select(x =>
                new { Id = x.KursId, Value = x.EmriKursit + " " + x.Niveli })
                .ToList()
            };
            cmbCourses.DataSource = courseSource;
            cmbCourses.DisplayMember = "Value";
            cmbCourses.ValueMember = "Id";
        }

    }
}
