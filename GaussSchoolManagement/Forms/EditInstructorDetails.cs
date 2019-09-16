using GaussSchoolManagement.DataModel;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class EditInstructorDetails : Form
    {
        private InstructorOverview _parent;
        private bool _isNewInstructor;

        private EditInstructorDetails()
        {
            InitializeComponent();
        }

        public EditInstructorDetails(InstructorOverview instructorOverview1, bool isNewInstructor = false) : this()
        {
            _parent = instructorOverview1;
            _isNewInstructor = isNewInstructor;
            FormLoad();
        }

        private void FormLoad()
        {
            if (_parent == null || !_parent.InstructorIDs.Contains(_parent.InstructorID))
                return;

            if (!_isNewInstructor)
            {
                var data = DatabaseModel.Instance.Instruktores.First(x => x.InstruktorId == _parent.InstructorID);
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
            var data = new Instruktore() { Persona = new Persona() };
            if (!_isNewInstructor && _parent.InstructorIDs.Contains(_parent.InstructorID))
                data = DatabaseModel.Instance.Instruktores.First(x => x.InstruktorId == _parent.InstructorID);

            data.Persona.Emri = txtName.Text;
            data.Persona.Mbiemri = txtSurname.Text;
            data.Persona.DataLindjes = dtpBirthday.Value;
            data.Persona.EmailAdresa = txtEmailAddress.Text;
            data.Persona.Telefoni = txtPhoneNumber.Text;
            data.Persona.Adresa = txtAddress.Text;

            if (_isNewInstructor)
            {
                DatabaseModel.Instance.Instruktores.Add(data);
                DatabaseModel.Instance.SaveChanges();
                _parent.UpdateInstructorIds();
            }
            else
                DatabaseModel.Instance.SaveChanges();

            _parent.InstructorID = data.InstruktorId;
        }

        private void Exit()
        {
            Close();
            _parent.Show();
        }
    }
}
