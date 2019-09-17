using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class InstructorOverview : Form
    {
        public List<int> InstructorIDs { get; set; }

        private int _id = -1;
        public int InstructorID
        {
            get => _id;
            set
            {
                _id = value;
                FillTextFields();
            }
        }

        public InstructorOverview()
        {
            InitializeComponent();
            UpdateInstructorIds();
            InstructorID = InstructorIDs.Min();
        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new EditInstructorDetails(this);
            form.Show();
        }

         private void BtnFindInstructor_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new InstructorsList(this);
            form.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var form = new EditInstructorDetails(this, true);
            form.Show();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (!InstructorIDs.Any() || InstructorID <= InstructorIDs.Min())
                return;

            DecrementInstructorId();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!InstructorIDs.Any() || InstructorID >= InstructorIDs.Max())
                return;

            IncrementInstructorId();
        }

        private void FillTextFields()
        {
            if (InstructorID <= 0 || !InstructorIDs.Contains(InstructorID))
                return;

            var data = DatabaseModel.Instance.Instruktores.First(x => x.InstruktorId == InstructorID);
            lblId.Text = InstructorID.ToString();
            lblName.Text = data.Persona.Emri;
            lblSurname.Text = data.Persona.Mbiemri;

            var courses = data.InstruktoreKurses
                .Where(x => x.InstruktorId == InstructorID)
                .Select(x => x.Kurse.EmriKursit + " " + x.Kurse.VitiShkollor)
                .ToList();
            lbCourses.DataSource = courses;
            
            // Cannot use data.InstruktorePagesas for some reason ?!
            var payments = DatabaseModel.Instance.InstruktorePagesas
                .Where(x => x.InstruktorId == InstructorID)
                .Select(x => x.Pagesa.FormaPageses + " " + x.Pagesa.ShumaPaguar)
                .ToList();
            lbPayments.DataSource = payments;

            UpdateButtonEnabled();
        }

        private void UpdateButtonEnabled()
        {
            if (InstructorID == InstructorIDs.Max())
                btnNext.Enabled = false;

            if (InstructorID > InstructorIDs.Min())
                btnPrevious.Enabled = true;

            if (InstructorID == InstructorIDs.Min())
                btnPrevious.Enabled = false;

            if (InstructorID < InstructorIDs.Max())
                btnNext.Enabled = true;
        }

        public void UpdateInstructorIds()
        {
            InstructorIDs =  DatabaseModel.Instance.Instruktores
                                .Select(x => x.InstruktorId)
                                .AsEnumerable().ToList();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (!InstructorIDs.Contains(InstructorID))
                return;
            var instructor = DatabaseModel.Instance.Instruktores.First(x => x.InstruktorId == InstructorID);
            DatabaseModel.Instance.Instruktores.Remove(instructor);
            DatabaseModel.Instance.SaveChanges();
            UpdateInstructorIds();
            if(InstructorIDs.Contains(InstructorID + 1))
                IncrementInstructorId();
            else
                 DecrementInstructorId();
            UpdateButtonEnabled();
        }

        private void IncrementInstructorId()
        {
            var nextId = _id + 1;
            while (nextId < InstructorIDs.Max() && !InstructorIDs.Contains(nextId))
                nextId++;

            InstructorID = nextId;
        }

        private void DecrementInstructorId()
        {
            var previousId = _id - 1;
            while (previousId > InstructorIDs.Min() && !InstructorIDs.Contains(previousId))
                previousId--;
            InstructorID = previousId;
        }
    }
}
