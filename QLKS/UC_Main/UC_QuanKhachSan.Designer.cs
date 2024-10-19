namespace QLKS.UC_Main
{
    partial class UC_QuanKhachSan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýKháchSạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLoạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.danhSáchPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1824, 60);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKháchSạnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1824, 59);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quảnLýKháchSạnToolStripMenuItem
            // 
            this.quảnLýKháchSạnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchLoạiPhòngToolStripMenuItem,
            this.toolStripSeparator1,
            this.danhSáchPhòngToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1});
            this.quảnLýKháchSạnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 22.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýKháchSạnToolStripMenuItem.Image = global::QLKS.Properties.Resources.menu1;
            this.quảnLýKháchSạnToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quảnLýKháchSạnToolStripMenuItem.Name = "quảnLýKháchSạnToolStripMenuItem";
            this.quảnLýKháchSạnToolStripMenuItem.Size = new System.Drawing.Size(401, 55);
            this.quảnLýKháchSạnToolStripMenuItem.Text = "Quản Lý Khách Sạn";
            this.quảnLýKháchSạnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchSạnToolStripMenuItem_Click);
            // 
            // danhSáchLoạiPhòngToolStripMenuItem
            // 
            this.danhSáchLoạiPhòngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchLoạiPhòngToolStripMenuItem.Image = global::QLKS.Properties.Resources.beds;
            this.danhSáchLoạiPhòngToolStripMenuItem.Name = "danhSáchLoạiPhòngToolStripMenuItem";
            this.danhSáchLoạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(451, 50);
            this.danhSáchLoạiPhòngToolStripMenuItem.Text = "Danh Sách Loại Phòng";
            this.danhSáchLoạiPhòngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchLoạiPhòngToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(448, 6);
            // 
            // danhSáchPhòngToolStripMenuItem
            // 
            this.danhSáchPhòngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchPhòngToolStripMenuItem.Image = global::QLKS.Properties.Resources.bedroom;
            this.danhSáchPhòngToolStripMenuItem.Name = "danhSáchPhòngToolStripMenuItem";
            this.danhSáchPhòngToolStripMenuItem.Size = new System.Drawing.Size(451, 50);
            this.danhSáchPhòngToolStripMenuItem.Text = "Danh Sách Phòng";
            this.danhSáchPhòngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhòngToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(448, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Image = global::QLKS.Properties.Resources.tiles1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(451, 50);
            this.toolStripMenuItem1.Text = "Danh Sách Tầng";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1824, 946);
            this.panel2.TabIndex = 1;
            // 
            // UC_QuanKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_QuanKhachSan";
            this.Size = new System.Drawing.Size(1824, 1008);
            this.Load += new System.EventHandler(this.UC_QuanLyPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchSạnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLoạiPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
