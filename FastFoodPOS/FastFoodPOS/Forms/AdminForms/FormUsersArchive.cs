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
    public partial class FormUsersArchive : UserControl
    {
        List<User> deleted;

        public FormUsersArchive()
        {
            InitializeComponent();
            RefreshData();
        }

        private void RefreshData()
        {
            deleted = User.GetAllDeleted();
            DataGridViewUsers.Rows.Clear();
            deleted.ForEach(user =>
            {
                DataGridViewUsers.Rows.Add(
                    user.Id,
                    user.Fullname,
                    user.Email,
                    user.Role
                );
            });
            if (deleted.Count == 0) DataGridViewUsers.Rows.Add("Silinen Kullanıcı yok.");
        }

        private void LinkProductArchive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAdminPanel.GetInstance().LoadFormControl(new FormProductArchive());
        }

        private void DataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deleted.Count == 0) return;
            User selected = deleted[e.RowIndex];
            DialogResult result = Dialog.ConfirmDialogBox.ShowDialog("Bu kullanıcıyı geri yüklemek istediğinize emin misiniz? " + selected.Fullname);
            if (result == DialogResult.Yes)
            {
                selected.Recover();
                MessageBox.Show("Kullanıcı başarıyla geri yüklendi.");
                RefreshData();
            }
        }
    }
}
