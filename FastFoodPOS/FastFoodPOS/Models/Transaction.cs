using FastFoodPOS.DatabaseUtil;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Transaction
    {
        public int Id { get; set; }
        public string TransactionCode { get; set; }
        public DateTime Date { get; set; }
        public decimal Cash { get; set; }
        public int CashierId { get; set; }
        public int CafeTableId { get; set; }

        private decimal _total = -1;
        public decimal Total
        {
            get
            {
                if (Orders == null && _total > -1)
                    return _total;
                return GetOrders().Sum((Order item) => item.Subtotal);
            }
        }

        public decimal Change
        {
            get
            {
                return Cash - Total;
            }
        }

        List<Order> Orders = null;
        User Cashier = null;

        public Transaction(List<Order> Orders, User Cashier)
        {
            this.Orders = Orders;
            this.Cashier = Cashier;
            this.CashierId = Cashier.Id;
        }

        public Transaction(decimal total)
        {
            this._total = total;
        }

        public User GetCashier()
        {
            if (Cashier == null) Cashier = User.Find(CashierId);
            return Cashier;
        }

        public List<Order> GetOrders()
        {
            if (Orders == null) Orders = Order.GetAll(TransactionCode);
            return Orders;
        }

        public void Save()
        {
            GenerateId();
            using (var cmd = DatabaseModel.CreateCommand("INSERT INTO transactions (TransactionCode,CashierId,cash,CafeTableId ) VALUES (@p1, @p2,@p3,@p4)"))
            {
                DatabaseModel.BindParameters(cmd, TransactionCode, Cashier.Id, Cash,CafeTableId);
                DatabaseModel.GetConnection().Open();
                cmd.ExecuteNonQuery();
                DatabaseModel.GetConnection().Close();
            }
            Orders.ForEach((Order item) => item.Save(TransactionCode));
        }
        public void Save2(string transCode)
        {
            Orders.ForEach((Order item) => item.Save(transCode));
        }
        public static void Delete(string transCode)
        {
            using (var cmd = DatabaseModel.CreateCommand("Delete Transactions WHERE TransactionCode =@p1"))
            {
                DatabaseModel.BindParameters(cmd,transCode);
                DatabaseModel.GetConnection().Open();
                cmd.ExecuteNonQuery();
                DatabaseModel.GetConnection().Close();
            }
        }

        private void GenerateId()
        {
            string result = string.Format("{0}_{1:N}", "KPN", Guid.NewGuid()).Substring(0, 12).ToUpper();
            TransactionCode = result;
        }

        public static List<Transaction> GetTransactions(DateTime date)
        {
            var result = new List<Transaction>();
            //using (var cmd = Database.CreateCommand("SELECT * FROM  TransactionsView  WHERE FIX( date_created )=@p1"))
            //Between Convert(date,'2022-07-22') and Convert(date,GETDATE()+1)
            using (var cmd = DatabaseModel.CreateCommand("SELECT * FROM  Transactions Where Date Between Convert(date,'"+ DatabaseModel.GetProvider().FormatShortDate(date) + "') AND Convert(date,'" + DatabaseModel.GetProvider().FormatShortDate(date.AddDays(1)) + "') "))
            {
                DatabaseModel.BindParameters(cmd, DatabaseModel.GetProvider().FormatShortDate(date));
                DatabaseModel.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) result.Add(ConvertReaderToTransaction(reader));
                }
                DatabaseModel.GetConnection().Close();
            }
            return result;
        }

        public static List<Transaction> GetAllTransactions()
        {
            var result = new List<Transaction>();
            using (var cmd = DatabaseModel.CreateCommand("SELECT * FROM  Transactions"))
            {
                DatabaseModel.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) result.Add(ConvertReaderToTransaction(reader));
                }
                DatabaseModel.GetConnection().Close();
            }
            return result;
        }

        private static Transaction ConvertReaderToTransaction(DbDataReader reader)
        {
            return new Transaction(reader.GetDecimal(3))
            {
                Id = reader.GetInt32(0),
                CashierId = reader.GetInt32(4),
                Date = reader.GetDateTime(2),
                Cash = reader.GetDecimal(3),
                CafeTableId = reader.GetInt32(5),
                TransactionCode = reader.GetString(1),
            };
        }
    }
}
