using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_NhaCungCap;

namespace AdminQuanLyShop
{
    public partial class FrmNhaCungCap : Form
    {
        Service_NhaCungCapClient svncc = new Service_NhaCungCapClient();
        List<Service_NhaCungCap.NhaCungCap> ncc = new List<NhaCungCap>();
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!txtTenNCC.Text.Equals(""))
            {
                bool x = svncc.ThemNhaCungCap(txtTenNCC.Text,txtDiaChi.Text,txtSDT.Text,txtSoTK.Text);
                if (x == true)
                {
                    MessageBox.Show("Nhập nhà cung cấp thành công");
                    load();
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Chưa nhập tên nhà cung cấp");

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            dtgNhaCungCap.DataSource = ncc;
            dtgNhaCungCap.Columns[1].DisplayIndex = 0;
            dtgNhaCungCap.Columns[1].Width = 50;
            dtgNhaCungCap.Columns[1].HeaderText = "ID";
            dtgNhaCungCap.Columns[4].DisplayIndex = 1;
            dtgNhaCungCap.Columns[4].Width = 180;
            dtgNhaCungCap.Columns[4].HeaderText = "Nhà cung cấp";
            dtgNhaCungCap.Columns[0].DisplayIndex = 2;
            dtgNhaCungCap.Columns[0].Width = 180;
            dtgNhaCungCap.Columns[0].HeaderText = "Địa chỉ";
            dtgNhaCungCap.Columns[2].DisplayIndex = 3;
            dtgNhaCungCap.Columns[2].Width = 100;
            dtgNhaCungCap.Columns[2].HeaderText = "Số ĐT";
            dtgNhaCungCap.Columns[3].DisplayIndex = 4;
            dtgNhaCungCap.Columns[3].Width = 50;
            dtgNhaCungCap.Columns[3].HeaderText = "Số tài khoản";
          

        }

        private void dtgNhaCungCap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dtgNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txtTenNCC.Text = dtgNhaCungCap.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dtgNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            txtSDT.Text = dtgNhaCungCap.CurrentRow.Cells[2].Value.ToString(); ;
            txtSoTK.Text = dtgNhaCungCap.CurrentRow.Cells[3].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (!txtTenNCC.Text.Equals("") && !txtMaNCC.Text.Equals(""))
            {
                bool x = svncc.SuaNhaCungCap(int.Parse(txtMaNCC.Text), txtTenNCC.Text,txtDiaChi.Text,txtSDT.Text,txtSoTK.Text);
                if (x == true)
                {
                    MessageBox.Show("sửa nhà cung cấp thành công");
                    ncc = svncc.LayTatCaNhaCungCap().ToList();
                    load();
                }
                else
                    MessageBox.Show("sửa nhà cung cấp không thành công");
            }
            else
                MessageBox.Show("Chưa nhập mã và tên nhà cung cấp cần sửa");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaNCC.Text.Equals(""))
            {
                int MaNCC = int.Parse(txtMaNCC.Text);
                bool x = svncc.XoaNhaCungCap(MaNCC);
                if (x == true)
                {
                    MessageBox.Show("Đã xóa nhà cung cấp");
                    load();
                }
                else
                    MessageBox.Show("Không xóa được");

            }
            else
                MessageBox.Show("Chưa có mã nhà cung cấp cần xóa");
        }

        private void btNhapmoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtSoTK.Text = "";
        }

        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            ncc = svncc.LayTatCaNhaCungCap().ToList();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (!txtLoc.Text.Equals(""))
            {
                string x = txtLoc.Text.ToString();
                dtgNhaCungCap.DataSource = ncc.Where(p => p.DiaChi.Contains(x) || p.TenNCC.Contains(x) || p.SoTK.Contains(x) || p.SDT.Contains(x)).ToList();
            }
            else
                MessageBox.Show("Nhập dữ liệu cần tìm");
        }
    }
}
