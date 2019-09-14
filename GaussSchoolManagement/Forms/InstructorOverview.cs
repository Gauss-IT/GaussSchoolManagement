using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class InstructorOverview : Form
    {

        private int _id = 1;
        public int InstructorID
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
                    _maxId = DatabaseModel.Instance.Instruktores.Count();

                return _maxId;
            }

            set
            {
                if (_maxId == value)
                    return;

                _maxId = value;
            }
        }

        public InstructorOverview()
        {
            InitializeComponent();
        }

        private void FillTextFields()
        {
            if (InstructorID <= 0)
                return;

            var data = DatabaseModel.Instance.Instruktores.First(x => x.InstruktorId == InstructorID);
            lblId.Text = InstructorID.ToString();
            lblName.Text = data.Persona.Emri;
            lblSurname.Text = data.Persona.Mbiemri;

            var kurse = data.InstruktoreKurses
                .Where(x => x.InstruktorId == InstructorID)
                .Select(x => x.Kurse.EmriKursit + " " + x.Kurse.VitiShkollor)
                .ToList();
            lbCourses.DataSource = kurse;

            if (InstructorID == MaxId)
                btnNext.Enabled = false;

            if (InstructorID > 1)
                btnPrevious.Enabled = true;

            if (InstructorID == 1)
                btnPrevious.Enabled = false;

            if (InstructorID < MaxId)
                btnNext.Enabled = true;
        }

        private void BtnEditDetails_Click_1(object sender, EventArgs e)
        {
            Hide();
            //var form = new EditStudentDetails(this);
            //form.Show();
        }

        private void BtnFindInstructor_Click(object sender, EventArgs e)
        {
            Hide();
            //var form = new StudentsList(this);
            //form.Show();
        }

        private void BtnPrevious_Click_1(object sender, EventArgs e)
        {
            if (InstructorID <= 1)
                return;

            InstructorID--;
        }

        private void BtnNext_Click_1(object sender, EventArgs e)
        {
            if (InstructorID >= MaxId)
                return;

            InstructorID++;
        }
    }
}
