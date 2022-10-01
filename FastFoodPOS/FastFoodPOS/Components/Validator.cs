using FastFoodPOS.DatabaseUtil;
using FastFoodPOS.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS.Components
{
    class Validator
    {
        private Color default_border_color;
        private Guna2TextBox control;
        private Label error_message;
        private string name;
        private string rules;
        private bool is_valid = false;

        public Guna2TextBox compare_control { get; set; }
        public string unique_ignore { get; set; }

        public Validator(Guna2TextBox control, Label error_message, string name, string rules)
        {
            this.control = control;
            this.default_border_color = control.BorderColor;
            this.error_message = error_message;
            this.name = name;
            this.rules = rules;
            this.control.Leave += control_LostFocus;
            ResetStyle();
        }

        void control_LostFocus(object sender, EventArgs e)
        {
            Validate();
        }

        public void Validate()
        {
            ResetStyle();
            is_valid = true;
            string text = control.Text.Trim();
            string[] rules = this.rules.Split('|');
            foreach(string ruleString in rules) 
            {
                
                string[] rule = ruleString.Split(':');
                string ruleBody = rule[0];
                string ruleParam = rule.Length > 1 ? rule[1] : "";

                if(ruleBody.Equals("required") && text.Length == 0) {
                    is_valid = false;
                    control.BorderColor = Color.Red;
                    error_message.Text =name + " alanı zorunlu";
                    break;
                }
                else if (ruleBody.Equals("min") && text.Length < Int32.Parse(ruleParam))
                {
                    is_valid = false;
                    control.BorderColor = Color.Red;
                    error_message.Text =name + " alanı  " + ruleParam + " karakter'den az olamaz.";
                    break;
                }
                else if (ruleBody.Equals("email") && !Util.IsEmail(text))
                {
                    is_valid = false;
                    control.BorderColor = Color.Red;
                    error_message.Text =name + " alanı doğru şekilde tanımlanmalı.";
                    break;
                }
                else if (ruleBody.Equals("unique") && !isUnique(text, ruleParam.Split(',')))
                {
                    is_valid = false;
                    control.BorderColor = Color.Red;
                    error_message.Text =name + " zaten var.";
                    break;
                }
                else if (ruleBody.Equals("compare") && !text.Equals(compare_control.Text))
                {
                    is_valid = false;
                    control.BorderColor = Color.Red;
                    error_message.Text = name + " alanı eşleşmiyor.";
                    break;
                }
                else if (ruleBody.Equals("name") && !isValidName(text))
                {
                    is_valid = false;
                    control.BorderColor = Color.Red;
                    error_message.Text =name + " alanı sayı ve sembol içermemelidir.";
                    break;
                }
            }
        }

        public bool isUnique(string text, string[] ruleParams)
        {
            bool result = true;
            string table = ruleParams[0];
            string column = ruleParams[1];
            if (unique_ignore != control.Text && DatabaseModel.IsExist(table, column, text.Trim()))
                result = false;
            return result;
        }

        public bool isValidName(string name)
        {
            bool result = true;
            foreach(char val in name.ToCharArray()){
                if (!char.IsLetter(val) && val != ' ' && val != '-')
                {//The name must not contain symbos except [space] and [hypen]
                    result = false;
                    break;
                }
                if(char.IsNumber(val)) { //the name must not contains a number
                    result = false;
                    break;
                }
            }
            return result;
        }

        public void Reset()
        {
            ResetStyle();
        }

        public bool IsValid()
        {
            Validate();
            return is_valid;
        }

        void ResetStyle()
        {
            error_message.Text = "";
            control.BorderColor = default_border_color;
        }

    }
}
