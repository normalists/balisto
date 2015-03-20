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
    public partial class FeedForm : Form
    {
        private MainForm parent;
        private long startingGSN = 10000000001;
        private PriceFeedItem CurrentItem;

        public FeedForm()
        {
            
            InitializeComponent();
        }

        public void SendFeedTick()
        {

            GetNextFeedItem();
        }

        private void GetNextFeedItem()
        {
            PriceFeedItem item = DummyClasses.GetNextFeedItem(CurrentItem, parent.da);
            feedList.Items.Add(item);
            parent.InformParent(item);
            CurrentItem = item;
        }

        public void SetUpForm()
        {
            parent = Program.GetMainForm();
            CurrentItem = PriceFeedHandler.FeedItemFromGSN(startingGSN, parent.da);
        }

        private void FeedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            parent.ToggleFeedDisplay();
            e.Cancel = true;
        }
    }
}
