using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnudangxuathethong_Click(object sender, EventArgs e)
        {

            mnuquanlybenhnhan.Enabled = false;
            mnutimkiem.Enabled = false;
            mnucapnhatdanhmuc.Enabled = false;
        }

        private void mnuhuydangxuat_Click(object sender, EventArgs e)
        {

            FrmDoiMatKhau FrmCapNhatGiaoVien = new FrmDoiMatKhau();
            FrmCapNhatGiaoVien.MdiParent = this;
            FrmCapNhatGiaoVien.Show();
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            FrmKetNoiCSDL frmketnoicsdl = new FrmKetNoiCSDL();
            frmketnoicsdl.MdiParent = this;
            frmketnoicsdl.Show();
        }

        private void mnucapnhatgiaovien_Click(object sender, EventArgs e)
        {
            FrmBenhAnChiTiet FrmCapNhatGiaoVien = new FrmBenhAnChiTiet();
            FrmCapNhatGiaoVien.MdiParent = this;
            FrmCapNhatGiaoVien.Show();
        }

        private void mnucapnhatmonhoc_Click(object sender, EventArgs e)
        {
            FrmChuyenkhoa FrmCapNhatMonHoc = new FrmChuyenkhoa();
            FrmCapNhatMonHoc.MdiParent = this;
            FrmCapNhatMonHoc.Show();
        }

        private void mnucapnhatnguoidung_Click(object sender, EventArgs e)
        {
            FrmThanhToanVienPhi FrmCapNhatNguoiDung = new FrmThanhToanVienPhi();
            FrmCapNhatNguoiDung.MdiParent = this;
            FrmCapNhatNguoiDung.Show();
        }

        private void mnucapnhathocky_Click(object sender, EventArgs e)
        {
            FrmDichVuSuDungcs FrmCapNhatHocKy = new FrmDichVuSuDungcs();
            FrmCapNhatHocKy.MdiParent = this;
            FrmCapNhatHocKy.Show();
        }

        private void mnucapnhatlop_Click(object sender, EventArgs e)
        {
            FrmThuoc FrmCapNhatLop = new FrmThuoc();
            FrmCapNhatLop.MdiParent = this;
            FrmCapNhatLop.Show();
        }

        private void mnucapnhathocsinh_Click(object sender, EventArgs e)
        {
            FrmThongTinHanhChinh FrmCapNhatHocSinh = new FrmThongTinHanhChinh();
            FrmCapNhatHocSinh.MdiParent = this;
            FrmCapNhatHocSinh.Show();
        }

        private void mnutimkiemgiaovien_Click(object sender, EventArgs e)
        {
           Frmtimtheodonthuoc FrmTimKiemGiaoVien = new Frmtimtheodonthuoc();
            FrmTimKiemGiaoVien.MdiParent = this;
            FrmTimKiemGiaoVien.Show();
        }

        private void mnutimkiemhs_Click(object sender, EventArgs e)
        {
            Frmtimtheotenvama FrmTimKiemHocSinh = new Frmtimtheotenvama();
            FrmTimKiemHocSinh.MdiParent = this;
            FrmTimKiemHocSinh.Show();
        }

      

        private void mnuthongkegv_Click(object sender, EventArgs e)
        {
            FrmDanhMucBacSi FrmThongKeGiaoVien = new FrmDanhMucBacSi();
            FrmThongKeGiaoVien.MdiParent = this;
            FrmThongKeGiaoVien.Show();
        }

    

    

     
      

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnucapnhatthongtin_Click(object sender, EventArgs e)
        {

        }

        private void mnuxuatvienchuyenvien_Click(object sender, EventArgs e)
        {
            FrmXuatVienChuyenVien frmxuatvienchuyenvien = new FrmXuatVienChuyenVien();
            frmxuatvienchuyenvien.MdiParent = this;
            frmxuatvienchuyenvien.Show();
        }

        private void mnutimkiemdichvusudung_Click(object sender, EventArgs e)
        {
            Frmtimtheodichvusudung frmtimtheodichvusudung = new Frmtimtheodichvusudung();
            frmtimtheodichvusudung.MdiParent = this;
            frmtimtheodichvusudung.Show();
        }

        private void mnutimkiemgiuongbenh_Click(object sender, EventArgs e)
        {
            Frmtimkiemgiuongbenh frmtimkiemtheogiuongbenh = new Frmtimkiemgiuongbenh();
            frmtimkiemtheogiuongbenh.MdiParent = this;
            frmtimkiemtheogiuongbenh.Show();
            
        }

        private void mnudanhmucdichvu_Click(object sender, EventArgs e)
        {
            FrmDanhMucDichVu frmdanhmucdichvu = new FrmDanhMucDichVu();
            frmdanhmucdichvu.MdiParent = this;
            frmdanhmucdichvu.Show();
            
        }

        private void mnudanhmucthuoc_Click(object sender, EventArgs e)
        {
            FrmDanhMucThuoc frmdanhmucthuoc = new FrmDanhMucThuoc();
            frmdanhmucthuoc.MdiParent = this;
            frmdanhmucthuoc.Show();
        }

        private void mnudanhmuckhoa_Click(object sender, EventArgs e)
        {
            FrmDanhMucKhoa frmdanhmucthuoc = new FrmDanhMucKhoa();
            frmdanhmucthuoc.MdiParent = this;
            frmdanhmucthuoc.Show();
        }

        private void mnudanhmucphong_Click(object sender, EventArgs e)
        {
            FrmDanhMucPhong frmdanhmucthuoc = new FrmDanhMucPhong();
            frmdanhmucthuoc.MdiParent = this;
            frmdanhmucthuoc.Show();

        }

        private void menuquanlynguoidung_Click(object sender, EventArgs e)
        {

        }
    }
}
