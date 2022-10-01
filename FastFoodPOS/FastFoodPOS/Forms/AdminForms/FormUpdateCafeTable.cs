using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodPOS.Models;
using FastFoodPOS.Components;

namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormUpdateCafeTable : UserControl, IKeepable
    {
        CafeTableCardComponent pcc;
        CafeTables cafeTables;
        Validator NameValidator;
        public FormUpdateCafeTable(CafeTableCardComponent pcc)
        {
            InitializeComponent();
            this.pcc = pcc;
            this.cafeTables = pcc.cafeTables;
            NameValidator = new Validator(TextName, LabelName, "İsim", "required");
            ResetData();            
        }

        void ResetData()
        {
            TextName.Text = cafeTables.TableName;
            TextCode.Text = cafeTables.TableCode;
            NameValidator.Reset();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormManageCafeTables());
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(NameValidator.IsValid())
            {
                CafeTables uCafeTable = cafeTables.Clone();
                uCafeTable.TableName = TextName.Text;
                uCafeTable.TableCode = TextCode.Text;
                uCafeTable.IsAvailable = ToggleAvailability.Checked;
                uCafeTable.TransactionCode = "";
                uCafeTable.Update();
                cafeTables.Copy(uCafeTable);

                Log.AddLog("Masalar üzerinde değişiklik yapıldı[" + uCafeTable.TableID+"]");

                AlertNotification.ShowAlertMessage("Masa bilgisi başarıyla güncellendi.", AlertNotification.AlertType.SUCCESS);

                ButtonBack.PerformClick();
            }
        }

        public bool ShouldKeepForm { get; set; }

        public void OnMounted()
        {

        }

        public void OnUnMounted(ref UserControl next)
        {

        }
    }
}
