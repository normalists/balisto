﻿using HackathonClassLibrary;
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

        private ArbiterTerminal arbiter;

        int usersOnline;

        int nextId = 1;

        bool showArbiter;

        private List<QuickTerminal> quickTerminals;
        private int usersRequired;

        private List<QuestionedPriceFeedItem> arbiterFeedItems;

        public UserArea()
        {
            InitializeComponent();
        }

        public void SetUpForm()
        {
            parent = Program.GetMainForm();
            //usersRequiredCombo.SelectedText = usersRequiredCombo.Items[0].ToString();
            quickTerminals = new List<QuickTerminal>();
            showArbiter = false;

            arbiterFeedItems = new List<QuestionedPriceFeedItem>();

            arbiter = new ArbiterTerminal();
            arbiter.SetUpForm();

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

        private void showArbiterButton_Click(object sender, EventArgs e)
        {
            showArbiter = !showArbiter;
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

            if (showArbiter)
            {
                arbiter.Show();
            }
            else
            {
                arbiter.Hide();
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

        internal IEnumerable<PriceFeedItem> GetRecentItems(int valor)
        {
            return parent.GetRecentItems(valor);
        }



        internal void DecisionMade(QuestionedPriceFeedItem currentIssue)
        {
            if (currentIssue.DecisionsMade >= 2)
            {
                if (currentIssue.DecisionsAgree && (currentIssue.TopDecision == ManualOutcome.Accepted || currentIssue.TopDecision == ManualOutcome.Rejected))
                {
                    parent.DecisionMade(currentIssue);
                }
                else
                {
                    arbiterFeedItems.Add(currentIssue);
                }
            }
        }

        internal void DecisionMadeArbiter(QuestionedPriceFeedItem currentIssue)
        {
            parent.DecisionMade(currentIssue);
            arbiterFeedItems.Remove(currentIssue);
        }



        internal QuestionedPriceFeedItem GetNextArbiterIssue()
        {
            if (arbiterFeedItems.Count > 0)
            {
                return arbiterFeedItems[0];
            }

            return null;
        }

        internal void ToggleArbiterDisplay()
        {
            showArbiter = !showArbiter;
        }
    }
}
