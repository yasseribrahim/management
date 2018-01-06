﻿using System;
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
    public partial class ReportInboxUserControl : UserControl
    {
        private DatabaseAccess access;

        public ReportInboxUserControl()
        {
            InitializeComponent();
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
            try
            {
                this.access = DatabaseAccess.getInstance();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message...");
            }
        }

        private void rdoInterval_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInterval.Checked)
            {
                btnSearch.Enabled = true;
                dtpDay.Enabled = false;
                cbxMonthly.Enabled = false;
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
        }

        private void rdoMonthely_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMonthely.Checked)
            {
                btnSearch.Enabled = true;
                dtpDay.Enabled = false;
                cbxMonthly.Enabled = true;
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }

        private void rdoDayly_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDayly.Checked)
            {
                btnSearch.Enabled = true;
                dtpDay.Enabled = true;
                cbxMonthly.Enabled = false;
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now.AddMonths(-1);
            DateTime date2 = DateTime.Now;
            if (rdoDayly.Checked)
            {
                date1 = dtpDay.Value;
                date2 = date1;
            }
            else if (rdoInterval.Checked)
            {
                date1 = dtpFrom.Value;
                date2 = dtpTo.Value;
            }

            try
            {
                dgvIncoming.Rows.Clear();
                dgvSales.Rows.Clear();
                txtTotal.Text = "";
                txtTotalIncoming.Text = "";
                txtTotalDiscount.Text = "";
                txtTotalSale.Text = "";
                List<OperationDelay> delies = access.GetAllOperationDelay(date1.Date, date2.Date);
                List<OrdersInfo> orders = access.GetAllOrdersInfo(date1.Date, date2.Date);

                int counter = 1;
                float totalIncoming = 0, total = 0, totalSale = 0, totalDiscount = 0;
                foreach(OperationDelay delay in delies)
                {
                    dgvIncoming.Rows.Add(new object[] { counter, delay.Date.ToShortDateString(), delay.Paied});
                    totalIncoming += delay.Paied;
                    counter++;
                }

                counter = 1;
                foreach (OrdersInfo order in orders)
                {
                    dgvSales.Rows.Add(new object[] { counter, order.Date.ToShortDateString(), order.Total, order.TotalSale, order.Discount });
                    total += order.Total;
                    totalSale += order.TotalSale;
                    totalDiscount += order.Discount;
                    counter++;
                }

                txtTotal.Text = total + "";
                txtTotalIncoming.Text = totalIncoming + "";
                txtTotalDiscount.Text = totalDiscount + "";
                txtTotalSale.Text = totalSale + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message...");
            }
        }

        private void ReportInboxUserControl_Load(object sender, EventArgs e)
        {
            int width = this.dgvIncoming.Width;
            int normal = (int)(0.35 * width);
            int id = (int)(0.1 * width);// 5%
            int date = width - (normal + id + 40);
            dgvIncoming.Columns[0].Width = id;
            dgvIncoming.Columns[1].Width = date;
            dgvIncoming.Columns[2].Width = normal;

            width = this.dgvSales.Width;
            normal = (int)(0.25 * width);// 10%
            id = (int)(0.1 * width);// 5%
            date = width - ((normal * 2) + id + 40);
            dgvSales.Columns[0].Width = id;
            dgvSales.Columns[1].Width = date;
            dgvSales.Columns[2].Width = normal;
            dgvSales.Columns[3].Width = normal;
        }
    }
}