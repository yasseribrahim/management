using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernHouse.App_Code
{
    public class Accounting
    {
        private int id;
        private float blance;
        private float lastPaied;
        private DateTime lastPaiedDate;

        public Accounting()
        {
            this.id = -1;
        }

        public Accounting(int id, float blance, float lastPaied, DateTime date)
        {
            this.id = id;
            this.blance = blance;
            this.lastPaiedDate = date;
            this.lastPaied = lastPaied;
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

        public float Blance
        {
            get
            {
                return blance;
            }
            set
            {
                blance = value;
            }
        }

        public float LastPaied
        {
            get
            {
                return lastPaied;
            }
            set
            {
                lastPaied = value;
            }
        }

        public DateTime LastPaiedDate
        {
            get
            {
                return lastPaiedDate;
            }
            set
            {
                lastPaiedDate = value;
            }
        }

        public override string ToString()
        {
            return "ID: " + id + ", Blance: " + blance + ", LastPaied: " + lastPaied + ", LastPaiedDate: " + lastPaiedDate;
        }

        public static string SELECT_ID = "SELECT * FROM Accounting WHERE ID = @ID";
        public static string SELECT = "SELECT * FROM Order";
        public static string INSERT = "INSERT INTO Accounting VALUES(@ID, @Blance, @LastPaied, @LastPaiedDate)";
        public static string UPDATE = "UPDATE Accounting SET Blance += @LastPaied, LastPaied = @LastPaied, LastPaiedDate = @LastPaiedDate WHERE ID = @ID";
        public static string DELETE = "DELETE FROM Accounting WHERE ID = @ID";
    }
}
