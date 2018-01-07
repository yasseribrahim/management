namespace Management
{
    partial class ReportInboxUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxMonthly = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.rdoInterval = new System.Windows.Forms.RadioButton();
            this.rdoMonthely = new System.Windows.Forms.RadioButton();
            this.rdoDayly = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxSales = new System.Windows.Forms.GroupBox();
            this.txtTotalDiscount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbxSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbxMonthly);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpDay);
            this.groupBox1.Controls.Add(this.rdoInterval);
            this.groupBox1.Controls.Add(this.rdoMonthely);
            this.groupBox1.Controls.Add(this.rdoDayly);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(419, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(697, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختر نوع التقرير";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(7, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "بحــــــث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxMonthly
            // 
            this.cbxMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonthly.FormattingEnabled = true;
            this.cbxMonthly.Location = new System.Drawing.Point(410, 52);
            this.cbxMonthly.Name = "cbxMonthly";
            this.cbxMonthly.Size = new System.Drawing.Size(215, 23);
            this.cbxMonthly.TabIndex = 15;
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(144, 81);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(213, 21);
            this.dtpTo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(373, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "الى";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(410, 81);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(215, 21);
            this.dtpFrom.TabIndex = 12;
            // 
            // dtpDay
            // 
            this.dtpDay.Enabled = false;
            this.dtpDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDay.Location = new System.Drawing.Point(410, 21);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(215, 21);
            this.dtpDay.TabIndex = 11;
            // 
            // rdoInterval
            // 
            this.rdoInterval.AutoSize = true;
            this.rdoInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInterval.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoInterval.Location = new System.Drawing.Point(650, 81);
            this.rdoInterval.Name = "rdoInterval";
            this.rdoInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoInterval.Size = new System.Drawing.Size(36, 19);
            this.rdoInterval.TabIndex = 10;
            this.rdoInterval.TabStop = true;
            this.rdoInterval.Text = "من";
            this.rdoInterval.UseVisualStyleBackColor = true;
            this.rdoInterval.CheckedChanged += new System.EventHandler(this.rdoInterval_CheckedChanged);
            // 
            // rdoMonthely
            // 
            this.rdoMonthely.AutoSize = true;
            this.rdoMonthely.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMonthely.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoMonthely.Location = new System.Drawing.Point(637, 53);
            this.rdoMonthely.Name = "rdoMonthely";
            this.rdoMonthely.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoMonthely.Size = new System.Drawing.Size(49, 19);
            this.rdoMonthely.TabIndex = 9;
            this.rdoMonthely.TabStop = true;
            this.rdoMonthely.Text = "شهريا";
            this.rdoMonthely.UseVisualStyleBackColor = true;
            this.rdoMonthely.CheckedChanged += new System.EventHandler(this.rdoMonthely_CheckedChanged);
            // 
            // rdoDayly
            // 
            this.rdoDayly.AutoSize = true;
            this.rdoDayly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDayly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoDayly.Location = new System.Drawing.Point(642, 25);
            this.rdoDayly.Name = "rdoDayly";
            this.rdoDayly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoDayly.Size = new System.Drawing.Size(44, 19);
            this.rdoDayly.TabIndex = 8;
            this.rdoDayly.TabStop = true;
            this.rdoDayly.Text = "يوميا";
            this.rdoDayly.UseVisualStyleBackColor = true;
            this.rdoDayly.CheckedChanged += new System.EventHandler(this.rdoDayly_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(5, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1111, 1);
            this.label5.TabIndex = 14;
            // 
            // gbxSales
            // 
            this.gbxSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxSales.Controls.Add(this.txtTotalDiscount);
            this.gbxSales.Controls.Add(this.txtTotal);
            this.gbxSales.Controls.Add(this.label7);
            this.gbxSales.Controls.Add(this.txtTotalSale);
            this.gbxSales.Controls.Add(this.label8);
            this.gbxSales.Controls.Add(this.label4);
            this.gbxSales.Controls.Add(this.label6);
            this.gbxSales.Controls.Add(this.dgvSales);
            this.gbxSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSales.ForeColor = System.Drawing.Color.Navy;
            this.gbxSales.Location = new System.Drawing.Point(5, 138);
            this.gbxSales.Name = "gbxSales";
            this.gbxSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxSales.Size = new System.Drawing.Size(1111, 401);
            this.gbxSales.TabIndex = 17;
            this.gbxSales.TabStop = false;
            this.gbxSales.Text = "المبيعات";
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDiscount.Enabled = false;
            this.txtTotalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDiscount.Location = new System.Drawing.Point(532, 367);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.Size = new System.Drawing.Size(179, 21);
            this.txtTotalDiscount.TabIndex = 21;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(808, 341);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(179, 21);
            this.txtTotal.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(474, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(631, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "اجمالى الشراء";
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalSale.Enabled = false;
            this.txtTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSale.Location = new System.Drawing.Point(808, 370);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.Size = new System.Drawing.Size(179, 21);
            this.txtTotalSale.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(171, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(631, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "أجمالى الخصومات";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(474, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(631, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "أجمالى المبيعات";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(6, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1099, 1);
            this.label6.TabIndex = 16;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3});
            this.dgvSales.Location = new System.Drawing.Point(6, 19);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvSales.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSales.Size = new System.Drawing.Size(1099, 302);
            this.dgvSales.TabIndex = 15;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "م";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 38;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "التاريخ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "اسعار الشراء";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "المبيعات";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "الخصومات";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ReportInboxUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ReportInboxUserControl";
            this.Size = new System.Drawing.Size(1121, 542);
            this.Load += new System.EventHandler(this.ReportInboxUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxSales.ResumeLayout(false);
            this.gbxSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxMonthly;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.RadioButton rdoInterval;
        private System.Windows.Forms.RadioButton rdoMonthely;
        private System.Windows.Forms.RadioButton rdoDayly;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxSales;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
