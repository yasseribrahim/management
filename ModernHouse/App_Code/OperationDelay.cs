using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernHouse.App_Code
{
    public class OperationDelay
    {
        private int id;
        private string name;
        private string phone;
        private string address;
        private float blance;
        private float lastPaied;
        private DateTime lastPaiedDate;
        private float paied;
        private DateTime date;

        public OperationDelay()
        {
            this.id = -1;
            this.name = "";
            this.phone = "";
            this.address = "";
        }

        public OperationDelay(int id, string name, string phone, string address, float blance, float lastPaied, DateTime lastPaiedDate, float paied, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.blance = blance;
            this.lastPaied = lastPaied;
            this.lastPaiedDate = lastPaiedDate;
            this.paied = paied;
            this.date = date;
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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
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

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public string ToString2()
        {
            return "ID: " + id + ", Name: " + name + ", Phone: " + phone + ", Address: " + address;
        }

        public override string ToString()
        {
            return name;
        }

        public static string SELECT_BETWEEN_DATE = "SELECT * FROM OperationDelay WHERE [Date] BETWEEN @Date1 AND @Date2";
        public static string SELECT = "SELECT * FROM OperationDelay";
    }
}
