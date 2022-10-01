using System;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ObjectBinding;
using System.Windows.Forms;
using FastFoodPOS.Models;
using Entities.Tools;

namespace CoreTech.Reports.Fatura
{
    partial class rptBilgiFisi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBilgiFisi(Transaction transaction)
        {
            InitializeComponent();
            try
            {
                lblFisKodu.Text = transaction.TransactionCode;
                lblTarih.Text = DateTime.Now.ToString();
                xrLblFirma.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_EmriBiznesit);
                xrLblAdres.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_Vendi);
                lblNrFiscal.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_NrFiskal);
                lblTVSH.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_NrTVSH);
                lblMobil.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_MobilPronar);
                lblKullaniciAdi.Text = transaction.GetCashier().Fullname;
                ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = transaction.GetOrders() };
                this.DataSource = stokDataSource;
                CalculatedField calcTutar = new CalculatedField();
                this.CalculatedFields.Add(calcTutar);
                calcTutar.Name = "SubTotal";
                calcTutar.Expression = "[Quantity]*[Price]";


             



                XRSummary sumGenelToplam = new XRSummary();
                sumGenelToplam.Func = SummaryFunc.Sum;
                sumGenelToplam.Running = SummaryRunning.Report;
                sumGenelToplam.FormatString = "{0:C2}";

                lblGenelToplam.DataBindings.Add("Text", null, "SubTotal");

                lblGenelToplam.Summary = sumGenelToplam;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
