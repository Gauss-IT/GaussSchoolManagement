using GaussSchoolManagement.DataModel;
using System;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class CoursesList : Form
    {
        public CoursesList()
        {
            InitializeComponent();
        }

        private void BtnSaveCourses_Click(object sender, EventArgs e)
        {
            DatabaseModel.Instance.SaveChanges();
        }
    }
}
