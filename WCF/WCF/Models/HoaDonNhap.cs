namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    public partial class HoaDonNhap
    {
        private int MaHDN;

        [DataMember]
        public int _MaHDN
        {
            get { return MaHDN; }
            set { MaHDN = value; }
        }
        private int MaNCC;

        [DataMember]
        public int _MaNCC
        {
            get { return MaNCC; }
            set { MaNCC = value; }
        }
        private int MaNV;

        [DataMember]
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
        private string NCC;

        [DataMember]
        public string _NCC
        {
            get { return NCC; }
            set { NCC = value; }
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