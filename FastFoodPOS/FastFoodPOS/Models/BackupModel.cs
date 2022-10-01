using Entities.Tools;
using FastFoodPOS.DatabaseUtil;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Data;
using System.Windows.Forms;

namespace FastFoodPOS.Models
{
    public class BackupModel
    {
        public void BackUpData(string konum,out bool isSucces)
        {
            try
            {
                string server = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_ServerName);
                string userName = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_UserName);
                string password = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_Password);
                string databaseName = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_GecerliDB);
                Server dbServer = new Server(new ServerConnection(server));
                dbServer.ConnectionContext.LoginSecure = true;
                Backup dbBackup = new Backup() { Action = BackupActionType.Database, Database = databaseName };
                dbBackup.Devices.AddDevice(konum+"\\" + databaseName+".bak", DeviceType.File);
                //dbServer.BackupDirectory = konum;
                dbBackup.Initialize = true;
                dbBackup.SqlBackupAsync(dbServer);
                isSucces = true;
            }
            catch (System.Exception ex)
            {
                isSucces = false;
                MessageBox.Show(ex.Message);
            }

        }
        public void RestoreData(string fileName, out bool isSuccess)
        {
            try
            {
                string server = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_ServerName);
                string userName = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_UserName);
                string password = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_Password);
                string databaseName = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_GecerliDB);
                Server dbServer = new Server(new ServerConnection(server));
                dbServer.ConnectionContext.LoginSecure = true;
                Restore dbRestore = new Restore() { Database = databaseName, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                dbRestore.Devices.AddDevice(fileName, DeviceType.File);
                dbRestore.SqlRestoreAsync(dbServer);
                isSuccess = true;
            }
            catch (System.Exception ex)
            {
                isSuccess = false;
                MessageBox.Show(ex.Message);
            }

        }
    }
}
