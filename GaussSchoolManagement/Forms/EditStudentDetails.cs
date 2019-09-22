using GaussSchoolManagement.DataModel;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class EditStudentDetails : Form
    {
        private StudentOverview _parent;
        private bool _isNewStudent;

        private EditStudentDetails()
        {
            InitializeComponent();
        }

        public EditStudentDetails(StudentOverview studentOverview, bool isNewStudent = false) : this()
        {
            _parent = studentOverview;
            _isNewStudent = isNewStudent;
            FormLoad();
        }

        private void FormLoad()
        {
            if (_parent == null || !_parent.StudentIDs.Contains(_parent.StudentID))
                return;

            if (!_isNewStudent)
            {
                var data = DatabaseModel.Instance.Nxenes.First(x => x.NxenesId == _parent.StudentID);
                txtName.Text = data.Persona.Emri;
                txtSurname.Text = data.Persona.Mbiemri;
                dtpBirthday.Value = data.Persona.DataLindjes.Value;
                txtEmailAddress.Text = data.Persona.EmailAdresa;
                txtPhoneNumber.Text = data.Persona.Telefoni;
                txtAddress.Text = data.Persona.Adresa;
            }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Exit();
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            UpdateData();
            Exit();
        }

        private void UpdateData()
        {
            try
            {
                var data = new Nxene() { Persona = new Persona() };
                if (!_isNewStudent && _parent.StudentIDs.Contains(_parent.StudentID))
                    data = DatabaseModel.Instance.Nxenes.First(x => x.NxenesId == _parent.StudentID);

                data.Persona.Emri = txtName.Text;
                data.Persona.Mbiemri = txtSurname.Text;
                data.Persona.DataLindjes = dtpBirthday.Value;
                data.Persona.EmailAdresa = txtEmailAddress.Text;
                data.Persona.Telefoni = txtPhoneNumber.Text;
                data.Persona.Adresa = txtAddress.Text;

                if (_isNewStudent)
                {
                    DatabaseModel.Instance.Nxenes.Add(data);
                    DatabaseModel.Instance.SaveChanges();
                    _parent.UpdateStudentIds();
                }
                else
                    DatabaseModel.Instance.SaveChanges();

                _parent.StudentID = data.NxenesId;
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
