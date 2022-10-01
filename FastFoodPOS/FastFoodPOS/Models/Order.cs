using FastFoodPOS.DatabaseUtil;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string TransactionCode { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }



        public decimal Subtotal
        {
            get
            {
                return Quantity * Price;
            }
        }

        public Product product = null;
        public string ProductName
        {
            get
            {
                return product.Name;
            }
        }
        public Order(Product product)
        {
            this.product = product;
            this.ProductId = product.Id;
            this.Quantity = 1;
            this.Price = product.Price;
        }

        public Order()
        {
            // TODO: Complete member initialization
        }

        public void Save(string transactionCode)
        {
            using (var cmd = DatabaseModel.CreateCommand("INSERT INTO  orders ( ProductId ,  TransactionCode ,  quantity ,  price ) VALUES (@p1, @p2, @p3, @p4)"))
            {
                DatabaseModel.BindParameters(cmd, ProductId, transactionCode, Quantity, Price);
                DatabaseModel.GetConnection().Open();
                cmd.ExecuteNonQuery();
                DatabaseModel.GetConnection().Close();
            }
        }
        public static void Delete(string transCode)
        {
            using (var cmd = DatabaseModel.CreateCommand("Delete Orders WHERE  TransactionCode=@p1"))
            {
                DatabaseModel.BindParameters(cmd, transCode);
                DatabaseModel.GetConnection().Open();
                cmd.ExecuteNonQuery();
                DatabaseModel.GetConnection().Close();
            }
        }
        public Product GetProduct()
        {
            if (product == null)
            {
                product = Product.Find(Id);
            }
            return product;
        }

        public static List<Order> GetAll()
        {
            var result = new List<Order>();
            using (var cmd = DatabaseModel.CreateCommand("SELECT * FROM  Orders"))
            {
                DatabaseModel.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        result.Add(ConvertReaderToOrder(reader));
                }
                DatabaseModel.GetConnection().Close();
            }
            return result;
        }

        public static List<Order> GetAll(string transactionCode)
        {
            var result = new List<Order>();
            using (var cmd = DatabaseModel.CreateCommand("SELECT * FROM  orders  WHERE  TransactionCode =@p1"))
            {
                DatabaseModel.BindParameters(cmd, transactionCode);
                DatabaseModel.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        result.Add(ConvertReaderToOrder(reader));
                }
                DatabaseModel.GetConnection().Close();
            }
            return result;
        }

        private static Order ConvertReaderToOrder(DbDataReader reader)
        {
            var result = new Order
            {
                Id = reader.GetInt32(0),
                ProductId = reader.GetInt32(1),
                TransactionCode = reader.GetString(2),
                Quantity = reader.GetInt32(3),
                Price = reader.GetDecimal(4)
            };
            return result;
        }

    }
}
