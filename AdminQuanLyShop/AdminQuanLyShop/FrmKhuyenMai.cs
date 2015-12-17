using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_KhuyenMai;

namespace AdminQuanLyShop
{
    public partial class FrmKhuyenMai : Form
    {
        Service_KhuyenMaiClient svkm = new Service_KhuyenMaiClient();
        public FrmKhuyenMai()
        {
            InitializeComponent();
        }

        private void dtgKhuyenMai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKM.Text = dtgKhuyenMai.CurrentRow.Cells[0].Value.ToString();
            txtTenKM.Text = dtgKhuyenMai.CurrentRow.Cells[3].Value.ToString();

            string day = dtgKhuyenMai.CurrentRow.Cells[1].Value.ToString();
            DateTime thedate = DateTime.Parse(day);
            String dateString = thedate.ToString("yyyy/MM/dd");
            day = dateString;

            char[] cut = day.ToCharArray();
            string nam = "";
            for (int i = 0; i < 4; i++)
            {
                nam += cut[i];
            }
            string thang = "";
            for (int i = 5; i < 7; i++)
            {
                thang += cut[i];
            }
            string ngay = "";
            for (int i = 8; i < 10; i++)
            {
                ngay += cut[i];
            }
            dtBatDau.Value = new DateTime(int.Parse(nam), int.Parse(thang), int.Parse(ngay));

            string day1 = dtgKhuyenMai.CurrentRow.Cells[2].Value.ToString();
            DateTime thedate1 = DateTime.Parse(day1);
            String dateString1 = thedate1.ToString("yyyy/MM/dd");
            day1 = dateString1;

            char[] cut1 = day1.ToCharArray();
            string nam1 = "";
            for (int i = 0; i < 4; i++)
            {
                nam1 += cut1[i];
            }
            string thang1 = "";
            for (int i = 5; i < 7; i++)
            {
                thang1 += cut1[i];
            }
            string ngay1 = "";
            for (int i = 8; i < 10; i++)
            {
                ngay1 += cut1[i];
            }
            dtKetThuc.Value = new DateTime(int.Parse(nam1), int.Parse(thang1), int.Parse(ngay1));
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            dtgKhuyenMai.DataSource = svkm.LayTatCaKM();
            this.dtgKhuyenMai.Columns[0].HeaderText = "Mã Khuyến mãi";
            this.dtgKhuyenMai.Columns[0].Width = 140;

            this.dtgKhuyenMai.Columns[3].DisplayIndex = 1;
            this.dtgKhuyenMai.Columns[3].Width = 140;
            this.dtgKhuyenMai.Columns[3].HeaderText = "Loại Khuyến Mãi";

            this.dtgKhuyenMai.Columns[1].DisplayIndex = 2;
            this.dtgKhuyenMai.Columns[1].Width = 140;
            this.dtgKhuyenMai.Columns[1].HeaderText = "Ngày bắt đầu";
            this.dtgKhuyenMai.Columns[2].DisplayIndex = 3;
            this.dtgKhuyenMai.Columns[2].Width = 140;
            this.dtgKhuyenMai.Columns[2].HeaderText = "Ngày kết thúc";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!txtTenKM.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm khuyến mãi", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DateTime Ngaybd = DateTime.Parse(dtBatDau.Value.ToString("yyyy-MM-dd"));
                    DateTime Ngaykt = DateTime.Parse(dtKetThuc.Value.ToString("yyyy-MM-dd"));
                    bool x = svkm.ThemKM(txtTenKM.Text, Ngaybd, Ngaykt);
                    if (x == true)
                    {
                        MessageBox.Show("Nhập khuyến mãi thành công");
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
                MessageBox.Show("Chưa nhập loại khuyến mãi");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (!txtTenKM.Text.Equals("") && !txtMaKM.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin khuyến mãi", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DateTime Ngaybd = DateTime.Parse(dtBatDau.Value.ToString("yyyy-MM-dd"));
                    DateTime Ngaykt = DateTime.Parse(dtKetThuc.Value.ToString("yyyy-MM-dd"));
                    bool x = svkm.SuaKM(int.Parse(txtMaKM.Text), txtTenKM.Text, Ngaybd, Ngaykt);
                    if (x == true)
                    {
                        MessageBox.Show("sửa khuyến mãi thành công");
                        load();
                    }
                    else
                        MessageBox.Show("sửa sỉze không thành công");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            
            }
            else
                MessageBox.Show("Chưa nhập tên khuyến mãi");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaKM.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa khuyến mãi này", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int MaKM = int.Parse(txtMaKM.Text);
                    bool x = svkm.XoaKM(MaKM);
                    if (x == true)
                    {
                        MessageBox.Show("Đã xóa khuyến mãi");
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
                MessageBox.Show("Chưa có mã khuyến mãi cần xóa");
        }

        private void FrmKhuyenMai_Load(object sender, EventArgs e)
        {

        }
    }
}
