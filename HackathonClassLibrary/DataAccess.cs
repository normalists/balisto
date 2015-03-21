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
            return;

            if((Array.IndexOf(statisticTypeWhiteList,i.StatisticType)==-1)||(Array.IndexOf(valueTypeWhiteList,i.ValueType)==-1))
            {
                return;
            }

            try
            {
                string SQL = @"
                    declare @sample table
                    (
	                    price numeric(24,12),
	                    [GSN] [varchar](50) NULL,
	                    [date] [datetime] NULL,
	                    [original_date] [varchar](50) NULL,
	                    [marketCode] [varchar](50) NULL,
	                    [currencyCode] [varchar](50) NULL,
	                    [valorNumber] [varchar](50) NULL,
	                    [valueType] [varchar](50) NULL,
	                    [statisticType] [varchar](50) NULL,
	                    [valueStyle] [varchar](50) NULL,
	                    [value] [varchar](50) NULL
                    )

                    declare @mean numeric(24,12)
                    declare @variance numeric(24,12)

                    insert into @sample
			            select
				            top 10
				            cast(value as numeric(24,12)) as price,
				            GSN, [date], original_date, marketCode, currencyCode, valorNumber, valueType, statisticType, valueStyle, value
			            from
				            mdf_stream_emulated
			            where
				            datediff(ss, [date], @timeslot) > 0
				            and
				            statisticType in (2,3,9,10,11,12)
				            and
				            valueType in (1,2,3,4,7)
				            and 
				            currencyCode = @currrencyCode
				            and
				            valorNumber = @valor
			            order by
				            gsn desc

		            select
			            @mean = avg(price),
			            @variance = var(price)
		            from
			            @sample

		            if(@mean is not null)
			            begin
				            insert into averages(GSN, valor, lastUpdated, currencyCode, mean, variance, avgDifference, avgProportion)
				            select distinct
					            @GSN,
					            @valor as Valor,
					            @timeslot,
					            @currrencyCode as CurrencyCode,
					            @mean as Mean,
					            @variance as Variance,
					            avg([difference]) as avgDifference,
					            avg(proportion) as avgProportion
				            from
					            (select
						            s.valorNumber,
						            s.[date],
						            s.price,
						            @mean as mean,
						            abs(s.price - @mean) as [difference],
						            abs(s.price - @mean) / s.price as [proportion]
					            from
						            @sample s
					            ) aa
			            end";

                    DbCommand insCmd = da.db.GetSqlStringCommand(SQL);
                    da.db.AddInParameter(insCmd, "GSN", DbType.Int64, i.GSN);
                    da.db.AddInParameter(insCmd, "valor", DbType.Int32, i.Valor);
                    da.db.AddInParameter(insCmd, "timeslot", DbType.DateTime, i.Timestamp);
                    da.db.AddInParameter(insCmd, "price", DbType.Decimal, i.Value);
                    da.db.AddInParameter(insCmd, "currencyCode", DbType.Int32, i.Currency);
                    da.db.AddInParameter(insCmd, "valueType", DbType.String, i.ValueType);
                    da.db.AddInParameter(insCmd, "statisticType", DbType.String, i.StatisticType);
                    da.db.AddInParameter(insCmd, "valueStyle", DbType.String, "");

                    da.db.ExecuteNonQuery(insCmd);
            }
            catch (Exception ex)
            {
                
                throw;
            }

        }
    }
}
