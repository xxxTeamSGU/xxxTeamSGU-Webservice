using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_Mau;

namespace AdminQuanLyShop
{
    public partial class FrmMau : Form
    {
        Service_MauClient svm = new Service_MauClient();
        public FrmMau()
        {
            InitializeComponent();
        }

        private void dtgMau_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMau.Text = dtgMau.CurrentRow.Cells[0].Value.ToString();
            txtTenMau.Text = dtgMau.CurrentRow.Cells[1].Value.ToString();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            dtgMau.DataSource = svm.LayTatCaMau();
            this.dtgMau.Columns[0].HeaderText = "Mã Màu";
            this.dtgMau.Columns[1].HeaderText = "Tên Màu";
            this.dtgMau.Columns[0].Width = 150;
            this.dtgMau.Columns[1].Width = 200;

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!txtTenMau.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm màu", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool x = svm.ThemMau(txtTenMau.Text);
                    if (x == true)
                    {
                        MessageBox.Show("Nhập màu thành công");
                        load();
                    }
                    else
                        MessageBox.Show("Thêm không thành công");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
              
            }
            else
                MessageBox.Show("Chưa nhập tên màu");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (!txtTenMau.Text.Equals("") && !txtMaMau.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa màu", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool x = svm.SuaMau(int.Parse(txtMaMau.Text), txtTenMau.Text);
                    if (x == true)
                    {
                        MessageBox.Show("sửa màu thành công");
                        load();
                    }
                    else
                        MessageBox.Show("sửa màu không thành công");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
             
            }
            else
                MessageBox.Show("Chưa nhập tên màu");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaMau.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa sản phẩm", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int MaMau = int.Parse(txtMaMau.Text);
                    bool x = svm.XoaMau(MaMau);
                    if (x == true)
                    {
                        MessageBox.Show("Đã xóa màu");
                        load();
                    }
                    else
                        MessageBox.Show("Không xóa được");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
             

            }
            else
                MessageBox.Show("Chưa có mã màu cần xóa");
        }

        private void FrmMau_Load(object sender, EventArgs e)
        {

        }
    }
}
