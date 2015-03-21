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
    public partial class MainForm : Form
    {
        FeedForm feedForm;
        AcceptedForm acceptedForm;
        QuestionableForm questionableForm;
        UserArea userArea;

        public DataAccess da;

        bool feedFormShown;
        bool acceptedFormShown;
        bool questionableFormShown;
        bool userAreaShow;

        DateTime latestFeedTimestamp;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void SetUpForm()
        {
            da = new DataAccess();

            feedForm = new FeedForm();
            feedForm.SetUpForm();
            feedFormShown = false;

            acceptedForm = new AcceptedForm();
            acceptedForm.SetUpForm();
            acceptedFormShown = false;

            questionableForm = new QuestionableForm();
            questionableForm.SetUpForm();
            questionableFormShown = false;

            userArea = new UserArea();
            userArea.SetUpForm();
            userAreaShow = false;

            feedTimer.Start();
        }

        private void InformObserversNewFeedItem(PriceFeedItem feedItem)
        {
            AutomatedOutcome outcome = DummyClasses.AutomaticProcessResult(feedItem, da);

            switch (outcome)
            {
                case AutomatedOutcome.Accepted:
                    acceptedForm.InformAccepted(feedItem);
                    DummyClasses.SaveAcceptedItem(feedItem,da);
                    
                    break;
                case AutomatedOutcome.Deleted:
                    // to do - should just be removed
                    break;
                case AutomatedOutcome.Questionable:
                    QuestionedPriceFeedItem qItem = new QuestionedPriceFeedItem(feedItem);
                    questionableForm.InformQuestioned(qItem);
                    break;
                default:
                    break;
            }

            feedForm.ClearOut(feedItem);
        }

        

        private void toggleFeedDisplay_Click(object sender, EventArgs e)
        {
            ToggleFeedDisplay();
            
        }

        private void toggleAcceptedDisplay_Click(object sender, EventArgs e)
        {
            ToggleAcceptedDisplay();
        }

        private void questionableDisplay_Click(object sender, EventArgs e)
        {
            ToggleQuestionableDisplay();
        }

        private void userAreaDisplayButton_Click(object sender, EventArgs e)
        {
            ToggleUserAreaDisplay();
        }

        




        internal void ToggleFeedDisplay()
        {
            feedFormShown = !feedFormShown;

            UpdateVisibilities();
        }

        internal void ToggleAcceptedDisplay()
        {
            acceptedFormShown = !acceptedFormShown;

            UpdateVisibilities();
        }

        internal void ToggleQuestionableDisplay()
        {
            questionableFormShown = !questionableFormShown;

            UpdateVisibilities();
        }

        internal void ToggleUserAreaDisplay()
        {
            userAreaShow = !userAreaShow;

            UpdateVisibilities();
        }



        private void UpdateVisibilities()
        {
            if (feedFormShown)
            {
                feedForm.Show();
            }
            else
            {
                feedForm.Hide();
            }



            if (acceptedFormShown)
            {
                acceptedForm.Show();
            }
            else
            {
                acceptedForm.Hide();
            }


            if (questionableFormShown)
            {
                questionableForm.Show();
            }
            else
            {
                questionableForm.Hide();
            }

            if (userAreaShow)
            {
                userArea.Show();
            }
            else
            {
                userArea.Hide();
        }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void feedTimer_Tick(object sender, EventArgs e)
        {
            feedForm.SendFeedTick();
        }



        private void SetTime(DateTime dateTime)
        {
            latestFeedTimestamp = dateTime;
            timeLabel.Text = latestFeedTimestamp.ToString("dd/MM/yyyy HH:mm:ss.fff");
        }



        internal void InformParent(PriceFeedItem item)
        {
            SetTime(item.Timestamp);
            InformObserversNewFeedItem(item);
        }









        internal UserArea GetUserArea()
        {
            return userArea;
        }
        
        internal QuestionedPriceFeedItem GetNextIssue(int quickTerminalId)
        {
            return questionableForm.GetNextIssue(quickTerminalId);
        }

        internal void CancelWork(QuestionedPriceFeedItem currentIssue, int quickTerminalId)
        {
            questionableForm.CancelWork(currentIssue, quickTerminalId);
        }

        internal IEnumerable<PriceFeedItem> GetRecentItems(int valor)
        {
            return acceptedForm.GetRecentItems(valor);
        }



        internal void DecisionMade(QuestionedPriceFeedItem questionedFeedItem)
        {
            switch (questionedFeedItem.TopDecision)
            {
                case ManualOutcome.Accepted:
                    acceptedForm.InformAccepted(questionedFeedItem.FeedItem);
                    questionableForm.InformDealtWith(questionedFeedItem);
                    DummyClasses.SaveAcceptedItem(questionedFeedItem.FeedItem, da);
                    break;
                case ManualOutcome.Rejected:
                    questionableForm.InformDealtWith(questionedFeedItem);
                    break;
                default:
                    break;
            }
        }

        
    }
}
