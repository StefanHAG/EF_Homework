using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (var context = new AccountContext())
            {
                context.Database.ExecuteSqlCommand(@"insert into [EF6Recipes9].[Chapter2.9].[Account]
(DeletedOn,AccountHolderId) values ('2/10/2009',1728)");

                var account = new Account { AccountHolderID = 2320 };
                context.Accounts.Add(account);
                account = new Account { AccountHolderID = 2502 };
                context.Accounts.Add(account);
                account = new Account { AccountHolderID = 2603 };
                context.Accounts.Add(account);

                context.SaveChanges();
            }

            MessageBox.Show("Data inserted!");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (var context = new AccountContext())
            {
                foreach (var account in context.Accounts)
                {
                    Console.WriteLine("Account Id = {0}",
                    account.AccountHolderID.ToString());

                    dataGridView.Rows.Add();
                    int RowIndex = dataGridView.RowCount - 1;
                    DataGridViewRow row = dataGridView.Rows[RowIndex];

                    row.Cells["AccountID"].Value = account.AccountHolderID.ToString();

                }
            }
        }
    }
}
