using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class CourseOverview : Form
    {
        public List<int> CourseIDs { get; set; }

        private int _id = -1;
        public int CourseID
        {
            get => _id;
            set
            {
                _id = value;
                FillTextFields();
            }
        }

        public CourseOverview()
        {
            InitializeComponent();
            UpdateCourseIDs();
            CourseID = CourseIDs.Min();
        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new EditCourseDetails(this);
            form.Show();
        }

        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new CoursesList(this);
            form.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var form = new EditCourseDetails(this, true);
            form.Show();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (!CourseIDs.Any() || CourseID <= CourseIDs.Min())
                return;

            DecrementCourseID();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!CourseIDs.Any() || CourseID >= CourseIDs.Max())
                return;

            IncrementCourseID();
        }

        private void FillTextFields()
        {
            if (CourseID <= 0 || !CourseIDs.Contains(CourseID))
                return;

            var data = DatabaseModel.Instance.Kurses.First(x => x.KursId == CourseID);
            lblId.Text = CourseID.ToString();
            lblCode.Text = data.ShifraKursit;
            lblName.Text = data.EmriKursit;
            lblLevel.Text = data.Niveli;
            lblYear.Text = data.VitiShkollor;


            //var courses = data.NxenesKurses
            //    .Where(x => x.NxenesId == CourseID)
            //    .Select(x => x.Kurse.EmriKursit + " " + x.Kurse.VitiShkollor)
            //    .ToList();
            //lbCourses.DataSource = courses;

            //var payments = data.NxenesPagesas
            //    .Where(x => x.NxenesId == CourseID)
            //    .Select(x => x.Pagesa.FormaPageses + " " + x.Pagesa.ShumaPaguar)
            //    .ToList();
            //lbPayments.DataSource = payments;


            UpdateButtonEnabled();
        }

        private void UpdateButtonEnabled()
        {
            if (CourseID == CourseIDs.Max())
                btnNext.Enabled = false;

            if (CourseID > CourseIDs.Min())
                btnPrevious.Enabled = true;

            if (CourseID == CourseIDs.Min())
                btnPrevious.Enabled = false;

            if (CourseID < CourseIDs.Max())
                btnNext.Enabled = true;
        }

        public void UpdateCourseIDs()
        {
            CourseIDs =  DatabaseModel.Instance.Kurses
                                .Select(x => x.KursId)
                                .AsEnumerable().ToList();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (!CourseIDs.Contains(CourseID))
                return;
            var course = DatabaseModel.Instance.Kurses.First(x => x.KursId == CourseID);
            DatabaseModel.Instance.Kurses.Remove(course);
            DatabaseModel.Instance.SaveChanges();
            UpdateCourseIDs();
            if (CourseIDs.Contains(CourseID + 1))
                IncrementCourseID();
            else
                DecrementCourseID();
            UpdateButtonEnabled();
        }

        private void IncrementCourseID()
        {
            var nextId = _id + 1;
            while (nextId < CourseIDs.Max() && !CourseIDs.Contains(nextId))
                nextId++;

            CourseID = nextId;
        }

        private void DecrementCourseID()
        {
            var previousId = _id - 1;
            while (previousId > CourseIDs.Min() && !CourseIDs.Contains(previousId))
                previousId--;
            CourseID = previousId;
        }
    }
}
