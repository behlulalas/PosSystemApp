using ClosedXML.Excel;
using FastFoodPOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS.Dialog
{
    partial class OrderDetail : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public OrderDetail(List<Order> orders)
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            label1.Text = orders.First().TransactionCode ?? "";
            RefreshOrders(orders);
        }
        void RefreshOrders(List<Order> orders)
        {
            int proccesCount = 0;
            decimal total = 0;
            DataGridViewTransaction.Rows.Clear();
            orders.ForEach((Order order) =>
            {
                proccesCount++;
                var product = Product.Find(order.ProductId);
                order.product = product;
                DataGridViewTransaction.Rows.Add(
                    "#" + proccesCount,
                    order.GetProduct().Name,
                    order.Quantity,
                    order.Price,
                    order.Subtotal + "€"
                );
                total += order.Subtotal;
            });
            if (orders.Count == 0)
            {
                DataGridViewTransaction.Rows.Add("Seçilen tarihte işlem yok.");
            }
            labelTotalSatis.Text = total.ToString() + "€";
        }
        private void ButtonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
