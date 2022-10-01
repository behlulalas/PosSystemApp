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

namespace FastFoodPOS.Forms.AdminForms
{
    partial class FormActivityLog : UserControl
    {
        User _user;
        void RefreshLogs(DateTime date)
        {
            var logs = Log.GetLogs(_user, DateTimeSpecifier.Value);
            DataGridViewLogs.Rows.Clear();
            logs.ForEach(log =>
            {
                DataGridViewLogs.Rows.Add(
                    log.date_created.ToString(),
                    _user.Fullname,
                    log.activity
                );
            });
            if (logs.Count == 0)
            {
                DataGridViewLogs.Rows.Add(
                    "", "Kullanıcıya ait henüz bir hareket yok.", ""
                );
            }
        }
        public FormActivityLog(User user)
        {
            InitializeComponent();
            _user = user;
            DateTimeSpecifier.MaxDate = DateTime.Now;
            DateTimeSpecifier.Value = DateTimeSpecifier.MaxDate;
            //RefreshLogs(DateTimeSpecifier.Value);
        }

        private void DateTimeSpecifier_ValueChanged(object sender, EventArgs e)
        {
            RefreshLogs(DateTimeSpecifier.Value);
        }
    }
}
