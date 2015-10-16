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
    public partial class Form_NhaCungCap : Form
    {
        Service_NhaCungCap.Service_NhaCungCapSoapClient sv = new Service_NhaCungCap.Service_NhaCungCapSoapClient();
        public Form_NhaCungCap()
        {
            InitializeComponent();
        }

      

        private void tableNhaCungCap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          txtMaNCC.Text =  tableNhaCungCap.CurrentRow.Cells[0].Value.ToString();
          txtNCC.Text = tableNhaCungCap.CurrentRow.Cells[1].Value.ToString();
          txtDiaChi.Text = tableNhaCungCap.CurrentRow.Cells[2].Value.ToString();
          txtSoDT.Text = tableNhaCungCap.CurrentRow.Cells[3].Value.ToString();
          txtSoTK.Text = tableNhaCungCap.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(!txtMaNCC.Text.Equals(""))
            {
                int MaNCC = int.Parse(txtMaNCC.Text);
                string NCC = txtNCC.Text;
                string DiaChi = txtDiaChi.Text;
                string SoDT = txtSoDT.Text;
                string SoTK = txtSoTK.Text;
                bool x = sv.SuaNhaCungCap(MaNCC,NCC, DiaChi, SoDT, SoTK);
                if (x == true)
                {
                    tableNhaCungCap.DataSource = sv.LayTatCaNhaCungCap().ToList();
                    MessageBox.Show("Sửa thông tin thành công");
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, không sửa được");
            }
            else
                MessageBox.Show("Chưa nhập mã Nhà Cung Cấp");
            
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            tableNhaCungCap.DataSource = sv.LayTatCaNhaCungCap().ToList();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!txtNCC.Text.Equals(""))
            {
                string NCC = txtNCC.Text;
                string DiaChi = txtDiaChi.Text;
                string SoDT = txtSoDT.Text;
                string SoTK = txtSoTK.Text;
                bool x = sv.ThemNhaCungCap(NCC, DiaChi, SoDT, SoTK);
                if (x == true)
                {
                    tableNhaCungCap.DataSource = sv.LayTatCaNhaCungCap().ToList();
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, không thêm được");
            }
            else
                MessageBox.Show("Chưa nhập tên Nhà Cung Cấp");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaNCC.Text.Equals(""))
            {
                int x = int.Parse(txtMaNCC.Text.ToString());
                bool y = sv.XoaNhaCungCap(x);
                if (y == true)
                {
                    MessageBox.Show("Xóa thành công");
                    tableNhaCungCap.DataSource = sv.LayTatCaNhaCungCap().ToList();
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                MessageBox.Show("Chưa nhập mã nhà cung cấp cần xóa");
        }

        private void btNhapmoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtNCC.Text = "";
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            txtSoTK.Text = "";
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (!txtTim.Text.Equals(""))
            {
                tableNhaCungCap.DataSource = sv.TimKiemNhaCungCap(txtTim.Text).ToList();
            }
        }

    }
}
