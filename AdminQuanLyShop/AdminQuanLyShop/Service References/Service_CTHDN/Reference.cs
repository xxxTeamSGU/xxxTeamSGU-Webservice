﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminQuanLyShop.Service_CTHDN {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HoaDon", Namespace="http://schemas.datacontract.org/2004/07/Service_GiayDep.Models", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class HoaDon : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal _GiaSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _MaMauField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _MaSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _MaSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _MauField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _SizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _SoLuongField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _TenSPField;
        
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
        public decimal _GiaSP {
            get {
                return this._GiaSPField;
            }
            set {
                if ((this._GiaSPField.Equals(value) != true)) {
                    this._GiaSPField = value;
                    this.RaisePropertyChanged("_GiaSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _MaMau {
            get {
                return this._MaMauField;
            }
            set {
                if ((this._MaMauField.Equals(value) != true)) {
                    this._MaMauField = value;
                    this.RaisePropertyChanged("_MaMau");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _MaSP {
            get {
                return this._MaSPField;
            }
            set {
                if ((this._MaSPField.Equals(value) != true)) {
                    this._MaSPField = value;
                    this.RaisePropertyChanged("_MaSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _MaSize {
            get {
                return this._MaSizeField;
            }
            set {
                if ((this._MaSizeField.Equals(value) != true)) {
                    this._MaSizeField = value;
                    this.RaisePropertyChanged("_MaSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _Mau {
            get {
                return this._MauField;
            }
            set {
                if ((object.ReferenceEquals(this._MauField, value) != true)) {
                    this._MauField = value;
                    this.RaisePropertyChanged("_Mau");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _Size {
            get {
                return this._SizeField;
            }
            set {
                if ((this._SizeField.Equals(value) != true)) {
                    this._SizeField = value;
                    this.RaisePropertyChanged("_Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _SoLuong {
            get {
                return this._SoLuongField;
            }
            set {
                if ((this._SoLuongField.Equals(value) != true)) {
                    this._SoLuongField = value;
                    this.RaisePropertyChanged("_SoLuong");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _TenSP {
            get {
                return this._TenSPField;
            }
            set {
                if ((object.ReferenceEquals(this._TenSPField, value) != true)) {
                    this._TenSPField = value;
                    this.RaisePropertyChanged("_TenSP");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service_CTHDN.IService_CTHDN")]
    public interface IService_CTHDN {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_CTHDN/LayCTHDN", ReplyAction="http://tempuri.org/IService_CTHDN/LayCTHDNResponse")]
        AdminQuanLyShop.Service_CTHDN.HoaDon[] LayCTHDN(int MaHDN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_CTHDN/LayCTHDN", ReplyAction="http://tempuri.org/IService_CTHDN/LayCTHDNResponse")]
        System.Threading.Tasks.Task<AdminQuanLyShop.Service_CTHDN.HoaDon[]> LayCTHDNAsync(int MaHDN);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_CTHDN/ThemCTHDN", ReplyAction="http://tempuri.org/IService_CTHDN/ThemCTHDNResponse")]
        bool ThemCTHDN(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_CTHDN/ThemCTHDN", ReplyAction="http://tempuri.org/IService_CTHDN/ThemCTHDNResponse")]
        System.Threading.Tasks.Task<bool> ThemCTHDNAsync(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_CTHDN/SuaCTHDN", ReplyAction="http://tempuri.org/IService_CTHDN/SuaCTHDNResponse")]
        bool SuaCTHDN(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_CTHDN/SuaCTHDN", ReplyAction="http://tempuri.org/IService_CTHDN/SuaCTHDNResponse")]
        System.Threading.Tasks.Task<bool> SuaCTHDNAsync(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_CTHDN/XoaCTHDN", ReplyAction="http://tempuri.org/IService_CTHDN/XoaCTHDNResponse")]
        bool XoaCTHDN(int MaHDN, int MaSP, int MaMau, int MaSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_CTHDN/XoaCTHDN", ReplyAction="http://tempuri.org/IService_CTHDN/XoaCTHDNResponse")]
        System.Threading.Tasks.Task<bool> XoaCTHDNAsync(int MaHDN, int MaSP, int MaMau, int MaSize);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_CTHDNChannel : AdminQuanLyShop.Service_CTHDN.IService_CTHDN, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_CTHDNClient : System.ServiceModel.ClientBase<AdminQuanLyShop.Service_CTHDN.IService_CTHDN>, AdminQuanLyShop.Service_CTHDN.IService_CTHDN {
        
        public Service_CTHDNClient() {
        }
        
        public Service_CTHDNClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_CTHDNClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_CTHDNClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_CTHDNClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AdminQuanLyShop.Service_CTHDN.HoaDon[] LayCTHDN(int MaHDN) {
            return base.Channel.LayCTHDN(MaHDN);
        }
        
        public System.Threading.Tasks.Task<AdminQuanLyShop.Service_CTHDN.HoaDon[]> LayCTHDNAsync(int MaHDN) {
            return base.Channel.LayCTHDNAsync(MaHDN);
        }
        
        public bool ThemCTHDN(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia) {
            return base.Channel.ThemCTHDN(MaHDN, MaSP, MaMau, MauSize, SoLuong, DonGia);
        }
        
        public System.Threading.Tasks.Task<bool> ThemCTHDNAsync(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia) {
            return base.Channel.ThemCTHDNAsync(MaHDN, MaSP, MaMau, MauSize, SoLuong, DonGia);
        }
        
        public bool SuaCTHDN(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia) {
            return base.Channel.SuaCTHDN(MaHDN, MaSP, MaMau, MauSize, SoLuong, DonGia);
        }
        
        public System.Threading.Tasks.Task<bool> SuaCTHDNAsync(int MaHDN, int MaSP, int MaMau, int MauSize, int SoLuong, decimal DonGia) {
            return base.Channel.SuaCTHDNAsync(MaHDN, MaSP, MaMau, MauSize, SoLuong, DonGia);
        }
        
        public bool XoaCTHDN(int MaHDN, int MaSP, int MaMau, int MaSize) {
            return base.Channel.XoaCTHDN(MaHDN, MaSP, MaMau, MaSize);
        }
        
        public System.Threading.Tasks.Task<bool> XoaCTHDNAsync(int MaHDN, int MaSP, int MaMau, int MaSize) {
            return base.Channel.XoaCTHDNAsync(MaHDN, MaSP, MaMau, MaSize);
        }
    }
}