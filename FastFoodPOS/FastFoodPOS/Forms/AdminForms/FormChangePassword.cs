using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodPOS.Components;
using FastFoodPOS.Models;

namespace FastFoodPOS.Forms.AdminForms
{
    public partial class FormChangePassword : UserControl
    {

        List<Validator> validators = new List<Validator>();
        User user;

        public FormChangePassword()
        {
            InitializeComponent();

            user = User.CurrentUser;

            validators.Add(new Validator(TextNewPassword, LabelNewPassword, "Yeni Şifre", "required|min:1"));
            validators.Add(new Validator(TextConfirmPassword, LabelConfirmPassword, "Şifre Tekrarı", "required|min:1|compare") { compare_control = TextNewPassword });
            validators.Add(new Validator(TextOldPassword, LabelOldPassword, "Eski Şifre", "required|min:1"));

        }


        private void LinkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormUpdateCurrentUser(user));
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (validators.Count == validators.Count(validator => validator.IsValid()))
            {
                if (user.Password.Equals(Util.GetHashSHA256(TextOldPassword.Text)))
                {
                    User clone = user.Clone();
                    clone.Password = Util.GetHashSHA256(TextNewPassword.Text.Trim());
                    clone.Update();

                    user.Password = clone.Password;

                    AlertNotification.ShowAlertMessage("Parola başarıyla güncellendi.", AlertNotification.AlertType.SUCCESS);
                    LinkBack_LinkClicked(null, null);
                }
                else
                {
                    AlertNotification.ShowAlertMessage("Parola Hatalı.", AlertNotification.AlertType.ERROR);
                }
            }
        }
    }
}
