namespace QuanLyKho
{
    partial class frmMenu
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.checkmk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.thôngTinSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXuatKho = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txttaikhoan.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(431, 225);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 34);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(271, 82);
            this.txttk.Margin = new System.Windows.Forms.Padding(4);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(259, 22);
            this.txttk.TabIndex = 3;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(271, 228);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(100, 32);
            this.btndangnhap.TabIndex = 5;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(271, 151);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(259, 22);
            this.txtmatkhau.TabIndex = 4;
            // 
            // checkmk
            // 
            this.checkmk.AutoSize = true;
            this.checkmk.Location = new System.Drawing.Point(101, 233);
            this.checkmk.Margin = new System.Windows.Forms.Padding(4);
            this.checkmk.Name = "checkmk";
            this.checkmk.Size = new System.Drawing.Size(83, 21);
            this.checkmk.TabIndex = 2;
            this.checkmk.Text = "Hiển Thị";
            this.checkmk.UseVisualStyleBackColor = true;
            this.checkmk.CheckedChanged += new System.EventHandler(this.checkmk_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttaikhoan.BackColor = System.Drawing.Color.DarkKhaki;
            this.txttaikhoan.Controls.Add(this.btnthoat);
            this.txttaikhoan.Controls.Add(this.txttk);
            this.txttaikhoan.Controls.Add(this.btndangnhap);
            this.txttaikhoan.Controls.Add(this.txtmatkhau);
            this.txttaikhoan.Controls.Add(this.checkmk);
            this.txttaikhoan.Controls.Add(this.label2);
            this.txttaikhoan.Controls.Add(this.label1);
            this.txttaikhoan.Location = new System.Drawing.Point(325, 106);
            this.txttaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Padding = new System.Windows.Forms.Padding(4);
            this.txttaikhoan.Size = new System.Drawing.Size(677, 341);
            this.txttaikhoan.TabIndex = 1;
            this.txttaikhoan.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1304, 619);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txttaikhoan);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1296, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // thôngTinSảnPhẩmToolStripMenuItem
            // 
            this.thôngTinSảnPhẩmToolStripMenuItem.Name = "thôngTinSảnPhẩmToolStripMenuItem";
            this.thôngTinSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinSảnPhẩmToolStripMenuItem.Text = "Thông tin sản phẩm";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.thôngTinSảnPhẩmToolStripMenuItem});
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(79, 24);
            this.btnTroGiup.Text = "Trợ Giúp";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thêmTàiKhoảnToolStripMenuItem
            // 
            this.thêmTàiKhoảnToolStripMenuItem.Name = "thêmTàiKhoảnToolStripMenuItem";
            this.thêmTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmTàiKhoảnToolStripMenuItem.Text = "Thêm Tài Khoản";
            this.thêmTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thêmTàiKhoảnToolStripMenuItem_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(87, 24);
            this.btnTaiKhoan.Text = "Tài Khoản";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(86, 24);
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(83, 24);
            this.btnXuatKho.Text = "Xuất Kho";
            this.btnXuatKho.Click += new System.EventHandler(this.xuấtKhoToolStripMenuItem_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(89, 24);
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.Click += new System.EventHandler(this.nhậpKhoToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNhapKho,
            this.btnXuatKho,
            this.btnThongKe,
            this.btnTaiKhoan,
            this.btnTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 647);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.txttaikhoan.ResumeLayout(false);
            this.txttaikhoan.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.CheckBox checkmk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox txttaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTroGiup;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem btnThongKe;
        private System.Windows.Forms.ToolStripMenuItem btnXuatKho;
        private System.Windows.Forms.ToolStripMenuItem btnNhapKho;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}