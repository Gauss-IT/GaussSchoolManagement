using GaussSchoolManagement.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class PaymentList : Form
    {
        private Form _parent;

        private List<PaymentsListData> _gridData;
        private List<PaymentsListData> GridData => _gridData ?? (_gridData =
            DatabaseModel.Instance.Pagesas
                .Select(x =>
                new
                {
                    Id = x.PageseId,
                    PaymentForm = x.FormaPageses,
                    Date = x.Data,
                    PaymentDescription = x.PershkrimiPageses,
                    TotalPaid = x.ShumaPaguar,
                    Discount = x.Zbritje
                }).AsEnumerable().Select(z =>

                 new PaymentsListData
                 {
                     Id = z.Id,
                     PaymentForm = z.PaymentForm,
                     Date = z.Date,
                     PaymentDescription = z.PaymentDescription,
                     TotalPaid = z.TotalPaid,
                     Discount = z.Discount
                 }).ToList());

        public PaymentList(Form parent, bool multiSelectEnabled = false) : this()
        {
            dtgPaymentsDataGrid.MultiSelect = multiSelectEnabled;
            _parent = parent;
        }

        public PaymentList()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        private void BtnSelectPayment_Click(object sender, EventArgs e)
        {
            OnCoursesSelected();
        }

        private void DtgPaymentsDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OnCoursesSelected();
        }

        private void OnCoursesSelected()
        {
            if (dtgPaymentsDataGrid.SelectedRows.Count == 0)
                return;
            var selectedIds = new List<int>();
            for (var i = 0; i < dtgPaymentsDataGrid.SelectedRows.Count; i++)
                selectedIds.Add((int)dtgPaymentsDataGrid.SelectedRows[i].Cells[0].Value);
            OnPaymentsSelected(this, selectedIds);
            _parent.Show();
            Close();
        }

        private void PopulateDataGrid(IEnumerable<PaymentsListData> data = null)
        {
            dtgPaymentsDataGrid.DataSource = new BindingSource { DataSource = data ?? GridData };
            foreach (DataGridViewColumn column in dtgPaymentsDataGrid.Columns)
            {
                if (column.Name == "Id")
                    column.Visible = false;
            }
        }

        private void OnInputChanged(object sender, EventArgs e)
        {
            var selectedGridData = GridData as IEnumerable<PaymentsListData>;

            if (txtPaymentForm.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.PaymentForm.ToLower().StartsWith(txtPaymentForm.Text.ToLower()));

            if (txtServiceDescription.Text.Any())
                selectedGridData = selectedGridData.Where(x => x.PaymentDescription.ToLower().StartsWith(txtServiceDescription.Text.ToLower()));

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

        public event EventHandler<List<int>> PaymentsSelected;

        protected virtual void OnPaymentsSelected(object sender, List<int> e)
        {
            EventHandler<List<int>> handler = PaymentsSelected;
            handler?.Invoke(this, e);
        }

        public class PaymentsListData
        {
            public int Id { get; set; }
            public string PaymentForm { get; set; }
            public DateTime? Date { get; set; }
            public string PaymentDescription { get; set; }
            public decimal? TotalPaid{ get; set; }
            public decimal? Discount { get; set; }
        }

        
    }
}
