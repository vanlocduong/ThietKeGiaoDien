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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttendangnhap.Text = "";
            txtmatkhau.Text = "";
        }
       // public int Kiemtra(string tendangnhap, string matkhau)
        //{
           // tendangnhap.Trim();
           // matkhau.Trim();
           // string sql = " select * from DangNhap where tendangnhap = '" + tendangnhap + "' and matkhau = '" + matkhau + "'";
           // SqlConnection cn = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = QuanLyHocSinhTHCS; Trusted_Connection = yes ");
            //cn.Open();
          //  SqlCommand cmd = new SqlCommand(sql, cn);
            //if (cmd.ExecuteScalar() != null)
               // return 1;
           // else
              //  return 0;
        //}
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            //if (Kiemtra(btndangnhap.Text, txtmatkhau.Text) > 0)
            // {
            // DialogResult dr = MessageBox.Show("Bạn đã đăng nhập thành công", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // if (dr == DialogResult.Yes)
            //{
                FrmMain Main= new FrmMain();
                Main.Show();
                    this.Hide();

         
               // }
          //  }
            //else
               // MessageBox.Show("Tên đăng nhập " + txttendangnhap.Text + "Không có hoặc mật khẩu bị sai", "Thông báo");

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Bạn có muốn thoát chương trình không?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
