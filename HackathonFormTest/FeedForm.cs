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
            PriceFeedItem item = DummyClasses.GetNextFeedItem();
            feedList.Items.Add(item);
            //feedList.ite
            
            parent.InformParent(item);
        }

        public void SetUpForm()
        {
            parent = Program.GetMainForm();
        }

        private void FeedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            parent.ToggleFeedDisplay();
            e.Cancel = true;
        }
    }
}
