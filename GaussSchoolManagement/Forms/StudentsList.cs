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
        private StudentOverview _parent;

        private List<StudentsListData> _gridData;
        private List<StudentsListData> GridData => _gridData ?? (_gridData =
            DatabaseModel.Instance.Nxenes
                .Select(x =>
                new
                {
                    Id = x.NxenesId,
                    Name = x.Persona.Emri,
                    Surname = x.Persona.Mbiemri,
                    Kurse = x.NxenesKurses.Select(y => y.Kurse.EmriKursit).ToList(),
                    Birthday = x.Persona.DataLindjes,
                    School = x.Shkolla.ShkollaEmri
                }).AsEnumerable().Select(z =>
                 
                 new StudentsListData {
                    Id = z.Id,
                    Name = z.Name,
                    Surname = z.Surname,
                    Kurse = string.Join(", ", z.Kurse),
                    Birthday = z.Birthday,
                    School = z.School
                 }).ToList());

        public StudentsList(StudentOverview studentOverview):this()
        {
            _parent = studentOverview;
        }

        public StudentsList()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        private void BtnStudentOverview_Click(object sender, EventArgs e)
        {
            OnStudentSelected();
        }

        private void OnStudentSelected()
        {
            if (dtgStudentsDataGrid.SelectedRows.Count == 0)
                return;

            var id = (int)dtgStudentsDataGrid.SelectedRows[0].Cells[0].Value;            
            _parent.StudentID = id;
            _parent.Show();
            Close();
        }

        private void PopulateDataGrid()
        {
            DatabaseModel.Instance.Nxenes.Load();
            dtgStudentsDataGrid.DataSource = new BindingSource { DataSource = GridData };
            dtgStudentsDataGrid.Columns["Id"].Visible = false;
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

            if (txtSchool.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.School.ToLower().StartsWith(txtSchool.Text.ToLower()));

            if (txtBirthYear.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Birthday.HasValue 
                && x.Birthday.Value.Year.ToString().ToLower().Contains(txtSchool.Text.ToLower()));

            dtgStudentsDataGrid.DataSource = new BindingSource
            {
                DataSource = selectedGridData
            }; 
        }

        private void DtgStudentsDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OnStudentSelected();
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtSchool.Text = "";
            txtCourse.Text = "";
            txtBirthYear.Text = "";
        }
    }
    public class StudentsListData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Kurse { get; set; }
        public DateTime? Birthday { get; set; }
        public string School { get; set; }
    }
}
