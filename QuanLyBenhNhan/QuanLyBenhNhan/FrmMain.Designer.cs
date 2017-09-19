namespace QuanLyBenhNhan
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuhethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuhuydangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuquanlynguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuquanlybenhnhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthongtinhanhchinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubenhbanchitiet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuchuyenkhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudichvusudung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthanhtoanvientphi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuxuatvienchuyenvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimkiemtheotenvama = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimtheodonthuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimkiemdichvusudung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutimkiemgiuongbenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucapnhatdanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmucbacsi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmucdichvu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmucthuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmuckhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmucphong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhethong,
            this.mnuquanlybenhnhan,
            this.mnutimkiem,
            this.mnucapnhatdanhmuc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuhethong
            // 
            this.mnuhethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudangnhap,
            this.mnuhuydangxuat,
            this.mnuthoat,
            this.menuquanlynguoidung});
            this.mnuhethong.Name = "mnuhethong";
            this.mnuhethong.Size = new System.Drawing.Size(69, 20);
            this.mnuhethong.Text = "Hệ thống";
            // 
            // mnudangnhap
            // 
            this.mnudangnhap.Name = "mnudangnhap";
            this.mnudangnhap.Size = new System.Drawing.Size(185, 22);
            this.mnudangnhap.Text = "Đăng Nhập";
            this.mnudangnhap.Click += new System.EventHandler(this.mnudangxuathethong_Click);
            // 
            // mnuhuydangxuat
            // 
            this.mnuhuydangxuat.Name = "mnuhuydangxuat";
            this.mnuhuydangxuat.Size = new System.Drawing.Size(185, 22);
            this.mnuhuydangxuat.Text = "Đổi Mật Khẩu";
            this.mnuhuydangxuat.Click += new System.EventHandler(this.mnuhuydangxuat_Click);
            // 
            // mnuthoat
            // 
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(185, 22);
            this.mnuthoat.Text = "Kết Nối CSDL";
            this.mnuthoat.Click += new System.EventHandler(this.mnuthoat_Click);
            // 
            // menuquanlynguoidung
            // 
            this.menuquanlynguoidung.Name = "menuquanlynguoidung";
            this.menuquanlynguoidung.Size = new System.Drawing.Size(185, 22);
            this.menuquanlynguoidung.Text = "Quản Lý Người Dùng";
            this.menuquanlynguoidung.Click += new System.EventHandler(this.menuquanlynguoidung_Click);
            // 
            // mnuquanlybenhnhan
            // 
            this.mnuquanlybenhnhan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuthongtinhanhchinh,
            this.mnubenhbanchitiet,
            this.mnuchuyenkhoa,
            this.mnudichvusudung,
            this.mnuthuoc,
            this.mnuthanhtoanvientphi,
            this.mnuxuatvienchuyenvien});
            this.mnuquanlybenhnhan.Name = "mnuquanlybenhnhan";
            this.mnuquanlybenhnhan.Size = new System.Drawing.Size(124, 20);
            this.mnuquanlybenhnhan.Text = "Quản Lý Bệnh Nhân";
            this.mnuquanlybenhnhan.Click += new System.EventHandler(this.mnucapnhatthongtin_Click);
            // 
            // mnuthongtinhanhchinh
            // 
            this.mnuthongtinhanhchinh.Name = "mnuthongtinhanhchinh";
            this.mnuthongtinhanhchinh.Size = new System.Drawing.Size(196, 22);
            this.mnuthongtinhanhchinh.Text = "Thông Tin Hành Chính";
            this.mnuthongtinhanhchinh.Click += new System.EventHandler(this.mnucapnhathocsinh_Click);
            // 
            // mnubenhbanchitiet
            // 
            this.mnubenhbanchitiet.Name = "mnubenhbanchitiet";
            this.mnubenhbanchitiet.Size = new System.Drawing.Size(196, 22);
            this.mnubenhbanchitiet.Text = "Bệnh Án Chi Tiết";
            this.mnubenhbanchitiet.Click += new System.EventHandler(this.mnucapnhatgiaovien_Click);
            // 
            // mnuchuyenkhoa
            // 
            this.mnuchuyenkhoa.Name = "mnuchuyenkhoa";
            this.mnuchuyenkhoa.Size = new System.Drawing.Size(196, 22);
            this.mnuchuyenkhoa.Text = "Chuyển Khoa";
            this.mnuchuyenkhoa.Click += new System.EventHandler(this.mnucapnhatmonhoc_Click);
            // 
            // mnudichvusudung
            // 
            this.mnudichvusudung.Name = "mnudichvusudung";
            this.mnudichvusudung.Size = new System.Drawing.Size(196, 22);
            this.mnudichvusudung.Text = "Dịch Vụ Sử Dụng ";
            this.mnudichvusudung.Click += new System.EventHandler(this.mnucapnhathocky_Click);
            // 
            // mnuthuoc
            // 
            this.mnuthuoc.Name = "mnuthuoc";
            this.mnuthuoc.Size = new System.Drawing.Size(196, 22);
            this.mnuthuoc.Text = "Thuốc";
            this.mnuthuoc.Click += new System.EventHandler(this.mnucapnhatlop_Click);
            // 
            // mnuthanhtoanvientphi
            // 
            this.mnuthanhtoanvientphi.Name = "mnuthanhtoanvientphi";
            this.mnuthanhtoanvientphi.Size = new System.Drawing.Size(196, 22);
            this.mnuthanhtoanvientphi.Text = "Thanh Toán Viện Phí";
            this.mnuthanhtoanvientphi.Click += new System.EventHandler(this.mnucapnhatnguoidung_Click);
            // 
            // mnuxuatvienchuyenvien
            // 
            this.mnuxuatvienchuyenvien.Name = "mnuxuatvienchuyenvien";
            this.mnuxuatvienchuyenvien.Size = new System.Drawing.Size(196, 22);
            this.mnuxuatvienchuyenvien.Text = "Xuất Viện Chuyển Viện";
            this.mnuxuatvienchuyenvien.Click += new System.EventHandler(this.mnuxuatvienchuyenvien_Click);
            // 
            // mnutimkiem
            // 
            this.mnutimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnutimkiemtheotenvama,
            this.mnutimtheodonthuoc,
            this.mnutimkiemdichvusudung,
            this.mnutimkiemgiuongbenh});
            this.mnutimkiem.Name = "mnutimkiem";
            this.mnutimkiem.Size = new System.Drawing.Size(69, 20);
            this.mnutimkiem.Text = "Tìm kiếm";
            // 
            // mnutimkiemtheotenvama
            // 
            this.mnutimkiemtheotenvama.Name = "mnutimkiemtheotenvama";
            this.mnutimkiemtheotenvama.Size = new System.Drawing.Size(212, 22);
            this.mnutimkiemtheotenvama.Text = "Tìm kiếm theo tên và mã";
            this.mnutimkiemtheotenvama.Click += new System.EventHandler(this.mnutimkiemhs_Click);
            // 
            // mnutimtheodonthuoc
            // 
            this.mnutimtheodonthuoc.Name = "mnutimtheodonthuoc";
            this.mnutimtheodonthuoc.Size = new System.Drawing.Size(212, 22);
            this.mnutimtheodonthuoc.Text = "Tìm kiếm theo đơn thuốc";
            this.mnutimtheodonthuoc.Click += new System.EventHandler(this.mnutimkiemgiaovien_Click);
            // 
            // mnutimkiemdichvusudung
            // 
            this.mnutimkiemdichvusudung.Name = "mnutimkiemdichvusudung";
            this.mnutimkiemdichvusudung.Size = new System.Drawing.Size(212, 22);
            this.mnutimkiemdichvusudung.Text = "Tim kiếm dịch vụ sử dụng";
            this.mnutimkiemdichvusudung.Click += new System.EventHandler(this.mnutimkiemdichvusudung_Click);
            // 
            // mnutimkiemgiuongbenh
            // 
            this.mnutimkiemgiuongbenh.Name = "mnutimkiemgiuongbenh";
            this.mnutimkiemgiuongbenh.Size = new System.Drawing.Size(212, 22);
            this.mnutimkiemgiuongbenh.Text = "Tìm kiếm giường bệnh";
            this.mnutimkiemgiuongbenh.Click += new System.EventHandler(this.mnutimkiemgiuongbenh_Click);
            // 
            // mnucapnhatdanhmuc
            // 
            this.mnucapnhatdanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudanhmucbacsi,
            this.mnudanhmucdichvu,
            this.mnudanhmucthuoc,
            this.mnudanhmuckhoa,
            this.mnudanhmucphong});
            this.mnucapnhatdanhmuc.Name = "mnucapnhatdanhmuc";
            this.mnucapnhatdanhmuc.Size = new System.Drawing.Size(127, 20);
            this.mnucapnhatdanhmuc.Text = "Cập Nhật Danh Mục";
            // 
            // mnudanhmucbacsi
            // 
            this.mnudanhmucbacsi.Name = "mnudanhmucbacsi";
            this.mnudanhmucbacsi.Size = new System.Drawing.Size(171, 22);
            this.mnudanhmucbacsi.Text = "Danh Mục bác sĩ";
            this.mnudanhmucbacsi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnudanhmucbacsi.Click += new System.EventHandler(this.mnuthongkegv_Click);
            // 
            // mnudanhmucdichvu
            // 
            this.mnudanhmucdichvu.Name = "mnudanhmucdichvu";
            this.mnudanhmucdichvu.Size = new System.Drawing.Size(171, 22);
            this.mnudanhmucdichvu.Text = "Danh Mục dịch vụ";
            this.mnudanhmucdichvu.Click += new System.EventHandler(this.mnudanhmucdichvu_Click);
            // 
            // mnudanhmucthuoc
            // 
            this.mnudanhmucthuoc.Name = "mnudanhmucthuoc";
            this.mnudanhmucthuoc.Size = new System.Drawing.Size(171, 22);
            this.mnudanhmucthuoc.Text = "Danh Mục thuốc";
            this.mnudanhmucthuoc.Click += new System.EventHandler(this.mnudanhmucthuoc_Click);
            // 
            // mnudanhmuckhoa
            // 
            this.mnudanhmuckhoa.Name = "mnudanhmuckhoa";
            this.mnudanhmuckhoa.Size = new System.Drawing.Size(171, 22);
            this.mnudanhmuckhoa.Text = "Danh Mục khoa";
            this.mnudanhmuckhoa.Click += new System.EventHandler(this.mnudanhmuckhoa_Click);
            // 
            // mnudanhmucphong
            // 
            this.mnudanhmucphong.Name = "mnudanhmucphong";
            this.mnudanhmucphong.Size = new System.Drawing.Size(171, 22);
            this.mnudanhmucphong.Text = "Danh Mục Phòng";
            this.mnudanhmucphong.Click += new System.EventHandler(this.mnudanhmucphong_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 343);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.Text = "Hệ Thống Quản Lý Thông Tin Bệnh Viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuhethong;
        private System.Windows.Forms.ToolStripMenuItem mnudangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuhuydangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
        private System.Windows.Forms.ToolStripMenuItem mnuquanlybenhnhan;
        private System.Windows.Forms.ToolStripMenuItem mnuthongtinhanhchinh;
        private System.Windows.Forms.ToolStripMenuItem mnubenhbanchitiet;
        private System.Windows.Forms.ToolStripMenuItem mnuchuyenkhoa;
        private System.Windows.Forms.ToolStripMenuItem mnudichvusudung;
        private System.Windows.Forms.ToolStripMenuItem mnuthuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuthanhtoanvientphi;
        private System.Windows.Forms.ToolStripMenuItem mnutimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnutimkiemtheotenvama;
        private System.Windows.Forms.ToolStripMenuItem mnutimtheodonthuoc;
        private System.Windows.Forms.ToolStripMenuItem mnucapnhatdanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmucbacsi;
        private System.Windows.Forms.ToolStripMenuItem menuquanlynguoidung;
        private System.Windows.Forms.ToolStripMenuItem mnuxuatvienchuyenvien;
        private System.Windows.Forms.ToolStripMenuItem mnutimkiemdichvusudung;
        private System.Windows.Forms.ToolStripMenuItem mnutimkiemgiuongbenh;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmucdichvu;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmucthuoc;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmuckhoa;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmucphong;
    }
}