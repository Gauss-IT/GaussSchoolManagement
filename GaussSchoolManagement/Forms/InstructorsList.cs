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
    public partial class InstructorsList : Form
    {
        public InstructorsList()
        {
            InitializeComponent();
        }

        private void BtnSaveInstructors_Click(object sender, EventArgs e)
        {
            DatabaseModel.Instance.SaveChanges();
        }
    }
}
