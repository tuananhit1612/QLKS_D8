namespace QLKS.UC_QLKhachSan.UC_SoDoPhong
{
    partial class UC_Tang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Tang));
            this.PanelLoaiPhong = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTang = new System.Windows.Forms.Label();
            this.PanelLoaiPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLoaiPhong
            // 
            this.PanelLoaiPhong.BackgroundColor = System.Drawing.Color.White;
            this.PanelLoaiPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLoaiPhong.BackgroundImage")));
            this.PanelLoaiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLoaiPhong.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelLoaiPhong.BorderRadius = 20;
            this.PanelLoaiPhong.BorderThickness = 1;
            this.PanelLoaiPhong.Controls.Add(this.flowLayoutPanel1);
            this.PanelLoaiPhong.Controls.Add(this.label1);
            this.PanelLoaiPhong.Controls.Add(this.lblTang);
            this.PanelLoaiPhong.Location = new System.Drawing.Point(3, 3);
            this.PanelLoaiPhong.Name = "PanelLoaiPhong";
            this.PanelLoaiPhong.ShowBorders = true;
            this.PanelLoaiPhong.Size = new System.Drawing.Size(3997, 231);
            this.PanelLoaiPhong.TabIndex = 5;
            this.PanelLoaiPhong.Click += new System.EventHandler(this.PanelLoaiPhong_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(3859, 225);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tầng";
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.BackColor = System.Drawing.Color.White;
            this.lblTang.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTang.Location = new System.Drawing.Point(28, 109);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(46, 54);
            this.lblTang.TabIndex = 1;
            this.lblTang.Text = "1";
            // 
            // UC_Tang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelLoaiPhong);
            this.Name = "UC_Tang";
            this.Size = new System.Drawing.Size(4000, 231);
            this.Load += new System.EventHandler(this.UC_Tang_Load);
            this.PanelLoaiPhong.ResumeLayout(false);
            this.PanelLoaiPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel PanelLoaiPhong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.Label label1;
    }
}
