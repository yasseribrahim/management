
namespace Management.App_Code
{
    public class Client
    {
        private int id;
        private string name;
        private string phone;
        private string address;
        private string note;

        public Client()
        {
            this.id = -1;
            this.name = "";
            this.phone = "";
            this.address = "";
            this.note = "";
        }

        public Client(int id, string name, string phone, string address, string note)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
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

        public string ToString2()
        {
            return "ID: " + id + ", Name: " + name + ", Phone: " + phone + ", Address: " + address + ", Note: " + note;
        }

        public override string ToString()
        {
            return name;
        }

        public static string SELECT_ID = "SELECT * FROM Clients WHERE ID = @ID";
        public static string SELECT_LIKE_NAME = "SELECT * FROM Clients WHERE Name LIKE @Name";
        public static string SELECT = "SELECT * FROM Clients";
        public static string INSERT = "[dbo].[InsertClient]";
        public static string UPDATE = "UPDATE Clients SET Name = @Name, Phone = @Phone, Address = @Address , Note = @Note WHERE ID = @ID";
        public static string DELETE = "DELETE FROM Clients WHERE ID = @ID";
        /*
        DELETE FROM Clients;
        DBCC CHECKIDENT (Clients, RESEED, 0);
        */
    }
}
