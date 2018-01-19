using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Management.App_Code;

namespace Management
{
    public partial class ClientUserControl : UserControl
    {
        private DatabaseAccess access;
        private Client client;

        public ClientUserControl(Client client)
        {
            InitializeComponent();

            try {
                this.access = DatabaseAccess.getInstance();
                this.client = client;
                this.txtName.Text = this.client.Name;
                this.txtPhone.Text = this.client.Phone;
                this.txtAddress.Text = this.client.Address;
                this.txtNote.Text = this.client.Note;
                if (client.Id == -1)
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
            this.txtPhone.Text = "";
            this.txtAddress.Text = "";
            this.txtNote.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UIUtilties.Loading(true);
            try
            {
                if (Validate())
                {
                    client.Id = access.SaveClient(client);
                    MessageBox.Show(" تم الحفظ", "Message....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم الحفظ" + "\n" + ex.Message, "Error Message....", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            UIUtilties.Loading(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UIUtilties.Loading(true);
            try
            {
                if (Validate())
                {
                    if (access.UpdateClient(client))
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
            UIUtilties.Loading(false);
        }

        private new bool Validate()
        {
            this.client.Name = this.txtName.Text;
            this.client.Phone = this.txtPhone.Text;
            this.client.Address = this.txtAddress.Text;
            this.client.Note = this.txtNote.Text;
            if (this.client.Name.Length == 0)
            {
                MessageBox.Show("من فضلك ادخل الاسم", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtName.Focus();
                return false;
            }
            if (this.client.Phone.Length == 0)
            {
                MessageBox.Show("من فضلك ادخل الهاتف", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtPhone.Focus();
                return false;

            }
            if (this.client.Address.Length == 0)
            {
                MessageBox.Show("من فضلك ادخل العنوان", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtAddress.Focus();
                return false;
            }
            return true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int) e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
