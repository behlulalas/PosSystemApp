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
using Guna.UI2.WinForms;
using FastFoodPOS.ErrorHandler;
using FastFoodPOS.Forms.CashierForms;
using CoreTech.Reports.Fatura;
using CoreTech.Forms.RaportViewer;
using Entities.Tools;

namespace FastFoodPOS.Forms.CashierForms
{
    partial class FormPOS : BaseForm
    {
        decimal Total;
        List<Product> AllProducts;
        List<Order> AllOrders;
        public BindingList<OrderItemComponent> OrderComponents;
        User cashier_user = null;
        CafeTables _cafeTables;
        bool _isEdit;
        public FormPOS(User logged_in, CafeTables cafeTables, bool isEdit = false)
        {
            InitializeComponent();
            _isEdit = isEdit;
            _cafeTables = cafeTables;
            label1.Text += " | " + cafeTables.TableName;
            //Fetch All Products
            AllProducts = Product.GetAllProducts();

            //Initialized  Binding Source
            OrderComponents = new BindingList<OrderItemComponent>();
            OrderComponents.ListChanged += Orders_ListChanged;


            cashier_user = logged_in;

            //Reset Order
            Reset();
            if (isEdit)
            {
                ButtonClear.Text = "Sipariş'i Güncelle";
                AllOrders = Order.GetAll(cafeTables.TransactionCode);
                foreach (var item in AllOrders)
                {
                    var product = Product.Find(item.ProductId);
                    item.product = product;
                    OrderItemComponent oic = new OrderItemComponent(OrderComponents, item);
                    oic.OnOrderIncrement += pcc_IncrementOrder;
                    OrderComponents.Add(oic);
                    PanelOrders.Controls.Add(oic);
                    oic.BringToFront();
                }
            }
            //Select Food
            ButtonFoods.PerformClick();
        }

        void Orders_ListChanged(object sender, ListChangedEventArgs e)
        {
            Total = 0;
            foreach (OrderItemComponent oc in OrderComponents)
            {
                Total += oc._Order.Subtotal;
            }
            LabelTotal.Text = Total.ToString() + "€";
            LabelChange.Text = "--";
            TextPayment.Value = Total;
        }

        public OrderItemComponent AddOrderComponent(Product item)
        {
            Order order = new Order(item);
            OrderItemComponent oic = new OrderItemComponent(OrderComponents, order);
            oic.OnOrderIncrement += pcc_IncrementOrder;
            OrderComponents.Add(oic);
            PanelOrders.Controls.Add(oic);
            oic.BringToFront();
            //Orders.Add(order);
            return oic;
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            TextQuery.Text = "";
            PanelProducts.SuspendLayout();
            DisposeProductsPanel();
            string filter = ((Guna2Button)sender).Tag.ToString();
            AllProducts.ForEach((Product product) =>
            {
                if (product.Category.Equals(filter))
                {
                    AddProductComponent(product);
                }
            });
            PanelProducts.ResumeLayout();
        }

        void AddProductComponent(Product product)
        {
            var pcc = new ProductCardComponent1(product);
            pcc.ButtonAddProductClick += pcc_ButtonAddProductClick;
            PanelProducts.Controls.Add(pcc);
        }

        void pcc_ButtonAddProductClick(object sender, Product e)
        {
            var oic = OrderComponents.FirstOrDefault((OrderItemComponent item) => item._Order.ProductId == e.Id);
            if (oic == null)
            {
                oic = AddOrderComponent(e);
                oic.UpdateData();
            }
            else
            {
                pcc_IncrementOrder(1, oic);
            }
        }

        void pcc_IncrementOrder(object sender, OrderItemComponent e)
        {
            e._Order.Quantity += Convert.ToInt32(sender);
            if (e._Order.Quantity < 1)
            {
                OrderComponents.Remove(e);
                e.Dispose();
            }
            else
            {
                e.UpdateData();
                OrderComponents.ResetBindings();
            }
        }

        private void DisposeProductsPanel()
        {
            while (PanelProducts.Controls.Count >= 1)
            {
                PanelProducts.Controls[0].Dispose();
            }
        }

        private void Reset()
        {
            foreach (var item in OrderComponents)
            {
                item.Dispose();
            }
            OrderComponents.Clear();
            TextPayment.Text = "";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            #region EskiKod
            //if (OrderComponents.Count == 0) return;
            //var result = Dialog.ConfirmDialogBox.ShowDialog("Siparişi temizlemek istediğinize emin misiniz??");
            ////var result = MessageBox.Show("Are you sure to clear order?", "Confirm", MessageBoxButtons.OKCancel);
            //if (result == DialogResult.Yes)
            //    Reset();
            #endregion

            if (OrderComponents.Count == 0) return;
            try
            {
                GetChange();
                if (!_isEdit)
                {
                    var transaction = new Transaction(GetOrders(), User.CurrentUser)
                    {
                        Date = DateTime.Now,
                        Cash = Total,
                        CafeTableId = _cafeTables.TableID,
                    };
                    transaction.Save();
                    CafeTables uCafeTable = _cafeTables.Clone();
                    uCafeTable.IsAvailable = false;
                    uCafeTable.TransactionCode = transaction.TransactionCode;
                    uCafeTable.Update();
                    _cafeTables.Copy(uCafeTable);
                    Log.AddLog(_cafeTables.TableName + " adlı masaya müşteri geldi ve Siparişler alındı.");
                    AlertNotification.ShowAlertMessage("Masa siparişi başarıyla alındı.", AlertNotification.AlertType.SUCCESS);
                    FormCashierPanel.LoadControl(new FormTables(cashier_user));
                }
                else
                {
                    Transaction.Delete(_cafeTables.TransactionCode);
                    Order.Delete(_cafeTables.TransactionCode);
                    var transaction2 = new Transaction(GetOrders(), User.CurrentUser);
                    transaction2.CafeTableId = _cafeTables.TableID;
                    transaction2.Date = DateTime.Now;
                    transaction2.Cash = Total;
                    transaction2.Save();
                    CafeTables uCafeTable = _cafeTables.Clone();
                    uCafeTable.IsAvailable = false;
                    uCafeTable.TransactionCode = transaction2.TransactionCode;
                    uCafeTable.Update();
                    _cafeTables.Copy(uCafeTable);
                    Log.AddLog(_cafeTables.TableName + " adlı masanın Siparişleri Güncellendi.");
                    AlertNotification.ShowAlertMessage("Masa siparişi başarıyla güncellendi.", AlertNotification.AlertType.SUCCESS);
                    FormCashierPanel.LoadControl(new FormTables(cashier_user));
                }
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }

        }

        private decimal GetChange()
        {
            decimal change = TextPayment.Value - Total;
            if (change < 0) throw new Level1Exception("Ödemeniz " + Math.Abs(change) + "€ yetersiz.");
            return change;
        }

        private void ButtonCalculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                LabelChange.Text = GetChange().ToString() + "€";
            }
            catch (Level1Exception ex)
            {
                ex.DisplayMessage();
            }
        }
        private void FisiKaydet(ReportsPrintTool.Belge belge)
        {
            try
            {
                switch (belge)
                {
                    case ReportsPrintTool.Belge.Fatura:
                        break;
                    case ReportsPrintTool.Belge.BilgiFisi:
                        
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ButtonProccess_Click(object sender, EventArgs e)
        {
            if (OrderComponents.Count == 0) return;


            if (!_isEdit)
            {
                var transaction = new Transaction(GetOrders(), User.CurrentUser)
                {
                    Date = DateTime.Now,
                    Cash = Total,
                    CafeTableId = _cafeTables.TableID,
                };
                transaction.Save();
                CafeTables uCafeTable = _cafeTables.Clone();
                uCafeTable.IsAvailable = true;
                uCafeTable.TransactionCode = "";
                uCafeTable.Update();
                _cafeTables.Copy(uCafeTable);
                int ayarFis = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari));
                if (ayarFis != 3)
                {
                    ReportsPrintTool yazdirBilgiFisi = new ReportsPrintTool();
                    rptBilgiFisi bilgiFisi = new rptBilgiFisi(transaction);
                    yazdirBilgiFisi.RaporYazdir(bilgiFisi, ReportsPrintTool.Belge.BilgiFisi);
                }
            }
            else
            {
                Transaction.Delete(_cafeTables.TransactionCode);
                Order.Delete(_cafeTables.TransactionCode);
                var transaction2 = new Transaction(GetOrders(), User.CurrentUser);
                transaction2.CafeTableId = _cafeTables.TableID;
                transaction2.Date = DateTime.Now;
                transaction2.Cash = Total;
                transaction2.Save();
                CafeTables uCafeTable = _cafeTables.Clone();
                uCafeTable.IsAvailable = true;
                uCafeTable.TransactionCode = "";
                uCafeTable.Update();
                _cafeTables.Copy(uCafeTable);
                int ayarFis = Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazdirmaAyari));
                if (ayarFis != 3)
                {
                    ReportsPrintTool yazdirBilgiFisi = new ReportsPrintTool();
                    rptBilgiFisi bilgiFisi = new rptBilgiFisi(transaction2);
                    yazdirBilgiFisi.RaporYazdir(bilgiFisi, ReportsPrintTool.Belge.BilgiFisi);
                }
                
            }
            Log.AddLog(_cafeTables.TableName + " adlı masanın hesabı kapatıldı.");
            AlertNotification.ShowAlertMessage("Masa hesabı başarıyla alındı.", AlertNotification.AlertType.SUCCESS);
            FormCashierPanel.LoadControl(new FormTables(cashier_user));

        }

        private List<Order> GetOrders()
        {
            var orders = new List<Order>();
            foreach (var item in OrderComponents)
                orders.Add(item._Order);
            return orders;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextQuery.Text.Equals("")) return;

            foreach (Guna2Button menu in ButtonsMenu.Controls)
                menu.Checked = false;

            PanelProducts.SuspendLayout();
            DisposeProductsPanel();
            SearchResult().ForEach((product) => AddProductComponent(product));
            PanelProducts.ResumeLayout();
        }

        private List<Product> SearchResult()
        {
            List<Product> result = AllProducts.FindAll((product) => product.ContainsAnd(TextQuery.Text));
            if (result.Count == 0)
                result = AllProducts.FindAll((product) => product.ContainsOr(TextQuery.Text));
            return result;
        }

        private void ButtonIptal_Click(object sender, EventArgs e)
        {
            FormCashierPanel.LoadControl(new FormTables(cashier_user));
        }
    }
}
