﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminQuanLyShop.Service_HoaDonNhap {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HoaDonNhap", Namespace="http://schemas.datacontract.org/2004/07/Service_GiayDep.Models", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class HoaDonNhap : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _MaHDNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _MaNCCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _MaNVField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _NCCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime _NgayLapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _NhanVienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _TinhTrangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal _TongTienField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _MaHDN {
            get {
                return this._MaHDNField;
            }
            set {
                if ((this._MaHDNField.Equals(value) != true)) {
                    this._MaHDNField = value;
                    this.RaisePropertyChanged("_MaHDN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _MaNCC {
            get {
                return this._MaNCCField;
            }
            set {
                if ((this._MaNCCField.Equals(value) != true)) {
                    this._MaNCCField = value;
                    this.RaisePropertyChanged("_MaNCC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _MaNV {
            get {
                return this._MaNVField;
            }
            set {
                if ((this._MaNVField.Equals(value) != true)) {
                    this._MaNVField = value;
                    this.RaisePropertyChanged("_MaNV");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _NCC {
            get {
                return this._NCCField;
            }
            set {
                if ((object.ReferenceEquals(this._NCCField, value) != true)) {
                    this._NCCField = value;
                    this.RaisePropertyChanged("_NCC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime _NgayLap {
            get {
                return this._NgayLapField;
            }
            set {
                if ((this._NgayLapField.Equals(value) != true)) {
                    this._NgayLapField = value;
                    this.RaisePropertyChanged("_NgayLap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _NhanVien {
            get {
                return this._NhanVienField;
            }
            set {
                if ((object.ReferenceEquals(this._NhanVienField, value) != true)) {
                    this._NhanVienField = value;
                    this.RaisePropertyChanged("_NhanVien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _TinhTrang {
            get {
                return this._TinhTrangField;
            }
            set {
                if ((this._TinhTrangField.Equals(value) != true)) {
                    this._TinhTrangField = value;
                    this.RaisePropertyChanged("_TinhTrang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal _TongTien {
            get {
                return this._TongTienField;
            }
            set {
                if ((this._TongTienField.Equals(value) != true)) {
                    this._TongTienField = value;
                    this.RaisePropertyChanged("_TongTien");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service_HoaDonNhap.IService_HoaDonNhap")]
    public interface IService_HoaDonNhap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/LayTatCaHoaDon", ReplyAction="http://tempuri.org/IService_HoaDonNhap/LayTatCaHoaDonResponse")]
        AdminQuanLyShop.Service_HoaDonNhap.HoaDonNhap[] LayTatCaHoaDon();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/LayTatCaHoaDon", ReplyAction="http://tempuri.org/IService_HoaDonNhap/LayTatCaHoaDonResponse")]
        System.Threading.Tasks.Task<AdminQuanLyShop.Service_HoaDonNhap.HoaDonNhap[]> LayTatCaHoaDonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/TimHoaDon", ReplyAction="http://tempuri.org/IService_HoaDonNhap/TimHoaDonResponse")]
        AdminQuanLyShop.Service_HoaDonNhap.HoaDonNhap[] TimHoaDon(string x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/TimHoaDon", ReplyAction="http://tempuri.org/IService_HoaDonNhap/TimHoaDonResponse")]
        System.Threading.Tasks.Task<AdminQuanLyShop.Service_HoaDonNhap.HoaDonNhap[]> TimHoaDonAsync(string x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/ThemHDN", ReplyAction="http://tempuri.org/IService_HoaDonNhap/ThemHDNResponse")]
        bool ThemHDN(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/ThemHDN", ReplyAction="http://tempuri.org/IService_HoaDonNhap/ThemHDNResponse")]
        System.Threading.Tasks.Task<bool> ThemHDNAsync(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/SuaHDN", ReplyAction="http://tempuri.org/IService_HoaDonNhap/SuaHDNResponse")]
        bool SuaHDN(int MaHDN, int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/SuaHDN", ReplyAction="http://tempuri.org/IService_HoaDonNhap/SuaHDNResponse")]
        System.Threading.Tasks.Task<bool> SuaHDNAsync(int MaHDN, int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/XoaHDN", ReplyAction="http://tempuri.org/IService_HoaDonNhap/XoaHDNResponse")]
        bool XoaHDN(int MaHDN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/XoaHDN", ReplyAction="http://tempuri.org/IService_HoaDonNhap/XoaHDNResponse")]
        System.Threading.Tasks.Task<bool> XoaHDNAsync(int MaHDN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/LayMotHoaDon", ReplyAction="http://tempuri.org/IService_HoaDonNhap/LayMotHoaDonResponse")]
        int LayMotHoaDon();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/LayMotHoaDon", ReplyAction="http://tempuri.org/IService_HoaDonNhap/LayMotHoaDonResponse")]
        System.Threading.Tasks.Task<int> LayMotHoaDonAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/DuyetHD", ReplyAction="http://tempuri.org/IService_HoaDonNhap/DuyetHDResponse")]
        bool DuyetHD(int MaHDN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/DuyetHD", ReplyAction="http://tempuri.org/IService_HoaDonNhap/DuyetHDResponse")]
        System.Threading.Tasks.Task<bool> DuyetHDAsync(int MaHDN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/ThemHDNVaTraVeMaDHN", ReplyAction="http://tempuri.org/IService_HoaDonNhap/ThemHDNVaTraVeMaDHNResponse")]
        int ThemHDNVaTraVeMaDHN(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_HoaDonNhap/ThemHDNVaTraVeMaDHN", ReplyAction="http://tempuri.org/IService_HoaDonNhap/ThemHDNVaTraVeMaDHNResponse")]
        System.Threading.Tasks.Task<int> ThemHDNVaTraVeMaDHNAsync(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_HoaDonNhapChannel : AdminQuanLyShop.Service_HoaDonNhap.IService_HoaDonNhap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_HoaDonNhapClient : System.ServiceModel.ClientBase<AdminQuanLyShop.Service_HoaDonNhap.IService_HoaDonNhap>, AdminQuanLyShop.Service_HoaDonNhap.IService_HoaDonNhap {
        
        public Service_HoaDonNhapClient() {
        }
        
        public Service_HoaDonNhapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_HoaDonNhapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_HoaDonNhapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_HoaDonNhapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AdminQuanLyShop.Service_HoaDonNhap.HoaDonNhap[] LayTatCaHoaDon() {
            return base.Channel.LayTatCaHoaDon();
        }
        
        public System.Threading.Tasks.Task<AdminQuanLyShop.Service_HoaDonNhap.HoaDonNhap[]> LayTatCaHoaDonAsync() {
            return base.Channel.LayTatCaHoaDonAsync();
        }
        
        public AdminQuanLyShop.Service_HoaDonNhap.HoaDonNhap[] TimHoaDon(string x) {
            return base.Channel.TimHoaDon(x);
        }
        
        public System.Threading.Tasks.Task<AdminQuanLyShop.Service_HoaDonNhap.HoaDonNhap[]> TimHoaDonAsync(string x) {
            return base.Channel.TimHoaDonAsync(x);
        }
        
        public bool ThemHDN(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang) {
            return base.Channel.ThemHDN(MaNCC, MaNV, NgayLap, TongTien, TinhTrang);
        }
        
        public System.Threading.Tasks.Task<bool> ThemHDNAsync(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang) {
            return base.Channel.ThemHDNAsync(MaNCC, MaNV, NgayLap, TongTien, TinhTrang);
        }
        
        public bool SuaHDN(int MaHDN, int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang) {
            return base.Channel.SuaHDN(MaHDN, MaNCC, MaNV, NgayLap, TongTien, TinhTrang);
        }
        
        public System.Threading.Tasks.Task<bool> SuaHDNAsync(int MaHDN, int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang) {
            return base.Channel.SuaHDNAsync(MaHDN, MaNCC, MaNV, NgayLap, TongTien, TinhTrang);
        }
        
        public bool XoaHDN(int MaHDN) {
            return base.Channel.XoaHDN(MaHDN);
        }
        
        public System.Threading.Tasks.Task<bool> XoaHDNAsync(int MaHDN) {
            return base.Channel.XoaHDNAsync(MaHDN);
        }
        
        public int LayMotHoaDon() {
            return base.Channel.LayMotHoaDon();
        }
        
        public System.Threading.Tasks.Task<int> LayMotHoaDonAsync() {
            return base.Channel.LayMotHoaDonAsync();
        }
        
        public bool DuyetHD(int MaHDN) {
            return base.Channel.DuyetHD(MaHDN);
        }
        
        public System.Threading.Tasks.Task<bool> DuyetHDAsync(int MaHDN) {
            return base.Channel.DuyetHDAsync(MaHDN);
        }
        
        public int ThemHDNVaTraVeMaDHN(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang) {
            return base.Channel.ThemHDNVaTraVeMaDHN(MaNCC, MaNV, NgayLap, TongTien, TinhTrang);
        }
        
        public System.Threading.Tasks.Task<int> ThemHDNVaTraVeMaDHNAsync(int MaNCC, int MaNV, string NgayLap, decimal TongTien, int TinhTrang) {
            return base.Channel.ThemHDNVaTraVeMaDHNAsync(MaNCC, MaNV, NgayLap, TongTien, TinhTrang);
        }
    }
}
