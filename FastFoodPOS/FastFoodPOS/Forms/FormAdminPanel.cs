using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodPOS.Forms.AdminForms;
using Guna.UI2.WinForms;
using FastFoodPOS.Models;
using CoreTech.Forms;
using Entities.Tools;
using System.Net;
using System.Reflection;
using System.Diagnostics;

namespace FastFoodPOS.Forms
{
    partial class FormAdminPanel : BaseForm
    {
        User LoggedInUser = null;

        private static FormAdminPanel Instance;

        public static FormAdminPanel GetInstance()
        {
            return Instance;
        }

        public FormAdminPanel(User _LoggedInUser)
        {
            InitializeComponent();

            Instance = this;
            LoggedInUser = _LoggedInUser;
            label3.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_EmriBiznesit)+" POS Sistemi";



        }

        public override void OnLoad()
        {
            Reset();

            ButtonDashboard.PerformClick();
        }

        private void Reset()
        {
            PictureUserImage.Image = Util.GetImageFromFile(LoggedInUser.Image);
            LabelUserName.Text = LoggedInUser.Fullname;
            LabelUserRole.Text = LoggedInUser.Role;

            if (LoggedInUser.Role == "SubAdministrator")
            {
                ButtonUsers.Visible = false;
                ButtonArchives.Visible = false;
            }

        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            Guna2Button ButtonMenu = (Guna2Button)sender;

            switch (Convert.ToInt16(ButtonMenu.Tag))
            {
                case 1:
                    LoadFormControl(new FormDashboard());
                    break;
                case 3:
                    LoadFormControl(new FormManageProducts());
                    break;
                case 4:
                    LoadFormControl(new FormTransactions());
                    break;
                case 5:
                    LoadFormControl(new FormSalesReport());
                    break;
                case 6:
                    LoadFormControl(new FormUsers());
                    break;
                case 7:
                    LoadFormControl(new FormProductArchive());
                    break;
                case 8:
                    LoadFormControl(new FormManageCafeTables());
                    break;
            }

        }

        public void LoadFormControl(UserControl uc)
        {
            ParentForm.AcceptButton = null;
            DisposeAdminForm(ref uc);

            IKeepable ucKeepable = uc as IKeepable;
            
            uc.Dock = DockStyle.Fill;
            panel5.Controls.Add(uc);

            if (ucKeepable != null) ((IKeepable)uc).OnMounted();
        }

        private void DisposeAdminForm(ref UserControl next)
        {
            while (panel5.Controls.Count >= 1)
            {
                IKeepable ucToRemove = panel5.Controls[0] as IKeepable;
                if (ucToRemove != null)
                {
                    ucToRemove.OnUnMounted(ref next);
                    if (ucToRemove.ShouldKeepForm)
                        panel5.Controls.RemoveAt(0);
                    else
                        panel5.Controls[0].Dispose();
                }
                else
                {
                    panel5.Controls[0].Dispose();
                }
            }
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            if(Dialog.ConfirmDialogBox.ShowDialog("Çıkış yapmak istediğinize emin misiniz?") == DialogResult.Yes)
                MainForm.LoadForm(new FormAdminLogin());
        }

        private void ButtonUpdateInfo_Click(object sender, EventArgs e)
        {
            FormUpdateCurrentUser fuu = new FormUpdateCurrentUser(LoggedInUser);
            fuu.OnUpdate_Success += fuu_OnUpdate_Success;
            LoadFormControl(fuu);
            foreach (Guna2Button btn in ButtonsMenuPanel.Controls)
            {
                if (btn.Checked) btn.Checked = false;
            }
        }

        void fuu_OnUpdate_Success(object sender, User e)
        {
            this.LoggedInUser = e;
            User.CurrentUser = e;
            Reset();
            ButtonDashboard.PerformClick();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }

        private void ButtonUpdateSoftware_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient indir = new WebClient();

                string programVersion = Assembly.Load("FastFoodPOS").GetName().Version.ToString();
                string guncelVersion = indir.DownloadString(SettingsTool.AyarOku(SettingsTool.Ayarlar.GuncellemeAyarlari_VersionURL));
                if (programVersion != guncelVersion)
                {
                    Process.Start($"{Application.StartupPath}\\Update.exe");
                }
                else
                {
                    MessageBox.Show("Uygulamanız güncel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
