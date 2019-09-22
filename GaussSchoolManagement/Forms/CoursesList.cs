using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{    
    public partial class CoursesList : Form
    {
        private Form _parent;

        private List<CoursesListData> _gridData;
        private List<CoursesListData> GridData => _gridData ?? (_gridData =
            DatabaseModel.Instance.Kurses
                .Select(x =>
                new
                {
                    Id = x.KursId,
                    Code = x.ShifraKursit,
                    Name = x.EmriKursit,
                    Level = x.Niveli,
                    Year = x.VitiShkollor,
                    Description = x.Pershkrimi
                }).AsEnumerable().Select(z =>
                 
                 new CoursesListData {
                     Id = z.Id,
                     Code = z.Code,
                     Name = z.Name,
                     Level = z.Level,
                     Year = z.Year,
                     Description = z.Description
                 }).ToList());

        public CoursesList(Form parent, bool multiSelectEnabled = false) : this()
        {
            dtgCourses.MultiSelect = multiSelectEnabled;
            _parent = parent;
        }

        public CoursesList(CourseOverview studentOverview):this()
        {
            _parent = studentOverview;
        }

        public CoursesList()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        private void BtnStudentOverview_Click(object sender, EventArgs e)
        {
            OnCoursesSelected();
        }

        private void OnCoursesSelected()
        {
            if (dtgCourses.SelectedRows.Count == 0)
                return;
            var selectedIds = new List<int>();
            for (var i = 0; i < dtgCourses.SelectedRows.Count; i++)
                selectedIds.Add((int)dtgCourses.SelectedRows[i].Cells[0].Value);
            OnCoursesSelected(this, selectedIds);
            _parent.Show();
            Close();
        }

        private void PopulateDataGrid()
        {
            DatabaseModel.Instance.Kurses.Load();
            dtgCourses.DataSource = new BindingSource { DataSource = GridData };
            dtgCourses.Columns["Id"].Visible = false;
        }

        private void OnInputChanged(object sender, EventArgs e)
        {
            var selectedGridData = GridData as IEnumerable<CoursesListData>;

            

            if (txtCode.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Code.ToLower().StartsWith(txtCode.Text.ToLower()));

            if (txtName.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Name.ToLower().StartsWith(txtName.Text.ToLower()));

            if (txtLevel.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Level.ToLower().Contains(txtLevel.Text.ToLower()));

            if (txtYear.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Year.ToLower().StartsWith(txtYear.Text.ToLower()));

            if (txtDescription.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Description.ToLower().Contains(txtDescription.Text.ToLower()));

            //Needs a better place
            if (dtgCourses.Columns["Id"] != null)
                dtgCourses.Columns["Id"].Visible = false;

            dtgCourses.DataSource = new BindingSource
            {
                DataSource = selectedGridData
            }; 
        }

        private void DtgStudentsDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OnCoursesSelected();
        }

        private void BtnClearSearch_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtLevel.Text = "";
            txtYear.Text = "";
        }

        public event EventHandler<List<int>> CoursesSelected;

        protected virtual void OnCoursesSelected(object sender, List<int> e)
        {
            EventHandler<List<int>> handler = CoursesSelected;
            handler?.Invoke(this, e);
        }
    }
    public class CoursesListData
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
    }
}
