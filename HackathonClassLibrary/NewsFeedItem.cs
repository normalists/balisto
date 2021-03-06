using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace HackathonClassLibrary
{
    public class NewsFeedItem
    {
        
            public int NewsID { get; set; }

            public string NewsDate { get; set; }

            public string NewsTime { get; set; }

            public string Headline { get; set; }

            public string Sources { get; set; }

            //Create the sql adapter connection objects    
           
        //Create the public method for the NewsFeedItem
        public NewsFeedItem()
			{
			}

        // use this access method for lst  : List<DataRow> list = dt.AsEnumerable().ToList();
        public static IEnumerable<string> GetRelevantNewsFeedItem(DateTime fromDate, DateTime toDate, string searchTerm)
        {
            SqlDataAdapter sqlDA = null;

            DataTable retdt = new DataTable();
            // Please replace the data source to reflect the DB
            using (SqlConnection connection = new SqlConnection(@"Server=WIN764RP;Database=hackathon;User Id=sa;Password=Dagr1eve;"))

            using (SqlCommand cmd = new SqlCommand("normalist_get_news_by_caption_and_feed_time", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("varFromDate", fromDate);
                cmd.Parameters.AddWithValue("varToDate", toDate);
                cmd.Parameters.AddWithValue("varSearchTerm", searchTerm);
                connection.Open();
                sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = cmd;

                sqlDA.Fill(retdt);
            }

            List<string> test = new System.Collections.Generic.List<string>();
            foreach (DataRow r in retdt.Rows)
            {
                test.Add(r["headline"].ToString());
            }
            return test;
        }
			


    }
}
