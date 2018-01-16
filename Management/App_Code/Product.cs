
namespace Management.App_Code
{
    public class Product
    {
        private int id;
        private string name;
        private int quantity;
        private int limit;
        private float price;
        private float priceSale;
        private string note;

        public Product()
        {
            this.id = -1;
            this.name = "";
            this.quantity = 0;
            this.limit = 0;
            this.price = 0;
            this.priceSale = 0;
        }

        public Product(int id, string name, int quantity, int limit, float price, float priceSale, string note)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.limit = limit;
            this.price = price;
            this.priceSale = priceSale;
            this.note = note;
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

        public int Limit
        {
            get
            {
                return limit;
            }
            set
            {
                limit = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public float PriceSale
        {
            get
            {
                return priceSale;
            }
            set
            {
                priceSale = value;
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

        public override string ToString()
        {
            return name;
        }

        public string ToString2()
        {
            return "ID: " + id + ", Name: " + name + ", Quantity: " + quantity + ", Limit: " + limit + ", Price: " + price + ", PriceSale: " + priceSale + ", Note: " + note;
        }

        public static string SELECT_ID = "SELECT * FROM Products WHERE ID = @ID";
        public static string SELECT = "SELECT * FROM Products";
        public static string SELECT_BY_NAME = "SELECT * FROM Products WHERE Name LIKE '%PRODUCT_NAME%'";
        public static string INSERT = "[dbo].[InsertProduct]";
        public static string UPDATE = "UPDATE Products SET Name = @Name, Quantity = @Quantity, Limit = @Limit, Price = @Price, PriceSale = @PriceSale , Note = @Note WHERE ID = @ID";
        public static string UPDATE_STORE = "UPDATE Products SET Quantity = @Quantity WHERE ID = @ID";
        public static string SELECT_REQUIRED = "SELECT * FROM Products WHERE Quantity <= Limit";
        public static string DELETE = "DELETE FROM Products WHERE ID = @ID";
        /*
        DELETE FROM Clients;
        DBCC CHECKIDENT (Clients, RESEED, 0);
        SELECT * FROM Clients;
        */
    }
}
