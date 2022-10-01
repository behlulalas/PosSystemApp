using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FastFoodPOS.Dialog;
using FastFoodPOS.Models;

namespace FastFoodPOS.Forms.AdminForms
{
    public partial class FormTransactions : UserControl
    {
        Dictionary<int, User> Users;
        Dictionary<int, CafeTables> Tables;
        List<Transaction> MyTransactions;
        public FormTransactions()
        {
            InitializeComponent();
            Users = new Dictionary<int, User>();
            Tables = new Dictionary<int, CafeTables>();
            User.GetAll(true).ForEach((User user) => Users.Add(user.Id, user));
            CafeTables.GetAllTables().ForEach((CafeTables cafe) => Tables.Add(cafe.TableID, cafe));
            DateTimeSpecifier.MaxDate = DateTime.Now;
            DateTimeSpecifier.Value = DateTimeSpecifier.MaxDate;
        }

        void RefreshTransactions(DateTime date)
        {
            int proccesCount = 0;
            decimal total =0;
            var Transactions = Transaction.GetTransactions(date);
            DataGridViewTransaction.Rows.Clear();
            Transactions.ForEach((Transaction transaction) =>
            {
                proccesCount++;
                DataGridViewTransaction.Rows.Add(
                    transaction.TransactionCode,
                    "#" + proccesCount,
                    transaction.Date.ToShortTimeString(),
                    Users[transaction.CashierId].Fullname,
                    Tables[transaction.CafeTableId].TableName,
                    transaction.Total + "€"
                );
                total += transaction.Total;
            });
            if (Transactions.Count == 0)
            {
                DataGridViewTransaction.Rows.Add(null,"Seçilen tarihte işlem yok.");
            }
            labelTotalSatis.Text = total.ToString() + "€";
        }

        private void DateTimeSpecifier_ValueChanged(object sender, EventArgs e)
        {
            RefreshTransactions(DateTimeSpecifier.Value);
        }

        private void DataGridViewTransaction_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void DataGridViewTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //MessageBox.Show(e.RowIndex.ToString());
            var tCode = DataGridViewTransaction.Rows[e.RowIndex].Cells[0].Value;
            if (tCode == null) return;
            MyTransactions = Transaction.GetTransactions(DateTimeSpecifier.Value);
            Transaction tDetail = MyTransactions.FirstOrDefault(x => x.TransactionCode == tCode.ToString());
            List<Order> oDetail = tDetail.GetOrders();
            OrderDetail orderDetail = new OrderDetail(oDetail);
            orderDetail.ShowDialog();
        }
    }
}
