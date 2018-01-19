using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Management.App_Code;

namespace Management
{
    public partial class OrdersListUserControl : UserControl, RefreshListeners.OrderListener
    {
        private DatabaseAccess access;
        private float total = 0, totalSale = 0, totalDiscount = 0;

        public OrdersListUserControl()
        {
            InitializeComponent();
            try
            {
                this.access = DatabaseAccess.getInstance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message...");
            }
        }

        public void onAdded(Order order)
        {
            if (dtpDay.Value.Date.ToShortDateString().Equals(order.Date.ToShortDateString()))
            {
                AddOrder(order);
                RefreshTotal();
            }
        }

        public void onUpdated(Order order)
        {
            throw new NotImplementedException();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            UIUtilties.Loading(true);
            DateTime date = dtpDay.Value;

            try
            {
                dgvSales.Rows.Clear();
                txtTotal.Text = "";
                txtTotalDiscount.Text = "";
                txtTotalSale.Text = "";
                List<Order> orders = access.GetAllOrders(date.Date);

                total = 0;
                totalSale = 0;
                totalDiscount = 0;
                
                foreach (Order order in orders)
                {
                    AddOrder(order);
                }

                RefreshTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message...");
            }
            UIUtilties.Loading(false);
        }

        private void AddOrder(Order order)
        {
            dgvSales.Rows.Add(new object[] { order.Id, order.Date.ToShortDateString(), order.Total, order.TotalSale, order.Discount });
            total += order.Total;
            totalSale += order.TotalSale;
            totalDiscount += order.Discount;
        }

        private void dgvSales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UIUtilties.DataGridView_RowAdded(sender, e.RowIndex);
        }

        private void RefreshTotal()
        {
            txtTotal.Text = total + "";
            txtTotalDiscount.Text = totalDiscount + "";
            txtTotalSale.Text = totalSale + "";
        }

        private void OrdersListUserControl_Load(object sender, EventArgs e)
        {
            int width = this.dgvSales.Width;
            int normal = (int)(0.2 * width);
            int id = (int)(0.1 * width);// 5%
            int date = width - ((normal * 3) + id + 40);

            dgvSales.Columns[0].Width = id;
            dgvSales.Columns[1].Width = date;
            dgvSales.Columns[2].Width = normal;
            dgvSales.Columns[3].Width = normal;
            dgvSales.Columns[4].Width = normal;
        }
    }
}
