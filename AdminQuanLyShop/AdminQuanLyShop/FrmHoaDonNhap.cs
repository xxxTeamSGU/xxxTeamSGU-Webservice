using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_HoaDonNhap;
using AdminQuanLyShop.Service_NhaCungCap;
using AdminQuanLyShop.Service_CTHDN;
using AdminQuanLyShop.Service_Kho;


namespace AdminQuanLyShop
{
    public partial class FrmHoaDonNhap : Form
    {
        string mess = "";
        Service_HoaDonNhapClient svhdn = new Service_HoaDonNhapClient();
        Service_NhaCungCapClient svncc = new Service_NhaCungCapClient();
        Service_CTHDNClient svcthdn = new Service_CTHDNClient();
        Service_KhoClient svkho = new Service_KhoClient();
        private List<Service_HoaDonNhap.HoaDonNhap> listhtimkiem = new List<Service_HoaDonNhap.HoaDonNhap>();
        //  List<CTHDN> list = new List<CTHDN>();
        public delegate void SendMessage(string Message);
        public SendMessage Sender;    
          //Hàm có nhiệm vụ lấy tham số truyền vào
        private void GetMessage(string Message)
        {
                    mess = Message;
        }
        public FrmHoaDonNhap()
        {
            InitializeComponent();
           

            Sender = new SendMessage(GetMessage);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btTaiDonHang_Click(object sender, EventArgs e)
        {
            LoadHDN();
        }
        private void LoadHDN()
        {
            dtgHoaDonNhap.DataSource = svhdn.LayTatCaHoaDon();
            this.dtgHoaDonNhap.Columns[0].HeaderText = "Mã hóa đơn";
            this.dtgHoaDonNhap.Columns[0].DisplayIndex = 0;
            this.dtgHoaDonNhap.Columns[3].HeaderText = "Nhà cung cấp";
            this.dtgHoaDonNhap.Columns[3].DisplayIndex = 1;
            this.dtgHoaDonNhap.Columns[4].HeaderText = "Ngày lập";
            this.dtgHoaDonNhap.Columns[4].DisplayIndex = 3;
            this.dtgHoaDonNhap.Columns[5].HeaderText = "Nhân viên";
            this.dtgHoaDonNhap.Columns[5].DisplayIndex = 2;
            this.dtgHoaDonNhap.Columns[6].HeaderText = "Tình trạng";
            this.dtgHoaDonNhap.Columns[6].DisplayIndex = 5;
            this.dtgHoaDonNhap.Columns[7].HeaderText = "Tổng tiền";
            this.dtgHoaDonNhap.Columns[7].DisplayIndex = 4;
            this.dtgHoaDonNhap.Columns[1].Visible = false;
            this.dtgHoaDonNhap.Columns[2].Visible = false;


           
        }

        private void dtgHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgHoaDonNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dtgHoaDonNhap.CurrentRow.Cells[0].Value.ToString();
            txtNhaCungCap.Text = dtgHoaDonNhap.CurrentRow.Cells[3].Value.ToString();
            string day = dtgHoaDonNhap.CurrentRow.Cells[4].Value.ToString();
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
            txtTongTien.Text = dtgHoaDonNhap.CurrentRow.Cells[7].Value.ToString();
            int check = int.Parse(dtgHoaDonNhap.CurrentRow.Cells[6].Value.ToString());
            if (check == 1)
            {
                btDuyet.Text = "Đã duyệt";
                btDuyet.Enabled = false;
                btXoa.Enabled = false;
            }
            if (check == 0)
            {
                btDuyet.Text = "Duyệt đơn hàng";
                btDuyet.Enabled = true;
                btXoa.Enabled = true;
            }
            txtNhanVien.Text = dtgHoaDonNhap.CurrentRow.Cells[5].Value.ToString();
            XemChiTiet(int.Parse(dtgHoaDonNhap.CurrentRow.Cells[0].Value.ToString()));
        }

        private void FrmHoaDonNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btXemCTHD_Click(object sender, EventArgs e)
        {
            if (!txtMaHD.Text.Equals(""))
            {
                dtgChitiet.DataSource = svcthdn.LayCTHDN(int.Parse(txtMaHD.Text));
                this.dtgChitiet.Columns[7].HeaderText = "Tên Sản phẩm";
                this.dtgChitiet.Columns[7].DisplayIndex = 0;
                this.dtgChitiet.Columns[7].Width = 200;
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

        }
        private void XemChiTiet(int ma)
        {
            dtgChitiet.DataSource = svcthdn.LayCTHDN(int.Parse(txtMaHD.Text));
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
            if (!txtMaHD.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn duyệt hóa đơn này", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool check = true;
                    check = svkho.ThemKho(int.Parse(txtMaHD.Text));
                    if (check == true)
                    {
                        MessageBox.Show("Đã duyệt thành công hóa đơn");
                        btDuyet.Text = "Đã duyệt";
                        btDuyet.Enabled = false;
                        LoadHDN();
                    }
                    else
                        MessageBox.Show("Không duyệt thành công");
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            
            }
            else
                MessageBox.Show("Không có mã hóa đơn cần duyệt");
        }

        private void btNhapDH_Click(object sender, EventArgs e)
        {
            FrmCTHDN fr = new FrmCTHDN();
            fr.Sender(mess);
            fr.ShowDialog();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaHD.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa đơn hàng này", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (svhdn.XoaHDN(int.Parse(txtMaHD.Text.ToString())))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        LoadHDN();

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
                MessageBox.Show("Chọn hóa đơn cần xóa");
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if(!txtTim.Text.Equals(""))
            {
                listhtimkiem = svhdn.TimHoaDon(txtTim.Text.ToString()).ToList();
                if (listhtimkiem != null)
                {
                    dtgHoaDonNhap.DataSource = listhtimkiem;
                    this.dtgHoaDonNhap.Columns[0].HeaderText = "Mã hóa đơn";
                    this.dtgHoaDonNhap.Columns[0].DisplayIndex = 0;
                    this.dtgHoaDonNhap.Columns[3].HeaderText = "Nhà cung cấp";
                    this.dtgHoaDonNhap.Columns[3].DisplayIndex = 1;
                    this.dtgHoaDonNhap.Columns[4].HeaderText = "Ngày lập";
                    this.dtgHoaDonNhap.Columns[4].DisplayIndex = 3;
                    this.dtgHoaDonNhap.Columns[5].HeaderText = "Nhân viên";
                    this.dtgHoaDonNhap.Columns[5].DisplayIndex = 2;
                    this.dtgHoaDonNhap.Columns[6].HeaderText = "Tình trạng";
                    this.dtgHoaDonNhap.Columns[6].DisplayIndex = 5;
                    this.dtgHoaDonNhap.Columns[7].HeaderText = "Tổng tiền";
                    this.dtgHoaDonNhap.Columns[7].DisplayIndex = 4;
                    this.dtgHoaDonNhap.Columns[1].Visible = false;
                    this.dtgHoaDonNhap.Columns[2].Visible = false;
                }
            }
        }
    }
}
