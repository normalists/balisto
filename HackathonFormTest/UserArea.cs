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
    public partial class UserArea : Form
    {
        private MainForm parent;

        int usersOnline;

        int nextId = 1;

        private List<QuickTerminal> quickTerminals;
        private int usersRequired;

        public UserArea()
        {
            InitializeComponent();
        }

        public void SetUpForm()
        {
            parent = Program.GetMainForm();
            //usersRequiredCombo.SelectedText = usersRequiredCombo.Items[0].ToString();
            quickTerminals = new List<QuickTerminal>();
            UpdateDisplay();

            
        }

        private void CreateNewTerminal()
        {
            QuickTerminal terminal = new QuickTerminal();
            quickTerminals.Add(terminal);
            terminal.SetUpForm(nextId);
            nextId++;
            terminal.Show();
            

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            CreateNewTerminal();
            UpdateDisplay();
        }

        private void UserArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.ToggleUserAreaDisplay();
            e.Cancel = true;
        }

        public void UpdateUserChecks()
        {
            usersOnline = quickTerminals.FindAll(delegate(QuickTerminal qTTemp) { return qTTemp.IsOnline; }).Count;
            usersRequired = (int)usersRequiredNumeric.Value;
        }

        public void UpdateDisplay()
        {
            
            usersOnlineNumber.Text = usersOnline.ToString();

            if (usersOnline >= usersRequired)
            {
                usersOnlineNumber.ForeColor = Color.Green;
            }
            else
            {
                usersOnlineNumber.ForeColor = Color.Red;
            }

        }

        internal void RemoveQuickTerminal(QuickTerminal quickTerminal)
        {
            quickTerminals.Remove(quickTerminal);
            UpdateUserChecks();
            UpdateDisplay();
        }

        private void usersRequiredCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        internal QuestionedPriceFeedItem GetNextIssue(int quickTerminalId)
        {
            return parent.GetNextIssue(quickTerminalId);
        }

        internal void CancelWork(QuestionedPriceFeedItem currentIssue, int quickTerminalId)
        {
            parent.CancelWork(currentIssue, quickTerminalId);
        }
    }
}
