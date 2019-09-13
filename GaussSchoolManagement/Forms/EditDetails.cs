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
    public partial class EditDetails : Form
    {
        int StudentID = -1;
        public EditDetails()
        {
            InitializeComponent();
        }

        public EditDetails(int id) : this()
        {
            StudentID = id;
            FormLoad();

        }

        private void FormLoad()
        {
            if (StudentID == -1)
                return;
            var data = DatabaseModel.Instance.Nxenes.First(x => x.NxenesId == StudentID);
            txtName.Text = data.Persona.Emri;
            txtSurname.Text = data.Persona.Mbiemri;
            dtpBirthday.Value = data.Persona.DataLindjes.Value;
            txtEmailAddress.Text = data.Persona.EmailAdresa;
            txtPhoneNumber.Text = data.Persona.Telefoni;
            txtAddress.Text = data.Persona.Adresa;
        }
    }
}
