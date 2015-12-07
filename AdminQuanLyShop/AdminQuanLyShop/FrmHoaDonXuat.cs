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
    public partial class FrmHoaDonXuat : Form
    {
        string mess = "";
        Service_KhachHang.Service_KhachHangClient svkh = new Service_KhachHang.Service_KhachHangClient();
        Service_DonHang.Service_DonHangClient svdh = new Service_DonHang.Service_DonHangClient();
        Service_CTDH.Service_CTDHClient svctdh = new Service_CTDH.Service_CTDHClient();
        Service_NhanVienClient svnv = new Service_NhanVienClient();
        private List<Service_KhachHang.KhachHang> listkhachhang = new List<Service_KhachHang.KhachHang>();
        private List<Service_DonHang.HoaDonXuat> listhdxuat = new List<Service_DonHang.HoaDonXuat>();
        NhanVien nv = new NhanVien();
        public delegate void SendMessage(string Message);
        public SendMessage Sender;  
        public FrmHoaDonXuat()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }
        private void GetMessage(string Message)
        {
            mess = Message;
        }
        private void loadDSKH()
        {
            listkhachhang = svkh.LayTatCaKhachHang().ToList();
        }
        private void loadDH()
        {
            dtgHoaDonXuat.DataSource = listhdxuat;
            this.dtgHoaDonXuat.Columns[1].HeaderText = "Mã hóa đơn";
            this.dtgHoaDonXuat.Columns[1].DisplayIndex = 0;
            this.dtgHoaDonXuat.Columns[0].HeaderText = "Khách hàng";
            this.dtgHoaDonXuat.Columns[0].DisplayIndex = 1;
            this.dtgHoaDonXuat.Columns[3].HeaderText = "Ngày lập";
            this.dtgHoaDonXuat.Columns[3].DisplayIndex = 2;
            this.dtgHoaDonXuat.Columns[5].HeaderText = "Tình trạng";
            this.dtgHoaDonXuat.Columns[5].DisplayIndex = 3;
            this.dtgHoaDonXuat.Columns[6].HeaderText = "Tổng tiền";
            this.dtgHoaDonXuat.Columns[6].DisplayIndex = 4;
            this.dtgHoaDonXuat.Columns[4].HeaderText = "Nhân viên";
            this.dtgHoaDonXuat.Columns[4].DisplayIndex = 5;
            this.dtgHoaDonXuat.Columns[2].Visible = false;
        }
        private void FrmHoaDonXuat_Load(object sender, EventArgs e)
        {
            listhdxuat = svdh.LayTatCaDonHang().ToList();
            loadTT();
        }
        private void loadTT()
        {
            if (!mess.Equals(""))
            {

                MessageBox.Show(mess);

            }
            else
                MessageBox.Show("null");
        }
        private void btTaiDonHang_Click(object sender, EventArgs e)
        {
            loadDH();
        }

        private void dtgHoaDonXuat_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaHD.Text = this.dtgHoaDonXuat.CurrentRow.Cells[1].Value.ToString();
            txtKhachHang.Text = this.dtgHoaDonXuat.CurrentRow.Cells[0].Value.ToString();
            string day = dtgHoaDonXuat.CurrentRow.Cells[3].Value.ToString();
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
            timeNgayNhap.Value = new DateTime(int.Parse(nam), int.Parse(thang), int.Parse(ngay));

            txtTongTien.Text = dtgHoaDonXuat.CurrentRow.Cells[6].Value.ToString();
            int check = int.Parse(dtgHoaDonXuat.CurrentRow.Cells[5].Value.ToString());
            if (check == 1)
            {
                btDuyet.Text = "Đã duyệt";
                btDuyet.Enabled = false;
            }
            if (check == 0)
            {
                btDuyet.Text = "Duyệt đơn hàng";
                btDuyet.Enabled = true;
            }
            XemChiTiet(int.Parse(this.dtgHoaDonXuat.CurrentRow.Cells[1].Value.ToString()));
        }
        private void XemChiTiet(int ma)
        {
            dtgChitiet.DataSource = svctdh.LayCTHDN(int.Parse(txtMaHD.Text));
            this.dtgChitiet.Columns[7].HeaderText = "Tên Sản phẩm";
            this.dtgChitiet.Columns[7].DisplayIndex = 0;
            this.dtgChitiet.Columns[7].Width = 220;
            this.dtgChitiet.Columns[4].HeaderText = "Màu sắc";
            this.dtgChitiet.Columns[4].DisplayIndex = 1;
            this.dtgChitiet.Columns[5].HeaderText = "Size";
            this.dtgChitiet.Columns[5].DisplayIndex = 2;
            this.dtgChitiet.Columns[6].HeaderText = "Số lượng";
            this.dtgChitiet.Columns[6].DisplayIndex = 3;
            this.dtgChitiet.Columns[0].HeaderText = "Giá Sản phẩn";
            this.dtgChitiet.Columns[0].DisplayIndex = 4;
            this.dtgChitiet.Columns[1].Visible = false;
            this.dtgChitiet.Columns[2].Visible = false;
            this.dtgChitiet.Columns[3].Visible = false;
            
        }

        private void btDuyet_Click(object sender, EventArgs e)
        {

        }

    }
}
