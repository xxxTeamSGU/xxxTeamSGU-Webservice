namespace Service_GiayDep.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    public class Kho_SP
    {
        private int MaSP;

        [DataMember]
        public int _MaSP
        {
            get { return MaSP; }
            set { MaSP = value; }
        }
        private string TenSP;

        [DataMember]
        public string _TenSP
        {
            get { return TenSP; }
            set { TenSP = value; }
        }
        private int MaMau;

        [DataMember]
        public int _MaMau
        {
            get { return MaMau; }
            set { MaMau = value; }
        }
        private string Mau;

        [DataMember]
        public string _Mau
        {
            get { return Mau; }
            set { Mau = value; }
        }
        private int MaSize;

        [DataMember]
        public int _MaSize
        {
            get { return MaSize; }
            set { MaSize = value; }
        }
        private int Size;

        [DataMember]
        public int _Size
        {
            get { return Size; }
            set { Size = value; }
        }
        private int SoLuong;

        [DataMember]
        public int _SoLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }
        private decimal GiaBan;

        [DataMember]
        public decimal _GiaBan
        {
            get { return GiaBan; }
            set { GiaBan = value; }
        }
        private decimal GiaNhap;

        [DataMember]
        public decimal _GiaNhap
        {
            get { return GiaNhap; }
            set { GiaNhap = value; }
        }

      
    }
}