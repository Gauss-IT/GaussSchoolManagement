using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class PaymentOverview : Form
    {
        public List<int> PaymentIDs { get; set; }

        private int _id = -1;
        public int PaymentID
        {
            get => _id;
            set
            {
                _id = value;
                FillTextFields();
            }
        }

        public PaymentOverview()
        {
            InitializeComponent();
            UpdatePaymentIds();
            PaymentID = PaymentIDs.Min();
        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new EditPaymentDetails(this);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new PaymentList(this);
            form.PaymentsSelected += (s, args) =>
            {
                if (args.Count < 1)
                    return;

                PaymentID = args[0];
            };
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var form = new EditPaymentDetails(this, true);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (!PaymentIDs.Any() || PaymentID <= PaymentIDs.Min())
                return;

            DecrementPaymentId();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (!PaymentIDs.Any() || PaymentID >= PaymentIDs.Max())
                return;

            IncrementPaymentId();
        }

        private void FillTextFields()
        {
            if (PaymentID <= 0 || !PaymentIDs.Contains(PaymentID))
                return;

            var data = DatabaseModel.Instance.Pagesas.First(x => x.PageseId == PaymentID);
            lblId.Text = PaymentID.ToString();
            lblPaymentForm.Text = data.FormaPageses;
            lblDate.Text = data.Data.ToString();
            lblDescription.Text = data.Sherbimet.Pershkrimi;
            lblTotalPaid.Text = data.ShumaPaguar.ToString();
            
            UpdateButtonEnabled();
        }

        private void UpdateButtonEnabled()
        {
            if (PaymentID == PaymentIDs.Max())
                btnNext.Enabled = false;

            if (PaymentID > PaymentIDs.Min())
                btnPrevious.Enabled = true;

            if (PaymentID == PaymentIDs.Min())
                btnPrevious.Enabled = false;

            if (PaymentID < PaymentIDs.Max())
                btnNext.Enabled = true;
        }

        public void UpdatePaymentIds()
        {
            PaymentIDs =  DatabaseModel.Instance.Pagesas
                                .Select(x => x.PageseId)
                                .AsEnumerable().ToList();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (!PaymentIDs.Contains(PaymentID))
                return;
            try
            { 
                var payment = DatabaseModel.Instance.Pagesas.First(x=>x.PageseId == PaymentID);
                var instructorPayments = DatabaseModel.Instance.InstruktorePagesas.Where(x=>x.PageseId == PaymentID);
                var studentPayments = DatabaseModel.Instance.NxenesPagesas.Where(x => x.PageseId == PaymentID);
                DatabaseModel.Instance.NxenesPagesas.RemoveRange(studentPayments);
                DatabaseModel.Instance.InstruktorePagesas.RemoveRange(instructorPayments);
                DatabaseModel.Instance.Pagesas.Remove(payment);
                DatabaseModel.Instance.SaveChanges();
                    MessageBox.Show($"This payment {payment.PageseId} was removed successfully!");
                UpdatePaymentIds();
                if (PaymentIDs.Contains(PaymentID + 1))
                    IncrementPaymentId();
                else
                    DecrementPaymentId();
                UpdateButtonEnabled();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error with the database transaction!");
                
            }
        }

        private void IncrementPaymentId()
        {
            var nextId = _id + 1;
            while (nextId < PaymentIDs.Max() && !PaymentIDs.Contains(nextId))
                nextId++;

            PaymentID = nextId;
        }

        private void DecrementPaymentId()
        {
            var previousId = _id - 1;
            while (previousId > PaymentIDs.Min() && !PaymentIDs.Contains(previousId))
                previousId--;
            PaymentID = previousId;
        }
    }
}
