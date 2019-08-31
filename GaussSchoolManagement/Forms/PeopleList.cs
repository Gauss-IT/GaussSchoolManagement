using GaussSchoolManagement.DataModel;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class PeopleList : Form
    {
        public PeopleList()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DatabaseModel.Instance.SaveChanges();
        }
    }
}
