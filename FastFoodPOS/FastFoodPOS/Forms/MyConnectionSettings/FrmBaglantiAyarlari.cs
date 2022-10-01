using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using Entities.Tools;
using FastFoodPOS.DatabaseUtil;
using FastFoodPOS.Tools;

namespace Admin
{
    public partial class FrmBaglantiAyarlari : DevExpress.XtraEditors.XtraForm
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public bool kaydedildi = false;
        public FrmBaglantiAyarlari()
        {
            InitializeComponent();
            try
            {
                CreateConnectionString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateConnectionString()
        {
            try
            {
                builder.DataSource = txtServer.Text;
                builder.InitialCatalog = "master";
                if (chkWindows.Checked)
                {
                    builder.IntegratedSecurity = true;
                }
                else
                {
                    builder.UserID = txtKullaniciAdi.Text;
                    builder.Password = txtParola.Text;
                    builder.IntegratedSecurity = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTestEt_Click(object sender, EventArgs e)
        {
            try
            {
                CreateConnectionString();
                builder.InitialCatalog = "master";
                if (ConnectionTool.CheckConnection(builder.ConnectionString))
                {
                    MessageBox.Show("Bağlantı Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bağlantı Hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        private void chkSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkSqlServer.Checked)
                {
                    txtKullaniciAdi.Enabled = true;
                    txtParola.Enabled = true;
                }
                else
                {
                    txtKullaniciAdi.Enabled = false;
                    txtParola.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                CreateConnectionString();
                builder.InitialCatalog = "master";
                if (ConnectionTool.CheckConnection(builder.ConnectionString)&& TextDatabase.Text!=null)
                {

                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_BaglantiCumlesi, builder.ConnectionString);
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_ServerName, txtServer.Text);
                    
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_GecerliDB, TextDatabase.Text);
                    if (chkSqlServer.Checked)
                    {
                        SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_Security, "0");
                        SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_UserName, txtKullaniciAdi.Text);
                        SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_Password, txtParola.Text);
                    }
                    else
                    {
                        SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_Security, "1");
                        SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_UserName, "sa");
                        SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DatabaseAyarlari_Password, "123456");
                    }
                    SettingsTool.Save();

                    kaydedildi = true;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Bağlantı Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void FrmBaglantiAyarlari_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!kaydedildi)
                {
                    MessageBox.Show("Pencereyi Kapattığınız için ayarlar kaydedilmedi.");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}