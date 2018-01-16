using System;
using System.Drawing;
using System.Windows.Forms;
using Management.App_Code;

namespace Management
{
    public partial class Management : Form
    {
        private static OrdersListUserControl control;
        public Management()
        {
            InitializeComponent();
        }

        private void ModernHouse_Load(object sender, EventArgs e)
        {
            control = new OrdersListUserControl();
            control.Size = panel1.Size;
            panel1.Controls.Add(control);
        }

        public static void ShowDialog(UserControl control, string title)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            Form form = new Form();
            form.Text = title + "...";
            form.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Size = new Size(control.Width + 40, control.Height + 40);
            form.Controls.Add(control);
            form.StartPosition = FormStartPosition.CenterParent;
            control.Dock = DockStyle.Fill;
            form.ShowDialog();
        }

        private void tsmiNewProduct_Click(object sender, EventArgs e)
        {
            ShowDialog(new ProductUserControl(new App_Code.Product()), "منتج جديد");
        }

        private void tsmiNewClient_Click(object sender, EventArgs e)
        {
            ShowDialog(new ClientUserControl(new App_Code.Client()), "عميل جديد");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderUserControl order = new OrderUserControl(new App_Code.Order());
            order.OrderListener = control;
            ShowDialog(order, "فاتورة جديدة");
        }

        private void ModernHouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tmsiInbox_Click(object sender, EventArgs e)
        {
            ShowDialog(new ReportInboxUserControl(), "التقارير");
        }

        private void tmsiViewProducts_Click(object sender, EventArgs e)
        {
            ShowDialog(new ProductsUserControl(), "عرض المنتجات");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DatabaseAccess.getInstance().GetCountProductsRequired() > 0)
            {
                UIUtilties.ShowNotification("من فضلك تحقق من الكميات المتاحة للمنتجات");
            }
        }
    }
}
