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
    public partial class QuickTerminal : Form
    {
        private UserArea parent;

        private bool online;

        private QuestionedPriceFeedItem currentIssue;

        private int id;

        public QuickTerminal()
        {
            InitializeComponent();
            
        }



        internal void SetUpForm(int id)
        {
            this.id = id;
            parent = Program.GetUserArea();
            online = false;
            UpdateDisplay();
            
        }

        public bool IsOnline
        {
            get
            {
                return online;
            }
            
        }

        private void onlineStatusButton_Click(object sender, EventArgs e)
        {
            online = !online;
            parent.UpdateUserChecks();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            if (online)
            {
                onlineStatusButton.Text = "Go Offline";
                onlineLabel.Text = "CURRENTLY ONLINE!";
                onlineLabel.ForeColor = Color.Green;
                timer1.Start();

                if (currentIssue != null)
                {
                    issueLabel.Text = currentIssue.ToString();
                }

                issuePanel.Visible = true;
            }
            else
            {
                onlineStatusButton.Text = "Go Online!";
                onlineLabel.Text = "Currently Offline";
                onlineLabel.ForeColor = Color.Blue;

                if (currentIssue != null)
                {
                    parent.CancelWork(currentIssue, id);
                    currentIssue = null;
                    issueLabel.Text = "";
                }

                issuePanel.Visible = false;

                timer1.Stop();
            }

            parent.UpdateDisplay();
        }

        private void QuickTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.RemoveQuickTerminal((QuickTerminal)sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentIssue == null)
            {
                currentIssue = parent.GetNextIssue(id);

                
            }

            UpdateDisplay();
        }
    }
}
