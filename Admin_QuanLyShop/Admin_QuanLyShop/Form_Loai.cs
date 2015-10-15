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
    public partial class Form_Loai : Form
    {
        Service_Loai.Service_LoaiSoapClient sv = new Service_Loai.Service_LoaiSoapClient();
        public Form_Loai()
        {
            InitializeComponent();
        }

        private void btNap_Click(object sender, EventArgs e)
        {
            tableLoai.DataSource = sv.LayTatCaLoai().ToList();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!txtTenLoai.Text.Equals(""))
            {
                bool x = sv.ThemLoai(txtTenLoai.Text);
                if (x == true)
                {
                    MessageBox.Show("Nhập loại thành công");
                    tableLoai.DataSource = sv.LayTatCaLoai().ToList();
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Chưa nhập tên loại");
        }

        private void tableLoai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoai.Text = tableLoai.CurrentRow.Cells[0].Value.ToString();
            txtTenLoai.Text = tableLoai.CurrentRow.Cells[1].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaLoai.Text.Equals(""))
            {
                int MaLoai = int.Parse(txtMaLoai.Text);
                bool x = sv.XoaLoai(MaLoai);

            }
            else
                MessageBox.Show("Chưa có mã loại cần xóa");
        }

        
    }
}
