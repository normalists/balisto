using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace HackathonClassLibrary
{
    public class DataAccess
    {
        // singleton
        private Database db;

        public DataAccess()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            db = factory.Create("default");
        }

        public DataSet GetDataSet(string SQLcode)
        {
            return db.ExecuteDataSet(CommandType.Text, SQLcode);
        }
        public DataSet GetDataSet(string ProcedureName, object[] Parameters)
        {
            return db.ExecuteDataSet(ProcedureName, Parameters);
        }
        public void ExecuteProcedure(string ProcedureName, object[] Parameters)
        {
            db.ExecuteNonQuery(ProcedureName, Parameters);
        }
    }

    public class PriceFeedHandler
    {
        public static PriceFeedItem GetNextFeedItem(PriceFeedItem i, DataAccess da)
        {
            string SQL = @"select min(GSN) from mdf_stream_emulated where GSN > " + i.GSN.ToString();

            DataSet ds = da.GetDataSet(SQL);

            //return FeedItemFromDataRow(ds.Tables[0].Rows[0]);
            return FeedItemFromGSN(long.Parse(ds.Tables[0].Rows[0][0].ToString()),da);
        }

        public static PriceFeedItem FeedItemFromGSN(long GSN, DataAccess da)
        {
            string SQL = @"
                declare @GSN bigint

                set @GSN = " + GSN + @"
                
                select
                    [GSN]
                    ,[date]
                    ,[original_date]
                    ,[marketCode]
                    ,[currencyCode]
                    ,[valorNumber]
                    ,[valueType]
                    ,[statisticType]
                    ,[valueStyle]
                    ,[value]
                from 
                    mdf_stream_emulated 
                where 
                    GSN = @GSN";

            DataSet ds = da.GetDataSet(SQL);

            return FeedItemFromDataRow(ds.Tables[0].Rows[0]);
        }

        private static PriceFeedItem FeedItemFromDataRow(DataRow dr)
        {
            PriceFeedItem n = new PriceFeedItem();
            n.GSN = long.Parse(dr["GSN"].ToString());
            n.Timestamp = DateTime.Parse(dr["date"].ToString());
            n.MarketCode = int.Parse(dr["marketCode"].ToString());
            n.Currency = int.Parse(dr["currencyCode"].ToString());
            n.Valor = int.Parse(dr["valorNumber"].ToString());
            n.ValueType = int.Parse(dr["valueType"].ToString());
            n.StatisticType = int.Parse(dr["statisticType"].ToString());
            n.Value = decimal.Parse(dr["value"].ToString());

            return n;
        }

        private static void UpdateAverage(PriceFeedItem i, DataAccess da)
        {
            object[] p = { i.GSN, i.Valor, i.Timestamp, i.Value, i.Currency, i.ValueType, i.StatisticType, "" };
            da.ExecuteProcedure("normalist_update_averages",p);
        }
    }
}
