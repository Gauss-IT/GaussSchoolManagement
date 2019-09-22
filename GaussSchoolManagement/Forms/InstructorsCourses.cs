using GaussSchoolManagement.DataModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class InstructorsCourses : Form
    {
        public InstructorsCourses()
        {
            InitializeComponent();
            PopulateDataGrid();
            PopulateComboBoxes();
        }

        private void BtnAddInstrCrs_Click(object sender, System.EventArgs e)
        {
            try
            {
                var kurseInstruktore = new InstruktoreKurse
                {
                    InstruktorId = ((dynamic)cmbInstructors.SelectedItem).Id,
                    KursId = ((dynamic)cmbCourses.SelectedItem).Id
                };
                DatabaseModel.Instance.InstruktoreKurses.Add(kurseInstruktore);
                DatabaseModel.Instance.SaveChanges();
                PopulateDataGrid();
            }
            catch
            {
                MessageBox.Show("There was an error");
            }
        }

        private void BtnRemoveInstCrs_Click(object sender, System.EventArgs e)
        {
            //TODO: Implement the remove button
        }

        private void PopulateDataGrid()
        {
            DatabaseModel.Instance.InstruktoreKurses.Load();
            var source = new BindingSource
            {
                DataSource = DatabaseModel.Instance.InstruktoreKurses
                .Select(x =>
                new {
                    x.Instruktore.Persona.Emri,
                    x.Instruktore.Persona.Mbiemri,
                    x.Kurse.EmriKursit,
                    x.Kurse.Pershkrimi
                })
                .ToList()
            };
            dtgInstructorsCourses.DataSource = source;
        }

        private void PopulateComboBoxes()
        {
            var instSource = new BindingSource
            {
                DataSource = DatabaseModel.Instance.Instruktores
               .Select(x => new { Id = x.InstruktorId, Value = x.Persona.Emri + " " + x.Persona.Mbiemri })
               .ToList()
            };
            cmbInstructors.DataSource = instSource;
            cmbInstructors.DisplayMember = "Value";
            cmbInstructors.ValueMember = "Id";

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
