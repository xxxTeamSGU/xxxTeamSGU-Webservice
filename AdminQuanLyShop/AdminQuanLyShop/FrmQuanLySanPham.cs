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
using AdminQuanLyShop.Service_Loai;
using AdminQuanLyShop.Service_KhuyenMai;
using System.IO;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace AdminQuanLyShop
{
    public partial class FrmQuanLySanPham : Form
    {
        Service_SanPhamClient svsp = new Service_SanPhamClient();
        Service_LoaiClient svl = new Service_LoaiClient();
        Service_KhuyenMaiClient svkm = new Service_KhuyenMaiClient();
        List<Service_SanPham.SanPham> _DMSP = new List<Service_SanPham.SanPham>();
        string[] ListAnh = new string[50];
        string[] nguonanh = new string[50];
        string AnhHienTai = "";
        string TenAnh = "";
        string TenAnhCuaSP = "";
        public FrmQuanLySanPham()
        {
            InitializeComponent();
        }

       

        private void FrmQuanLySanPham_Load(object sender, EventArgs e)
        {
            _DMSP = svsp.LayTatCaSanPham().ToList();

            cbLoai.DataSource = svl.LayTatCaLoai();
            cbLoai.DisplayMember = "TenLoai";
            cbLoai.ValueMember = "MaLoai";

            cbKM.DataSource = svkm.LayTatCaKM();
            cbKM.DisplayMember = "TenKM";
            cbKM.ValueMember = "MaKM";

            string [] Thuonghieu  = {"Nike", "Addidas", "Puma","Reebok","Converse","New Balance","Fila","K-Swiss","ASICS","Li-Ning"};
            cbThuongHieu.DataSource = Thuonghieu;
        }
        public void showanh(string ten)
        {
            string LinkAnh = @"https://huyimages.blob.core.windows.net/sanpham/";
            string anh = LinkAnh + ten;
            picBox.Size = new System.Drawing.Size(250,200);
            picBox.ImageLocation = anh;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private void btTaiSP_Click(object sender, EventArgs e)
        {
            LoadSP();

        }
        private void LoadSP()
        {
           
            dtgSanPham.DataSource = svsp.LayTatCaSanPham().ToList();
            dtgSanPham.Columns[5].DisplayIndex = 0;
            dtgSanPham.Columns[5].Width = 50;
            dtgSanPham.Columns[5].HeaderText = "ID";
            dtgSanPham.Columns[9].DisplayIndex = 1;
            dtgSanPham.Columns[9].Width = 280;
            dtgSanPham.Columns[9].HeaderText = "Tên sản phẩm";
            dtgSanPham.Columns[4].DisplayIndex = 2;
            dtgSanPham.Columns[4].Width = 50;
            dtgSanPham.Columns[4].HeaderText = "Mã loại";
            dtgSanPham.Columns[10].DisplayIndex = 3;
            dtgSanPham.Columns[10].Width = 180;
            dtgSanPham.Columns[10].HeaderText = "Thương hiệu";
            dtgSanPham.Columns[6].DisplayIndex = 4;
            dtgSanPham.Columns[6].Width = 180;
            dtgSanPham.Columns[6].HeaderText = "Mô tả";
            dtgSanPham.Columns[7].DisplayIndex = 5;
            dtgSanPham.Columns[7].Width = 180;
            dtgSanPham.Columns[7].HeaderText = "Mô tả chi tiết";
            dtgSanPham.Columns[3].DisplayIndex = 6;
            dtgSanPham.Columns[3].Width = 50;
            dtgSanPham.Columns[3].HeaderText = "Mã Khuyến Mãi";
            dtgSanPham.Columns[8].HeaderText = "Ngày đăng";
            dtgSanPham.Columns[0].Visible = false;
            dtgSanPham.Columns[1].Visible = false;
            dtgSanPham.Columns[2].Visible = false;
            dtgSanPham.Columns[11].Visible = false;

          

           
        }

        private void dtgSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMasp.Text = dtgSanPham.CurrentRow.Cells[5].Value.ToString();
            txbTenSP.Text =  dtgSanPham.CurrentRow.Cells[9].Value.ToString();
            cbLoai.SelectedValue =  int.Parse(dtgSanPham.CurrentRow.Cells[4].Value.ToString());
            cbThuongHieu.SelectedItem = dtgSanPham.CurrentRow.Cells[11].Value.ToString();
            cbKM.SelectedValue = int.Parse(dtgSanPham.CurrentRow.Cells[3].Value.ToString());

            string day = dtgSanPham.CurrentRow.Cells[8].Value.ToString();
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
            datetimeNgayDang.Value = new DateTime(int.Parse(nam), int.Parse(thang), int.Parse(ngay));

            txbMoTa.Text = dtgSanPham.CurrentRow.Cells[6].Value.ToString();
            rtxbChiTiet.Text = dtgSanPham.CurrentRow.Cells[7].Value.ToString();

            if (!String.IsNullOrEmpty(Convert.ToString(dtgSanPham.CurrentRow.Cells[0].Value)))
            {
                TenAnh = dtgSanPham.CurrentRow.Cells[0].Value.ToString();
                string Anh = dtgSanPham.CurrentRow.Cells[0].Value.ToString();
                Anh = Anh.Trim();
                TenAnhCuaSP = Anh.Trim();
                ListAnh = Anh.Split(new Char[] { ' ' });
                showanh(ListAnh[0]);
                AnhHienTai = ListAnh[0].ToString();
            }
            }

            private void btNext_Click(object sender, EventArgs e)
            {
            txbTenSP.Text = ListAnh.Length +"";

            if(AnhHienTai!= null)
            {
                for (int i = 0; i < ListAnh.Length -1; i++)
                {
                    if (ListAnh[i] != null)
                    {

                        if (ListAnh[i].Equals(AnhHienTai) && i < ListAnh.Length - 1 )
                        {
                            if (ListAnh[i+1] != null)
                            {
                                showanh(ListAnh[i + 1]);
                                 AnhHienTai = ListAnh[i + 1].ToString();
                                 break;
                            
                            }
                            else
                                break;
                        }
                    }
                    else
                        break;
                }      
            }
        }

        private void btPre_Click(object sender, EventArgs e)
        {
         
               
                
                if (AnhHienTai != null)
                {
                    for (int i = 0; i < ListAnh.Length; i++)
                    {

                        if (ListAnh[i] != null)
                        {

                            if (ListAnh[i].Equals(AnhHienTai) && i > 0)
                            {
                                showanh(ListAnh[i - 1]);
                                AnhHienTai = ListAnh[i - 1].ToString();
                                break;

                            }
                        }
                        else
                            break;
                    }
                }
        }

        private void btNhapMoi_Click(object sender, EventArgs e)
        {
            Nhapmoi();
        }
        private void Nhapmoi()
        {
            AnhHienTai = null;
            txbMasp.Text = "";
            txbTenSP.Text = "";
            txbMoTa.Text = "";
            cbThuongHieu.SelectedIndex= 0;
            rtxbChiTiet.Text = "";
            datetimeNgayDang.Value = DateTime.Now;
            cbLoai.SelectedIndex = 0;
            cbKM.SelectedIndex = 0;
            showanh("noimage.png");
            ResetListanh();
    
            TenAnh = "";
            TenAnhCuaSP = "";
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Convert.ToString(txbTenSP.Text)))
            {
                string Tensp = txbTenSP.Text;
                int loaisp = int.Parse(cbLoai.SelectedValue.ToString());
                string Thuonghieu = cbThuongHieu.SelectedValue.ToString();
                int KM = int.Parse(cbKM.SelectedValue.ToString());
                DateTime Ngayday = DateTime.Parse(datetimeNgayDang.Value.ToString("yyyy-MM-dd"));
                string Mota = txbMoTa.Text.ToString();
                string CTMT = rtxbChiTiet.Text.ToString();
                string HinhAnh = TenAnh;
                bool x = svsp.ThemSanPham(Tensp, loaisp, Thuonghieu, HinhAnh, Mota, KM, Ngayday, CTMT);
                if (x == true)
                {
                    MessageBox.Show("Thêm sp thành công");
                    LoadSP();
                    Nhapmoi();
                }
                else
                    MessageBox.Show("Không thêm được");

            }
            else
                MessageBox.Show("Bạn chưa nhập tên sp");
            
        }

        private void btThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (ofile.ShowDialog() == DialogResult.OK)
            {
                picBox.ImageLocation = ofile.FileName;
                picBox.Size = new System.Drawing.Size(250, 200);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            Random generator = new Random();
            String r = generator.Next(1, 100).ToString("D3");
            StorageCredentials sc = new StorageCredentials("huyimages", "blFLz1X7CCNGyHXDMskJ6wKJ75BgyPRXqEi1mGCX9icPIUBTZRT1m2Lq9MsI6bR8Xrey1STCcvEpuiXZr9HZPQ==");
            CloudStorageAccount storageAccount = new CloudStorageAccount(sc, false);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("sanpham");

            string filename = "";
            filename = System.IO.Path.GetFileName(ofile.FileName);
            filename = r + filename;
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(filename);


            // Create or overwrite the "myblob" blob with contents from a local file.
            using (var fileStream = System.IO.File.OpenRead(ofile.FileName))
            {
                blockBlob.UploadFromStream(fileStream);
            }
            AnhHienTai = filename;
            TenAnh = TenAnh + " " + filename;

            

        }
        
          

       
        private void ResetListanh()
        {
            for (int i =0; i< ListAnh.Length ; i++)
            {
                if (ListAnh[i] != null)
                {
                    ListAnh[i] = null;
                    nguonanh[i] = null;
                }
                else
                    break;
            }
        }
        // btxoaanh
        private void button1_Click(object sender, EventArgs e)
        {
            TenAnh = "";
            ListAnh = ListAnh.Where(p => p != AnhHienTai).ToArray();
            for(int i=0 ; i< ListAnh.Length; i++)
                TenAnh = TenAnh + ListAnh[i] + " ";
            if (ListAnh.Length != 0)
            {
                AnhHienTai = ListAnh[0];
                showanh(AnhHienTai);
            }
            else
            {
                AnhHienTai = null;
                showanh("noimage.png");
            }
        }

        private void btSuaSP_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Convert.ToString(txbTenSP.Text)))
            {
                int MaSP = int.Parse(txbMasp.Text.ToString());
                string Tensp = txbTenSP.Text;
                int loaisp = int.Parse(cbLoai.SelectedValue.ToString());
                string Thuonghieu = cbThuongHieu.SelectedValue.ToString();
                int KM = int.Parse(cbKM.SelectedValue.ToString());
                DateTime Ngayday = DateTime.Parse(datetimeNgayDang.Value.ToString("yyyy-MM-dd"));
                string Mota = txbMoTa.Text.ToString();
                string CTMT = rtxbChiTiet.Text.ToString();
                string HinhAnh = TenAnh;
                
                bool x = svsp.SuaSanPham(MaSP,Tensp, loaisp, Thuonghieu, HinhAnh, Mota, KM, Ngayday, CTMT);
                if (x == true)
                {
                    MessageBox.Show("Sửa sp thành công");
                    LoadSP();
                    Nhapmoi();
                }
                else
                    MessageBox.Show("Không sửa được");

            }
            else
                MessageBox.Show("Bạn chưa nhập tên sp");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Convert.ToString(txbMasp.Text)))
            {
                bool x = svsp.XoaSanPham(int.Parse(txbMasp.Text.ToString()));
                if (x == true)
                {
                    MessageBox.Show("Xóa sản phẩm thành công");
                    LoadSP();
                    Nhapmoi();
                }
                else
                {
                     MessageBox.Show("Xóa sản phẩm không    thành công");
                     LoadSP();
                     Nhapmoi();
                }
            }
            else
                MessageBox.Show("Nhập mã sản phẩm cần xóa");
        }

        private List<Service_SanPham.SanPham> filter(string request)
        {
            request = txbLoc.Text.ToLower();
            int number;
            bool isNumber = Int32.TryParse(request, out number);
            if (isNumber)
            {
                var linqQuery = _DMSP.Where
                (s => s.MaSP.Equals(number)
                || s.TenSP.Equals(number)
                || s.ThuongHieu.Equals(number)
                || s.MaLoai.Equals(number)
                || s.NgayDang.Equals(number)
                );
                return linqQuery.ToList<Service_SanPham.SanPham>();
            }
            else
            {
                var linqQuery = _DMSP.Where
                (s => s.TenSP.ToLower().Contains(request)
                || s.ThuongHieu.ToLower().Contains(request)
                );
                return linqQuery.ToList<Service_SanPham.SanPham>();
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (!txbLoc.Text.Equals(""))
            {
                string x = txbLoc.Text.ToString();
                List<Service_SanPham.SanPham> listsptim = new List<Service_SanPham.SanPham>();
                listsptim = _DMSP.Where(p => p.TenSP.Contains(x) || p.ThuongHieu.Contains(x)).ToList();
                dtgSanPham.DataSource = listsptim;
                dtgSanPham.Columns[5].DisplayIndex = 0;
                dtgSanPham.Columns[5].Width = 50;
                dtgSanPham.Columns[9].DisplayIndex = 1;
                dtgSanPham.Columns[9].Width = 280;
                dtgSanPham.Columns[4].DisplayIndex = 2;
                dtgSanPham.Columns[4].Width = 50;
                dtgSanPham.Columns[10].DisplayIndex = 3;
                dtgSanPham.Columns[10].Width = 180;
                dtgSanPham.Columns[6].DisplayIndex = 4;
                dtgSanPham.Columns[6].Width = 180;
                dtgSanPham.Columns[7].DisplayIndex = 5;
                dtgSanPham.Columns[7].Width = 180;
                dtgSanPham.Columns[3].DisplayIndex = 6;
                dtgSanPham.Columns[3].Width = 50;
                dtgSanPham.Columns[0].Visible = false;
                dtgSanPham.Columns[1].Visible = false;
                dtgSanPham.Columns[2].Visible = false;
                dtgSanPham.Columns[11].Visible = false;

            }
            else
                MessageBox.Show("Chưa nhập dữ liệu cần tìm");
        }

        private void dtgSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThemLoai_Click(object sender, EventArgs e)
        {
            FrmLoai fr = new FrmLoai();
            fr.ShowDialog();
        }

        private void btThemKM_Click(object sender, EventArgs e)
        {
            FrmKhuyenMai fr = new FrmKhuyenMai();
            fr.ShowDialog();
        }

      
      

      

           
    }
}
