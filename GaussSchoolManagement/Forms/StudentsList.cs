using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{    
    public partial class StudentsList : Form
    {
        private List<StudentsListData> _gridData;
        private List<StudentsListData> GridData => _gridData ?? (_gridData =
            DatabaseModel.Instance.Nxenes
                .Select(x =>
                new
                {
                    Name = x.Persona.Emri,
                    Surname = x.Persona.Mbiemri,
                    Kurse = x.NxenesKurses.Select(y => y.Kurse.EmriKursit).ToList(),
                    Birthday = x.Persona.DataLindjes,
                    School = x.Shkolla.ShkollaEmri
                }).AsEnumerable().Select(z =>
                 
                 new StudentsListData {
                    Name = z.Name,
                    Surname = z.Surname,
                    Kurse = string.Join(", ", z.Kurse),
                    Birthday = z.Birthday,
                    School = z.School
                 }).ToList());

        public StudentsList()
        {
            InitializeComponent();
            PopulateDataGrid();
            PopulateComboBox();
        }

        private void BtnAddStudents_Click(object sender, EventArgs e)
        {
            //var newStudent = new Nxene();
            //newStudent.PersonId = ((dynamic)cmbPeople.SelectedItem).Id;
            //DatabaseModel.Instance.Nxenes.Add(newStudent);
            //DatabaseModel.Instance.SaveChanges();
            //PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            DatabaseModel.Instance.Nxenes.Load();
            dtgStudentsDataGrid.DataSource = new BindingSource { DataSource = GridData };
        }

        private void PopulateComboBox()
        {
            //var peopleSource = new BindingSource
            //{
            //    DataSource = DatabaseModel.Instance.Personas
            //   .Select(x => new { Id = x.PersonId, Value = x.Emri + " " + x.Mbiemri })
            //   .ToList()
            //};
            //cmbPeople.DataSource = peopleSource;
            //cmbPeople.DisplayMember = "Value";
            //cmbPeople.ValueMember = "Id";
        }

        private void OnInputChanged(object sender, EventArgs e)
        {

            var selectedGridData = GridData as IEnumerable<StudentsListData>;

            if (txtName.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Name.ToLower().StartsWith(txtName.Text.ToLower()));

            if (txtSurname.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Surname.ToLower().StartsWith(txtSurname.Text.ToLower()));
            if (txtCourse.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Kurse.ToLower().Contains(txtCourse.Text.ToLower()));

            dtgStudentsDataGrid.DataSource = new BindingSource
            {
                DataSource = selectedGridData
            }; 
        }
        public class StudentsListData
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Kurse { get; set; }
            public DateTime? Birthday { get; set; }
            public string School { get; set; }
        }

    }
}
