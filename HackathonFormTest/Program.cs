using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonFormTest
{
    static class Program
    {
        //static HackathonClassLibrary.DataAccess da;
        static MainForm mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //da = new HackathonClassLibrary.DataAccess();
            mainForm = new MainForm();
            
            Application.Run(mainForm);
        }

        internal static MainForm GetMainForm()
        {
            return mainForm;
        }

        internal static UserArea GetUserArea()
        {
            return mainForm.GetUserArea();
        }
    }
}
