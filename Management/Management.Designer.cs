namespace Management
{
    partial class Management
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param clientId="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSystemManager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.التقاريرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiInbox = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 438);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystemManager,
            this.التقاريرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, -1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "mnuStrip";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmiSystemManager
            // 
            this.tsmiSystemManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmiNewClient,
            this.tsmiNewProduct});
            this.tsmiSystemManager.Name = "tsmiSystemManager";
            this.tsmiSystemManager.Size = new System.Drawing.Size(75, 20);
            this.tsmiSystemManager.Text = "أدارة النظام";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem1.Text = "فاتورة جديدة...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmiNewClient
            // 
            this.tsmiNewClient.Name = "tsmiNewClient";
            this.tsmiNewClient.Size = new System.Drawing.Size(144, 22);
            this.tsmiNewClient.Text = "عميل جديد ...";
            this.tsmiNewClient.Click += new System.EventHandler(this.tsmiNewClient_Click);
            // 
            // tsmiNewProduct
            // 
            this.tsmiNewProduct.Name = "tsmiNewProduct";
            this.tsmiNewProduct.Size = new System.Drawing.Size(144, 22);
            this.tsmiNewProduct.Text = "منتج جديد ...";
            this.tsmiNewProduct.Click += new System.EventHandler(this.tsmiNewProduct_Click);
            // 
            // التقاريرToolStripMenuItem
            // 
            this.التقاريرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiInbox});
            this.التقاريرToolStripMenuItem.Name = "التقاريرToolStripMenuItem";
            this.التقاريرToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.التقاريرToolStripMenuItem.Text = "التقارير";
            // 
            // tmsiInbox
            // 
            this.tmsiInbox.Name = "tmsiInbox";
            this.tmsiInbox.Size = new System.Drawing.Size(116, 22);
            this.tmsiInbox.Text = "الايرلدات";
            this.tmsiInbox.Click += new System.EventHandler(this.tmsiInbox_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Management";
            this.Text = "البيت الحديث";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModernHouse_FormClosing);
            this.Load += new System.EventHandler(this.ModernHouse_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem التقاريرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsiInbox;
    }
}

