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
    partial class ProductCardComponent : UserControl
    {
        public Product product;

        [Browsable(true)]
        [Category("Action")]
        public event EventHandler<ProductCardComponent> ButtonUpdateClick;

        [Browsable(true)]
        [Category("Action")]
        public event EventHandler<ProductCardComponent> ButtonRemoveClick;

        public ProductCardComponent(Product product)
        {
            InitializeComponent();
            this.product = product;
            UpdateData();
        }

        public void UpdateData()
        {
            PictureProductImage.ImageLocation = product.Image;
            LabelProductName.Text = product.Name;
            LabelPrice.Text = product.Price + "€";

            if (product.IsAvailable)
            {
                ButtonSetAvailability.FillColor = Color.FromArgb(179, 15, 25);
                ButtonSetAvailability.Text = "Stok: Mevcut";
            }
            else
            {
                ButtonSetAvailability.FillColor = Color.Gray;
                ButtonSetAvailability.Text = "Stok: Mevcut Değil";
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
                if (product.IsAvailable) Log.AddLog("Ürünü[" + product.Id + "] kapalı olarak ayarla.");
                else Log.AddLog("Ürünü[" + product.Id + "] açık olarak ayarla");
                product.ToggleAvailability();
                AlertNotification.ShowAlertMessage("Ürün başarıyla güncellendi.", AlertNotification.AlertType.SUCCESS);
                UpdateData();
            }
        }

        private DialogResult ShowConfirmDialog()
        {
            return Dialog.ConfirmDialogBox.ShowDialog(
                product.IsAvailable
                    ? "Bu ürünü kapatmak istediğinize emin misiniz?"
                    : "Bu ürünü açmak istediğinize emin misiniz?");
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
