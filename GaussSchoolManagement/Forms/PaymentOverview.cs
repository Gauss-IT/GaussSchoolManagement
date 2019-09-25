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
            try
            {
                InitializeComponent();
                UpdatePaymentIds();
                PaymentID = PaymentIDs.Min();
                ResetGridData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditDetails_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new EditPaymentDetails(this);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var form = new EditPaymentDetails(this, true);
            form.MdiParent = this.MdiParent;
            form.Show();
        }

        private void FillTextFields()
        {
            if (PaymentID <= 0 || !PaymentIDs.Contains(PaymentID))
                return;

            var data = DatabaseModel.Instance.Pagesas.First(x => x.PageseId == PaymentID);
            lblPaymentForm.Text = data.FormaPageses;
            lblDate.Text = data.Data.ToString();
            lblDescription.Text = data.PershkrimiPageses;
            lblTotalPaid.Text = data.ShumaPaguar.ToString();
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
                ResetGridData();
            }
            catch
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
       
        private List<PaymentsListData> _gridData;
        private List<PaymentsListData> GridData => _gridData ?? (_gridData =
            DatabaseModel.Instance.Pagesas
                .Select(x =>
                new
                {
                    Id = x.PageseId,
                    PaymentForm = x.FormaPageses,
                    PaymentDescription = x.PershkrimiPageses,
                    Date = x.Data,
                    TotalPaid = x.ShumaPaguar,
                    Discount = x.Zbritje
                }).AsEnumerable().Select(z =>

                 new PaymentsListData
                 {
                     Id = z.Id,
                     PaymentForm = z.PaymentForm,
                     PaymentDescription = z.PaymentDescription,
                     Date = z.Date,
                     TotalPaid = z.TotalPaid,
                     Discount = z.Discount
                 }).ToList());

        private void PopulateDataGrid(IEnumerable<PaymentsListData> data = null)
        {
            dtgPayments.DataSource = new BindingSource { DataSource = data ?? GridData };
            foreach (DataGridViewColumn column in dtgPayments.Columns)
            {
                if (column.Name == "Id")
                    column.Visible = false;
            }
        }

        public void ResetGridData()
        {
            _gridData = null;
            PopulateDataGrid();
        }

        private void OnInputChanged(object sender, EventArgs e)
        {
            var selectedGridData = GridData as IEnumerable<PaymentsListData>;

            if (txtPaymentForm.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.PaymentForm.ToLower().StartsWith(txtPaymentForm.Text.ToLower()));

            if (txtServiceDescription.Text.Any())
               selectedGridData = selectedGridData.Where(x =>  x.PaymentDescription.ToLower().StartsWith(txtServiceDescription.Text.ToLower()));

            if (txtTotalPaid.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.TotalPaid.ToString().ToLower().Contains(txtTotalPaid.Text.ToLower()));

            if (txtDiscount.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Discount.ToString().ToLower().StartsWith(txtDiscount.Text.ToLower()));

            if (txtDate.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.Date.HasValue
                && x.Date.Value.Year.ToString().ToLower().Contains(txtDate.Text.ToLower()));

            PopulateDataGrid(selectedGridData);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDate.Text = "";
            txtDiscount.Text = "";
            txtPaymentForm.Text = "";
            txtServiceDescription.Text = "";
            txtTotalPaid.Text = "";
        }

        public class PaymentsListData
        {
            public int Id { get; set; }
            public string PaymentForm { get; set; }
            public string PaymentDescription { get; set; }
            public DateTime? Date { get; set; }
            public decimal? TotalPaid { get; set; }
            public decimal? Discount { get; set; }
        }

        private void DtgPayments_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgPayments.CurrentRow.Cells[0].Value != null)
                PaymentID = (int)dtgPayments.CurrentRow.Cells[0].Value;
        }
    }
}
