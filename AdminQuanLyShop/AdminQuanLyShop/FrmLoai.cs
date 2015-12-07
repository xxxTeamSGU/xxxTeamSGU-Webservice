using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_Loai;

namespace AdminQuanLyShop
{
    public partial class FrmLoai : Form
    {
        Service_LoaiClient svl = new Service_LoaiClient();
        public FrmLoai()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLoadLoai_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            dtgLoai.DataSource = svl.LayTatCaLoai();
            this.dtgLoai.Columns[0].HeaderText = "Mã Loại";
            this.dtgLoai.Columns[1].HeaderText = "Tên Loại";
            this.dtgLoai.Columns[0].Width = 150;
            this.dtgLoai.Columns[1].Width = 200;

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!txtTenLoai.Text.Equals(""))
            {
                bool x = svl.ThemLoai(txtTenLoai.Text);
                if (x == true)
                {
                    MessageBox.Show("Nhập loại thành công");
                    load();
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Chưa nhập tên loại");
        }

        private void btSualoai_Click(object sender, EventArgs e)
        {
            if (!txtTenLoai.Text.Equals("") && !txtMaLoai.Text.Equals(""))
            {
                bool x = svl.SuaLoai(int.Parse(txtMaLoai.Text),txtTenLoai.Text);
                if (x == true)
                {
                    MessageBox.Show("sửa loại thành công");
                    load();
                }
                else
                    MessageBox.Show("sửa loại không thành công");
            }
            else
                MessageBox.Show("Chưa nhập tên loại");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaLoai.Text.Equals(""))
            {
                int MaLoai = int.Parse(txtMaLoai.Text);
                bool x = svl.XoaLoai(MaLoai);
                if (x == true)
                {
                    MessageBox.Show("Đã xóa loại");
                    load();
                }
                else
                    MessageBox.Show("Không xóa được");

            }
            else
                MessageBox.Show("Chưa có mã loại cần xóa");
        }

        private void dtgLoai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoai.Text = dtgLoai.CurrentRow.Cells[0].Value.ToString();
            txtTenLoai.Text = dtgLoai.CurrentRow.Cells[1].Value.ToString();
        }

        private void FrmLoai_Load(object sender, EventArgs e)
        {

        }

       
    }
}
