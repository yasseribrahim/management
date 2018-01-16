using System;

namespace Management.App_Code
{
    public class OrdersInfo
    {
        private DateTime date;
        private float total;
        private float totalSale;
        private float discount;

        public OrdersInfo(DateTime date, float total, float totalSale, float discount)
        {
            this.date = date;
            this.total = total;
            this.totalSale = totalSale;
            this.discount = discount;
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

        public override string ToString()
        {
            return "Date: " + date + ", Total: " + total + ", TotalSale: " + totalSale;
        }

        public static string SELECT_BETWEEN_DATE = "SELECT * FROM OrdersInfo WHERE Date BETWEEN @Date1 AND @Date2";
    }
}
