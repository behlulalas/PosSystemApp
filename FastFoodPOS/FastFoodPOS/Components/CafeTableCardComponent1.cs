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

namespace FastFoodPOS.Components
{
    partial class CafeTableCardComponent1 : UserControl
    {
        public CafeTables cafeTables;

        public event EventHandler<CafeTables> ButtonAddProductClick;
        public event EventHandler<CafeTables> ButtonEditProductClick;

        public CafeTableCardComponent1(CafeTables cafeTables)
        {
            InitializeComponent();
            this.cafeTables = cafeTables;

            ButtonAddProduct.Visible = cafeTables.IsAvailable;
            ButtonEditOrder.Visible = !cafeTables.IsAvailable;
            guna2Panel1.BackColor = cafeTables.IsAvailable ? Color.Green:Color.Red;
            LabelPrice.ForeColor = Color.White;

        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            if (ButtonAddProductClick != null) ButtonAddProductClick(sender, cafeTables);
        }

        private void ProductCardComponent1_Load(object sender, EventArgs e)
        {
            LabelPrice.Text = cafeTables.TableName;
        }

        private void ButtonEditOrder_Click(object sender, EventArgs e)
        {
            if (ButtonEditProductClick != null) ButtonEditProductClick(sender, cafeTables);
        }
    }
}
