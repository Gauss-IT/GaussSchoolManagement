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
    public partial class PaymentList : Form
    {
        public PaymentList()
        {
            InitializeComponent();
        }

        private void BtnSavePayments_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseModel.Instance.SaveChanges();
            }
            catch
            {
                MessageBox.Show("There was an error");
            }
        }
    }
}
