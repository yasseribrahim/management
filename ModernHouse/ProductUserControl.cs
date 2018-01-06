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
    public partial class ProductUserControl : UserControl
    {
        private DatabaseAccess access;
        private Product product;

        public ProductUserControl(Product product)
        {
            InitializeComponent();

            try {
                this.access = DatabaseAccess.getInstance();
                this.product = product;
                this.txtName.Text = this.product.Name;
                this.txtQuantity.Text = this.product.Quantity + "";
                this.txtPrice.Text = this.product.Price + "";
                this.txtPriceSale.Text = this.product.PriceSale + "";
                this.txtNote.Text = this.product.Note;
                if (product.Id == -1)
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

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtQuantity.Text = "";
            this.txtPrice.Text = "";
            this.txtPriceSale.Text = "";
            this.txtNote.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    product.Id = access.SaveProduct(product);
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
                    if (access.UpdateProduct(product))
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
            int result;
            float result2;
            if (this.txtName.Text.Length == 0)
            {
                MessageBox.Show("من فضلك ادخل الاسم", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtName.Focus();
                return false;
            }
            if (!int.TryParse(this.txtQuantity.Text, out result))
            {
                MessageBox.Show("من فضلك ادخل الكمية المتاحة", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtQuantity.Focus();
                return false;

            }
            if (!float.TryParse(this.txtPrice.Text, out result2))
            {
                MessageBox.Show("من فضلك ادخل سعر الشراء", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtPrice.Focus();
                return false;
            }
            if (!float.TryParse(this.txtPriceSale.Text, out result2))
            {
                MessageBox.Show("من فضلك ادخل سعر البيع", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtPriceSale.Focus();
                return false;
            }
            if (float.Parse(this.txtPriceSale.Text) < float.Parse(this.txtPrice.Text))
            {
                MessageBox.Show("من فضلك سعر البيع يجب ان يكون اكبر من سعر الشراء", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtPriceSale.Focus();
                return false;
            }
            this.product.Name = this.txtName.Text;
            this.product.Quantity = int.Parse(this.txtQuantity.Text);
            this.product.Price = float.Parse(this.txtPrice.Text);
            this.product.PriceSale = float.Parse(this.txtPriceSale.Text);
            this.product.Note = this.txtNote.Text;
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
    }
}
