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
    public partial class AcceptedForm : Form
    {
        private MainForm parent;
        private List<PriceFeedItem> feedItemsAccepted;

        public AcceptedForm()
        {
            InitializeComponent();
        }

        public void SetUpForm()
        {
            parent = Program.GetMainForm();
            feedItemsAccepted = new List<PriceFeedItem>();
        }

        private void AcceptedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.ToggleAcceptedDisplay();
            e.Cancel = true;
        }

        internal void InformAccepted(PriceFeedItem feedItem)
        {
            feedItemsAccepted.Add(feedItem);
            acceptedListBox.Items.Add(feedItem);

            if (acceptedListBox.Items.Count > 10)
            {
                acceptedListBox.Items.Remove(feedItemsAccepted[0]);
                feedItemsAccepted.RemoveAt(0);
            }
        }

        
    }
}
