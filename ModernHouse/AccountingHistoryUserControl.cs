using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModernHouse.App_Code;

namespace ModernHouse
{
    public partial class AccountingHistoryUserControl : UserControl
    {
        private DatabaseAccess access;
        private ClientInfo client;
        private List<AccountingHistory> history;

        public AccountingHistoryUserControl(ClientInfo client)
        {
            InitializeComponent();

            try {
                this.access = DatabaseAccess.getInstance();
                this.history = access.GetAccountingHistoryByAccountID(client.Id);
                this.client = client;
                this.txtName.Text = this.client.Name;
                this.txtBalance.Text = (this.client.Blance * -1) + "";
                this.dtpDate.Value = client.LastPaiedDate;

                this.btnSave.Enabled = false;
                this.btnUpdate.Enabled = false;
                this.btnReset.Enabled = false;

                int counter = 1;
                foreach(AccountingHistory row in history)
                {
                    dgvHistory.Rows.Add(new object[] { counter, row.Paied, row.PaiedDate});
                    counter++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message...");
            }
        }
    }
}
