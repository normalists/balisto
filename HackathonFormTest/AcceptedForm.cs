using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackathonFormTest
{
    public partial class AcceptedForm : Form
    {
        private MainForm parent;

        public AcceptedForm()
        {
            InitializeComponent();
        }

        public void SetUpForm()
        {
            parent = Program.GetMainForm();
        }

        private void AcceptedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.ToggleFeedDisplay();
            e.Cancel = true;
        }
    }
}
