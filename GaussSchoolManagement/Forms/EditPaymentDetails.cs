using GaussSchoolManagement.DataModel;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class EditPaymentDetails : Form
    {
        private PaymentOverview _parent;
        private bool _isNewPayment;

        private EditPaymentDetails()
        {
            InitializeComponent();
        }

        public EditPaymentDetails(PaymentOverview paymentOverview, bool isNewStudent = false) : this()
        {
            _parent = paymentOverview;
            _isNewPayment = isNewStudent;
            FormLoad();
        }

        private void FormLoad()
        {
            if (_parent == null || !_parent.PaymentIDs.Contains(_parent.PaymentID))
                return;

            if (!_isNewPayment)
            {
                var data = DatabaseModel.Instance.Pagesas.First(x => x.PageseId == _parent.PaymentID);
                txtPaymentForm.Text = data.FormaPageses;
                txtServiceDescription.Text = data.PershkrimiPageses;
                dtpDate.Value = data.Data.Value;
                txtTotalPaid.Text = data.ShumaPaguar.ToString();
                txtDiscount.Text = data.Zbritje.ToString();
            }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Exit();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            UpdateData();
            _parent.ResetGridData();
            Exit();
        }

        private void UpdateData()
        {
            try
            {
                var data = new Pagesa();
                if (!_isNewPayment && _parent.PaymentIDs.Contains(_parent.PaymentID))
                    data = DatabaseModel.Instance.Pagesas.First(x => x.PageseId == _parent.PaymentID);

                data.FormaPageses = txtPaymentForm.Text;
                data.PershkrimiPageses = txtServiceDescription.Text;
                data.Data = dtpDate.Value;
                data.ShumaPaguar = decimal.Parse(txtTotalPaid.Text);
                data.Zbritje = decimal.Parse(txtDiscount.Text);

                if (_isNewPayment)
                {
                    DatabaseModel.Instance.Pagesas.Add(data);
                    DatabaseModel.Instance.SaveChanges();
                    _parent.UpdatePaymentIds();
                }
                else
                    DatabaseModel.Instance.SaveChanges();

                _parent.PaymentID = data.PageseId;
            }
            catch
            {
                MessageBox.Show("There was an error");
            }
        }

        private void Exit()
        {
            Close();
            _parent.Show();
        }
    }
}
