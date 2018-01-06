using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModernHouse
{
    public partial class ModernHouse : Form
    {
        private static ClientsUserControl control;
        public ModernHouse()
        {
            InitializeComponent();
        }

        private void ModernHouse_Load(object sender, EventArgs e)
        {
            control = new ClientsUserControl();
            control.Size = panel1.Size;
            panel1.Controls.Add(control);
        }

        public static void ShowDialog(UserControl control, string title)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernHouse));
            Form form = new Form();
            form.Text = title + "...";
            form.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Size = new Size(control.Width + 10, control.Height + 40);
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
            ShowDialog(new OrderUserControl(new App_Code.Order()), "فاتورة جديدة");
        }

        private void ModernHouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tmsiInbox_Click(object sender, EventArgs e)
        {
            ShowDialog(new ReportInboxUserControl(), "التقارير");
        }
    }
}
