namespace BTL_QL_KTX
{
    partial class frmTrangChu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTínToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinPhongKíTúcXáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTiềnĐiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTiềnNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTiềnWifiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTiềnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSINHVIEN = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSINHVIEN)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýTàiToolStripMenuItem,
            this.cậpNhậtThôngTinPhongKíTúcXáToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinSinhViênToolStripMenuItem});
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
            // 
            // xemThôngTinSinhViênToolStripMenuItem
            // 
            this.xemThôngTinSinhViênToolStripMenuItem.Name = "xemThôngTinSinhViênToolStripMenuItem";
            this.xemThôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.xemThôngTinSinhViênToolStripMenuItem.Text = "Xem thông tin sinh viên";
            this.xemThôngTinSinhViênToolStripMenuItem.Click += new System.EventHandler(this.Xem_TTSV_Click);
            // 
            // quảnLýTàiToolStripMenuItem
            // 
            this.quảnLýTàiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmThôngTinToolStripMenuItem,
            this.sửaThôngTínToolStripMenuItem,
            this.xóaThôngTinToolStripMenuItem});
            this.quảnLýTàiToolStripMenuItem.Name = "quảnLýTàiToolStripMenuItem";
            this.quảnLýTàiToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.quảnLýTàiToolStripMenuItem.Text = "Cập nhật thông tin";
            this.quảnLýTàiToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiToolStripMenuItem_Click);
            // 
            // thêmThôngTinToolStripMenuItem
            // 
            this.thêmThôngTinToolStripMenuItem.Name = "thêmThôngTinToolStripMenuItem";
            this.thêmThôngTinToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.thêmThôngTinToolStripMenuItem.Text = "Thêm thông tin";
            // 
            // sửaThôngTínToolStripMenuItem
            // 
            this.sửaThôngTínToolStripMenuItem.Name = "sửaThôngTínToolStripMenuItem";
            this.sửaThôngTínToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.sửaThôngTínToolStripMenuItem.Text = "Sửa thông tín";
            // 
            // xóaThôngTinToolStripMenuItem
            // 
            this.xóaThôngTinToolStripMenuItem.Name = "xóaThôngTinToolStripMenuItem";
            this.xóaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.xóaThôngTinToolStripMenuItem.Text = "Xóa thông tin";
            // 
            // cậpNhậtThôngTinPhongKíTúcXáToolStripMenuItem
            // 
            this.cậpNhậtThôngTinPhongKíTúcXáToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmTiềnĐiệnToolStripMenuItem,
            this.thêmTiềnNướcToolStripMenuItem,
            this.thêmTiềnWifiToolStripMenuItem,
            this.thêmTiềnPhòngToolStripMenuItem});
            this.cậpNhậtThôngTinPhongKíTúcXáToolStripMenuItem.Name = "cậpNhậtThôngTinPhongKíTúcXáToolStripMenuItem";
            this.cậpNhậtThôngTinPhongKíTúcXáToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.cậpNhậtThôngTinPhongKíTúcXáToolStripMenuItem.Text = "Cập nhật thông tin phong kí túc xá";
            // 
            // thêmTiềnĐiệnToolStripMenuItem
            // 
            this.thêmTiềnĐiệnToolStripMenuItem.Name = "thêmTiềnĐiệnToolStripMenuItem";
            this.thêmTiềnĐiệnToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.thêmTiềnĐiệnToolStripMenuItem.Text = "Thêm tiền điện";
            // 
            // thêmTiềnNướcToolStripMenuItem
            // 
            this.thêmTiềnNướcToolStripMenuItem.Name = "thêmTiềnNướcToolStripMenuItem";
            this.thêmTiềnNướcToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.thêmTiềnNướcToolStripMenuItem.Text = "Thêm tiền nước";
            // 
            // thêmTiềnWifiToolStripMenuItem
            // 
            this.thêmTiềnWifiToolStripMenuItem.Name = "thêmTiềnWifiToolStripMenuItem";
            this.thêmTiềnWifiToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.thêmTiềnWifiToolStripMenuItem.Text = "Thêm tiền wifi";
            // 
            // thêmTiềnPhòngToolStripMenuItem
            // 
            this.thêmTiềnPhòngToolStripMenuItem.Name = "thêmTiềnPhòngToolStripMenuItem";
            this.thêmTiềnPhòngToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.thêmTiềnPhòngToolStripMenuItem.Text = "Thêm tiền phòng";
            // 
            // dgvSINHVIEN
            // 
            this.dgvSINHVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSINHVIEN.Location = new System.Drawing.Point(75, 132);
            this.dgvSINHVIEN.Name = "dgvSINHVIEN";
            this.dgvSINHVIEN.RowHeadersWidth = 51;
            this.dgvSINHVIEN.RowTemplate.Height = 24;
            this.dgvSINHVIEN.Size = new System.Drawing.Size(693, 246);
            this.dgvSINHVIEN.TabIndex = 3;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSINHVIEN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSINHVIEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTínToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinPhongKíTúcXáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTiềnĐiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTiềnNướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTiềnWifiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTiềnPhòngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSINHVIEN;
    }
}