namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]



    public partial class SanPham_Price
    {
        [DataMember]
        private int MaSP;

        [DataMember]
        public int _MaSP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }

        [DataMember]
        private int MaMau;

        [DataMember]
        public int _MaMau
        {
            get { return MaMau; }
            set { MaMau = value; }
        }



        
        private string TenSP;

        [DataMember]
        public string _TenSP
        {
            get { return TenSP; }
            set { TenSP = value; }
        }
        
        private int Size;

        [DataMember]
        public int _Size
        {
            get { return Size; }
            set { Size = value; }
        }

        private int SL;

        [DataMember]
        public int _SL
        {
            get { return SL; }
            set { SL = value; }
        }
        
        private string TenMau;

        [DataMember]
        public string _TenMau
        {
            get { return TenMau; }
            set { TenMau = value; }
        }
       
        private decimal GiaSP;

        [DataMember]
        public decimal _GiaSP
        {
            get { return GiaSP; }
            set { GiaSP = value; }
        }

       
        private string HinhAnh;
        [DataMember]
        public string _HinhAnh
        {
            get { return HinhAnh; }
            set { HinhAnh = value; }
        }
       
        private decimal GiaBan;
        [DataMember]
        public decimal _GiaBan
        {
            get { return GiaBan; }
            set { GiaBan = value; }
        } 

       
        private DateTime NgayDang;
        [DataMember]
        public DateTime _NgayDang
        {
            get { return NgayDang; }
            set { NgayDang = value; }
        }
    }

}