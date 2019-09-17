using GaussSchoolManagement.DataModel;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();            
        }
        
        private void BtnEditPerson_Click(object sender, EventArgs e)
        {
            var form = new StudentOverview();
            form.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var form = new EntryForm();
            form.Show();
        }
    }
}
