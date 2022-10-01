using FastFoodPOS.DatabaseUtil;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class CafeTables
    {
        public int TableID { get; set; }
        public string TableCode { get; set; }
        public string TableName { get; set; }
        public string TransactionCode { get; set; }
        public bool IsAvailable { get; set; }

        public CafeTables Clone()
        {
            return new CafeTables
            {
                TableID = this.TableID,
                TableCode = this.TableCode,
                TableName = this.TableName,
                TransactionCode = this.TransactionCode,
                IsAvailable = this.IsAvailable,
            };
        }

        public void Copy(CafeTables cafeTables)
        {
            this.TableID = cafeTables.TableID;
            this.TableCode = cafeTables.TableCode;
            this.TableName = cafeTables.TableName;
            this.TransactionCode = cafeTables.TransactionCode;
            this.IsAvailable = cafeTables.IsAvailable;

        }

        public void Save()
        {
            using (var cmd = DatabaseModel.CreateCommand("INSERT INTO  CafeTables ( TableName ,  TableCode ,  IsAvailable) VALUES (@p1, @p2, @p3)"))
            {
                DatabaseModel.BindParameters(cmd, TableName, TableCode,IsAvailable);
                DatabaseModel.GetConnection().Open();
                cmd.ExecuteNonQuery();
                DatabaseModel.GetConnection().Close();
            }
        }

        public bool ContainsOr(string query)
        {
            query = query.ToUpper();
            string[] words = query.Split(' ');
            string product = (TableCode + TableName).ToUpper();
            return words.Any((word) => product.Contains(word));
        }

        public bool ContainsAnd(string query)
        {
            query = query.ToUpper();
            string[] words = query.Split(' ');
            string product = (TableCode + TableName).ToUpper();
            return words.All((word) => product.Contains(word));
        }

        public void ToggleAvailability()
        {
            this.IsAvailable = !this.IsAvailable;
            Update();
        }


        public void Recover()
        {
            this.IsAvailable = false;
            Update();
        }


        public void Update()
        {
            using (var cmd = DatabaseModel.CreateCommand("UPDATE  CafeTables  SET  TableName =@p1,TableCode =@p2,IsAvailable =@p3, TransactionCode=@p4 WHERE  TableID =@p5"))
            {
                DatabaseModel.BindParameters(cmd, TableName, TableCode, IsAvailable, TransactionCode,TableID);
                DatabaseModel.GetConnection().Open();
                cmd.ExecuteNonQuery();
                DatabaseModel.GetConnection().Close();
            }
        }

        public static CafeTables Find(int id)
        {
            CafeTables result = null;
            using (var cmd = DatabaseModel.CreateCommand("SELECT * FROM  CafeTables  WHERE  TableID =@p1"))
            {
                DatabaseModel.BindParameters(cmd, id);
                DatabaseModel.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) result = ConvertReaderToProduct(reader);
                }
                DatabaseModel.GetConnection().Close();
            }
            return result;
        }

        public static List<CafeTables> GetAllTables()
        {
            List<CafeTables> result = new List<CafeTables>();
            using (var cmd = DatabaseModel.CreateCommand("SELECT * FROM  CafeTables"))
            {
                DatabaseModel.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(ConvertReaderToProduct(reader));
                    }
                }
                DatabaseModel.GetConnection().Close();
            }
            return result;
        }

        public static CafeTables ConvertReaderToProduct(DbDataReader reader)
        {
            CafeTables result = new CafeTables
            {
                TableID = reader.GetInt32(0),
                TableCode = reader.GetString(1),
                TableName = reader.GetString(2),
                TransactionCode = reader.IsDBNull(3) ? null : reader.GetString(3),
                IsAvailable = reader.GetBoolean(4),
            };
            return result;
        }
    }
}
