using HackathonClassLibrary;
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
    public partial class QuestionableForm : Form
    {
        private MainForm parent;

        public QuestionableForm()
        {
            InitializeComponent();
        }

        public void SetUpForm()
        {
            parent = Program.GetMainForm();
        }


        internal void InformQuestioned(QuestionedPriceFeedItem feedItem)
        {
            questionedListBox.Items.Add(feedItem);
        }

        private void QuestionableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.ToggleQuestionableDisplay();
            e.Cancel = true;
        }
    }
}
