using Service_GiayDep.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services;
using WCF.Models;


namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service_Kho" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service_Kho.svc or Service_Kho.svc.cs at the Solution Explorer and start debugging.
    public class Service_Kho : IService_Kho
    {
        DBGiayDepEntities db = new DBGiayDepEntities();
        //Phương thức lấy kho sản phẩm
        [WebMethod]
        public List<SanPham_Price> LayKhoTheoSP(int MaSP)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Khoes.Where(p => p.MaSP == MaSP).Select(p => new SanPham_Price {
                        _MaSP = p.MaSP, 
                        _TenSP = p.SanPham.TenSP,
                        _MaMau = p.MaMau,
                        _Size = p.MaSize,
                        _GiaSP = (decimal)p.GiaBan })
                        .ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }

        [WebMethod]
        public bool NhapMoi(int MaSP, int Mau, int MaSize, int Soluong, decimal GiaNhap)
        {
            Kho kho = new Kho();
            kho.MaSP = MaSP;
            kho.MaMau = Mau;
            kho.MaSize = MaSize;
            kho.SL = Soluong;
            kho.GiaNhap = GiaNhap;
            kho.GiaBan = 0;
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    db.Khoes.Add(kho);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

        [WebMethod]
        public bool CapNhat(int MaSP, int Mau, int MaSize, int Soluong, decimal GiaNhap)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Khoes.SingleOrDefault(p => p.MaSP == MaSP && p.MaMau == Mau && p.MaSize == MaSize);
                    if (item != null)
                    {
                        item.SL = item.SL + Soluong;
                        item.GiaNhap = GiaNhap;
                        db.SaveChanges();
                        return true;

                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        public bool CapNhatBanHang(int MaSP, int Mau, int MaSize, int Soluong)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Khoes.SingleOrDefault(p => p.MaSP == MaSP && p.MaMau == Mau && p.MaSize == MaSize);
                    if (item != null)
                    {
                        item.SL = item.SL - Soluong;
                        db.SaveChanges();
                        return true;

                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

        [WebMethod]
        public bool CheckKho(int MaSP, int Mau, int MaSize)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Khoes.SingleOrDefault(p => p.MaSP == MaSP && p.MaMau == Mau && p.MaSize == MaSize);
                    if (item != null)
                    {
                        return true;

                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        public bool CheckSoLuong(int MaSP, int Mau, int MaSize, int SoLuong)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Khoes.SingleOrDefault(p => p.MaSP == MaSP && p.MaMau == Mau && p.MaSize == MaSize);
                    if (item != null)
                    {
                        int x = (int)item.SL - SoLuong;
                        if (x < 0)
                            return false;
                        return true;

                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        [WebMethod]
        public bool ThemKho(int MaHDN)
        {
            try
            {
                bool check = true;
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.CTHDNs.Where(p => p.MaHDN == MaHDN).Select(p => p).ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (CheckKho(list[i].MaSP, list[i].MaMau, list[i].MaSize))
                        {
                            decimal GiaNhap = (decimal)list[i].GiaNhap;
                            int MaSP = list[i].MaSP;
                            int MaMau = list[i].MaMau;
                            int MaSize = list[i].MaSize;
                            int SoLuong = (int)list[i].SL;

                            check = CapNhat(MaSP, MaMau, MaSize, SoLuong, GiaNhap);
                            if (check == false)
                                break;
                        }
                        else
                        {

                            decimal GiaNhap = (decimal)list[i].GiaNhap;
                            int MaSP = list[i].MaSP;
                            int MaMau = list[i].MaMau;
                            int MaSize = list[i].MaSize;
                            int SoLuong = (int)list[i].SL;

                            check = NhapMoi(MaSP, MaMau, MaSize, SoLuong, GiaNhap);
                            if (check == false)
                                break;

                        }

                    }
                    if (check == true)
                    {
                        Service_HoaDonNhap sv = new Service_HoaDonNhap();
                        check = sv.DuyetHD(MaHDN);
                    }
                    return check;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

        [WebMethod]
        public bool XuatKho(int MaHD,string NhanVien)
        {
            try
            {
                bool check = true;
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.CTDHs.Where(p => p.MaDH == MaHD).Select(p => p).ToList();
                    if (list != null)
                    {
                        for(int i = 0; i < list.Count; i++)
                        {
                            check = CheckSoLuong(list[i].MaSP, list[i].MaMau, list[i].MaSize, (int)list[i].SL);
                            if (check == false) 
                            break;

                        }
                        if (check == true)
                        for (int i = 0; i < list.Count; i++)
                        {
                           
                                int MaSP = list[i].MaSP;
                                int MaMau = list[i].MaMau;
                                int MaSize = list[i].MaSize;
                                int SoLuong = (int)list[i].SL;

                                check = CapNhatBanHang(MaSP, MaMau, MaSize, SoLuong);
                                if (check == false)
                                    break;
                            


                        }
                        if (check == true)
                        {
                            Service_DonHang sv = new Service_DonHang();
                            check = sv.DuyetHD(MaHD,NhanVien);
                        }
                        return check;

                    }
                    else
                        return false;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

       
        [WebMethod]
        public List<Kho_SP> LayTatCaKho()
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var list = db.Khoes.Select(p => new Kho_SP
                    {
                        _MaSP = p.MaSP,
                        _TenSP = p.SanPham.TenSP,
                        _MaMau = p.MaMau,
                        _Mau = p.Mau.TenMau,
                        _MaSize = p.MaSize,
                        _Size = p.Size.Size1,
                        _SoLuong = (int)p.SL,
                        _GiaBan = (decimal)p.GiaBan,
                        _GiaNhap = (decimal)p.GiaNhap,

                    }).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }

        [WebMethod]
        public bool CapNhatGiaBanMoi(int MaSP, int MaMau, decimal GiaBan)
        {
            try
            {
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {
                    var item = db.Khoes.Where(p => p.MaSP == MaSP && p.MaMau == MaMau).ToList();
                    if (item != null)
                    {
                        for (int i = 0; i < item.Count; i++)
                            item[i].GiaBan = GiaBan;
                        db.SaveChanges();
                        return true;


                    }
                    else
                        return false;

                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        //Phương thức lấy kho sản phẩm
        [WebMethod]
        public Kho LayKho(int masp)
        {
            try
            {
                //Gọi tới Database
                using (DBGiayDepEntities db = new DBGiayDepEntities())
                {


                    var list = (db.Khoes.SingleOrDefault(n => n.MaSP == masp));

                    return list;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }

        }
        [WebMethod]
        public List<LaySize> LaySize(int masp, int mamau)
        {
            var laysize = db.Khoes.Where(n => n.MaSP == masp && n.Mau.MaMau == mamau).Select(n => new LaySize
            {
                _MaSize = n.Size.MaSize,
                _Size = (int)n.Size.Size1,
            }).ToList();

            return laysize;

        }
        [WebMethod]
        public List<LayMau> LayMau(int masp)
        {
            //var laymau = db.Khoes.Distinct().Where(n=>n.MaSP==masp).Select(n => new LayMau
            //{
            //    _TenMau= n.Mau.TenMau,
            //}).ToList();
            List<LayMau> list = db.Khoes.Where(n => n.MaSP == masp).Select(n => new LayMau
            {
                _MaSP = n.SanPham.MaSP,
                _MaMau = n.MaMau,
                _TenMau = n.Mau.TenMau,
            }).Distinct().ToList();
            return list;


        }
        [WebMethod]
        public int LayGia(int MaSP, int MaMau)
        {
            List<Kho> laygia = db.Khoes.Where(n => n.MaSP == MaSP && n.MaMau == MaMau).Select(p => p).ToList();
            if (laygia != null)
            {
                if (laygia.Count > 2)
                {
                    for (int i = 0; i < laygia.Count - 2; i++)
                    {
                        for (int j = i + 1; j < laygia.Count - 1; j++)
                            if (laygia[i].GiaBan != laygia[j].GiaBan)
                                return 0;
                        return (int)laygia[0].GiaBan;
                    }
                }
                if (laygia.Count == 2)
                {
                    if (laygia[0].GiaBan != laygia[1].GiaBan)
                        return 0;
                    return (int)laygia[0].GiaBan;
                }
                if (laygia.Count == 1)
                    return (int)laygia[0].GiaBan;


            }
            return 0;

        }
        [WebMethod]
        public List<LaySize> ChonMau(int MaSP, int MaMau)
        {
            var chonmau = db.Khoes.Where(n => n.MaSP == MaSP && n.MaMau == MaMau).Select(n => new LaySize
            {
                _MaSize = n.Size.MaSize,
                _Size = (int)n.Size.Size1,
            }).Distinct().ToList();
            return chonmau;
        }
    }
}
