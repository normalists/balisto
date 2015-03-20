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
        public HackathonClassLibrary.DataAccess da;
        
        bool feedFormShown;
        bool acceptedFormShown;

        DateTime latestFeedTimestamp;

        public MainForm()
        {
           InitializeComponent();
           da = new HackathonClassLibrary.DataAccess();
        }

        private void SetUpForm()
        {
            feedForm = new FeedForm();
            feedForm.SetUpForm();
            feedFormShown = false;

            acceptedForm = new AcceptedForm();
            acceptedForm.SetUpForm();
            acceptedFormShown = false;


            feedTimer.Start();
        }

        

        private void toggleFeedDisplay_Click(object sender, EventArgs e)
        {
            ToggleFeedDisplay();
            
        }

        internal void ToggleFeedDisplay()
        {
            feedFormShown = !feedFormShown;

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

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpForm();
        }

        private void feedTimer_Tick(object sender, EventArgs e)
        {
            feedForm.SendFeedTick();
        }



        internal void SetTime(DateTime dateTime)
        {
            latestFeedTimestamp = dateTime;
            timeLabel.Text = latestFeedTimestamp.ToString("dd/MM/yyyy HH:mm:ss.fff");
        }
    }
}
