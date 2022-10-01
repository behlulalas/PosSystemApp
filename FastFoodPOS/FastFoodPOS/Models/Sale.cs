using FastFoodPOS.DatabaseUtil;
using FastFoodPOS.ErrorHandler;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Sale
    {
        public decimal Value { get; set; }
        public int OrderCount { get; set; }
        public int CustomerCount { get; set; }
        public DateTime Date { get; set; }

        public static List<Sale> GetSalesBetween(DateTime from, DateTime to)
        {
            List<Sale> result = new List<Sale>();
            using (var cmd = DatabaseModel.CreateCommand("Select Date,Sum(Price*Quantity),Count(o.TransactionCode),Count(Distinct(t.TransactionCode)) From Transactions t inner join Orders o on t.TransactionCode=o.TransactionCode  WHERE  Date BETWEEN  CAST('@@from' AS DATE) AND CAST('@@to' AS DATE) Group By Date"))
            {
                //BindParams not working
                //idk why
                cmd.CommandText = cmd.CommandText.Replace("@@from", DatabaseModel.GetProvider().FormatShortDate(from.AddDays(-1)));
                cmd.CommandText = cmd.CommandText.Replace("@@to", DatabaseModel.GetProvider().FormatShortDate(to.AddDays(1)));
                DatabaseModel.GetConnection().Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Sale
                        {
                            Date = reader.GetDateTime(0),//Burada kaldık
                            Value = reader.GetDecimal(1),
                            OrderCount = reader.GetInt32(2),
                            CustomerCount =reader.GetInt32(3),
                        });
                    }
                }
                DatabaseModel.GetConnection().Close();
            }
            return result;
        }

        public static Sale GetSale(DateTime day)
        {
            Sale result = new Sale() { Value = 0, Date = day, OrderCount = 0, CustomerCount = 0 };
            using (var cmd = DatabaseModel.CreateCommand("Select Sum(Price*Quantity) as satis,Count(o.TransactionCode) as siparis,Count(Distinct(t.TransactionCode)) AS totalCustomer From Transactions t inner join Orders o on t.TransactionCode=o.TransactionCode  WHERE  Date BETWEEN  CAST(GetDate() AS DATE) AND CAST(GetDate()+1 AS DATE)"))
            {
                DatabaseModel.BindParameters(cmd, DatabaseModel.GetProvider().FormatShortDate(day));
                DatabaseModel.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result.Value = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                        result.OrderCount = reader.GetInt32(1);
                        result.CustomerCount = reader.GetInt32(2);
                    }
                }
                DatabaseModel.GetConnection().Close();
            }
            return result;
        }

        public static List<Sale> GetSalesFromLastWeek()
        {
            return GetSalesBetween(DateTime.Now.AddDays(-6), DateTime.Now);
        }

        public static string[] GetDaysLabelFromLastWeek()
        {
            return GetDaysLabel(DateTime.Now.AddDays(-6), DateTime.Now);
        }

        public static string[] GetDaysLabel(DateTime from, DateTime to)
        {
            if (from > to) throw new Level1Exception("Start date must not be Greater than end date");
            List<string> result = new List<string>();
            to = to.AddDays(1);
            while(!from.ToShortDateString().Equals(to.ToShortDateString()))
            {
                result.Add(from.ToString("MMM dd"));
                from = from.AddDays(1);
            }
            return result.ToArray<string>();
        }
    }
}
