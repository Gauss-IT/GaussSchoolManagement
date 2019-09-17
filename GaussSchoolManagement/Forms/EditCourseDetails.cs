using GaussSchoolManagement.DataModel;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement.Forms
{
    public partial class EditCourseDetails : Form
    {
        private CourseOverview _parent;
        private bool _isNewCourse;

        private EditCourseDetails()
        {
            InitializeComponent();
        }

        public EditCourseDetails(CourseOverview courseOverview, bool isNewCourse = false) : this()
        {
            _parent = courseOverview;
            _isNewCourse = isNewCourse;
            FormLoad();
        }

        private void FormLoad()
        {
            if (_parent == null || !_parent.CourseIDs.Contains(_parent.CourseID))
                return;

            if (!_isNewCourse)
            {
                var data = DatabaseModel.Instance.Kurses.First(x => x.KursId == _parent.CourseID);
                txtCode.Text = data.ShifraKursit;
                txtName.Text = data.EmriKursit;
                cmbLevel.Text = data.Niveli;
                txtYear.Text = data.VitiShkollor;
                txtDescription.Text = data.Pershkrimi;
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
            var data = new Kurse();
            if (!_isNewCourse && _parent.CourseIDs.Contains(_parent.CourseID))
                data = DatabaseModel.Instance.Kurses.First(x => x.KursId == _parent.CourseID);

            data.ShifraKursit = txtCode.Text;
            data.EmriKursit = txtName.Text;
            data.Niveli = cmbLevel.Text;
            data.VitiShkollor = txtYear.Text;
            data.Pershkrimi = txtDescription.Text;

            if (_isNewCourse)
            {
                DatabaseModel.Instance.Kurses.Add(data);
                DatabaseModel.Instance.SaveChanges();
                _parent.UpdateCourseIDs();
            }
            else
                DatabaseModel.Instance.SaveChanges();

            _parent.CourseID = data.KursId;
        }

        private void Exit()
        {
            Close();
            _parent.Show();
        }
    }
}
