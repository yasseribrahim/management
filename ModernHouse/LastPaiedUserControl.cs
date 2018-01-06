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
    public partial class LastPaiedUserControl : UserControl
    {
        private DatabaseAccess access;
        private ClientInfo client;
        private AccountingHistory history;

        public LastPaiedUserControl(ClientInfo client)
        {
            InitializeComponent();

            try {
                this.access = DatabaseAccess.getInstance();
                this.client = client;
                this.txtName.Text = this.client.Name;
                this.txtBalance.Text = (-1 * client.Blance) + "";
                this.btnSave.Enabled = true;
                this.btnUpdate.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message...");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtLastPaied.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    if (access.SaveAccountingHistory(history))
                    {
                        MessageBox.Show(" تم الحفظ", "Message....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        client = access.GetClientInfoById(client.Id);
                        this.txtBalance.Text = (-1 * client.Blance) + "";
                        txtLastPaied.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("لم يتم الحفظ", "Error Message....", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
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
                  //  if (access.UpdateProduct(client))
                    //{
                      ///  MessageBox.Show(" تم التعديل", "Message....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //else
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
            history = null;
            int paied;
            DateTime paiedDate = dtpDate.Value;
            if (this.txtLastPaied.Text.Length == 0)
            {
                MessageBox.Show("من فضلك ادخل المبلغ المدفوع", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtLastPaied.Focus();
                return false;
            }
            if(!int.TryParse(this.txtLastPaied.Text, out paied))
            {
                MessageBox.Show("يوجد خطاء فى المبلغ المدفوع", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtLastPaied.Focus();
                return false;
            }
            if ((paied > (-1 * client.Blance)) || (paied == 0))
            {
                MessageBox.Show("يوجد خطاء فى المبلغ المدفوع", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtLastPaied.Focus();
                return false;
            }
            if (paiedDate == null)
            {
                MessageBox.Show("من فضلك ادخل التاريخ", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.dtpDate.Focus();
                return false;
            }

            history = new AccountingHistory(-1, client.Id, paied, paiedDate);
            return true;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtLastPaied_TextChanged(object sender, EventArgs e)
        {
            int paied;
            if (txtLastPaied.Text.Length == 0)
            {
                txtLastPaied.Text = "0";
            }
            paied = int.Parse(txtLastPaied.Text);
            txtTotal.Text = (((-1 * client.Blance) - paied) > 0) ? ((-1 * client.Blance) - paied) + "" : (-1 * client.Blance) + "";
        }
    }
}
