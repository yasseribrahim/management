using System;
using System.Windows.Forms;
using Management.App_Code;
using System.Collections.Generic;

namespace Management
{
    public partial class ProductsUserControl : UserControl, RefreshListeners.ProductListener
    {
        private DatabaseAccess access;
        private List<Product> products;

        public ProductsUserControl()
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

        private void ProductsUserControl_Load(object sender, EventArgs e)
        {
            int width = this.dgvProducts.Width;
            int normal = (int)(0.15 * width);
            int id = (int)(0.1 * width);// 5%
            int date = width - ((normal * 4) + id + 40);

            dgvProducts.Columns[0].Width = id;
            dgvProducts.Columns[1].Width = date;
            dgvProducts.Columns[2].Width = normal;
            dgvProducts.Columns[3].Width = normal;
            dgvProducts.Columns[4].Width = normal;
            dgvProducts.Columns[5].Width = normal;

            LoadData();
        }

        private void LoadData()
        {
            string name = txtName.Text;
            if (name.Length == 0)
            {
                products = access.GetAllProducts();
            }
            else
            {
                products = access.GetAllProducts(name);
            }

            dgvProducts.Rows.Clear();
            foreach (Product product in products)
            {
                dgvProducts.Rows.Add(new object[] { product.Id, product.Name, product.Price, product.PriceSale, product.Quantity, product.Limit });
            }
        }

        private Product getSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                return products[dgvProducts.SelectedRows[0].Index];
            }
            else
            {
                MessageBox.Show("من فضلك اختر منتج اولا", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }

        private void tstmiEditProduct_Click(object sender, EventArgs e)
        {
            Product product = getSelectedProduct();
            if (product != null)
            {
                ProductUserControl control = new ProductUserControl(product);
                control.ProductListener = this;
                Management.ShowDialog(control, "تعديل منتج");
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducts.Rows[e.RowIndex].Selected = true;
        }

        public void onAdded(Product product)
        {

        }

        public void onUpdated(Product product)
        {
            int index = GetRowIndex(product);
            if (index != -1)
            {
                DataGridViewRow row = dgvProducts.Rows[index];
                row.Cells["ColumnName"].Value = product.Name + "";
                row.Cells["ColumnPrice"].Value = product.Price + "";
                row.Cells["ColumnPriceSale"].Value = product.PriceSale + "";
                row.Cells["ColumnQuantity"].Value = product.Quantity + "";
                row.Cells["ColumnLimit"].Value = product.Limit + "";
            }
        }

        private int GetRowIndex(Product product)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (int.Parse(row.Cells["ColumnID"].Value.ToString()) == product.Id)
                {
                    return row.Index;
                }
            }
            return -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
