namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    public class HoaDonXuat
    {
        private int MaHDN;

        [DataMember]
        public int _MaHDN
        {
            get { return MaHDN; }
            set { MaHDN = value; }
        }
        private int MaKH;

        [DataMember]
        public int _MaKH
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        private int MaNV;

        public int _MaNV
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        private DateTime NgayLap;

        [DataMember]
        public DateTime _NgayLap
        {
            get { return NgayLap; }
            set { NgayLap = value; }
        }
        private int TinhTrang;

        [DataMember]
        public int _TinhTrang
        {
            get { return TinhTrang; }
            set { TinhTrang = value; }
        }
        private decimal TongTien;

        [DataMember]
        public decimal _TongTien
        {
            get { return TongTien; }
            set { TongTien = value; }
        }
        private string KhachHang;

        [DataMember]
        public string _KhachHang
        {
            get { return KhachHang; }
            set { KhachHang = value; }
        }
        private string NhanVien;

        [DataMember]
        public string _NhanVien
        {
            get { return NhanVien; }
            set { NhanVien = value; }
        }
    }
}