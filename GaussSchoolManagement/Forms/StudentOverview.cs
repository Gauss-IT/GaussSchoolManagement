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
    public partial class StudentOverview : Form
    {
        public StudentOverview()
        {
            InitializeComponent();
        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            var form = new EditDetails();
            form.Show();
        }

        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            var form = new StudentsList();
            form.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var form = new EditDetails();
            form.Show();
        }
    }
}
