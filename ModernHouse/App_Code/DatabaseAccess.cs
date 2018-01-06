using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ModernHouse.App_Code
{
    public class DatabaseAccess
    {
        private static DatabaseAccess access = new DatabaseAccess();
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable table;

        public static DatabaseAccess getInstance()
        {
            return access;
        }

        private DatabaseAccess()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ModernHouse.Properties.Settings.ModernHouseDBConnectionString"].ConnectionString);
        }

        public Client GetClient(int id)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Client.SELECT_ID;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<Client> clients = new List<Client>();
                foreach (DataRow row in table.Rows)
                {
                    return ParseClient(row);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllClients:- " + ex.Message);
            }
        }

        public List<Client> GetAllClients()
        {
            try {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Client.SELECT;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<Client> clients = new List<Client>();
                foreach (DataRow row in table.Rows)
                {
                    clients.Add(ParseClient(row));
                }
                return clients;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllClients:- " + ex.Message);
            }
        }

        public List<ClientInfo> GetAllClientInfos()
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = ClientInfo.SELECT;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<ClientInfo> clients = new List<ClientInfo>();
                foreach (DataRow row in table.Rows)
                {
                    clients.Add(ParseClientInfo(row));
                }
                return clients;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllClientInfos:- " + ex.Message);
            }
        }

        public ClientInfo GetClientInfoById(int id)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = ClientInfo.SELECT_ID;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<ClientInfo> clients = new List<ClientInfo>();
                foreach (DataRow row in table.Rows)
                {
                    return ParseClientInfo(row);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllClientsByName:- " + ex.Message);
            }
        }

        public List<ClientInfo> GetAllClientInfosByName(string name)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = ClientInfo.SELECT_LIKE_NAME;
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = "%" + name + "%";
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<ClientInfo> clients = new List<ClientInfo>();
                foreach (DataRow row in table.Rows)
                {
                    clients.Add(ParseClientInfo(row));
                }
                return clients;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllClientsByName:- " + ex.Message);
            }
        }

        public List<ClientInfo> GetAllClientInfosByDate(DateTime date)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = ClientInfo.SELECT_BEFORE_DATE;
                command.Parameters.Add("@Date", SqlDbType.DateTime).Value = date;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<ClientInfo> clients = new List<ClientInfo>();
                foreach (DataRow row in table.Rows)
                {
                    clients.Add(ParseClientInfo(row));
                }
                return clients;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllOperationDelay:- " + ex.Message);
            }
        }

        public List<OperationDelay> GetAllOperationDelay()
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = OperationDelay.SELECT;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<OperationDelay> operations = new List<OperationDelay>();
                foreach (DataRow row in table.Rows)
                {
                    operations.Add(ParseOperationDelay(row));
                }
                return operations;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllOperationDelay:- " + ex.Message);
            }
        }

        public List<OperationDelay> GetAllOperationDelay(DateTime date1, DateTime date2)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = OperationDelay.SELECT_BETWEEN_DATE;
                command.Parameters.Add("@Date1", SqlDbType.DateTime).Value = date1;
                command.Parameters.Add("@Date2", SqlDbType.DateTime).Value = date2;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<OperationDelay> operations = new List<OperationDelay>();
                foreach (DataRow row in table.Rows)
                {
                    operations.Add(ParseOperationDelay(row));
                }
                return operations;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllOperationDelay:- " + ex.Message);
            }
        }

        public List<OrdersInfo> GetAllOrdersInfo(DateTime date1, DateTime date2)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = OrdersInfo.SELECT_BETWEEN_DATE;
                command.Parameters.Add("@Date1", SqlDbType.DateTime).Value = date1;
                command.Parameters.Add("@Date2", SqlDbType.DateTime).Value = date2;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<OrdersInfo> operations = new List<OrdersInfo>();
                foreach (DataRow row in table.Rows)
                {
                    operations.Add(ParseOrdersInfo(row));
                }
                return operations;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllOrdersInfo:- " + ex.Message);
            }
        }

        public List<Client> GetAllClientsByName(string name)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Client.SELECT_LIKE_NAME;
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = "%" + name + "%";
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<Client> clients = new List<Client>();
                foreach (DataRow row in table.Rows)
                {
                    clients.Add(ParseClient(row));
                }
                return clients;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllClientsByName:- " + ex.Message);
            }
        }

        public bool DeleteClient(int id)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Client.DELETE;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: SaveClients:- " + ex.Message);
            }
        }

        public int SaveClient(Client client)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Client.INSERT;
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter IDParameter = new SqlParameter("@ID", SqlDbType.Int);
                IDParameter.Direction = ParameterDirection.Output;
                SqlParameter NameParameter = new SqlParameter("@Name", SqlDbType.NVarChar);
                NameParameter.Value = client.Name;
                SqlParameter PhoneParameter = new SqlParameter("@Phone", SqlDbType.VarChar);
                PhoneParameter.Value = client.Phone;
                SqlParameter AddressParameter = new SqlParameter("@Address", SqlDbType.NVarChar);
                AddressParameter.Value = client.Address;
                SqlParameter NoteParameter = new SqlParameter("@Note", SqlDbType.NText);
                NoteParameter.Value = client.Note;

                command.Parameters.Add(IDParameter);
                command.Parameters.Add(NameParameter);
                command.Parameters.Add(PhoneParameter);
                command.Parameters.Add(AddressParameter);
                command.Parameters.Add(NoteParameter);

                command.ExecuteScalar();
                connection.Close();
                return (int) command.Parameters["@ID"].Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: SaveClients:- " + ex.Message);
            }
        }

        public bool UpdateClient(Client client)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Client.UPDATE;

                SqlParameter IDParameter = new SqlParameter("@ID", SqlDbType.Int);
                IDParameter.Value = client.Id;
                SqlParameter NameParameter = new SqlParameter("@Name", SqlDbType.NVarChar);
                NameParameter.Value = client.Name;
                SqlParameter PhoneParameter = new SqlParameter("@Phone", SqlDbType.VarChar);
                PhoneParameter.Value = client.Phone;
                SqlParameter AddressParameter = new SqlParameter("@Address", SqlDbType.NVarChar);
                AddressParameter.Value = client.Address;
                SqlParameter NoteParameter = new SqlParameter("@Note", SqlDbType.NText);
                NoteParameter.Value = client.Note;

                command.Parameters.Add(IDParameter);
                command.Parameters.Add(NameParameter);
                command.Parameters.Add(PhoneParameter);
                command.Parameters.Add(AddressParameter);
                command.Parameters.Add(NoteParameter);

                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: UpdateClient:- " + ex.Message);
            }
        }
        
        public Client ParseClient(DataRow row)
        {
            int id = int.Parse(row["Id"].ToString());
            string name = row["Name"].ToString();
            string phone = row["Phone"].ToString();
            string address = row["Address"].ToString();
            string note = row["Note"].ToString();
            return new Client(id, name, phone, address, note);
        }

        public ClientInfo ParseClientInfo(DataRow row)
        {
            int id = int.Parse(row["Id"].ToString());
            string name = row["Name"].ToString();
            string phone = row["Phone"].ToString();
            string address = row["Address"].ToString();
            string note = row["Note"].ToString();
            float blance = float.Parse(row["Blance"].ToString());
            float lastPaied = float.Parse(row["LastPaied"].ToString());
            DateTime lastPaiedDate = DateTime.Parse(row["LastPaiedDate"].ToString());
            return new ClientInfo(id, name, phone, address, note, blance, lastPaied, lastPaiedDate);
        }

        public OperationDelay ParseOperationDelay(DataRow row)
        {
            int id = int.Parse(row["Id"].ToString());
            string name = row["Name"].ToString();
            string phone = row["Phone"].ToString();
            string address = row["Address"].ToString();
            float blance = float.Parse(row["Blance"].ToString());
            float lastPaied = float.Parse(row["LastPaied"].ToString());
            DateTime lastPaiedDate = DateTime.Parse(row["LastPaiedDate"].ToString());
            float paied = float.Parse(row["Paied"].ToString());
            DateTime date = DateTime.Parse(row["Date"].ToString());
            return new OperationDelay(id, name, phone, address, blance, lastPaied, lastPaiedDate, paied, date);
        }

        public Product GetProduct(int id)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Product.SELECT_ID;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<Client> clients = new List<Client>();
                foreach (DataRow row in table.Rows)
                {
                    return ParseProduct(row);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetProduct:- " + ex.Message);
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Product.SELECT;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<Product> products = new List<Product>();
                foreach (DataRow row in table.Rows)
                {
                    products.Add(ParseProduct(row));
                }
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllProducts:- " + ex.Message);
            }
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Product.DELETE;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: DeleteProduct:- " + ex.Message);
            }
        }

        public int SaveProduct(Product product)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Product.INSERT;
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter IDParameter = new SqlParameter("@ID", SqlDbType.Int);
                IDParameter.Direction = ParameterDirection.Output;
                SqlParameter NameParameter = new SqlParameter("@Name", SqlDbType.NVarChar);
                NameParameter.Value = product.Name;
                SqlParameter QuantityParameter = new SqlParameter("@Quantity", SqlDbType.Int);
                QuantityParameter.Value = product.Quantity;
                SqlParameter PriceParameter = new SqlParameter("@Price", SqlDbType.Real);
                PriceParameter.Value = product.Price;
                SqlParameter PriceSaleParameter = new SqlParameter("@PriceSale", SqlDbType.Real);
                PriceSaleParameter.Value = product.PriceSale;
                SqlParameter NoteParameter = new SqlParameter("@Note", SqlDbType.NText);
                NoteParameter.Value = product.Note;

                command.Parameters.Add(IDParameter);
                command.Parameters.Add(NameParameter);
                command.Parameters.Add(QuantityParameter);
                command.Parameters.Add(PriceParameter);
                command.Parameters.Add(PriceSaleParameter);
                command.Parameters.Add(NoteParameter);

                command.ExecuteScalar();
                connection.Close();
                return (int) command.Parameters["@ID"].Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: SaveProduct:- " + ex.Message);
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Product.UPDATE;

                SqlParameter IDParameter = new SqlParameter("@ID", SqlDbType.Int);
                IDParameter.Value = product.Id;
                SqlParameter NameParameter = new SqlParameter("@Name", SqlDbType.NVarChar);
                NameParameter.Value = product.Name;
                SqlParameter QuantityParameter = new SqlParameter("@Quantity", SqlDbType.Int);
                QuantityParameter.Value = product.Quantity;
                SqlParameter PriceParameter = new SqlParameter("@Price", SqlDbType.Real);
                PriceParameter.Value = product.Price;
                SqlParameter PriceSaleParameter = new SqlParameter("@PriceSale", SqlDbType.Real);
                PriceSaleParameter.Value = product.PriceSale;
                SqlParameter NoteParameter = new SqlParameter("@Note", SqlDbType.NText);
                NoteParameter.Value = product.Note;

                command.Parameters.Add(IDParameter);
                command.Parameters.Add(NameParameter);
                command.Parameters.Add(QuantityParameter);
                command.Parameters.Add(PriceParameter);
                command.Parameters.Add(PriceSaleParameter);
                command.Parameters.Add(NoteParameter);

                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: UpdateProduct:- " + ex.Message);
            }
        }

        public Product ParseProduct(DataRow row)
        {
            int id = int.Parse(row["Id"].ToString());
            string name = row["Name"].ToString();
            int quantity = int.Parse(row["Quantity"].ToString());
            float price = float.Parse(row["Price"].ToString());
            float priceSale = float.Parse(row["PriceSale"].ToString());
            string note = row["Note"].ToString();
            return new Product(id, name, quantity, price, priceSale, note);
        }

        public Order GetOrder(int id)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Order.SELECT_ID;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();
                
                foreach (DataRow row in table.Rows)
                {
                    return ParseOrder(row);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetOrder:- " + ex.Message);
            }
        }

        public List<Order> GetOrderClientId(int clientId)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Order.SELECT_CLIENT_ID;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = clientId;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<Order> orders = new List<Order>();
                foreach (DataRow row in table.Rows)
                {
                    orders.Add(ParseOrder(row));
                }
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetOrder:- " + ex.Message);
            }
        }

        public List<Order> GetAllOrders()
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Order.SELECT;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<Order> orders = new List<Order>();
                foreach (DataRow row in table.Rows)
                {
                    orders.Add(ParseOrder(row));
                }
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllOrders:- " + ex.Message);
            }
        }

        public bool DeleteOrder(int id)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Order.DELETE;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: DeleteOrder:- " + ex.Message);
            }
        }

        public int SaveOrder(Order order)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Order.INSERT;
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter IDParameter = new SqlParameter("@ID", SqlDbType.Int);
                IDParameter.Direction = ParameterDirection.Output;
                SqlParameter ClientIdParameter = new SqlParameter("@ClientID", SqlDbType.Int);
                ClientIdParameter.Value = order.ClientId;
                SqlParameter DateParameter = new SqlParameter("@Date", SqlDbType.DateTime);
                DateParameter.Value = order.Date;
                SqlParameter TotalParameter = new SqlParameter("@Total", SqlDbType.Real);
                TotalParameter.Value = order.Total;
                SqlParameter TotalSaleParameter = new SqlParameter("@TotalSale", SqlDbType.Real);
                TotalSaleParameter.Value = order.TotalSale;
                SqlParameter DiscountParameter = new SqlParameter("@Discount", SqlDbType.Real);
                DiscountParameter.Value = order.Discount;
                SqlParameter NoteParameter = new SqlParameter("@Note", SqlDbType.NText);
                NoteParameter.Value = order.Note;

                command.Parameters.Add(IDParameter);
                command.Parameters.Add(ClientIdParameter);
                command.Parameters.Add(DateParameter);
                command.Parameters.Add(TotalParameter);
                command.Parameters.Add(TotalSaleParameter);
                command.Parameters.Add(DiscountParameter);
                command.Parameters.Add(NoteParameter);

                command.ExecuteScalar();
                connection.Close();
                int id = (int)command.Parameters["@ID"].Value;
                foreach(OrderDetail detail in order.Details)
                {
                    detail.OrderId = id;
                    SaveOrderDetail(detail);
                }
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: SaveOrder:- " + ex.Message);
            }
        }

        public bool UpdateOrder(Order order)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Order.UPDATE;

                SqlParameter IDParameter = new SqlParameter("@ID", SqlDbType.Int);
                IDParameter.Value = order.Id;
                SqlParameter ClientIdParameter = new SqlParameter("@ClientID", SqlDbType.Int);
                ClientIdParameter.Value = order.ClientId;
                SqlParameter DateParameter = new SqlParameter("@Date", SqlDbType.DateTime);
                DateParameter.Value = order.Date;
                SqlParameter TotalParameter = new SqlParameter("@Total", SqlDbType.Real);
                TotalParameter.Value = order.Total;
                SqlParameter TotalSaleParameter = new SqlParameter("@TotalSale", SqlDbType.Real);
                TotalSaleParameter.Value = order.TotalSale;
                SqlParameter DiscountParameter = new SqlParameter("@Discount", SqlDbType.Real);
                DiscountParameter.Value = order.Discount;
                SqlParameter NoteParameter = new SqlParameter("@Note", SqlDbType.NText);
                NoteParameter.Value = order.Note;

                command.Parameters.Add(IDParameter);
                command.Parameters.Add(ClientIdParameter);
                command.Parameters.Add(DateParameter);
                command.Parameters.Add(TotalParameter);
                command.Parameters.Add(TotalSaleParameter);
                command.Parameters.Add(DiscountParameter);
                command.Parameters.Add(NoteParameter);

                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: UpdateOrder:- " + ex.Message);
            }
        }

        public Order ParseOrder(DataRow row)
        {
            int id = int.Parse(row["Id"].ToString());
            int clientId = int.Parse(row["ClientID"].ToString());
            DateTime date = DateTime.Parse(row["Date"].ToString());
            float total = float.Parse(row["Total"].ToString());
            float totalSale = float.Parse(row["TotalSale"].ToString());
            float discount = float.Parse(row["Discount"].ToString());
            string note = row["Note"].ToString();
            return new Order(id, clientId, date, total, totalSale, discount, note);
        }

        public OrdersInfo ParseOrdersInfo(DataRow row)
        {
            DateTime date = DateTime.Parse(row["Date"].ToString());
            float total = float.Parse(row["Total"].ToString());
            float totalSale = float.Parse(row["TotalSale"].ToString());
            float discount = float.Parse(row["Discount"].ToString());
            return new OrdersInfo(date, total, totalSale, discount);
        }

        public List<OrderDetail> GetOrderDEtailsByOrder(int orderId)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = OrderDetail.SELECT_ORDER_ID;
                SqlParameter OrderIdParameter = new SqlParameter("@OrderID", SqlDbType.Int);
                OrderIdParameter.Value = orderId;
                command.Parameters.Add(OrderIdParameter);
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<OrderDetail> details = new List<OrderDetail>();
                foreach (DataRow row in table.Rows)
                {
                    details.Add(ParseOrderDetail(row));
                }
                return details;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetOrderDEtailsByOrder:- " + ex.Message);
            }
        }

        public bool SaveOrderDetail(OrderDetail detail)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = OrderDetail.INSERT;

                SqlParameter OrderIdParameter = new SqlParameter("@OrderID", SqlDbType.Int);
                OrderIdParameter.Value = detail.OrderId;
                SqlParameter ProductIdParameter = new SqlParameter("@ProductID", SqlDbType.Int);
                ProductIdParameter.Value = detail.ProductId;
                SqlParameter QuantityParameter = new SqlParameter("@Quantity", SqlDbType.Int);
                QuantityParameter.Value = detail.Quantity;

                command.Parameters.Add(OrderIdParameter);
                command.Parameters.Add(ProductIdParameter);
                command.Parameters.Add(QuantityParameter);

                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: SaveOrderDetail:- " + ex.Message);
            }
        }

        public OrderDetail ParseOrderDetail(DataRow row)
        {
            int orderId = int.Parse(row["OrderId"].ToString());
            int productId = int.Parse(row["ProductId"].ToString());
            int quantity = int.Parse(row["Quantity"].ToString());
            return new OrderDetail(orderId, productId, quantity);
        }

        public Accounting GetAccounting(int id)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Accounting.SELECT_ID;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();
                
                foreach (DataRow row in table.Rows)
                {
                    return ParseAccounting(row);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAccounting:- " + ex.Message);
            }
        }

        public List<Accounting> GetAllAccountings()
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Accounting.SELECT;
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<Accounting> accountings = new List<Accounting>();
                foreach (DataRow row in table.Rows)
                {
                    accountings.Add(ParseAccounting(row));
                }
                return accountings;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAllAccountings:- " + ex.Message);
            }
        }

        public bool DeleteAccountingt(int id)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Accounting.DELETE;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: DeleteAccounting:- " + ex.Message);
            }
        }

        public int SaveAccounting(Accounting accounting)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Accounting.INSERT;

                SqlParameter IDParameter = new SqlParameter("@ID", SqlDbType.Int);
                IDParameter.Value = accounting.Id;
                SqlParameter BalanceParameter = new SqlParameter("@Balance", SqlDbType.Real);
                BalanceParameter.Value = accounting.Blance;
                SqlParameter LastPaiedParameter = new SqlParameter("@LastPaied", SqlDbType.Real);
                LastPaiedParameter.Value = accounting.LastPaied;
                SqlParameter LastPaiedDateParameter = new SqlParameter("@LastPaiedDate", SqlDbType.DateTime);
                LastPaiedDateParameter.Value = accounting.LastPaiedDate;

                command.Parameters.Add(IDParameter);
                command.Parameters.Add(BalanceParameter);
                command.Parameters.Add(LastPaiedParameter);
                command.Parameters.Add(LastPaiedDateParameter);

                command.ExecuteScalar();
                connection.Close();
                return (int)command.Parameters["@ID"].Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: SaveAccounting:- " + ex.Message);
            }
        }

        public bool UpdateAccounting(Accounting accounting)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = Accounting.UPDATE;

                SqlParameter IDParameter = new SqlParameter("@ID", SqlDbType.Int);
                IDParameter.Value = accounting.Id;
                SqlParameter LastPaiedParameter = new SqlParameter("@LastPaied", SqlDbType.Real);
                LastPaiedParameter.Value = accounting.LastPaied;
                SqlParameter LastPaiedDateParameter = new SqlParameter("@LastPaiedDate", SqlDbType.DateTime);
                LastPaiedDateParameter.Value = accounting.LastPaiedDate;

                command.Parameters.Add(IDParameter);
                command.Parameters.Add(LastPaiedParameter);
                command.Parameters.Add(LastPaiedDateParameter);

                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: UpdateAccounting:- " + ex.Message);
            }
        }

        public Accounting ParseAccounting(DataRow row)
        {
            int id = int.Parse(row["Id"].ToString());
            float blance = float.Parse(row["Blance"].ToString());
            float lastPaied = float.Parse(row["LastPaied"].ToString());
            DateTime lastPaiedDate = DateTime.Parse(row["LastPaiedDate"].ToString());
            return new Accounting(id, blance, lastPaied, lastPaiedDate);
        }

        public List<AccountingHistory> GetAccountingHistoryByAccountID(int orderId)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = AccountingHistory.SELECT_ACCOUNT_ID;
                SqlParameter OrderIdParameter = new SqlParameter("@AccountID", SqlDbType.Int);
                OrderIdParameter.Value = orderId;
                command.Parameters.Add(OrderIdParameter);
                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                connection.Close();

                List<AccountingHistory> history = new List<AccountingHistory>();
                foreach (DataRow row in table.Rows)
                {
                    history.Add(ParseAccountingHistory(row));
                }
                return history;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: GetAccountingHistoryByAccount:- " + ex.Message);
            }
        }

        public bool SaveAccountingHistory(AccountingHistory history)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = AccountingHistory.INSERT;
                
                SqlParameter AccountIdParameter = new SqlParameter("@AccountID", SqlDbType.Real);
                AccountIdParameter.Value = history.AccountId;
                SqlParameter PaiedParameter = new SqlParameter("@Paied", SqlDbType.Real);
                PaiedParameter.Value = history.Paied;
                SqlParameter PaiedDateParameter = new SqlParameter("@PaiedDate", SqlDbType.DateTime);
                PaiedDateParameter.Value = history.PaiedDate;
                
                command.Parameters.Add(AccountIdParameter);
                command.Parameters.Add(PaiedParameter);
                command.Parameters.Add(PaiedDateParameter);

                command.ExecuteScalar();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: SaveAccounting:- " + ex.Message);
            }
        }

        public AccountingHistory ParseAccountingHistory(DataRow row)
        {
            int id = int.Parse(row["Id"].ToString());
            int accountId = int.Parse(row["AccountID"].ToString());
            float paied = float.Parse(row["Paied"].ToString());
            DateTime paiedDate = DateTime.Parse(row["PaiedDate"].ToString());
            return new AccountingHistory(id, accountId, paied, paiedDate);
        }

        public void Print(List<Object> list)
        {
            foreach (Object item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
