using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonClassLibrary
{
    public static class DummyClasses
    {
        public static PriceFeedItem GetNextFeedItem(PriceFeedItem currentPFI, DataAccess da)
        {
            PriceFeedItem item = PriceFeedHandler.GetNextFeedItem(currentPFI, da);
            //item.Timestamp = DateTime.Now;
            return item;
        }

        private static int itemCounter = 1;

        public static AutomatedOutcome AutomaticProcessResult(PriceFeedItem feedItemToCheck)
        {
            itemCounter++;

            if (itemCounter % 10 == 0 )
            {
                return AutomatedOutcome.Questionable;
            }
            else
            {
                return AutomatedOutcome.Accepted;
            }
            
        }

        public static List<NewsFeedItem> GetRelevantNewsFeedItem(DateTime fromDate, DateTime toDate, string searchTerm)
        {
            // todo need to link up

            List<NewsFeedItem> tests = new List<NewsFeedItem>();

            for (int i = 0; i < 10; i++)
            {
                NewsFeedItem n = new NewsFeedItem();
                tests.Add(n);
            }
            return tests;
        }

        private static int dummyValor = 1;

        public static int GetNextDummyValor()
        {

            dummyValor++;

            return dummyValor;
        }

        public static void SaveAcceptedItem(PriceFeedItem feedItem, DataAccess da)
        {
            PriceFeedHandler.UpdateAverage(feedItem, da);
            // todo: throw new NotImplementedException();
        }

        //public static 

        //public static IEnumerable<PriceFeedItem> Get
    }

    //public class NewsFeedItem
    //{

    //}

    public enum AutomatedOutcome
    {
        Accepted,
        Deleted,
        Questionable

    }

    public enum ManualOutcome
    {
        Accepted,
        Rejected,
        Postponed,
        Pending

    }

    public class PriceFeedItem : IComparable<PriceFeedItem>
    {

        public PriceFeedItem()
        {

        }

        public long GSN { get; set; }

        public DateTime Timestamp { get; set; }

        public int MarketCode { get; set; }

        public int Currency { get; set; }

        public int Valor { get; set; }

        public int ValueType { get; set; }

        public int StatisticType { get; set; }

        public decimal Value { get; set; }

        public override string ToString()
        {
            return GSN.ToString() + " // " + Valor.ToString() + "//" + Timestamp.ToString();
        }



        public int CompareTo(PriceFeedItem other)
        {
            return this.GSN.CompareTo(other.GSN);
        }
    }



    public class QuestionedPriceFeedItem
    {
        private PriceFeedItem feedItem;

        private int dummyValor;

        //private List<int> quickTerminalIds;

        private Dictionary<int, ManualOutcome> decisionLookup;

        private ManualOutcome arbiterDecision;

        public QuestionedPriceFeedItem(PriceFeedItem feedItem)
        {
            this.feedItem = feedItem;
            this.dummyValor = DummyClasses.GetNextDummyValor();
            //quickTerminalIds = new List<int>();
            decisionLookup = new Dictionary<int, ManualOutcome>();
            arbiterDecision = ManualOutcome.Pending;
        }

        public PriceFeedItem FeedItem
        {
            get
            {
                return feedItem;
            }
        }

        public override string ToString()
        {
            return feedItem.ToString();
        }


        public bool ReadBy(int quickTerminalId)
        {
            return decisionLookup.Keys.Contains(quickTerminalId);
        }

        public void CancelWork(int quickTerminalId)
        {
            decisionLookup.Remove(quickTerminalId);
        }

        public int GetWorkerCount()
        {
            return decisionLookup.Keys.Count;
        }

        public void Checkout(int quickTerminalId)
        {
            if (!decisionLookup.ContainsKey(quickTerminalId))
            {
                decisionLookup.Add(quickTerminalId, ManualOutcome.Pending);
            }
        }

        public int Valor
        {
            get
            {
                return feedItem.Valor;
            }
        }

        public DateTime Timestamp
        {
            get
            {
                return feedItem.Timestamp;
            }
        }

        public decimal Value
        {
            get
            {
                return feedItem.Value;
            }
        }

        public void DecisionMade(int quickTerminalId, ManualOutcome manualOutcome)
        {
            decisionLookup[quickTerminalId] = manualOutcome;
        }

        public int DecisionsMade
        {
            get
            {
                return decisionLookup.Values.ToList().FindAll(delegate(ManualOutcome outcome) { return outcome != ManualOutcome.Pending; }).Count;
            }
        }



        public bool DecisionsAgree
        {
            get
            {
                return decisionLookup.Values.ToList()[0] == decisionLookup.Values.ToList()[1];
            }

        }

        public ManualOutcome TopDecision
        {
            get
            {
                if (arbiterDecision != ManualOutcome.Pending)
                {
                    return arbiterDecision;
                }
                return decisionLookup.Values.ToList()[0];
            }

        }

        public void DecisionMade(ManualOutcome manualOutcome)
        {
            arbiterDecision = manualOutcome;
        }
    }
}
