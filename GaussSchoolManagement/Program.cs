using GaussSchoolManagement.DataModel;
using GaussSchoolManagement.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GaussSchoolManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Just a random small query to compile the model
            var justForInitialization = DatabaseModel.Instance.Shkollas.AsEnumerable();
            justForInitialization = null;
            Application.Run(new Dashboard());
        }
    }
}
