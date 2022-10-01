using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Tools
{
    public static class ConnectionTool
    {
        public static bool CheckConnection(string conString)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
