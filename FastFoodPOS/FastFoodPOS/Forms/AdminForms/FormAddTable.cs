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
    public partial class FormAddTable : UserControl
    {
        List<Validator> validators;
        public FormAddTable()
        {
            InitializeComponent();



            validators = new List<Validator>();
            validators.Add(new Validator(TextName, LabelName, "İsim", "required"));

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(IsValid()){
                CafeTables nProduct = new CafeTables
                {
                    TableName = TextName.Text,
                    TableCode = TextCode.Text,
                    IsAvailable = ToggleAvailability.Checked,
                };
                nProduct.Save();
                Log.AddLog("Yeni Masa Eklendi Masa Adı= " + TextName.Text);
                AlertNotification.ShowAlertMessage("Yeni Masa Eklendi.", AlertNotification.AlertType.SUCCESS);
                LinkBack_LinkClicked(null, null);
            }
        }

        private bool IsValid()
        {
            return validators.All((validator) => validator.IsValid());
        }

        

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TextName.Text = "";
            ToggleAvailability.Checked = true;
            validators.ForEach((validator) => validator.Reset());
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            ParentForm.AcceptButton = ButtonSave;
            TextName.Focus();
        }

        private void LinkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormManageCafeTables());
        }
    }
}
