using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management.App_Code
{
    public class Order
    {
        private int id;
        private int clientId;
        private DateTime date;
        private float total;
        private float totalSale;
        private float discount;
        private string note;
        private List<OrderDetail> details;

        public Order()
        {
            this.id = -1;
            this.details = new List<OrderDetail>();
        }

        public Order(int id, int clientId, DateTime date, float total, float totalSale, float discount, string note)
        {
            this.id = id;
            this.clientId = clientId;
            this.date = date;
            this.total = total;
            this.totalSale = totalSale;
            this.discount = discount;
            this.note = note;
            this.details = new List<OrderDetail>();
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

        public int ClientId
        {
            get
            {
                return clientId;
            }
            set
            {
                clientId = value;
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

        public float Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }

        public float TotalSale
        {
            get
            {
                return totalSale;
            }
            set
            {
                totalSale = value;
            }
        }

        public float Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
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

        public List<OrderDetail> Details
        {
            get
            {
                return details;
            }
            set
            {
                details = value;
            }
        }

        public float CalculateTotal()
        {
            total = 0;
            totalSale = 0;
            foreach(OrderDetail detail in details)
            {
                total += detail.Quantity * detail.Product.Price;
                totalSale += detail.Quantity * detail.Product.PriceSale;
            }
            totalSale = (ValidateDiscount()) ? (totalSale - discount) : totalSale;
            return totalSale;
        }

        public bool ValidateDiscount()
        {
            if (this.TotalSale > (this.Total + this.Discount))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "ID: " + id + ", ClientId: " + clientId + ", Date: " + date + ", Total: " + total + ", TotalSale: " + totalSale + ", Note: " + note;
        }

        public static string SELECT_ID = "SELECT * FROM Order WHERE ID = @ID";
        public static string SELECT_CLIENT_ID = "SELECT * FROM Order WHERE ClientID = @ClientID";
        public static string SELECT = "SELECT * FROM Order";
        public static string INSERT = "[dbo].[InsertOrder]";
        public static string UPDATE = "UPDATE Order SET ClientID = @ClientID, Date = @Date, Total = @Total, TotalSale = @TotalSale, Discount = @Discount, Note = @Note WHERE ID = @ID";
        public static string DELETE = "[dbo].[DeleteOrder]";
    }
}
