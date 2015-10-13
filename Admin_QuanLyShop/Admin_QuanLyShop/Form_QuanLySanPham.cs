using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_QuanLyShop.Service_SanPham;
using Admin_QuanLyShop.Service_Loai;
using System.IO;

namespace Admin_QuanLyShop
{
    public partial class Form_QuanLySanPham : Form
    {
        
        private string[] TaiAnh = new string[4]; // Tải ảnh lên từ database
        private string[] LuuAnh = new string[4]; // Tên file ảnh được chọn nhưng chưa lưu vào database và coppy vào thư mục
        private string[] TenAnh = new string[4]; // Tên file ảnh được chọn
        private string[] NguonAnh = new string[4]; // T
        Service_SanPham.Service_SanPhamSoapClient sv = new Service_SanPham.Service_SanPhamSoapClient();
        Service_Loai.Service_LoaiSoapClient svl = new Service_Loai.Service_LoaiSoapClient();
        private List<Service_Loai.Loai> lst2;
        public Form_QuanLySanPham()
        {
            InitializeComponent();
            LoadLoaiSP();
        }
        public void LoadLoaiSP()
        {
           // List<Service_SanPham.SanPham> lst = sv.LayTatCaSanPham().ToList();
            lst2 = svl.LayTatCaLoai().ToList();
            for (int i = 0; i< lst2.Count;i++)
            {
                Service_Loai.Loai loai = lst2[i] as Service_Loai.Loai;
                cbLoaiSP.Items.Add(loai.TenLoai);
            }
        }
        public void showanh(string ten)
        {
             string LinkAnh = @"C:\Users\huy\Documents\Visual Studio 2013\Projects\Admin_QuanLyShop\Admin_QuanLyShop\HinhAnh\";
            string anh = LinkAnh + ten;
            picBox.Size = new System.Drawing.Size(230, 145);
            picBox.ImageLocation = anh;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
       
       
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TaiAnh[0]))
                showanh(TaiAnh[0]);
            else
                picBox.ImageLocation =null;

            if (!String.IsNullOrEmpty(LuuAnh[0]))
                picBox.ImageLocation = LuuAnh[0];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TaiAnh[2]))
            showanh(TaiAnh[2]);
            else
            picBox.ImageLocation = null;

            if (!String.IsNullOrEmpty(LuuAnh[2]))
                picBox.ImageLocation = LuuAnh[2];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TaiAnh[1]))
            showanh(TaiAnh[1]);
            else
            picBox.ImageLocation = null;

            if (!String.IsNullOrEmpty(LuuAnh[1]))
                picBox.ImageLocation = LuuAnh[1];
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TaiAnh[3]))
            showanh(TaiAnh[3]);
            else
            picBox.ImageLocation = null;

            if (!String.IsNullOrEmpty(LuuAnh[3]))
                picBox.ImageLocation = LuuAnh[3];
        }

     
        private void button5_Click_1(object sender, EventArgs e)
        {
            tableSanPham.DataSource = sv.LayTatCaSanPham().ToList();
        }

       


        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x= cbLoaiSP.Text;
            for (int i =0 ; i < lst2.Count ; i++)
            {
                if (lst2[i].TenLoai.ToString().Equals(x))
                    txtMaLoai.Text = lst2[i].MaLoai.ToString();
            }
        }

        private void tableSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = tableSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = tableSanPham.CurrentRow.Cells[1].Value.ToString();
            txtMaLoai.Text = tableSanPham.CurrentRow.Cells[2].Value.ToString();
            for (int i = 0; i < lst2.Count; i++)
            {
                if (lst2[i].MaLoai == int.Parse(txtMaLoai.Text))
                {
                    cbLoaiSP.SelectedIndex = cbLoaiSP.Items.IndexOf(lst2[i].TenLoai.ToString());

                    break;
                }

            }
            txtThuongHieu.Text = tableSanPham.CurrentRow.Cells[3].Value.ToString();
            txtSize.Text = tableSanPham.CurrentRow.Cells[4].Value.ToString();
            txtMau.Text = tableSanPham.CurrentRow.Cells[5].Value.ToString();
            txtGiaSP.Text = tableSanPham.CurrentRow.Cells[6].Value.ToString();
            txtSoLuong.Text = tableSanPham.CurrentRow.Cells[11].Value.ToString();
         
            txtMoTa.Text = tableSanPham.CurrentRow.Cells[12].Value.ToString();

      
            int km = int.Parse(tableSanPham.CurrentRow.Cells[13].Value.ToString());
            if (km != 0)
                ckKhuyenMai.Checked = true;
            else ckKhuyenMai.Checked = false;

            rdHinh1.Checked = true;
            TaiAnh[0] = tableSanPham.CurrentRow.Cells[7].Value.ToString();
            TaiAnh[1] = tableSanPham.CurrentRow.Cells[8].Value.ToString();
            TaiAnh[2] = tableSanPham.CurrentRow.Cells[9].Value.ToString();
            TaiAnh[3] = tableSanPham.CurrentRow.Cells[10].Value.ToString();
            // lưu ảnh vào mảng để có thể sửa  sản phẩm
            TenAnh[0] = tableSanPham.CurrentRow.Cells[7].Value.ToString();
            TenAnh[1] = tableSanPham.CurrentRow.Cells[8].Value.ToString();
            TenAnh[2] = tableSanPham.CurrentRow.Cells[9].Value.ToString();
            TenAnh[3] = tableSanPham.CurrentRow.Cells[10].Value.ToString();
            showanh(TaiAnh[0]);
            if (!String.IsNullOrEmpty(Convert.ToString(tableSanPham.CurrentRow.Cells[14].Value)))
            {
                string day = tableSanPham.CurrentRow.Cells[14].Value.ToString();
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
                dateTimePicker1.Value = new DateTime(int.Parse(nam), int.Parse(thang), int.Parse(ngay));
            }
            else
                dateTimePicker1.Value = DateTime.Now;


        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string TenSP = txtTenSP.Text + "";
            int Loai = 0 + int.Parse(txtMaLoai.Text);
            string ThuongHieu = txtThuongHieu.Text + "";
            string Size = txtSize.Text + "";
            string Mau = txtMau.Text + "";
            decimal GiaSP = (decimal)(int.Parse(txtGiaSP.Text.ToString()));
            string Hinh1 = "" + TenAnh[0] ;
            string Hinh2 = "" + TenAnh[1];
            string Hinh3 = "" + TenAnh[2];
            string Hinh4 = "" + TenAnh[3];
            int SoLuong = 0 + int.Parse(txtSoLuong.Text);
            string MoTa = txtMoTa.Text + "";
            int KM = 0;
            if (ckKhuyenMai.Checked == true)
                KM = 1;
            string ngay = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00.000";

            bool x = sv.ThemSanPham(TenSP, Loai, ThuongHieu, Size, Mau, GiaSP, Hinh1, Hinh2, Hinh3, Hinh4, SoLuong, MoTa, KM, ngay);
            if (x == true)
            {
                MessageBox.Show("Thêm thành công");
                tableSanPham.DataSource = sv.LayTatCaSanPham().ToList();
            }
            else
                MessageBox.Show("Có lỗi xảy ra, không thêm được");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaSP.Text);
            bool x = sv.XoaSanPham(ma);
            if (x == true)
            {
                MessageBox.Show("Xóa thành công");
                tableSanPham.DataSource = sv.LayTatCaSanPham().ToList();
            }
            else
                MessageBox.Show("Không xóa được");
        }

        private void btChonHinh_Click(object sender, EventArgs e)
        {
           // string destinationPath = @"C:\Users\huy\Documents\Visual Studio 2013\Projects\Admin_QuanLyShop\Admin_QuanLyShop\HinhAnh\";
            if (rdHinh1.Checked == false && rdHinh2.Checked == false && rdHinh3.Checked == false && rdHinh4.Checked == false)
                rdHinh1.Checked = true;
            
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (ofile.ShowDialog() == DialogResult.OK)
            {
                picBox.ImageLocation = ofile.FileName;
                picBox.Size = new System.Drawing.Size(230, 145);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                string filechualuu = ofile.FileName;    
                string sourcePath = ofile.FileName;
                string filename = "";
                filename = System.IO.Path.GetFileName(ofile.FileName);
              //  destinationPath += Path.GetFileName(sourcePath);
               // if (File.Exists(destinationPath.ToString()))
               // {

                if (rdHinh1.Checked == true)
                {
                    LuuAnh[0] = filechualuu;
                    TenAnh[0] = filename;
                    NguonAnh[0] = sourcePath;
                }
                if (rdHinh2.Checked == true)
                {
                    LuuAnh[1] = filechualuu;
                    TenAnh[1] = filename;
                    NguonAnh[1] = sourcePath;
                }
                if (rdHinh3.Checked == true)
                {
                    LuuAnh[2] = filechualuu;
                    TenAnh[2] = filename;
                    NguonAnh[2] = sourcePath;
                }
                if (rdHinh4.Checked == true)
                {
                    LuuAnh[3] = filechualuu;
                    TenAnh[3] = filename;
                    NguonAnh[3] = sourcePath;
                }
                //}
                //else
                //{
                //    File.Copy(sourcePath, destinationPath);
                //    if (rdHinh1.Checked == true)
                //        TaiAnh[0] = filename;
                //    if (rdHinh2.Checked == true)
                //        TaiAnh[1] = filename;
                //    if (rdHinh3.Checked == true)
                //        TaiAnh[2] = filename;
                //    if (rdHinh4.Checked == true)
                //        TaiAnh[3] = filename;
                //}

            }
        }
      

       private void btnLuuHinh_Click(object sender, EventArgs e)
       {
          
           for (int i = 0; i <= 3; i++)
           {
               if (!String.IsNullOrEmpty(TenAnh[i]))
               {
                   string destinationPath = @"C:\Users\huy\Documents\Visual Studio 2013\Projects\Admin_QuanLyShop\Admin_QuanLyShop\HinhAnh\";
                   destinationPath = destinationPath + TenAnh[i];
                   if (File.Exists(destinationPath.ToString()))
                   {
                       TaiAnh[i] = TenAnh[i];
                       LuuAnh[i] = null;
                   }
                   else
                   {
                       TaiAnh[i] = TenAnh[i];
                       LuuAnh[i] = null;
                       File.Copy(NguonAnh[i].ToString(), destinationPath);

                   }
               }
           }
          
       }

       private void btNhapmoi_Click(object sender, EventArgs e)
       {
           txtMaSP.Text = "";
           txtTenSP.Text = "";
           txtMaLoai.Text = "";
           txtGiaSP.Text = "";
           txtMau.Text = "";
           txtMoTa.Text = "";
           txtSize.Text = "";
           txtSoLuong.Text = "";
           txtThuongHieu.Text = "";
           rdHinh1.Checked = false;
           rdHinh2.Checked = false;
           rdHinh3.Checked = false;
           rdHinh4.Checked = false;
           dateTimePicker1.Value = DateTime.Now;
           ckKhuyenMai.Checked = false;
           picBox.ImageLocation = null;
           for (int i = 0 ; i<=3 ; i++)
               TaiAnh[i] = null;
           

       }

       private void btSua_Click(object sender, EventArgs e)
       {
           int MaSP  = 0 +  int.Parse(txtMaSP.Text);
           string TenSP = txtTenSP.Text + "";
           int Loai = 0 + int.Parse(txtMaLoai.Text);
           string ThuongHieu = txtThuongHieu.Text + "";
           string Size = txtSize.Text + "";
           string Mau = txtMau.Text + "";
           decimal GiaSP = (decimal)(int.Parse(txtGiaSP.Text.ToString()));
           string Hinh1 = "" + TenAnh[0];
           string Hinh2 = "" + TenAnh[1];
           string Hinh3 = "" + TenAnh[2];
           string Hinh4 = "" + TenAnh[3];
           int SoLuong = 0 + int.Parse(txtSoLuong.Text);
           string MoTa = txtMoTa.Text + "";
           int KM = 0;
           if (ckKhuyenMai.Checked == true)
               KM = 1;
           string ngay = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00.000";

           
           bool y = sv.SuaSanPham(MaSP, TenSP, Loai, ThuongHieu, Size, Mau, GiaSP, Hinh1, Hinh2, Hinh3, Hinh4, SoLuong, MoTa, KM, ngay);
           if (y == true)
           {
               MessageBox.Show("Sửa sản phẩm thành công");
               tableSanPham.DataSource = sv.LayTatCaSanPham().ToList();
           }
           else
               MessageBox.Show("Có lỗi xảy ra, không sửa được");

       }

       private void button1_Click(object sender, EventArgs e)
       {
            if (!txtTim.Equals(""))
            {
                string tim = txtTim.Text;
                tableSanPham.DataSource = sv.TimKiemSanPham(tim).ToList();
            }
       }

      
    }
}
