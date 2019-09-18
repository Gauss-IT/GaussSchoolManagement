using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{    
    public partial class InstructorsList : Form
    {
        private InstructorOverview _parent;

        private List<InstructorsListData> _gridData;
        private List<InstructorsListData> GridData => _gridData ?? (_gridData =
            DatabaseModel.Instance.Instruktores
                .Select(x =>
                new
                {
                    Id = x.InstruktorId,
                    Name = x.Persona.Emri,
                    Surname = x.Persona.Mbiemri,
                    Kurse = x.InstruktoreKurses.Select(y => y.Kurse.EmriKursit).ToList(),
                    Birthday = x.Persona.DataLindjes
                }).AsEnumerable().Select(z =>
                 
                 new InstructorsListData
                 {
                    Id = z.Id,
                    Name = z.Name,
                    Surname = z.Surname,
                    Kurse = string.Join(", ", z.Kurse),
                    Birthday = z.Birthday
                 }).ToList());

        public InstructorsList(InstructorOverview instructorOverview):this()
        {
            _parent = instructorOverview;
        }

        public InstructorsList()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        private void BtnInstructorOverview_Click(object sender, EventArgs e)
        {
            OnInstructorSelected();
        }

        private void OnInstructorSelected()
        {
            if (dtgInstructorsDataGrid.SelectedRows.Count == 0)
                return;

            var id = (int)dtgInstructorsDataGrid.SelectedRows[0].Cells[0].Value;            
            _parent.InstructorID = id;
            _parent.Show();
            Close();
        }

        private void PopulateDataGrid(IEnumerable<InstructorsListData> data = null)
        {
                dtgInstructorsDataGrid.DataSource = new BindingSource { DataSource = data ?? GridData };
                foreach (DataGridViewColumn column in dtgInstructorsDataGrid.Columns)
                {
                    if (column.Name == "Id")
                        column.Visible = false;
                }
        }

        private void OnInputChanged(object sender, EventArgs e)
        {
            var selectedGridData = GridData as IEnumerable<InstructorsListData>;

            if (txtName.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Name.ToLower().StartsWith(txtName.Text.ToLower()));

            if (txtSurname.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Surname.ToLower().StartsWith(txtSurname.Text.ToLower()));

            if (txtCourse.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Kurse.ToLower().Contains(txtCourse.Text.ToLower()));

            if (txtBirthYear.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Birthday.HasValue 
                && x.Birthday.Value.Year.ToString().ToLower().Contains(txtBirthYear.Text.ToLower()));

            PopulateDataGrid(selectedGridData);
        }

        private void DtgInstructorsDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OnInstructorSelected();
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtCourse.Text = "";
            txtBirthYear.Text = "";
        }
    }
    public class InstructorsListData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Kurse { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
