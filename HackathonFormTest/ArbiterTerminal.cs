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
using System.Windows.Forms.DataVisualization.Charting;

namespace HackathonFormTest
{
    public partial class ArbiterTerminal : Form
    {
        private UserArea parent;

        private bool online;

        private QuestionedPriceFeedItem currentIssue;

        public ArbiterTerminal()
        {
            InitializeComponent();
        }

        internal void SetUpForm()
        {
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

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DecisionMade(ManualOutcome.Accepted);
        }



        private void postponeButton_Click(object sender, EventArgs e)
        {
            DecisionMade(ManualOutcome.Postponed);
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            DecisionMade(ManualOutcome.Rejected);
        }

        private void DecisionMade(ManualOutcome manualOutcome)
        {
            currentIssue.DecisionMade(manualOutcome);
            parent.DecisionMadeArbiter(currentIssue);
            currentIssue = null;
            UpdateDisplay();
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


            }
            else
            {
                onlineStatusButton.Text = "Go Online!";
                onlineLabel.Text = "Currently Offline";
                onlineLabel.ForeColor = Color.Blue;

                if (currentIssue != null)
                {
                    //parent.CancelWork(currentIssue);
                    currentIssue = null;
                    issueLabel.Text = "";
                }



                timer1.Stop();
            }

            issuePanel.Visible = currentIssue != null;
            UpdateIssuePanel();

            parent.UpdateDisplay();
        }

        private void UpdateIssuePanel()
        {
            if (currentIssue != null)
            {
                historyChart.Series.Clear();

                List<PriceFeedItem> recentItems = parent.GetRecentItems(currentIssue.Valor).ToList();
                Series S1 = new Series();
                foreach (PriceFeedItem item in recentItems)
                {


                    S1.Points.AddXY(item.Timestamp, item.Value);

                }
                historyChart.Series.Add(S1);




                Series S2 = new Series();
                S2.Points.AddXY(currentIssue.Timestamp, currentIssue.Value);
                historyChart.Series.Add(S2);

                historyChart.ResetAutoValues();

                historyChart.Series[0].XValueType = ChartValueType.DateTime;
                historyChart.Series[1].XValueType = ChartValueType.DateTime;

                //historyChart.res

            }




            //historyChart.da

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentIssue == null)
            {
                currentIssue = parent.GetNextArbiterIssue();


            }

            UpdateDisplay();
        }

        private void ArbiterTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.ToggleArbiterDisplay();
            e.Cancel = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = fromDP.Value;
            DateTime dateTo = toDP.Value;

            string searchTerm = searchTextBox.Text;

            List<NewsFeedItem> news = DummyClasses.GetRelevantNewsFeedItem(dateFrom, dateTo, searchTerm);

            newsFeed.Items.AddRange(news.ToArray());
        }
    }
}
