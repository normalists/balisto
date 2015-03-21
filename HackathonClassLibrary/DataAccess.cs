using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace HackathonClassLibrary
{
    public class DataAccess
    {
        // singleton
        public Database db;

        public DataAccess()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            db = factory.Create("default");
        }

        public DataSet GetDataSet(string SQLcode)
        {
            return db.ExecuteDataSet(CommandType.Text, SQLcode);
        }
    }

    public class PriceFeedHandler
    {
        private static int[] statisticTypeWhiteList = { 2, 3, 9, 10, 11, 12 };
        private static int[] valueTypeWhiteList = { 1, 2, 3, 4, 7 };

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

        public static void UpdateAverage(PriceFeedItem i, DataAccess da)
        {
            if (i.GSN >= 10000040578) { return; }

            if((Array.IndexOf(statisticTypeWhiteList,i.StatisticType)==-1)||(Array.IndexOf(valueTypeWhiteList,i.ValueType)==-1))
            {
                return;
            }

            try
            {
                string SQL = @"select 
	                    count(valor) 
                    from 
	                    averages_data a
                    where 
	                    a.valor = " + i.Valor.ToString();

                int rCount = int.Parse(da.db.ExecuteScalar(da.db.GetSqlStringCommand(SQL)).ToString());

                int rows = 0;

                if (rCount < 10)
                {
                    // insert
                    SQL = @"insert into averages_data(gsn,valor,[timestamp],price,currencyCode,valueType,statisticType,valueStyle)
		                    values(@GSN,@valor,@timestamp,@price,@currencyCode,@valueType,@statisticType,@valueStyle)";

                    DbCommand insCmd = da.db.GetSqlStringCommand(SQL);
                    da.db.AddInParameter(insCmd, "GSN", DbType.Int64, i.GSN);
                    da.db.AddInParameter(insCmd, "valor", DbType.Int32, i.Valor);
                    da.db.AddInParameter(insCmd, "timestamp", DbType.DateTime, i.Timestamp);
                    da.db.AddInParameter(insCmd, "price", DbType.Decimal, i.Value);
                    da.db.AddInParameter(insCmd, "currencyCode", DbType.Int32, i.Currency);
                    da.db.AddInParameter(insCmd, "valueType", DbType.String, i.ValueType);
                    da.db.AddInParameter(insCmd, "statisticType", DbType.String, i.StatisticType);
                    da.db.AddInParameter(insCmd, "valueStyle", DbType.String, "");

                    rows = da.db.ExecuteNonQuery(insCmd);
                }
                else
                {
                    // update
                    SQL = @"select 
			                    min(GSN) 
		                    from 
			                    averages_data a 
		                    where 
			                    a.valor = " + i.Valor.ToString();

                    long minGSN = long.Parse(da.db.ExecuteScalar(da.db.GetSqlStringCommand(SQL)).ToString());

                    SQL = @"update
			                    a
		                    set
			                    a.GSN = @GSN, 
			                    a.valor = @valor, 
			                    a.[timestamp] = @timestamp, 
			                    a.price = @price, 
			                    a.currencyCode = @currencyCode, 
			                    a.valueType = @valueType, 
			                    a.statisticType = @statisticType, 
			                    a.valueStyle = @valueStyle
		                    from	
			                    averages_data a
		                    where
			                    a.gsn = @MinGSN";

                    DbCommand updCmd = da.db.GetSqlStringCommand(SQL);
                    da.db.AddInParameter(updCmd, "GSN", DbType.Int64, i.GSN);
                    da.db.AddInParameter(updCmd, "valor", DbType.Int32, i.Valor);
                    da.db.AddInParameter(updCmd, "timestamp", DbType.DateTime, i.Timestamp);
                    da.db.AddInParameter(updCmd, "price", DbType.Decimal, i.Value);
                    da.db.AddInParameter(updCmd, "currencyCode", DbType.Int32, i.Currency);
                    da.db.AddInParameter(updCmd, "valueType", DbType.String, i.ValueType);
                    da.db.AddInParameter(updCmd, "statisticType", DbType.String, i.StatisticType);
                    da.db.AddInParameter(updCmd, "valueStyle", DbType.String, "");
                    da.db.AddInParameter(updCmd, "MinGSN", DbType.Int64, minGSN);

                    rows = da.db.ExecuteNonQuery(updCmd);
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }

        }
    }
}
