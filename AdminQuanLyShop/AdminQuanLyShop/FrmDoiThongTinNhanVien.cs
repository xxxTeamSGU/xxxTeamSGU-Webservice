using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminQuanLyShop.Service_NhanVien;

namespace AdminQuanLyShop
{
    public partial class FrmDoiThongTinNhanVien : Form
    {
        string mess = "";
        Service_NhanVien.Service_NhanVienClient svnv = new Service_NhanVienClient();
        Service_NhanVien.NhanVien nhanvien = new Service_NhanVien.NhanVien();
        public delegate void SendMessage(string Message);
        public SendMessage Sender;   
        public FrmDoiThongTinNhanVien()
        {
            InitializeComponent();
            //Tạo con trỏ tới hàm GetMessage
            Sender = new SendMessage(GetMessage);
            
        }    //Hàm có nhiệm vụ lấy tham số truyền vào
        private void GetMessage(string Message)
        {
                    mess = Message;
        }
      
        
        private void loadTT()
        {
            if (!mess.Equals(""))
            {
                
                nhanvien = svnv.LayNhanVienTheoMa(int.Parse(mess));
                if (nhanvien != null)
                {
                    lbMaNV.Text = nhanvien.MaNV + "";
                    lbTenNV.Text = nhanvien.HoTen;
                    txtEmail.Text = nhanvien.Email;
                    txtDiaChi.Text = nhanvien.DiaChi;
                    txtSoDT.Text = nhanvien.SDT;
                    txtCMND.Text = nhanvien.CMND;
                }
            }
        }
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals(""))
            {
                if (!EmailAddressCheck(txtEmail.Text, 1))
                {
                    MessageBox.Show("Email nhập vào không chính xác");
                    return;
                }

            
            }
              if (!txtCMND.Text.Equals(""))
            {
                if (!CheckNumber(txtCMND.Text) || txtCMND.Text.Length > 10 || txtCMND.Text.Length < 9)
                {
                    MessageBox.Show("CMND nhập vào không chính xác");
                    return;
                }


            }
          
            if (!txtSoDT.Text.Equals(""))
            {
                if (!CheckNumber(txtSoDT.Text) || txtSoDT.Text.Length > 10 || txtSoDT.Text.Length < 9)
                {
                    MessageBox.Show("Số điện thoại nhập vào không chính xác");
                    return;
                }
               

            }

            if(!txtMaKhau.Equals("") && !txtNhapLaiMK.Text.Equals(""))
            {
                if (!txtMaKhau.Text.Equals(txtNhapLaiMK.Text))
                {
                    MessageBox.Show("Bạn nhập mật khẩu không đúng , vui lòng nhập lại");
                    return;
                }
                else
                {
                    if(txtMaKhau.Text.Length > 6)
                        nhanvien.MatKhau = txtMaKhau.Text;
                    else
                    {
                        MessageBox.Show("Mật khẩu phải nhiều hơn 6 ký tự");
                        return;
                    }
                }
            }
          

            if (!txtCMND.Text.Equals(""))
                nhanvien.CMND = txtCMND.Text;
            if (!txtEmail.Text.Equals(""))
            {
                if (!txtEmail.Text.Equals(nhanvien.Email))
                {
                    if (svnv.CheckEmail(txtEmail.Text))
                        MessageBox.Show("Email này đã tồn tại");
                    else
                        nhanvien.Email = txtEmail.Text;
                }
            }
            if (!txtSoDT.Text.Equals(""))
                nhanvien.SDT = txtSoDT.Text;
            if (!txtDiaChi.Text.Equals(""))
                nhanvien.DiaChi = txtDiaChi.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa thông tin", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (svnv.SuaNhanVien(int.Parse(nhanvien.MaNV.ToString()), nhanvien.HoTen, nhanvien.Email, nhanvien.MatKhau, nhanvien.DiaChi, nhanvien.SDT, nhanvien.CMND, int.Parse(nhanvien.QuyenAdmin.ToString())))
                    MessageBox.Show("Bạn đã sửa thông tin thành công");
                else
                    MessageBox.Show("Không sửa được , vui lòng kiểm tra lại");  
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtMaKhau.ReadOnly = false;
            txtNhapLaiMK.ReadOnly = false;
        }

         private bool EmailAddressCheck(string emailAddress, int Mode)
        {
            bool functionReturnValue = false;
            if (Mode == 1)
            {
                string pattern = "^[a-zA-Z][\\w\\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\\w\\.-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z\\.]*[a-zA-Z]$";
                Match emailAddressMatch = Regex.Match(emailAddress, pattern);
                if (emailAddressMatch.Success)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
     
                }
            }
            return functionReturnValue;

        }
        private bool CheckLetter(string input)
        {
            string[] List = new string[20];
            List = input.Split(new Char[] { ' ' });

            for (int i = 0; i < List.Length; i++)
            {
                if (Regex.IsMatch(input, @"[0-9]"))
                    return false;
                return true;
            }
            return true;
        }
        private bool CheckNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        private void FrmDoiThongTinNhanVien_Load(object sender, EventArgs e)
        {
            loadTT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }


    }
}
