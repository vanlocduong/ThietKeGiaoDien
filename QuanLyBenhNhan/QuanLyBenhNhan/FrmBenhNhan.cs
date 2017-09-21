using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhNhan
{
    public partial class Form_BenhNhan : Form
    {
        public Form_BenhNhan()
        {
            InitializeComponent();
        }

        private void btnbenhan_Click(object sender, EventArgs e)
        {
            FrmBenhAnChiTiet frmbenhan = new FrmBenhAnChiTiet();
            frmbenhan.Show();
        }

        private void btnchuyenkhoa_Click(object sender, EventArgs e)
        {
            FrmChuyenkhoa frmbenhan = new FrmChuyenkhoa();
            frmbenhan.Show();
        }

        private void btndichvu_Click(object sender, EventArgs e)
        {
            FrmDichVuSuDungcs frmbenhan = new FrmDichVuSuDungcs();
            frmbenhan.Show();
        }

        private void btnthuoc_Click(object sender, EventArgs e)
        {
            FrmThuoc frmbenhan = new FrmThuoc();
            frmbenhan.Show();
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            FrmThanhToanVienPhi frmbenhan = new FrmThanhToanVienPhi();
            frmbenhan.Show();
        }

        private void btnxuatvien_Click(object sender, EventArgs e)
        {
            FrmXuatVienChuyenVien frmbenhan = new FrmXuatVienChuyenVien();
            frmbenhan.Show();
        }
    }
}
