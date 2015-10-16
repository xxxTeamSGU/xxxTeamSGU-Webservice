using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_QuanLyShop
{
    public partial class Form_NhanVien : Form
    {
        Service_NhanVien.Service_NhanVienSoapClient sv = new Service_NhanVien.Service_NhanVienSoapClient();
        public Form_NhanVien()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            tableNhanVien.DataSource = sv.LayTatCaNhaNhanVien().ToList();
        }

        private void tableNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.Value!=null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!txtNV.Text.Equals(""))
            {
                string TenNV = txtNV.Text;
                string Email = txtEmail.Text;
                string MatKhau = "12345678";
                string CapNhat = "[Chưa Cập Nhật]";
                string SoDT = CapNhat;
                string SoCMND = CapNhat;
                string DiaChi = CapNhat;
                int QuyenAdmin = 0;
                if (cbAdmin.Checked == true)
                    QuyenAdmin = 1;
                bool x = sv.ThemNhanVien(TenNV, Email, SoDT, SoCMND, DiaChi, MatKhau,QuyenAdmin);
                if ( x == true)
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    tableNhanVien.DataSource = sv.LayTatCaNhaNhanVien().ToList();
                }
            }
            else
                MessageBox.Show("Chưa nhập tên nhân viên cần thêm");
        }

        private void tableNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = tableNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtNV.Text = tableNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = tableNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtSoDT.Text = tableNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtSoCMND.Text = tableNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = tableNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtMatKhau.Text = tableNhanVien.CurrentRow.Cells[6].Value.ToString();
            int x = int.Parse(tableNhanVien.CurrentRow.Cells[7].Value.ToString());
            if (x == 1)
                cbAdmin.Checked = true;
            if (x == 0)
                cbAdmin.Checked = false;
        }

        private void btNhapmoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtNV.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtMatKhau.Text = "";
            txtSoCMND.Text = "";
            txtSoDT.Text = "";
            cbAdmin.Checked = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaNV.Text.Equals(""))
            {
                int MaNV = int.Parse(txtMaNV.Text);
                bool x = sv.XoaNhanVien(MaNV);
                if ( x == true)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    tableNhanVien.DataSource = sv.LayTatCaNhaNhanVien().ToList();
                }
            }
            else
                MessageBox.Show("Chưa nhập mã nhân viên cần xóa");
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (!txtTim.Text.Equals(""))
            {
                tableNhanVien.DataSource = sv.TimKiemNhanVien(txtTim.Text);
            }
            else
                MessageBox.Show("Chưa nhập thông tin cần tìm");
        }
    }
}
