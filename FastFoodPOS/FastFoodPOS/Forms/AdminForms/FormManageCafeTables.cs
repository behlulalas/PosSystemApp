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

namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormManageCafeTables : UserControl, IKeepable
    {
        List<CafeTables> AllTables;
        Button submit;

        public FormManageCafeTables()
        {
            init();
        }

        void init()
        {
            InitializeComponent();
            submit = new Button();
            submit.Click += ButtonSearch_Click;
            AllTables = CafeTables.GetAllTables();
            TextSearch.Text = "";
            flowLayoutPanel1.Visible = false;
            DisposePanelContent();
            AllTables.ForEach((CafeTables cafeTables) =>
            {
                AddProductComponent(cafeTables);
            });
            flowLayoutPanel1.Visible = true;
        }

        void pcc_ButtonRemoveClick(object sender, CafeTableCardComponent e)
        {
            DialogResult result = Dialog.ConfirmDialogBox.ShowDialog("Bu masayı silmek istediğinize emin misiniz?");
            if (result == DialogResult.Yes)
            {
                //e.cafeTables.Remove();
                AlertNotification.ShowAlertMessage("Masa başarıyla silindi", AlertNotification.AlertType.SUCCESS);
                AllTables.Remove(e.cafeTables);
                e.Dispose();
            }
        }

        void pcc_ButtonUpdateClick(object sender, CafeTableCardComponent e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormUpdateCafeTable(e));
        }


        private void DisposePanelContent()
        {
            while (flowLayoutPanel1.Controls.Count >= 1)
            {
                flowLayoutPanel1.Controls[0].Dispose();
            }
        }


        public bool ShouldKeepForm { get; set; }

        public void OnMounted()
        {
            ParentForm.AcceptButton = submit;
        }

        public void OnUnMounted(ref UserControl next)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            flowLayoutPanel1.Focus();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (TextSearch.Text == "") return;

            flowLayoutPanel1.SuspendLayout();
            DisposePanelContent();
            var result = SearchResult();
            result.ForEach((product) => AddProductComponent(product));
            flowLayoutPanel1.ResumeLayout();

            AlertNotification.ShowAlertMessage(result.Count + " öğe bulundu.", AlertNotification.AlertType.INFO);

        }

        private void AddProductComponent(CafeTables cafeTables)
        {
            CafeTableCardComponent pcc = new CafeTableCardComponent(cafeTables);
            pcc.ButtonUpdateClick += pcc_ButtonUpdateClick;
            pcc.ButtonRemoveClick += pcc_ButtonRemoveClick;
            flowLayoutPanel1.Controls.Add(pcc);
        }

        private List<CafeTables> SearchResult()
        {
            List<CafeTables> result = AllTables.FindAll((cafeTables) => cafeTables.ContainsAnd(TextSearch.Text));
            if (result.Count == 0)
                result = AllTables.FindAll((cafeTables) => cafeTables.ContainsOr(TextSearch.Text));
            if (result.Count >= 16)
                result.RemoveRange(15, result.Count - 15);
            return result;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormAddTable());
        }
    }
}
