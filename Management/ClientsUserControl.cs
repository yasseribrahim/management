using System;
using System.Windows.Forms;
using Management.App_Code;

namespace Management
{
    public partial class ClientsUserControl : UserControl
    {
        private DatabaseAccess access;

        public ClientsUserControl()
        {
            InitializeComponent();

            try {
                this.access = DatabaseAccess.getInstance();
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
            Management.ShowDialog(new ClientUserControl(new Client()), "عميل جديد");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Management.ShowDialog(new OrderUserControl(new Order()), "فاتورة جديدة");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Management.ShowDialog(new ClientUserControl(new Client()), "عميل جديد");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Management.ShowDialog(new ProductUserControl(new Product()), "منتج جديد");
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
        }
    }
}
