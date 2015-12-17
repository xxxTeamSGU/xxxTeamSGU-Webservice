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
using System.Text.RegularExpressions;

namespace AdminQuanLyShop
{
    public partial class FrmNhanVien : Form
    {
        Service_NhanVienClient svnv = new Service_NhanVienClient();
        List<Service_NhanVien.NhanVien> nhanvien = new List<Service_NhanVien.NhanVien>();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {

            dtgNhanvien.DataSource = nhanvien;
            dtgNhanvien.Columns[4].DisplayIndex = 0;
            dtgNhanvien.Columns[4].Width = 50;
            dtgNhanvien.Columns[4].HeaderText = "ID";
            dtgNhanvien.Columns[3].DisplayIndex = 1;
            dtgNhanvien.Columns[3].Width = 180;
            dtgNhanvien.Columns[3].HeaderText = "Họ tên";
            dtgNhanvien.Columns[1].DisplayIndex = 2;
            dtgNhanvien.Columns[1].Width = 180;
            dtgNhanvien.Columns[1].HeaderText = "Địa chỉ";
            dtgNhanvien.Columns[2].DisplayIndex = 3;
            dtgNhanvien.Columns[2].Width = 180;
            dtgNhanvien.Columns[2].HeaderText = "Email";
            dtgNhanvien.Columns[0].DisplayIndex = 4;
            dtgNhanvien.Columns[0].Width = 180;
            dtgNhanvien.Columns[0].HeaderText = "CMND";
            dtgNhanvien.Columns[7].DisplayIndex = 5;
            dtgNhanvien.Columns[7].Width = 100;
            dtgNhanvien.Columns[7].HeaderText = "Số điện thoại";
            dtgNhanvien.Columns[6].DisplayIndex = 6;
            dtgNhanvien.Columns[6].Width = 100;
            dtgNhanvien.Columns[6].HeaderText = "Admin";
            dtgNhanvien.Columns[5].Visible = false;
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (!txtTenNV.Text.Equals("") && !txtEmail.Text.Equals(""))
            {
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
                if (!txtEmail.Text.Equals(""))
                {
                    if (!EmailAddressCheck(txtEmail.Text, 1))
                    {
                        MessageBox.Show("Email nhập vào không chính xác");
                        return;
                    }


                }
                if(svnv.CheckEmail(txtEmail.Text.ToString()))
                {
                    MessageBox.Show("Email này đã tồn tại");
                    return;

                }

                int ad = 0;
                    if (cbAdmin.Checked == true)
                        ad = 1;
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm nhân viên ", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool x = svnv.ThemNhanVien(txtTenNV.Text, txtEmail.Text, "12345678", txtDiaChi.Text, txtSoDT.Text, txtCMND.Text, ad);
                        if (x == true)
                        {
                            MessageBox.Show("Nhập nhân viên thành công");
                            nhanvien = svnv.LayTatCaNhaNhanVien().ToList();
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
                MessageBox.Show("Chưa nhập tên nhân viên và email");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!txtMaNV.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int MaNV = int.Parse(txtMaNV.Text);
                    bool x = svnv.XoaNhanVien(MaNV);
                    if (x == true)
                    {
                        MessageBox.Show("Đã xóa nhân viên");
                        nhanvien = svnv.LayTatCaNhaNhanVien().ToList();
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
                MessageBox.Show("Chưa có mã nhân viên cần xóa");
        }

        private void btNhapmoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSoDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            cbAdmin.Checked = false;
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

        private void dtgNhanvien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = this.dtgNhanvien.CurrentRow.Cells[4].Value.ToString();
            txtTenNV.Text = this.dtgNhanvien.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = this.dtgNhanvien.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = this.dtgNhanvien.CurrentRow.Cells[1].Value.ToString();
            txtSoDT.Text = this.dtgNhanvien.CurrentRow.Cells[7].Value.ToString();
            txtCMND.Text = this.dtgNhanvien.CurrentRow.Cells[0].Value.ToString();

            int Quyenadmin = int.Parse(this.dtgNhanvien.CurrentRow.Cells[6].Value.ToString());
            if (Quyenadmin == 1)
                cbAdmin.Checked = true;
            if (Quyenadmin == 0)
                cbAdmin.Checked = false;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            nhanvien = svnv.LayTatCaNhaNhanVien().ToList();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            nhanvien = svnv.LayTatCaNhaNhanVien().ToList();
            if (!txtTim.Text.Equals(""))
            {
                string x = txtTim.Text.ToString();
                List<Service_NhanVien.NhanVien> listtim = new List<Service_NhanVien.NhanVien>();
                listtim = nhanvien.Where(p => p.HoTen.Contains(x) || p.Email.Contains(x) || p.DiaChi.Contains(x)).ToList();
                dtgNhanvien.DataSource = listtim;
                dtgNhanvien.Columns[4].DisplayIndex = 0;
                dtgNhanvien.Columns[4].Width = 50;
                dtgNhanvien.Columns[4].HeaderText = "ID";
                dtgNhanvien.Columns[3].DisplayIndex = 1;
                dtgNhanvien.Columns[3].Width = 180;
                dtgNhanvien.Columns[3].HeaderText = "Họ tên";
                dtgNhanvien.Columns[1].DisplayIndex = 2;
                dtgNhanvien.Columns[1].Width = 180;
                dtgNhanvien.Columns[1].HeaderText = "Địa chỉ";
                dtgNhanvien.Columns[2].DisplayIndex = 3;
                dtgNhanvien.Columns[2].Width = 180;
                dtgNhanvien.Columns[2].HeaderText = "Email";
                dtgNhanvien.Columns[0].DisplayIndex = 4;
                dtgNhanvien.Columns[0].Width = 180;
                dtgNhanvien.Columns[0].HeaderText = "CMND";
                dtgNhanvien.Columns[7].DisplayIndex = 5;
                dtgNhanvien.Columns[7].Width = 100;
                dtgNhanvien.Columns[7].HeaderText = "Số điện thoại";
                dtgNhanvien.Columns[6].DisplayIndex = 6;
                dtgNhanvien.Columns[6].Width = 100;
                dtgNhanvien.Columns[6].HeaderText = "Admin";
                dtgNhanvien.Columns[5].Visible = false;
            }
            else
                MessageBox.Show("Nhập dữ liệu cần tìm");
        }

    }
}
