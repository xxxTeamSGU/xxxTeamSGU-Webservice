using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_SanPham;
using AdminQuanLyShop.Service_Mau;
using AdminQuanLyShop.Service_Size;
using AdminQuanLyShop.Service_NhaCungCap;
using AdminQuanLyShop.Service_CTDH;

namespace AdminQuanLyShop
{
    public partial class FrmCTHDN : Form
    {
        string mess = "";
        Service_SanPhamClient svsp = new Service_SanPhamClient();
        Service_MauClient svm = new Service_MauClient();
        Service_NhaCungCapClient svncc = new Service_NhaCungCapClient();
        Service_SizeClient svsize = new Service_SizeClient();
        Service_CTHDN.Service_CTHDNClient svctdh = new Service_CTHDN.Service_CTHDNClient();
        Service_HoaDonNhap.Service_HoaDonNhapClient svhdn = new Service_HoaDonNhap.Service_HoaDonNhapClient();

        List<Service_NhaCungCap.NhaCungCap> _DSNCC = new List<Service_NhaCungCap.NhaCungCap>();
        List<Service_Size.Size> _DSSIZE = new List<Service_Size.Size>();
        List<Service_Mau.Mau> _DSMAU = new List<Service_Mau.Mau>();
        List<Service_SanPham.SanPham> _DSSP = new List<Service_SanPham.SanPham>();

           public delegate void SendMessage(string Message);
        public SendMessage Sender;    
        private void GetMessage(string Message)
        {
                    mess = Message;
        }
        public FrmCTHDN()
        {
            Sender = new SendMessage(GetMessage);
            InitializeComponent();

            _DSSP = svsp.LayTatCaSanPham().ToList();
            dtgTenSP.DataSource = _DSSP;
            dtgTenSP.DisplayMember = "TenSP";
            dtgTenSP.ValueMember = "MaSP";

            _DSSIZE = svsize.LayTatCaSize().ToList();
            dtgSize.DataSource = _DSSIZE;
            dtgSize.DisplayMember = "Size1";
            dtgSize.ValueMember = "MaSize";

            _DSMAU = svm.LayTatCaMau().ToList();
            dtgMau.DataSource = _DSMAU;
            dtgMau.DisplayMember = "TenMau";
            dtgMau.ValueMember = "MaMau";

            _DSNCC = svncc.LayTatCaNhaCungCap().ToList();
            cbNCC.DataSource = _DSNCC;
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";

            dtgChitiethoadon.AllowUserToAddRows = true;
        
        }

        private void FrmCTHDN_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btThemDH_Click(object sender, EventArgs e) 
        {
            List<Service_CTHDN.HoaDon> _ListCTHDN = new List<Service_CTHDN.HoaDon>();
            foreach (DataGridViewRow Datarow in dtgChitiethoadon.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null && Datarow.Cells[3].Value != null && Datarow.Cells[4].Value != null)
                {
                    Service_CTHDN.HoaDon chitiet = new Service_CTHDN.HoaDon();

                    chitiet._MaSP = int.Parse(Datarow.Cells[0].Value.ToString());
                    chitiet._MaMau = int.Parse(Datarow.Cells[1].Value.ToString());
                    chitiet._MaSize = int.Parse(Datarow.Cells[2].Value.ToString());
                    chitiet._SoLuong = int.Parse(Datarow.Cells[3].Value.ToString());
                    chitiet._GiaSP = decimal.Parse(Datarow.Cells[4].Value.ToString());
                    
                    _ListCTHDN.Add(chitiet);
                }
            }
            int check = 1;
            for (int i = 0; i < _ListCTHDN.Count - 1; i++)
            {
                for (int j = i + 1; j < _ListCTHDN.Count; j++)
                    if (_ListCTHDN[i]._MaSP.Equals(_ListCTHDN[j]._MaSP) && _ListCTHDN[i]._MaMau.Equals(_ListCTHDN[j]._MaMau)
                        && _ListCTHDN[i]._MaSize.Equals(_ListCTHDN[j]._MaSize))
                    {
                        check = 0;
                        break;
                    }
                if (check == 0)
                    break;
            }
            if (check == 1)
            {
                int MaNCC = _DSNCC[cbNCC.SelectedIndex].MaNCC;
                int MaNV = int.Parse(mess);
                string Ngaylap = timeNgaynhap.Value.ToString("yyyy-MM-dd");
                decimal Tongtien = decimal.Parse(txtTongTien.Text.ToString());
                int tinhtrang = 0;

                bool CheckCTHDN = true;
                int x = svhdn.ThemHDNVaTraVeMaDHN(MaNCC, MaNV, Ngaylap, Tongtien, tinhtrang);
                if (x != 0)
                {
                    for (int i = 0; i < _ListCTHDN.Count; i++)
                    {
                        int MaSP = _ListCTHDN[i]._MaSP;
                        int MaMau = _ListCTHDN[i]._MaMau;
                        int MaSize = _ListCTHDN[i]._MaSize;
                        int SoLuong = (int)_ListCTHDN[i]._SoLuong;
                        decimal Gianhap = (decimal)_ListCTHDN[i]._GiaSP;
                        CheckCTHDN = svctdh.ThemCTHDN(x, MaSP, MaMau, MaSize, SoLuong, Gianhap);
                        if (CheckCTHDN == false)
                            break;
                    }

                }

                if (CheckCTHDN == true && x != 0)
                    MessageBox.Show("Đã thêm thành công hóa đơn và chi tiết hóa đơn");
                else
                    MessageBox.Show("Không thêm thành công");


            }
            if (check == 0)
                MessageBox.Show("Chi tiết đơn hàng có sản phẩm trùng, kiểm tra lại");

            

            
        }
        private int Tongtien(int rows)
        {
            int tongtien = 0;
            for (int row = 0; row <= rows; row++)
            {
                int Soluong = int.Parse(dtgChitiethoadon.Rows[row].Cells[3].Value.ToString());
                int DonGia = int.Parse(dtgChitiethoadon.Rows[row].Cells[4].Value.ToString());
                tongtien = tongtien + Soluong * DonGia;
            }
            return tongtien;
        }

        private void dtgChitiethoadon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong != 0)
            {
                string TenSP = Convert.ToString((dtgChitiethoadon.Rows[dong - 1].Cells[0] as DataGridViewComboBoxCell).FormattedValue.ToString());
                string MauSac = Convert.ToString((dtgChitiethoadon.Rows[dong - 1].Cells[1] as DataGridViewComboBoxCell).FormattedValue.ToString());
                string Size = Convert.ToString((dtgChitiethoadon.Rows[dong - 1].Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString());
                if (!TenSP.Equals("") && !MauSac.Equals("") && !Size.Equals(""))
                {
                    if (!String.IsNullOrEmpty(Convert.ToString(dtgChitiethoadon.Rows[dong - 1].Cells[3].Value)) && !String.IsNullOrEmpty(Convert.ToString(dtgChitiethoadon.Rows[dong - 1].Cells[4].Value)))
                    {
                        txtTongTien.Text = Tongtien(dong - 1) + "";
                    }
                    else
                        MessageBox.Show("số lượng và đơn giá không được để trống");
                }
                else
                {
                    MessageBox.Show("Chọn sản phẩm, màu và size");
                }

            }
        }






        public int ComboRecord { get; set; }
    }
}
