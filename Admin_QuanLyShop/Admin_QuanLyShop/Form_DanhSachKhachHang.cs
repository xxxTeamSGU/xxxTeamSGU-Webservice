using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_QuanLyShop.Service_KhachHang;

namespace Admin_QuanLyShop
{
    public partial class Form_DanhSachKhachHang : Form
    {
        Service_KhachHang.Service_KhachHangSoapClient sv = new Service_KhachHang.Service_KhachHangSoapClient();
        public Form_DanhSachKhachHang()
        {
            InitializeComponent();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
        }

        private void btNap_Click(object sender, EventArgs e)
        {
            tableKhachHang.DataSource = sv.LayTatCaKhachHang().ToList();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            int x = 2;
            if (cbGioiTinh.Text.Equals("Nam"))
                x = 1;
            if (cbGioiTinh.Text.Equals("Nữ"))
                x = 0;

            if (x==2) 
                if( !txtHoTen.Text.Equals("") || !txtEmail.Text.Equals("") || !txtSoDT.Text.Equals(""))
                    tableKhachHang.DataSource = sv.TimKiemKhachHang(txtHoTen.Text, txtSoDT.Text, txtEmail.Text).ToList();

            if (x != 2)
                    tableKhachHang.DataSource = sv.TimKiemKhachHang_GioiTinh(txtHoTen.Text, txtSoDT.Text, txtEmail.Text, x).ToList();
            
          
        }
    }
}
