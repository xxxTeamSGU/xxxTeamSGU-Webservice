using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_KhachHang;
using System.Text.RegularExpressions;

namespace AdminQuanLyShop
{
    public partial class FrmKhachHang : Form
    {
        Service_KhachHangClient svkh = new Service_KhachHangClient();
        List<Service_KhachHang.KhachHang> _DSKH = new List<Service_KhachHang.KhachHang>();
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            dtgKhachHang.DataSource = _DSKH;
            this.dtgKhachHang.Columns[4].HeaderText = "Mã Khách hàng";
            this.dtgKhachHang.Columns[4].DisplayIndex = 0;
            this.dtgKhachHang.Columns[3].HeaderText = "Họ tên";
            this.dtgKhachHang.Columns[3].DisplayIndex = 1;
            this.dtgKhachHang.Columns[7].HeaderText = "Ngày sinh";
            this.dtgKhachHang.Columns[7].DisplayIndex = 2;
            this.dtgKhachHang.Columns[1].HeaderText = "Email";
            this.dtgKhachHang.Columns[1].DisplayIndex = 3;
            this.dtgKhachHang.Columns[5].HeaderText = "Mật Khẩu";
            this.dtgKhachHang.Columns[5].DisplayIndex = 4;
            this.dtgKhachHang.Columns[8].HeaderText = "Số điện thoại";
            this.dtgKhachHang.Columns[8].DisplayIndex = 5;
            this.dtgKhachHang.Columns[0].HeaderText = "Địa chỉ";
            this.dtgKhachHang.Columns[0].DisplayIndex = 6;
            this.dtgKhachHang.Columns[2].HeaderText = "Giới tính";
            this.dtgKhachHang.Columns[2].DisplayIndex = 7;
            this.dtgKhachHang.Columns[6].HeaderText = "Ngày đăng ký";
            this.dtgKhachHang.Columns[6].DisplayIndex = 8;
            this.dtgKhachHang.Columns[5].Visible = false;
            
        }

        private void dtgKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtMaKH.Text = dtgKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtHoten.Text = dtgKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dtgKhachHang.CurrentRow.Cells[1].Value.ToString();
            if(!String.IsNullOrEmpty(Convert.ToString(dtgKhachHang.CurrentRow.Cells[8].Value)))
               txtSoDT.Text = dtgKhachHang.CurrentRow.Cells[8].Value.ToString();
            if (!String.IsNullOrEmpty(Convert.ToString(dtgKhachHang.CurrentRow.Cells[0].Value)))
               txtDiaChi.Text = dtgKhachHang.CurrentRow.Cells[0].Value.ToString();
            if (!String.IsNullOrEmpty(Convert.ToString(dtgKhachHang.CurrentRow.Cells[2].Value)))
               txtGioiTinh.Text = dtgKhachHang.CurrentRow.Cells[2].Value.ToString();

            string day = dtgKhachHang.CurrentRow.Cells[7].Value.ToString();
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
            dtNgaySinh.Value = new DateTime(int.Parse(nam), int.Parse(thang), int.Parse(ngay));

            string day1 = dtgKhachHang.CurrentRow.Cells[6].Value.ToString();
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
            dtNgayDK.Value = new DateTime(int.Parse(nam1), int.Parse(thang1), int.Parse(ngay1));
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaKH.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa khách hàng này", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int MaKM = int.Parse(txtMaKH.Text);
                    bool x = svkh.XoaKhachHang(MaKM);
                    if (x == true)
                    {
                        MessageBox.Show("Đã xóa khách hàng");
                        _DSKH = svkh.LayTatCaKhachHang().ToList();
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
                MessageBox.Show("Chưa có mã khách hàng cần xóa");
        }

        private bool CheckNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (!txtLoc.Text.Equals(""))
            {
                if (CheckNumber(txtLoc.Text.ToString()))
                {
                    int x = int.Parse(txtLoc.Text.ToString());
                    dtgKhachHang.DataSource = _DSKH.Where(p => p.MaKH == x).ToList();
                    this.dtgKhachHang.Columns[4].HeaderText = "Mã Khách hàng";
                    this.dtgKhachHang.Columns[4].DisplayIndex = 0;
                    this.dtgKhachHang.Columns[3].HeaderText = "Họ tên";
                    this.dtgKhachHang.Columns[3].DisplayIndex = 1;
                    this.dtgKhachHang.Columns[7].HeaderText = "Ngày sinh";
                    this.dtgKhachHang.Columns[7].DisplayIndex = 2;
                    this.dtgKhachHang.Columns[1].HeaderText = "Email";
                    this.dtgKhachHang.Columns[1].DisplayIndex = 3;
                    this.dtgKhachHang.Columns[5].HeaderText = "Mật Khẩu";
                    this.dtgKhachHang.Columns[5].DisplayIndex = 4;
                    this.dtgKhachHang.Columns[8].HeaderText = "Số điện thoại";
                    this.dtgKhachHang.Columns[8].DisplayIndex = 5;
                    this.dtgKhachHang.Columns[0].HeaderText = "Địa chỉ";
                    this.dtgKhachHang.Columns[0].DisplayIndex = 6;
                    this.dtgKhachHang.Columns[2].HeaderText = "Giới tính";
                    this.dtgKhachHang.Columns[2].DisplayIndex = 7;
                    this.dtgKhachHang.Columns[6].HeaderText = "Ngày đăng ký";
                    this.dtgKhachHang.Columns[6].DisplayIndex = 8;
                    this.dtgKhachHang.Columns[5].Visible = false;
                }
                else
                {
                    string x = txtLoc.Text.ToString();
                    dtgKhachHang.DataSource = _DSKH.Where(p => p.HoTen.Contains(x) || p.Email.Contains(x) || p.SDT.Contains(x) || p.DiaChi.Contains(x)).ToList();
                    this.dtgKhachHang.Columns[4].HeaderText = "Mã Khách hàng";
                    this.dtgKhachHang.Columns[4].DisplayIndex = 0;
                    this.dtgKhachHang.Columns[3].HeaderText = "Họ tên";
                    this.dtgKhachHang.Columns[3].DisplayIndex = 1;
                    this.dtgKhachHang.Columns[7].HeaderText = "Ngày sinh";
                    this.dtgKhachHang.Columns[7].DisplayIndex = 2;
                    this.dtgKhachHang.Columns[1].HeaderText = "Email";
                    this.dtgKhachHang.Columns[1].DisplayIndex = 3;
                    this.dtgKhachHang.Columns[5].HeaderText = "Mật Khẩu";
                    this.dtgKhachHang.Columns[5].DisplayIndex = 4;
                    this.dtgKhachHang.Columns[8].HeaderText = "Số điện thoại";
                    this.dtgKhachHang.Columns[8].DisplayIndex = 5;
                    this.dtgKhachHang.Columns[0].HeaderText = "Địa chỉ";
                    this.dtgKhachHang.Columns[0].DisplayIndex = 6;
                    this.dtgKhachHang.Columns[2].HeaderText = "Giới tính";
                    this.dtgKhachHang.Columns[2].DisplayIndex = 7;
                    this.dtgKhachHang.Columns[6].HeaderText = "Ngày đăng ký";
                    this.dtgKhachHang.Columns[6].DisplayIndex = 8;
                    this.dtgKhachHang.Columns[5].Visible = false;
                }
            }
            else
                MessageBox.Show("Nhập thông tin cần tìm");

        }
        private List<Service_KhachHang.KhachHang> filter(string request)
        {
            request = txtLoc.Text.ToLower();
            int number;
            bool isNumber = Int32.TryParse(request, out number);
            if (isNumber)
            {
                var linqQuery = _DSKH.Where
                (s => s.MaKH.Equals(number)
                || s.HoTen.Equals(number)
                || s.Email.Equals(number)
                || s.GioiTinh.Equals(number)
                || s.DiaChi.Equals(number)
                );
                return linqQuery.ToList<Service_KhachHang.KhachHang>();
            }
            else
            {
                var linqQuery = _DSKH.Where
                (s => s.HoTen.ToLower().Contains(request)
                || s.Email.ToLower().Contains(request)
                || s.GioiTinh.ToLower().Contains(request)
                || s.DiaChi.ToLower().Contains(request)
                );
                return linqQuery.ToList<Service_KhachHang.KhachHang>();
            }
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            _DSKH = svkh.LayTatCaKhachHang().ToList();
        }
    }
}
