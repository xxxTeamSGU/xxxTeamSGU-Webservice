using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_QuanLyShop
{
    public partial class FormDangNhap : Form
    {
        Service_NhanVien.Service_NhanVienSoapClient svnv = new Service_NhanVien.Service_NhanVienSoapClient();

        public FormDangNhap()
        {
            InitializeComponent();
            panel3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals("") && !txtMaKhau.Text.Equals(""))
            {
                bool x = svnv.KiemTraNhanVien(txtEmail.Text, txtMaKhau.Text);
                if (x == true)
                {
                    panel2.Visible = false;
                    panel3.Visible = true;
                    panelDangNhap.Visible = false;
                }
                else
                    MessageBox.Show("Đăng nhập không thành công");
            }
            else
            MessageBox.Show("Nhap email va password");
           
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panelSauDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btQuanLySanPham_Click(object sender, EventArgs e)
        {
            Form_QuanLySanPham fr = new Form_QuanLySanPham();
            fr.Show();
        }
    }
}
