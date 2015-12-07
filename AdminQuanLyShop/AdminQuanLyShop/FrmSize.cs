using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_Size;
using System.Text.RegularExpressions;

namespace AdminQuanLyShop
{
    public partial class FrmSize : Form
    {
        Service_SizeClient svs = new Service_SizeClient();
        public FrmSize()
        {
            InitializeComponent();
        }

        private void dtgSize_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSize.Text = dtgSize.CurrentRow.Cells[0].Value.ToString();
            txtTenSize.Text = dtgSize.CurrentRow.Cells[1].Value.ToString();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            dtgSize.DataSource = svs.LayTatCaSize();
            this.dtgSize.Columns[0].HeaderText = "Mã Size";
            this.dtgSize.Columns[1].HeaderText = "Tên Size";
            this.dtgSize.Columns[0].Width = 150;
            this.dtgSize.Columns[1].Width = 200;

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!txtTenSize.Text.Equals(""))
            {
              
                bool x = svs.ThemSize(int.Parse(txtTenSize.Text));
                if (x == true)
                {
                    MessageBox.Show("Nhập size thành công");
                    load();
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Chưa nhập tên size");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (!txtTenSize.Text.Equals("") && !txtMaSize.Text.Equals(""))
            {
                bool x = svs.SuaSize(int.Parse(txtMaSize.Text), int.Parse(txtTenSize.Text));
                if (x == true)
                {
                    MessageBox.Show("sửa size thành công");
                    load();
                }
                else
                    MessageBox.Show("sửa sỉze không thành công");
            }
            else
                MessageBox.Show("Chưa nhập tên size");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaSize.Text.Equals(""))
            {
                int Masize = int.Parse(txtMaSize.Text);
                bool x = svs.XoaSize(Masize);
                if (x == true)
                {
                    MessageBox.Show("Đã xóa size");
                    load();
                }
                else
                    MessageBox.Show("Không xóa được");

            }
            else
                MessageBox.Show("Chưa có mã size cần xóa");
        }

        private void FrmSize_Load(object sender, EventArgs e)
        {

        }
        private bool CheckNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
        
    }
}
