using Entities.Tools;
using FastFoodPOS.Components;
using FastFoodPOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BackupData
{
    public partial class FrmBackUp : DevExpress.XtraEditors.XtraForm
    {
        string gecerliDB;
        BackupModel backup = new BackupModel();
        public FrmBackUp()
        {
            InitializeComponent();
            try
            {
                txtYedekKonum.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu);
                gecerliDB = SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlari_GecerliDB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            try
            {
                backup.BackUpData(txtYedekKonum.Text, out bool isSuccess);
                if (isSuccess)
                {
                    backgroundIndication();
                    AlertNotification.ShowAlertMessage("Yedekleme işlemi başarılı.", AlertNotification.AlertType.SUCCESS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtYedekKonum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FolderBrowserDialog form = new FolderBrowserDialog();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    txtYedekKonum.Text = form.SelectedPath;
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu, txtYedekKonum.Text);
                    SettingsTool.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Yedekleme Dosyası *.bak|*.bak";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    backup.RestoreData(fileDialog.FileName, out bool isSuccess);
                    if (isSuccess)
                    {
                        backgroundIndication();
                        AlertNotification.ShowAlertMessage("Geri Yükleme işlemi başarılı.", AlertNotification.AlertType.SUCCESS);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void ChangeLabel()
        {
            try
            {
                for (int i = 0; i <= 100; i++)
                {
                    SetLabelText(i);
                    Thread.Sleep(5);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private delegate void SetLabelTextDelegate(int number);
        private void SetLabelText(int number)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new SetLabelTextDelegate(SetLabelText), new object[] { number });
                    return;
                }
                lblInfo.Text = "% " + number.ToString() + " Başarılı.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void backgroundIndication()
        {
            try
            {
                progressBar1.Value = 0;
                lblInfo.Visible = true;
                Thread t = new Thread(new ThreadStart(ChangeLabel));
                t.Start();
                progressBar1.Visible = true;
                progressBar1.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
