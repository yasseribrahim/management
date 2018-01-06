using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModernHouse.App_Code;

namespace ModernHouse
{
    public partial class OrderUserControl : UserControl
    {
        private DatabaseAccess access;
        private Order order;
        private List<Client> clients;
        private List<Product> products;

        public OrderUserControl(Order order)
        {
            InitializeComponent();

            try {
                this.access = DatabaseAccess.getInstance();
                this.order = order;
                if (order.Id == -1)
                {
                    this.btnUpdate.Enabled = false;
                }
                else
                {
                    this.btnSave.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message...");
            }
        }

        private void ClientUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                clients = access.GetAllClients();
                products = access.GetAllProducts();

                foreach (Client client in clients)
                {
                    cobxClient.Items.Add(client);
                }
                foreach (Product product in products)
                {
                    cobxProduct.Items.Add(product);
                }

                if (clients.Count > 0)
                {
                    cobxClient.SelectedIndex = 0;
                }
                if (products.Count > 0)
                {
                    cobxProduct.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message...");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "";
            this.txtNote.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    order.Id = access.SaveOrder(order);
                    MessageBox.Show(" تم الحفظ", "Message....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم الحفظ" + "\n" + ex.Message, "Error Message....", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    if (access.UpdateOrder(order))
                    {
                        MessageBox.Show(" تم التعديل", "Message....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("لم يتم التعديل", "Error Message....", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم التعديل" + "\n" + ex.Message, "Error Message....", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private new bool Validate()
        {
            Client client = (Client)cobxClient.SelectedItem;
            DateTime date = dtpDate.Value;
            if (client == null)
            {
                MessageBox.Show("من فضلك اختر العميل", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.cobxClient.Focus();
                return false;
            }
            if (date == null)
            {
                MessageBox.Show("من فضلك اختر تاريخ الفاتورة", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.dtpDate.Focus();
                return false;
            }
            if (order.Details.Count == 0)
            {
                MessageBox.Show("من فضلك اختر منتجات الفاتورة", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.cobxProduct.Focus();
                return false;
            }

            order.ClientId = client.Id;
            order.Date = date;
            order.Note = txtNote.Text;
     
            return true;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (((TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = (Product) cobxProduct.SelectedItem;
            OrderDetail detail;
            bool exist = false;
            if (product != null)
            {
                for(int index = 0; index < order.Details.Count; index++)
                {
                    detail = order.Details[index];
                    if (detail.ProductId == product.Id)
                    {
                        detail.Quantity += 1;
                        dgvOrderDetails.Rows[index].Cells["Column3"].Value = detail.Quantity;
                        dgvOrderDetails.Rows[index].Cells["Column5"].Value = detail.Quantity * product.PriceSale;
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    detail = new OrderDetail(-1, product.Id, 1);
                    detail.Product = product;
                    order.Details.Add(detail);
                    dgvOrderDetails.Rows.Add(new object[] { dgvOrderDetails.Rows.Count + 1, product.Name, 1, product.PriceSale, product.PriceSale });
                }

                txtTotal.Text = (order.CalculateTotal() + order.Discount) + "";
                txtFinalTotal.Text = order.TotalSale + "";
            }
        }

        private void cobxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobxProduct.SelectedIndex != -1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void dgvOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderDetails.SelectedRows.Count > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvOrderDetails.SelectedRows[0].Index;
            order.Details.RemoveAt(index);
            dgvOrderDetails.Rows.RemoveAt(index);
            txtTotal.Text = (order.CalculateTotal() > 0) ? (order.CalculateTotal() + order.Discount) + "" : "0";
            txtFinalTotal.Text = order.TotalSale + "";
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if(txtDiscount.Text.Length == 0)
            {
                txtDiscount.Text = "0";
            }
            order.Discount = float.Parse(txtDiscount.Text);
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            calculateFinalTotal();
        }

        private void calculateFinalTotal()
        {
            float discount = float.Parse(txtDiscount.Text);
            float profit = order.TotalSale - order.Total;

            if (discount >= profit)
            {
                MessageBox.Show("هذا الخصم سيؤدى الى خسارة ماليه حيث ان قيمة الخصم اعلى من الربح", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiscount.Text = "0";
                discount = 0;
            }
            order.CalculateTotal();
            txtFinalTotal.Text = order.TotalSale + "";
        }
    }
}
