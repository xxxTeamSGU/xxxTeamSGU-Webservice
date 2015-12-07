using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_NhanVien;

namespace AdminQuanLyShop
{
    public partial class FrmDangNhap : Form
    {
        Service_NhanVienClient svnv = new Service_NhanVienClient();
        Service_NhanVien.NhanVien nhanvien = new Service_NhanVien.NhanVien();
      
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmLoai fr = new FrmLoai();
            fr.Show();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panelHinh.Visible = true;
            panelSaudangNhap.Visible = false;
            
        }

        private void btSanPham_Click(object sender, EventArgs e)
        {
            FrmQuanLySanPham fr = new FrmQuanLySanPham();
            fr.Show();
        }

        private void btKM_Click(object sender, EventArgs e)
        {
            FrmKhuyenMai fr = new FrmKhuyenMai();
            fr.ShowDialog();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Equals("") && !txtMatKhau.Equals(""))
            {


                nhanvien = svnv.LayMotNhanVien(txtEmail.Text, txtMatKhau.Text);
                if (nhanvien != null)
                {
                    panel1.Visible = true;
                    panelHinh.Visible = false;
                    panel2.Visible = false;
                    panelSaudangNhap.Visible = true;
                    lbtendn.Text = nhanvien.HoTen;
                    lbMaNV.Text = nhanvien.MaNV + "";
                }
                else
                    MessageBox.Show("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu, Vui lòng kiểm tra lại thông tin");
            }
            else
                MessageBox.Show("Chưa nhập đầy đủ tên và mật khẩu");
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelSaudangNhap.Visible = false;
                panel2.Visible = true;
                panel1.Visible = false;
                panelHinh.Visible = true;
                txtMatKhau.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
           
        }

        private void btKH_Click(object sender, EventArgs e)
        {
            FrmKhachHang fr = new FrmKhachHang();
            fr.Show();
        }

        private void btHDX_Click(object sender, EventArgs e)
        {
            FrmHoaDonNhap fr = new FrmHoaDonNhap();
            fr.Show();
        }

        private void btNCC_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap fr = new FrmNhaCungCap();
            fr.Show();
        }

        private void btdoithongtinnhanvien_Click(object sender, EventArgs e)
        {
            FrmDoiThongTinNhanVien frm = new FrmDoiThongTinNhanVien();
            frm.Sender(nhanvien.MaNV.ToString());
            frm.Show();
        }

        private void btHDN_Click(object sender, EventArgs e)
        {
            FrmHoaDonNhap fr = new FrmHoaDonNhap();
            fr.Sender(nhanvien.MaNV.ToString());
            fr.Show();
        }

      

        private void btKhuyenMai_Click(object sender, EventArgs e)
        {
            FrmKhuyenMai fr = new FrmKhuyenMai();
            fr.Show();
        }

        private void btKhoHang_Click(object sender, EventArgs e)
        {
            FrmKho fr = new FrmKho();
            fr.Show();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien fr = new FrmNhanVien();
            fr.Show();
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang fr = new FrmKhachHang();
            fr.Show();
        }

        private void btNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap fr = new FrmNhaCungCap();
            fr.Show();
        }

        private void btSize_Click(object sender, EventArgs e)
        {
            FrmSize fr = new FrmSize();
            fr.Show();
        }

        private void btMau_Click(object sender, EventArgs e)
        {
            FrmMau fr = new FrmMau();
            fr.Show();
        }

        private void btHoaDonNhap_Click(object sender, EventArgs e)
        {
            FrmHoaDonNhap fr = new FrmHoaDonNhap();
            fr.Sender(nhanvien.MaNV.ToString());
            fr.Show();
        }

        private void btHDXuat_Click(object sender, EventArgs e)
        {
            FrmHoaDonXuat fr = new FrmHoaDonXuat();
            fr.Sender(nhanvien.HoTen + "  Mã số : " + nhanvien.MaNV);
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
           
                
        }
    }
}
