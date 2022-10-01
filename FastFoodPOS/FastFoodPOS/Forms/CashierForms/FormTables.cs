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

namespace FastFoodPOS.Forms.CashierForms
{
    partial class FormTables : BaseForm
    {
        List<CafeTables> AllTables;
        User cashier_user = null;

        public FormTables(User logged_in)
        {
            InitializeComponent();

            //Fetch All Tabkes
            AllTables = CafeTables.GetAllTables();

            cashier_user = logged_in;
            TextQuery.Text = "";
            PanelProducts.SuspendLayout();
            DisposeProductsPanel();
            AllTables.ForEach((CafeTables cafeTables) =>
            {
                AddProductComponent(cafeTables);
            });
            PanelProducts.ResumeLayout();
        }
        void AddProductComponent(CafeTables cafeTables)
        {
            var pcc = new CafeTableCardComponent1(cafeTables);
            pcc.ButtonAddProductClick += pcc_ButtonAddProductClick;
            pcc.ButtonEditProductClick += pcc_ButtonEditProductClick;
            PanelProducts.Controls.Add(pcc);
        }
        void pcc_ButtonAddProductClick(object sender, CafeTables e)
        {
            FormCashierPanel.LoadControl(new FormPOS(cashier_user,e));
        }
        void pcc_ButtonEditProductClick(object sender, CafeTables e)
        {
            FormCashierPanel.LoadControl(new FormPOS(cashier_user, e,isEdit:true));
        }
        private void DisposeProductsPanel()
        {
            while (PanelProducts.Controls.Count >= 1)
            {
                PanelProducts.Controls[0].Dispose();
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextQuery.Text.Equals("")) return;
            PanelProducts.SuspendLayout();
            DisposeProductsPanel();
            SearchResult().ForEach((product) => AddProductComponent(product));
            PanelProducts.ResumeLayout();
        }
        private List<CafeTables> SearchResult()
        {
            List<CafeTables> result = AllTables.FindAll((product) => product.ContainsAnd(TextQuery.Text));
            if (result.Count == 0)
                result = AllTables.FindAll((product) => product.ContainsOr(TextQuery.Text));
            return result;
        }

        private void TextQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ButtonSearch.PerformClick();
            }
        }
    }
}
