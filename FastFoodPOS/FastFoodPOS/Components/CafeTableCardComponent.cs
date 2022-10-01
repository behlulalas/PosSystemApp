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
using FastFoodPOS.Forms;
using FastFoodPOS.Forms.AdminForms;

namespace FastFoodPOS.Components
{
    partial class CafeTableCardComponent : UserControl
    {
        public CafeTables cafeTables;

        [Browsable(true)]
        [Category("Action")]
        public event EventHandler<CafeTableCardComponent> ButtonUpdateClick;

        [Browsable(true)]
        [Category("Action")]
        public event EventHandler<CafeTableCardComponent> ButtonRemoveClick;

        public CafeTableCardComponent(CafeTables cafeTables)
        {
            InitializeComponent();
            this.cafeTables = cafeTables;
            UpdateData();
        }

        public void UpdateData()
        {
            LabelTableName.Text = cafeTables.TableName;

            if (cafeTables.IsAvailable)
            {
                ButtonSetAvailability.FillColor = Color.Green;
                ButtonSetAvailability.Text = "Durumu: Müsait";
            }
            else
            {
                ButtonSetAvailability.FillColor = Color.DarkRed;
                ButtonSetAvailability.Text = "Durumu: Dolu";
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (this.ButtonUpdateClick != null)
            {
                this.ButtonUpdateClick(sender, this);
            }
        }

        private void ButtonSetAvailability_Click(object sender, EventArgs e)
        {
            DialogResult result = ShowConfirmDialog();
            if (result == DialogResult.Yes)
            {
                if (cafeTables.IsAvailable) Log.AddLog("Masayı[" + cafeTables.TableID + "] kapalı olarak ayarladı.");
                else Log.AddLog("Masayı[" + cafeTables.TableID + "] açık olarak ayarladı.");
                cafeTables.ToggleAvailability();
                AlertNotification.ShowAlertMessage("Masa bilgisi başarıyla güncellendi.", AlertNotification.AlertType.SUCCESS);
                UpdateData();
            }
        }

        private DialogResult ShowConfirmDialog()
        {
            return Dialog.ConfirmDialogBox.ShowDialog(
                cafeTables.IsAvailable
                    ? "Bu Masayı kapatmak istediğinize emin misiniz?"
                    : "Bu Masayı açmak istediğinize emin misiniz?");
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (this.ButtonRemoveClick != null)
            {
                this.ButtonRemoveClick(sender, this);
            }
        }

    }
}
