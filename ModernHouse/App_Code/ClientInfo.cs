using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernHouse.App_Code
{
    public class ClientInfo
    {
        private int id;
        private string name;
        private string phone;
        private string address;
        private string note;
        private float blance;
        private float lastPaied;
        private DateTime lastPaiedDate;

        public ClientInfo()
        {
            this.id = -1;
            this.name = "";
            this.phone = "";
            this.address = "";
            this.note = "";
        }

        public ClientInfo(int id, string name, string phone, string address, string note, float blance, float lastPaied, DateTime lastPaiedDate)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.note = note;
            this.blance = blance;
            this.lastPaied = lastPaied;
            this.lastPaiedDate = lastPaiedDate;
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

        public string Note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
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

        public string ToString2()
        {
            return "ID: " + id + ", Name: " + name + ", Phone: " + phone + ", Address: " + address + ", Note: " + note;
        }

        public override string ToString()
        {
            return name;
        }

        public static string SELECT_ID = "SELECT * FROM ClientsInfo WHERE ID = @ID";
        public static string SELECT_LIKE_NAME = "SELECT * FROM ClientsInfo WHERE Name LIKE @Name";
        public static string SELECT_BEFORE_DATE = "SELECT * FROM ClientsInfo WHERE [LastPaiedDate] <= @Date";
        public static string SELECT = "SELECT * FROM ClientsInfo";
    }
}
