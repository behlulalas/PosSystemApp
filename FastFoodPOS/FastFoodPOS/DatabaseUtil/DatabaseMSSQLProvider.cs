using System;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Entities.Tools;
using Admin;

namespace FastFoodPOS.DatabaseUtil
{
    class DatabaseMSSQLProvider : DatabaseProvider
    {

        private SqlConnection connection = null;

        public override DbConnection GetConnection()
        {
            if (connection == null)
            {
                string host = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_ServerName);
                string user = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_UserName);
                string pass = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_Password);
                string gecerliDb = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_GecerliDB);
                string security = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_Security);
                string connection_strng = "SERVER=" + host + ";DATABASE=" + gecerliDb + ";Integrated Security=true;";
                if (security != "1")
                {
                   connection_strng = "SERVER=" + host + ";DATABASE=" + gecerliDb + ";User Id="+user+";Password="+pass+";";
                }
                connection = new SqlConnection(connection_strng);
            }
            return connection;
        }

        public override DbCommand CreateCommand(string query)
        {
            return new SqlCommand(query, GetConnection() as SqlConnection);
        }

        public override void BindParameters(DbCommand _cmd, params object[] parameters)
        {
            SqlCommand cmd = _cmd as SqlCommand;
            cmd.Parameters.Clear();
            cmd.Parameters.Clear();
            for (int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.AddWithValue("@p" + (i + 1), parameters[i]);
            }
        }

        public override bool IsExist(string table, string column, object value)
        {
            bool result = false;
            using (var cmd = CreateCommand("SELECT COUNT(*) FROM " + table + " WHERE " + column + " = '" + value + "'"))
            {
                GetConnection().Open();
                result = int.Parse(cmd.ExecuteScalar().ToString()) > 0;
                GetConnection().Close();
            }
            return result;
        }

        public override void ImportTables()
        {
            using (var cmd = CreateCommand(Properties.Settings.Default.MSSQLTables))
            {
                GetConnection().Open();
                cmd.ExecuteNonQuery();
                GetConnection().Close();
            }
        }
        private static bool CheckDatabaseExists()
        {
            string host = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_ServerName);
            string user = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_UserName);
            string pass = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_Password);
            string security = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_Security);
            string connection_strng = "SERVER=" + host + ";Integrated Security=true;";
            if (security!="1")
            {
                connection_strng = "SERVER=" + host + ";User Id=" + user + ";Password=" + pass + ";";
            }
           
            string sqlCreateDBQuery;
            bool result = false;

            try
            {
                var tmpConn = new SqlConnection(connection_strng);
                var databaseName = "FastFoodPOS";
                sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name= '{0}'", databaseName);

                using (tmpConn)
                {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
                    {
                        tmpConn.Open();

                        object resultObj = sqlCmd.ExecuteScalar();

                        int databaseID = 0;

                        if (resultObj != null)
                        {
                            int.TryParse(resultObj.ToString(), out databaseID);
                        }

                        tmpConn.Close();

                        result = (databaseID > 0);
                    }
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
        public override void CretaDatabaseIfNotExist()
        {
            FrmBaglantiAyarlari frmBaglantiAyarlari = new FrmBaglantiAyarlari();
            if (CheckDatabaseExists()) return;
            else
            {
                frmBaglantiAyarlari.ShowDialog();
            }
            if (!frmBaglantiAyarlari.kaydedildi) return;
            string str;
            string host = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_ServerName);
            string user = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_UserName);
            string pass = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_Password);
            string gecerliDb = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_GecerliDB);
            string security = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_Security);
            string db = "master";
            string connection_strng = "SERVER=" + host + ";DATABASE=" + db + ";Integrated Security=true;";
            if (security != "1")
            {
                connection_strng = "SERVER=" + host + ";DATABASE=" + db + ";User Id=" + user + ";Password=" + pass + ";";
            }
            SqlConnection myConn = new SqlConnection(connection_strng);
            str = "Create Database " + gecerliDb;
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Veritabanı başarıyla oluşturuldu.\nTablolar Aktarıldı.", "Fast Food POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fast Food POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        public override string FormatShortDate(DateTime day)
        {
            return day.ToString("yyyy-MM-dd");
        }

        public override string QUERY_SALES_BETWEEN_1
        {
            get { return "SELECT * FROM Transactions WHERE Date BETWEEN  CAST('@@from' AS DATE) AND CAST('@@to' AS DATE)"; }
        }

        public override string FormatDateTime(DateTime date)
        {
            return date.ToString("YYYY-MM-DD HH:MM:SS");
        }

        public override string QUERY_GET_TRANSACTIONS
        {
            get { return "SELECT * FROM  TransactionsView  WHERE CONVERT(Date,GETDATE())=@p1"; }
        }

        public override string QUERY_GENERATE_TRANSACTION_ID
        {
            get { return "SELECT COUNT(*) FROM  transactions  WHERE CONVERT(Date,GETDATE())=GETDATE()"; }
        }
    }
}
