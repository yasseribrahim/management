using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernHouse.App_Code
{
    public class AccountingHistory
    {
        private int id;
        private int accountId;
        private float paied;
        private DateTime paiedDate;

        public AccountingHistory()
        {
            this.id = -1;
        }

        public AccountingHistory(int id, int accountId, float paied, DateTime paiedDate)
        {
            this.id = id;
            this.accountId = accountId;
            this.paied = paied;
            this.paiedDate = paiedDate;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int AccountId
        {
            get
            {
                return accountId;
            }
            set
            {
                accountId = value;
            }
        }

        public float Paied
        {
            get
            {
                return paied;
            }
            set
            {
                paied = value;
            }
        }

        public DateTime PaiedDate
        {
            get
            {
                return paiedDate;
            }
            set
            {
                paiedDate = value;
            }
        }

        public override string ToString()
        {
            return "ID: " + id + ", AccountId: " + accountId + ", Paied: " + paied + ", PaiedDate:" + PaiedDate;
        }

        public static string SELECT_ACCOUNT_ID = "SELECT * FROM AccountingHistory WHERE AccountID = @AccountID ORDER BY PaiedDate DESC";
        public static string INSERT = "[dbo].[InsertAccountingHistory]";
        public static string DELETE = "DELETE FROM AccountingHistory WHERE ID = @ID";
    }
}
