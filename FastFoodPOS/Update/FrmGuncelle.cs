using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;
using DevExpress.XtraEditors;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using Update.Tools;

namespace Update
{
    public partial class FrmGuncelle : DevExpress.XtraEditors.XtraForm
    {
        WebClient indir = new WebClient();
        public static bool isRunning(string ProgramAdi)
        {
            try
            {
                return Process.GetProcessesByName(ProgramAdi).Length > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public FrmGuncelle()
        {
            InitializeComponent();
            try
            {
                if (isRunning("FastFoodPOS"))
                {
                    if (MessageBox.Show("Açık olan uygulama kapatılacak?", "Bildiri", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (var item in Process.GetProcessesByName("FastFoodPOS"))
                        {
                            item.CloseMainWindow();
                            item.Kill();
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + "\\temp"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\temp");
                }
                indir.DownloadProgressChanged += (DownloadProgressChangedEventHandler)indirmeDurumu;
                indir.DownloadFileCompleted += (AsyncCompletedEventHandler)indirmeBitti;
                indir.DownloadFileAsync(new Uri(SettingsTool.AyarOku(SettingsTool.Ayarlar.GuncellemeAyarlari_DownloadURL)), Application.StartupPath + "\\temp\\Update.zip");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void indirmeBitti(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                ZipFile.ExtractToDirectory(Application.StartupPath + "\\temp\\Update.zip", Application.StartupPath + "\\temp");
                XElement Dosyalar = XElement.Load(Application.StartupPath + "\\temp\\Liste.xml");
                foreach (var veriler in Dosyalar.Elements().ToList())
                {
                    if (File.Exists(Application.StartupPath + veriler.Element("YuklenecegiKonum").Value))
                    {
                        File.Delete(Application.StartupPath + veriler.Element("YuklenecegiKonum").Value);
                    }
                    File.Copy(Application.StartupPath + "\\temp\\" + veriler.Element("DosyaAdi").Value, Application.StartupPath + veriler.Element("YuklenecegiKonum").Value);

                }
                Directory.Delete(Application.StartupPath + "\\temp", true);
                MessageBox.Show("Güncelleme başarılı.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void indirmeDurumu(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                progressUpdate.Properties.Maximum = (int)e.TotalBytesToReceive;
                progressUpdate.Text = e.BytesReceived.ToString();
                lblIndirilen.Text = $"{(Convert.ToDecimal(e.BytesReceived) / 1024 / 1024).ToString("N2")} MB\\{(Convert.ToDecimal(e.TotalBytesToReceive) / 1024 / 1024).ToString("N2")} MB";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
