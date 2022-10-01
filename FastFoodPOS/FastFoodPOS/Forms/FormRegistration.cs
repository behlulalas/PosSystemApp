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

namespace FastFoodPOS.Forms
{
    public partial class FormRegistration : BaseForm
    {

        List<Validator> validators = new List<Validator>();

        public override bool IsFullScreen()
        {
            return false;
        }

        public override void OnLoad()
        {
            ParentForm.AcceptButton = BtnSubmit;
        }

        public FormRegistration()
        {
            InitializeComponent();
            validators.Add(new Validator(TextName, LabelNameError, "İsim", "required|name|min:1"));
            validators.Add(new Validator(TextEmail, LabelEmailError, "Kullanıcı Adı", "required|unique:users,email"));
            validators.Add(new Validator(TextPassword, LabelPasswordError, "Şifre", "required|min:1"));
            validators.Add(new Validator(TextConfirmPassword, LabelConfirmPasswordError, "Şifre Tekrarı", "required|min:1|compare") { compare_control = TextPassword });
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (validators.Count == validators.Count(validator => validator.IsValid()))
            {
                User new_user = new User();
                new_user.Fullname = TextName.Text.Trim();
                new_user.Email = TextEmail.Text.Trim();
                new_user.Password = Util.GetHashSHA256(TextPassword.Text.Trim());
                new_user.Role = "Administrator";
                new_user.Save();

                AlertNotification.ShowAlertMessage("Kayıt başarıyla oluşturuldu.", AlertNotification.AlertType.SUCCESS);

                MainForm.LoadForm(new FormAdminLogin());
            }
        }
    }
}
