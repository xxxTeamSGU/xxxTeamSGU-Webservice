using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_Kho;
using System.Text.RegularExpressions;

namespace AdminQuanLyShop
{
    public partial class FrmKho : Form
    {
        Service_KhoClient svkho = new Service_KhoClient();
        Service_SanPham.Service_SanPhamClient svsp = new Service_SanPham.Service_SanPhamClient();
        Service_Mau.Service_MauClient svm = new Service_Mau.Service_MauClient();
        
        private List<Service_Kho.Kho> listkho = new List<Service_Kho.Kho>();
        private List<Service_Mau.Mau> listmau = new List<Service_Mau.Mau>();
        private List<Service_SanPham.SanPham> listsp = new List<Service_SanPham.SanPham>();
        private List<Service_Size.Size> listsize = new List<Service_Size.Size>();
        Service_SanPham_Kho.Service_SanPham_KhoClient svspk = new Service_SanPham_Kho.Service_SanPham_KhoClient();
        private int MaSp_Hientai;
        private int MaMau_HienTai;
        private List<Service_Kho.Kho_SP> listkhosp = new List<Service_Kho.Kho_SP>();
    
        public FrmKho()
        {
            InitializeComponent();
        }
        private void loadkho()
        {
           
          dtKho.DataSource = listkhosp;           
          this.dtKho.Columns[8].HeaderText = "Tên sản phẩm";
          this.dtKho.Columns[8].ReadOnly = true;
          this.dtKho.Columns[8].Width = 200;
          this.dtKho.Columns[8].DisplayIndex = 0;
          this.dtKho.Columns[5].HeaderText = "Màu sắc";
          this.dtKho.Columns[5].ReadOnly = true;
          this.dtKho.Columns[5].Width = 100;
          this.dtKho.Columns[5].DisplayIndex = 1;
          this.dtKho.Columns[6].HeaderText = "Size";
          this.dtKho.Columns[6].ReadOnly = true;
          this.dtKho.Columns[6].Width = 100;
          this.dtKho.Columns[6].DisplayIndex = 2;
          this.dtKho.Columns[7].HeaderText = "Số lượng";
          this.dtKho.Columns[7].ReadOnly = true;
          this.dtKho.Columns[7].Width = 50;
          this.dtKho.Columns[7].DisplayIndex = 3;
          this.dtKho.Columns[0].HeaderText = "Giá Bán";
          this.dtKho.Columns[0].ReadOnly = true;
          this.dtKho.Columns[0].Width = 100;
          this.dtKho.Columns[0].DisplayIndex = 4;
          this.dtKho.Columns[1].HeaderText = "Giá Nhập";
          this.dtKho.Columns[1].ReadOnly = true;
          this.dtKho.Columns[1].Width = 100;
          this.dtKho.Columns[1].DisplayIndex = 5;
          this.dtKho.Columns[2].Visible = false;
          this.dtKho.Columns[3].Visible = false;
          this.dtKho.Columns[4].Visible = false;

            

           
        }

        private void btload_Click(object sender, EventArgs e)
        {
            loadkho();
        }

        private void FrmKho_Load(object sender, EventArgs e)
        {
            listkhosp = svkho.LayTatCaKho().ToList();
        }

        private bool CheckNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!txtTim.Text.Equals(""))
            {
                if (CheckNumber(txtTim.Text.ToString()))
                {
                    int x = int.Parse(txtTim.Text.ToString());
                    dtKho.DataSource = listkhosp.Where(p => p._MaSP == x).ToList();
                    this.dtKho.Columns[8].HeaderText = "Tên sản phẩm";
                    this.dtKho.Columns[8].ReadOnly = true;
                    this.dtKho.Columns[8].Width = 200;
                    this.dtKho.Columns[8].DisplayIndex = 0;
                    this.dtKho.Columns[5].HeaderText = "Màu sắc";
                    this.dtKho.Columns[5].ReadOnly = true;
                    this.dtKho.Columns[5].Width = 100;
                    this.dtKho.Columns[5].DisplayIndex = 1;
                    this.dtKho.Columns[6].HeaderText = "Size";
                    this.dtKho.Columns[6].ReadOnly = true;
                    this.dtKho.Columns[6].Width = 100;
                    this.dtKho.Columns[6].DisplayIndex = 2;
                    this.dtKho.Columns[7].HeaderText = "Số lượng";
                    this.dtKho.Columns[7].ReadOnly = true;
                    this.dtKho.Columns[7].Width = 50;
                    this.dtKho.Columns[7].DisplayIndex = 3;
                    this.dtKho.Columns[0].HeaderText = "Giá Bán";
                    this.dtKho.Columns[0].ReadOnly = true;
                    this.dtKho.Columns[0].Width = 100;
                    this.dtKho.Columns[0].DisplayIndex = 4;
                    this.dtKho.Columns[1].HeaderText = "Giá Nhập";
                    this.dtKho.Columns[1].ReadOnly = true;
                    this.dtKho.Columns[1].Width = 100;
                    this.dtKho.Columns[1].DisplayIndex = 5;
                    this.dtKho.Columns[2].Visible = false;
                    this.dtKho.Columns[3].Visible = false;
                    this.dtKho.Columns[4].Visible = false;
                }
                else
                {
                    string x = txtTim.Text.ToString();
                    dtKho.DataSource = listkhosp.Where(p => p._TenSP.Contains(x) || p._Mau.Contains(x)).ToList();
                    this.dtKho.Columns[8].HeaderText = "Tên sản phẩm";
                    this.dtKho.Columns[8].ReadOnly = true;
                    this.dtKho.Columns[8].Width = 200;
                    this.dtKho.Columns[8].DisplayIndex = 0;
                    this.dtKho.Columns[5].HeaderText = "Màu sắc";
                    this.dtKho.Columns[5].ReadOnly = true;
                    this.dtKho.Columns[5].Width = 100;
                    this.dtKho.Columns[5].DisplayIndex = 1;
                    this.dtKho.Columns[6].HeaderText = "Size";
                    this.dtKho.Columns[6].ReadOnly = true;
                    this.dtKho.Columns[6].Width = 100;
                    this.dtKho.Columns[6].DisplayIndex = 2;
                    this.dtKho.Columns[7].HeaderText = "Số lượng";
                    this.dtKho.Columns[7].ReadOnly = true;
                    this.dtKho.Columns[7].Width = 50;
                    this.dtKho.Columns[7].DisplayIndex = 3;
                    this.dtKho.Columns[0].HeaderText = "Giá Bán";
                    this.dtKho.Columns[0].ReadOnly = true;
                    this.dtKho.Columns[0].Width = 100;
                    this.dtKho.Columns[0].DisplayIndex = 4;
                    this.dtKho.Columns[1].HeaderText = "Giá Nhập";
                    this.dtKho.Columns[1].ReadOnly = true;
                    this.dtKho.Columns[1].Width = 100;
                    this.dtKho.Columns[1].DisplayIndex = 5;
                    this.dtKho.Columns[2].Visible = false;
                    this.dtKho.Columns[3].Visible = false;
                    this.dtKho.Columns[4].Visible = false;
                }
                }
                 else
                MessageBox.Show("Chưa nhập sản phẩm cần tìm");
        }

        private void dtKho_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTenSP.Text = this.dtKho.CurrentRow.Cells[8].Value.ToString();
            txtMau.Text = this.dtKho.CurrentRow.Cells[5].Value.ToString();
            txtGiaSP.Text = this.dtKho.CurrentRow.Cells[0].Value.ToString();
             MaSp_Hientai = int.Parse(this.dtKho.CurrentRow.Cells[3].Value.ToString());
             MaMau_HienTai = int.Parse(this.dtKho.CurrentRow.Cells[2].Value.ToString());

            

        }

        private void btCapNhatGia_Click(object sender, EventArgs e)
        {
            if (!txtTenSP.Text.Equals("") && !txtGiaSP.Text.Equals("") && !txtMau.Text.Equals(""))
            {
                if (svkho.CapNhatGiaBanMoi(MaSp_Hientai, MaMau_HienTai, decimal.Parse(txtGiaSP.Text.ToString())))
                {
                    MessageBox.Show("Cập nhật giá bán thành công");
                    listkhosp = svkho.LayTatCaKho().ToList();
                    loadkho();
                }
                else
                    MessageBox.Show("Không cập nhật được giá");
                  
            }
            else
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
        }
    }
}
