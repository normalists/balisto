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
        private Dictionary<int, List<PriceFeedItem>> priceFeedItemLookup;

        public AcceptedForm()
        {
            InitializeComponent();
        }

        public void SetUpForm()
        {
            parent = Program.GetMainForm();
            feedItemsAccepted = new List<PriceFeedItem>();
            priceFeedItemLookup = new Dictionary<int, List<PriceFeedItem>>();
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

            if (!priceFeedItemLookup.ContainsKey(feedItem.Valor))
            {
                priceFeedItemLookup.Add(feedItem.Valor, new List<PriceFeedItem>());
            }

            priceFeedItemLookup[feedItem.Valor].Add(feedItem);

            priceFeedItemLookup[feedItem.Valor].Sort();

            while (priceFeedItemLookup[feedItem.Valor].Count > 10)
            {
                priceFeedItemLookup[feedItem.Valor].RemoveAt(0);
            }

            if (acceptedListBox.Items.Count > 10)
            {
                acceptedListBox.Items.Remove(feedItemsAccepted[0]);
                feedItemsAccepted.RemoveAt(0);
            }
        }



        internal IEnumerable<PriceFeedItem> GetRecentItems(int valor)
        {
            if (priceFeedItemLookup.ContainsKey(valor))
            {
                return priceFeedItemLookup[valor];

            }
            else
            {
                return new List<PriceFeedItem>();
            }
            
        }
    }
}
