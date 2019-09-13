using GaussSchoolManagement.DataModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class StudentOverview : Form
    {
        private int _id = 1;
        public int StudentID
        {
            get => _id;
            set
            {
                if (_id == value)
                    return;
                _id = value;
                FillTextFields();
            }
        }
        private int _maxId = -1;
        public int MaxId
        {
            get
            {
                if (_maxId == -1)
                  _maxId = DatabaseModel.Instance.Nxenes.Count();

                return _maxId;
            }

            set
            {
                if (_maxId == value)
                    return;

                _maxId = value;                
            }
        }

        public StudentOverview()
        {
            InitializeComponent();
            FillTextFields();
        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new EditDetails(StudentID);
            form.Show();
        }

        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new StudentsList(this);
            form.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var form = new EditDetails();
            form.Show();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            FillTextFields();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (StudentID <= 1)
                return;

            StudentID--;
            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (StudentID >= MaxId)
                return;

            StudentID++;
            
        }

        private void FillTextFields()
        {
            if (StudentID <= 0)
                return;

            var data = DatabaseModel.Instance.Nxenes.First(x => x.NxenesId == StudentID);
            lblId.Text = StudentID.ToString();
            lblName.Text = data.Persona.Emri;
            lblSurname.Text = data.Persona.Mbiemri;

            var kurse = data.NxenesKurses
                .Where(x=>x.NxenesId == StudentID)
                .Select(x => x.Kurse.EmriKursit + " " + x.Kurse.VitiShkollor)
                .ToList();
            lbCourses.DataSource = kurse;

            if (StudentID == MaxId)
                btnNext.Enabled = false;

            if (StudentID > 1)
                btnPrevious.Enabled = true;

            if (StudentID == 1)
                btnPrevious.Enabled = false;

            if (StudentID < MaxId)
                btnNext.Enabled = true;
        }
    }
}
