namespace QLKS.UC_Main
{
    partial class UC_QuanLyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QuanLyPhong));
            this.ContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem_SoDoPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Phong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Booking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_CheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_SoDoPhong,
            this.toolStripMenuItem_Phong,
            this.toolStripMenuItem_Booking,
            this.toolStripMenuItem_CheckOut});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip.RenderStyle.ColorTable = null;
            this.ContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.ContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuStrip.Size = new System.Drawing.Size(274, 132);
            // 
            // toolStripMenuItem_SoDoPhong
            // 
            this.toolStripMenuItem_SoDoPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_SoDoPhong.Name = "toolStripMenuItem_SoDoPhong";
            this.toolStripMenuItem_SoDoPhong.Size = new System.Drawing.Size(273, 32);
            this.toolStripMenuItem_SoDoPhong.Text = "Sơ Đồ Phòng";
            this.toolStripMenuItem_SoDoPhong.Click += new System.EventHandler(this.toolStripMenuItem_SoDoPhong_Click);
            // 
            // toolStripMenuItem_Phong
            // 
            this.toolStripMenuItem_Phong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_Phong.Name = "toolStripMenuItem_Phong";
            this.toolStripMenuItem_Phong.Size = new System.Drawing.Size(273, 32);
            this.toolStripMenuItem_Phong.Text = "Quản Lý Phòng Thuê";
            this.toolStripMenuItem_Phong.Click += new System.EventHandler(this.toolStripMenuItem_Status_Click);
            // 
            // toolStripMenuItem_Booking
            // 
            this.toolStripMenuItem_Booking.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_Booking.Name = "toolStripMenuItem_Booking";
            this.toolStripMenuItem_Booking.Size = new System.Drawing.Size(273, 32);
            this.toolStripMenuItem_Booking.Text = "Quản Lý Đặt Phòng";
            this.toolStripMenuItem_Booking.Click += new System.EventHandler(this.toolStripMenuItem_Booking_Click);
            // 
            // toolStripMenuItem_CheckOut
            // 
            this.toolStripMenuItem_CheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_CheckOut.Name = "toolStripMenuItem_CheckOut";
            this.toolStripMenuItem_CheckOut.Size = new System.Drawing.Size(273, 32);
            this.toolStripMenuItem_CheckOut.Text = "Quản Lý Trả Phòng";
            this.toolStripMenuItem_CheckOut.Click += new System.EventHandler(this.toolStripMenuItem_CheckOut_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = global::QLKS.Properties.Resources.Screenshot_2024_07_29_211213___Copy;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = global::QLKS.Properties.Resources.Screenshot_2024_07_29_211213;
            this.bunifuImageButton3.ImageActive = global::QLKS.Properties.Resources.Screenshot_2024_07_29_211213___Copy;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 0;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(378, 69);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(379, 70);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(85, 3);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(379, 70);
            this.bunifuImageButton3.TabIndex = 12;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 0;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click_1);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel2.BorderRadius = 30;
            this.bunifuPanel2.BorderThickness = 5;
            this.bunifuPanel2.Location = new System.Drawing.Point(19, 74);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1898, 997);
            this.bunifuPanel2.TabIndex = 10;
            this.bunifuPanel2.Click += new System.EventHandler(this.bunifuPanel2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKS.Properties.Resources.menu;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(19, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UC_QuanLyKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_QuanLyKhachSan";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.UC_QuanLyPhong_Load);
            this.ContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_CheckOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Phong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Booking;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SoDoPhong;
    }
}
