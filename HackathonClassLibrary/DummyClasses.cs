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

        public static AutomatedOutcome AutomaticProcessResult(PriceFeedItem feedItemToCheck)
        {
            return AutomatedOutcome.Accepted;
        }

        public static List<NewsFeedItem> GetRelevantNewsFeedItem(DateTime fromDate, DateTime toDate, string searchTerm)
        {
            return new List<NewsFeedItem>();
        }
    }

    public class NewsFeedItem
    {

    }

    public enum AutomatedOutcome
    {
        Accepted,
        Deleted,
        Questionable

    }

    public class PriceFeedItem
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

    }


    public class QuestionedPriceFeedItem
    {
        private PriceFeedItem feedItem;

        public QuestionedPriceFeedItem(PriceFeedItem feedItem)
        {
            this.feedItem = feedItem;
        }

        public PriceFeedItem FeedItem
        {
            get
            {
                return feedItem;
            }
        }

    }
}
