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
    public partial class ClientsUserControl : UserControl
    {
        private DatabaseAccess access;
        private List<ClientInfo> clients;

        public ClientsUserControl()
        {
            InitializeComponent();

            try {
                this.access = DatabaseAccess.getInstance();
                this.clients = access.GetAllClientInfos();
                FillData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message...");
            }
        }

        private void ClientUserControl_Load(object sender, EventArgs e)
        {
            int width = this.Width;
            int normal = (int)(0.1 * width);// 40%
            int id = (int)(0.05 * width);// 5%
            int name = (int)(0.2 * width);// 20%
            int address = width - ((normal * 4) + id + name + 40);
            dgvClients.Columns[0].Width = id;
            dgvClients.Columns[1].Width = name;
            dgvClients.Columns[2].Width = address;
            dgvClients.Columns[3].Width = normal;
            dgvClients.Columns[4].Width = normal;
            dgvClients.Columns[5].Width = normal;
            dgvClients.Columns[6].Width = normal;

            dgvStatistical.Columns[0].Width = id;
            dgvStatistical.Columns[1].Width = name;
            dgvStatistical.Columns[2].Width = address;
            dgvStatistical.Columns[3].Width = normal;
            dgvStatistical.Columns[4].Width = normal;
            dgvStatistical.Columns[5].Width = normal;
            dgvStatistical.Columns[6].Width = normal;

            splitContainer1.SplitterDistance = (int)(0.7 * this.Height);
        }

        private void FillData()
        {
            dgvClients.Rows.Clear();
            foreach (ClientInfo client in clients)
            {
                dgvClients.Rows.Add(new object[] { client.Id, client.Name, client.Address, client.Phone, client.Blance * -1, client.LastPaied, client.LastPaiedDate });
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            refresh(txtName.Text);
        }

        private void refresh(string name)
        { 
            if(name == null)
            {
                clients = access.GetAllClientInfos();
                FillData();
            }
            else if (name.Length != 0)
            {
                clients = access.GetAllClientInfosByName(name);
                FillData();
                if (clients.Count == 0)
                {
                    MessageBox.Show("لا يوجد عملاء بهذا الاسم : " + name, "Message...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                btnSearch.Enabled = true;
            } else
            {
                btnSearch.Enabled = false;
            }
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            ModernHouse.ShowDialog(new ClientUserControl(new Client()), "عميل جديد");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadClients();
        }

        private void addLastPaiedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientInfo client = getSelectedClientInfo();
            if (client != null)
            {
                ModernHouse.ShowDialog(new LastPaiedUserControl(client), "دفعة جديدة");
            }
        }

        private void showAccountingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientInfo client = getSelectedClientInfo();
            if (client != null)
            {
                ModernHouse.ShowDialog(new AccountingHistoryUserControl(client), "عرض حساب عميل");
            }
        }

        private ClientInfo getSelectedClientInfo()
        {
            if(dgvClients.SelectedRows.Count > 0)
            {
                return clients[dgvClients.SelectedRows[0].Index];
            }
            else
            {
                MessageBox.Show("من فضلك اختر العميل اولا", "Message...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }

        public void ReloadClients()
        {
            string name = txtName.Text;
            refresh((name.Length > 0) ? name : null);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModernHouse.ShowDialog(new OrderUserControl(new Order()), "فاتورة جديدة");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModernHouse.ShowDialog(new ClientUserControl(new Client()), "عميل جديد");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModernHouse.ShowDialog(new ProductUserControl(new Product()), "منتج جديد");
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            if (txtDays.Text.Length > 0)
            {
                btnSearch2.Enabled = true;
            }
            else
            {
                btnSearch2.Enabled = false;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            try {
                int days = int.Parse(txtDays.Text);
                DateTime date = DateTime.Now.AddDays(days * -1);
                dgvStatistical.Rows.Clear();
                List<ClientInfo> operations = access.GetAllClientInfosByDate(date);
                foreach (ClientInfo client in operations)
                {
                    dgvStatistical.Rows.Add(new object[] { client.Id, client.Name, client.Address, client.Phone, client.Blance * -1, client.LastPaied, client.LastPaiedDate });
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
