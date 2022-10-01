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
using Entities.Tools;
using System.Printing;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace CoreTech.Forms
{
    public partial class FrmSettings : DevExpress.XtraEditors.XtraForm
    {

        public FrmSettings()
        {
            InitializeComponent();
            try
            {
                navigationPane1.SelectedPage = navFirma;
                cmbBilgiFisiYazici.Properties.Items.AddRange(YaziciListesi());
                cmbFaturaYazici.Properties.Items.AddRange(YaziciListesi());
                cmbFaturaAyari.SelectedIndex = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari));
                cmbFaturaYazici.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);
                cmbBilgiFisiAyari.SelectedIndex = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari));
                cmbBilgiFisiYazici.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);
                txtNrRegjistrim.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_NrBiznes);
                txtNumriFiskal.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_NrFiskal);
                txtNumriTvsh.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_NrTVSH);
                txtEmrieBiznesit.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_EmriBiznesit);
                txtVendi.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_Vendi);
                txtMobilPronar.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_MobilPronar);
                txtDownloadURL.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.GuncellemeAyarlari_DownloadURL);
                txtVersionURL.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.GuncellemeAyarlari_VersionURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<string> YaziciListesi()
        {
            try
            {
                return new LocalPrintServer().GetPrintQueues().Select(c => c.Name).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazdirmaAyari, cmbFaturaAyari.SelectedIndex.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici, cmbFaturaYazici.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari, cmbBilgiFisiAyari.SelectedIndex.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici, cmbBilgiFisiYazici.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FirmaAyarlari_NrBiznes, txtNrRegjistrim.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FirmaAyarlari_NrFiskal, txtNumriFiskal.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FirmaAyarlari_NrTVSH, txtNumriTvsh.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FirmaAyarlari_EmriBiznesit, txtEmrieBiznesit.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FirmaAyarlari_Vendi, txtVendi.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FirmaAyarlari_MobilPronar, txtMobilPronar.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.GuncellemeAyarlari_DownloadURL, txtDownloadURL.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.GuncellemeAyarlari_VersionURL, txtVersionURL.Text);
                SettingsTool.Save();
                MessageBox.Show("Ayarlar başarıyla Değiştirildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}