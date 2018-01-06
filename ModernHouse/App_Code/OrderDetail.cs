using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModernHouse.App_Code
{
    public class OrderDetail
    {
        private int orderId;
        private int productId;
        private int quantity;
        private Product product;

        public OrderDetail()
        {
            this.orderId = -1;
            this.productId = -1;
        }

        public OrderDetail(int orderId, int productId, int quantity)
        {
            this.orderId = orderId;
            this.productId = productId;
            this.quantity = quantity;
        }

        public int OrderId
        {
            get
            {
                return orderId;
            }
            set
            {
                orderId = value;
            }
        }

        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public Product Product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
            }
        }

        public override string ToString()
        {
            return "OderID: " + orderId + ", ProductId: " + productId + ", Quantity: " + quantity;
        }

        public static string SELECT_ORDER_ID = "SELECT * FROM OrderDetails WHERE OderId = @OderID";
        public static string INSERT = "INSERT INTO OrderDetails VALUES(@OrderID, @ProductID, @Quantity)";
    }
}
