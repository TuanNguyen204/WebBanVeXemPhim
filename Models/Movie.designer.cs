﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiTapLonWeb.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VeXemPhim")]
	public partial class MovieDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertPHIM(PHIM instance);
    partial void UpdatePHIM(PHIM instance);
    partial void DeletePHIM(PHIM instance);
    partial void InsertPHONG(PHONG instance);
    partial void UpdatePHONG(PHONG instance);
    partial void DeletePHONG(PHONG instance);
    partial void InsertSUATCHIEU(SUATCHIEU instance);
    partial void UpdateSUATCHIEU(SUATCHIEU instance);
    partial void DeleteSUATCHIEU(SUATCHIEU instance);
    partial void InsertTHELOAI(THELOAI instance);
    partial void UpdateTHELOAI(THELOAI instance);
    partial void DeleteTHELOAI(THELOAI instance);
    partial void InsertVEXEMPHIM(VEXEMPHIM instance);
    partial void UpdateVEXEMPHIM(VEXEMPHIM instance);
    partial void DeleteVEXEMPHIM(VEXEMPHIM instance);
    #endregion
		
		public MovieDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["VeXemPhimConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MovieDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<PHIM> PHIMs
		{
			get
			{
				return this.GetTable<PHIM>();
			}
		}
		
		public System.Data.Linq.Table<PHONG> PHONGs
		{
			get
			{
				return this.GetTable<PHONG>();
			}
		}
		
		public System.Data.Linq.Table<SUATCHIEU> SUATCHIEUs
		{
			get
			{
				return this.GetTable<SUATCHIEU>();
			}
		}
		
		public System.Data.Linq.Table<THELOAI> THELOAIs
		{
			get
			{
				return this.GetTable<THELOAI>();
			}
		}
		
		public System.Data.Linq.Table<VEXEMPHIM> VEXEMPHIMs
		{
			get
			{
				return this.GetTable<VEXEMPHIM>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAKH;
		
		private string _TENKH;
		
		private string _SDT;
		
		private System.Nullable<System.DateTime> _NGAYSINH;
		
		private string _DIACHI;
		
		private string _TK;
		
		private string _MK;
		
		private EntitySet<VEXEMPHIM> _VEXEMPHIMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAKHChanging(int value);
    partial void OnMAKHChanged();
    partial void OnTENKHChanging(string value);
    partial void OnTENKHChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnNGAYSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYSINHChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnTKChanging(string value);
    partial void OnTKChanged();
    partial void OnMKChanging(string value);
    partial void OnMKChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._VEXEMPHIMs = new EntitySet<VEXEMPHIM>(new Action<VEXEMPHIM>(this.attach_VEXEMPHIMs), new Action<VEXEMPHIM>(this.detach_VEXEMPHIMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MAKH
		{
			get
			{
				return this._MAKH;
			}
			set
			{
				if ((this._MAKH != value))
				{
					this.OnMAKHChanging(value);
					this.SendPropertyChanging();
					this._MAKH = value;
					this.SendPropertyChanged("MAKH");
					this.OnMAKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKH", DbType="NVarChar(50)")]
		public string TENKH
		{
			get
			{
				return this._TENKH;
			}
			set
			{
				if ((this._TENKH != value))
				{
					this.OnTENKHChanging(value);
					this.SendPropertyChanging();
					this._TENKH = value;
					this.SendPropertyChanged("TENKH");
					this.OnTENKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(50)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TK", DbType="Char(20)")]
		public string TK
		{
			get
			{
				return this._TK;
			}
			set
			{
				if ((this._TK != value))
				{
					this.OnTKChanging(value);
					this.SendPropertyChanging();
					this._TK = value;
					this.SendPropertyChanged("TK");
					this.OnTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MK", DbType="Char(20)")]
		public string MK
		{
			get
			{
				return this._MK;
			}
			set
			{
				if ((this._MK != value))
				{
					this.OnMKChanging(value);
					this.SendPropertyChanging();
					this._MK = value;
					this.SendPropertyChanged("MK");
					this.OnMKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_VEXEMPHIM", Storage="_VEXEMPHIMs", ThisKey="MAKH", OtherKey="MAKH")]
		public EntitySet<VEXEMPHIM> VEXEMPHIMs
		{
			get
			{
				return this._VEXEMPHIMs;
			}
			set
			{
				this._VEXEMPHIMs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_VEXEMPHIMs(VEXEMPHIM entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_VEXEMPHIMs(VEXEMPHIM entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHIM")]
	public partial class PHIM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAPHIM;
		
		private string _TENPHIM;
		
		private string _MATL;
		
		private string _DAODIEN;
		
		private string _MOTA;
		
		private System.Nullable<float> _GIAVE;
		
		private string _HINHANH;
		
		private EntitySet<SUATCHIEU> _SUATCHIEUs;
		
		private EntityRef<THELOAI> _THELOAI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPHIMChanging(int value);
    partial void OnMAPHIMChanged();
    partial void OnTENPHIMChanging(string value);
    partial void OnTENPHIMChanged();
    partial void OnMATLChanging(string value);
    partial void OnMATLChanged();
    partial void OnDAODIENChanging(string value);
    partial void OnDAODIENChanged();
    partial void OnMOTAChanging(string value);
    partial void OnMOTAChanged();
    partial void OnGIAVEChanging(System.Nullable<float> value);
    partial void OnGIAVEChanged();
    partial void OnHINHANHChanging(string value);
    partial void OnHINHANHChanged();
    #endregion
		
		public PHIM()
		{
			this._SUATCHIEUs = new EntitySet<SUATCHIEU>(new Action<SUATCHIEU>(this.attach_SUATCHIEUs), new Action<SUATCHIEU>(this.detach_SUATCHIEUs));
			this._THELOAI = default(EntityRef<THELOAI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHIM", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MAPHIM
		{
			get
			{
				return this._MAPHIM;
			}
			set
			{
				if ((this._MAPHIM != value))
				{
					this.OnMAPHIMChanging(value);
					this.SendPropertyChanging();
					this._MAPHIM = value;
					this.SendPropertyChanged("MAPHIM");
					this.OnMAPHIMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENPHIM", DbType="NVarChar(50)")]
		public string TENPHIM
		{
			get
			{
				return this._TENPHIM;
			}
			set
			{
				if ((this._TENPHIM != value))
				{
					this.OnTENPHIMChanging(value);
					this.SendPropertyChanging();
					this._TENPHIM = value;
					this.SendPropertyChanged("TENPHIM");
					this.OnTENPHIMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATL", DbType="Char(5)")]
		public string MATL
		{
			get
			{
				return this._MATL;
			}
			set
			{
				if ((this._MATL != value))
				{
					//if (this._THELOAI.HasLoadedOrAssignedValue)
					//{
					//	throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					//}
					this.OnMATLChanging(value);
					this.SendPropertyChanging();
					this._MATL = value;
					this.SendPropertyChanged("MATL");
					this.OnMATLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DAODIEN", DbType="NVarChar(50)")]
		public string DAODIEN
		{
			get
			{
				return this._DAODIEN;
			}
			set
			{
				if ((this._DAODIEN != value))
				{
					this.OnDAODIENChanging(value);
					this.SendPropertyChanging();
					this._DAODIEN = value;
					this.SendPropertyChanged("DAODIEN");
					this.OnDAODIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOTA", DbType="NVarChar(MAX)")]
		public string MOTA
		{
			get
			{
				return this._MOTA;
			}
			set
			{
				if ((this._MOTA != value))
				{
					this.OnMOTAChanging(value);
					this.SendPropertyChanging();
					this._MOTA = value;
					this.SendPropertyChanged("MOTA");
					this.OnMOTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIAVE", DbType="Real")]
		public System.Nullable<float> GIAVE
		{
			get
			{
				return this._GIAVE;
			}
			set
			{
				if ((this._GIAVE != value))
				{
					this.OnGIAVEChanging(value);
					this.SendPropertyChanging();
					this._GIAVE = value;
					this.SendPropertyChanged("GIAVE");
					this.OnGIAVEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HINHANH", DbType="Char(10)")]
		public string HINHANH
		{
			get
			{
				return this._HINHANH;
			}
			set
			{
				if ((this._HINHANH != value))
				{
					this.OnHINHANHChanging(value);
					this.SendPropertyChanging();
					this._HINHANH = value;
					this.SendPropertyChanged("HINHANH");
					this.OnHINHANHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHIM_SUATCHIEU", Storage="_SUATCHIEUs", ThisKey="MAPHIM", OtherKey="MAPHIM")]
		public EntitySet<SUATCHIEU> SUATCHIEUs
		{
			get
			{
				return this._SUATCHIEUs;
			}
			set
			{
				this._SUATCHIEUs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="THELOAI_PHIM", Storage="_THELOAI", ThisKey="MATL", OtherKey="MATL", IsForeignKey=true)]
		public THELOAI THELOAI
		{
			get
			{
				return this._THELOAI.Entity;
			}
			set
			{
				THELOAI previousValue = this._THELOAI.Entity;
				if (((previousValue != value) 
							|| (this._THELOAI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._THELOAI.Entity = null;
						previousValue.PHIMs.Remove(this);
					}
					this._THELOAI.Entity = value;
					if ((value != null))
					{
						value.PHIMs.Add(this);
						this._MATL = value.MATL;
					}
					else
					{
						this._MATL = default(string);
					}
					this.SendPropertyChanged("THELOAI");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SUATCHIEUs(SUATCHIEU entity)
		{
			this.SendPropertyChanging();
			entity.PHIM = this;
		}
		
		private void detach_SUATCHIEUs(SUATCHIEU entity)
		{
			this.SendPropertyChanging();
			entity.PHIM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHONG")]
	public partial class PHONG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAPHONG;
		
		private string _TENPHONG;
		
		private string _LOAIPH;
		
		private System.Nullable<int> _SOGHE;
		
		private EntitySet<SUATCHIEU> _SUATCHIEUs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAPHONGChanging(int value);
    partial void OnMAPHONGChanged();
    partial void OnTENPHONGChanging(string value);
    partial void OnTENPHONGChanged();
    partial void OnLOAIPHChanging(string value);
    partial void OnLOAIPHChanged();
    partial void OnSOGHEChanging(System.Nullable<int> value);
    partial void OnSOGHEChanged();
    #endregion
		
		public PHONG()
		{
			this._SUATCHIEUs = new EntitySet<SUATCHIEU>(new Action<SUATCHIEU>(this.attach_SUATCHIEUs), new Action<SUATCHIEU>(this.detach_SUATCHIEUs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
					this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENPHONG", DbType="NVarChar(50)")]
		public string TENPHONG
		{
			get
			{
				return this._TENPHONG;
			}
			set
			{
				if ((this._TENPHONG != value))
				{
					this.OnTENPHONGChanging(value);
					this.SendPropertyChanging();
					this._TENPHONG = value;
					this.SendPropertyChanged("TENPHONG");
					this.OnTENPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOAIPH", DbType="Char(2)")]
		public string LOAIPH
		{
			get
			{
				return this._LOAIPH;
			}
			set
			{
				if ((this._LOAIPH != value))
				{
					this.OnLOAIPHChanging(value);
					this.SendPropertyChanging();
					this._LOAIPH = value;
					this.SendPropertyChanged("LOAIPH");
					this.OnLOAIPHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOGHE", DbType="Int")]
		public System.Nullable<int> SOGHE
		{
			get
			{
				return this._SOGHE;
			}
			set
			{
				if ((this._SOGHE != value))
				{
					this.OnSOGHEChanging(value);
					this.SendPropertyChanging();
					this._SOGHE = value;
					this.SendPropertyChanged("SOGHE");
					this.OnSOGHEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHONG_SUATCHIEU", Storage="_SUATCHIEUs", ThisKey="MAPHONG", OtherKey="MAPHONG")]
		public EntitySet<SUATCHIEU> SUATCHIEUs
		{
			get
			{
				return this._SUATCHIEUs;
			}
			set
			{
				this._SUATCHIEUs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_SUATCHIEUs(SUATCHIEU entity)
		{
			this.SendPropertyChanging();
			entity.PHONG = this;
		}
		
		private void detach_SUATCHIEUs(SUATCHIEU entity)
		{
			this.SendPropertyChanging();
			entity.PHONG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SUATCHIEU")]
	public partial class SUATCHIEU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MASUAT;
		
		private System.Nullable<System.DateTime> _NGAYCHIEU;
		
		private System.Nullable<int> _MAPHONG;
		
		private System.Nullable<int> _MAPHIM;
		
		private EntitySet<VEXEMPHIM> _VEXEMPHIMs;
		
		private EntityRef<PHONG> _PHONG;
		
		private EntityRef<PHIM> _PHIM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMASUATChanging(int value);
    partial void OnMASUATChanged();
    partial void OnNGAYCHIEUChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYCHIEUChanged();
    partial void OnMAPHONGChanging(System.Nullable<int> value);
    partial void OnMAPHONGChanged();
    partial void OnMAPHIMChanging(System.Nullable<int> value);
    partial void OnMAPHIMChanged();
    #endregion
		
		public SUATCHIEU()
		{
			this._VEXEMPHIMs = new EntitySet<VEXEMPHIM>(new Action<VEXEMPHIM>(this.attach_VEXEMPHIMs), new Action<VEXEMPHIM>(this.detach_VEXEMPHIMs));
			this._PHONG = default(EntityRef<PHONG>);
			this._PHIM = default(EntityRef<PHIM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASUAT", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MASUAT
		{
			get
			{
				return this._MASUAT;
			}
			set
			{
				if ((this._MASUAT != value))
				{
					this.OnMASUATChanging(value);
					this.SendPropertyChanging();
					this._MASUAT = value;
					this.SendPropertyChanged("MASUAT");
					this.OnMASUATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYCHIEU", DbType="DateTime")]
		public System.Nullable<System.DateTime> NGAYCHIEU
		{
			get
			{
				return this._NGAYCHIEU;
			}
			set
			{
				if ((this._NGAYCHIEU != value))
				{
					this.OnNGAYCHIEUChanging(value);
					this.SendPropertyChanging();
					this._NGAYCHIEU = value;
					this.SendPropertyChanged("NGAYCHIEU");
					this.OnNGAYCHIEUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHONG", DbType="Int")]
		public System.Nullable<int> MAPHONG
		{
			get
			{
				return this._MAPHONG;
			}
			set
			{
				if ((this._MAPHONG != value))
				{
                    //if (this._PHONG.HasLoadedOrAssignedValue)
                    //{
                    //    throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    //}
                    this.OnMAPHONGChanging(value);
					this.SendPropertyChanging();
					this._MAPHONG = value;
					this.SendPropertyChanged("MAPHONG");
					this.OnMAPHONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAPHIM", DbType="Int")]
		public System.Nullable<int> MAPHIM
		{
			get
			{
				return this._MAPHIM;
			}
			set
			{
				if ((this._MAPHIM != value))
				{
					//if (this._PHIM.HasLoadedOrAssignedValue)
					//{
					//	throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					//}
					this.OnMAPHIMChanging(value);
					this.SendPropertyChanging();
					this._MAPHIM = value;
					this.SendPropertyChanged("MAPHIM");
					this.OnMAPHIMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SUATCHIEU_VEXEMPHIM", Storage="_VEXEMPHIMs", ThisKey="MASUAT", OtherKey="MASUAT")]
		public EntitySet<VEXEMPHIM> VEXEMPHIMs
		{
			get
			{
				return this._VEXEMPHIMs;
			}
			set
			{
				this._VEXEMPHIMs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHONG_SUATCHIEU", Storage="_PHONG", ThisKey="MAPHONG", OtherKey="MAPHONG", IsForeignKey=true)]
		public PHONG PHONG
		{
			get
			{
				return this._PHONG.Entity;
			}
			set
			{
				PHONG previousValue = this._PHONG.Entity;
				if (((previousValue != value) 
							|| (this._PHONG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PHONG.Entity = null;
						previousValue.SUATCHIEUs.Remove(this);
					}
					this._PHONG.Entity = value;
					if ((value != null))
					{
						value.SUATCHIEUs.Add(this);
						this._MAPHONG = value.MAPHONG;
					}
					else
					{
						this._MAPHONG = default(Nullable<int>);
					}
					this.SendPropertyChanged("PHONG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHIM_SUATCHIEU", Storage="_PHIM", ThisKey="MAPHIM", OtherKey="MAPHIM", IsForeignKey=true)]
		public PHIM PHIM
		{
			get
			{
				return this._PHIM.Entity;
			}
			set
			{
				PHIM previousValue = this._PHIM.Entity;
				if (((previousValue != value) 
							|| (this._PHIM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PHIM.Entity = null;
						previousValue.SUATCHIEUs.Remove(this);
					}
					this._PHIM.Entity = value;
					if ((value != null))
					{
						value.SUATCHIEUs.Add(this);
						this._MAPHIM = value.MAPHIM;
					}
					else
					{
						this._MAPHIM = default(Nullable<int>);
					}
					this.SendPropertyChanged("PHIM");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_VEXEMPHIMs(VEXEMPHIM entity)
		{
			this.SendPropertyChanging();
			entity.SUATCHIEU = this;
		}
		
		private void detach_VEXEMPHIMs(VEXEMPHIM entity)
		{
			this.SendPropertyChanging();
			entity.SUATCHIEU = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.THELOAI")]
	public partial class THELOAI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MATL;
		
		private string _TENTL;
		
		private EntitySet<PHIM> _PHIMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMATLChanging(string value);
    partial void OnMATLChanged();
    partial void OnTENTLChanging(string value);
    partial void OnTENTLChanged();
    #endregion
		
		public THELOAI()
		{
			this._PHIMs = new EntitySet<PHIM>(new Action<PHIM>(this.attach_PHIMs), new Action<PHIM>(this.detach_PHIMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATL", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MATL
		{
			get
			{
				return this._MATL;
			}
			set
			{
				if ((this._MATL != value))
				{
					this.OnMATLChanging(value);
					this.SendPropertyChanging();
					this._MATL = value;
					this.SendPropertyChanged("MATL");
					this.OnMATLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENTL", DbType="NVarChar(30)")]
		public string TENTL
		{
			get
			{
				return this._TENTL;
			}
			set
			{
				if ((this._TENTL != value))
				{
					this.OnTENTLChanging(value);
					this.SendPropertyChanging();
					this._TENTL = value;
					this.SendPropertyChanged("TENTL");
					this.OnTENTLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="THELOAI_PHIM", Storage="_PHIMs", ThisKey="MATL", OtherKey="MATL")]
		public EntitySet<PHIM> PHIMs
		{
			get
			{
				return this._PHIMs;
			}
			set
			{
				this._PHIMs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PHIMs(PHIM entity)
		{
			this.SendPropertyChanging();
			entity.THELOAI = this;
		}
		
		private void detach_PHIMs(PHIM entity)
		{
			this.SendPropertyChanging();
			entity.THELOAI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VEXEMPHIM")]
	public partial class VEXEMPHIM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAVE;
		
		private System.Nullable<int> _MAKH;
		
		private System.Nullable<int> _MASUAT;
		
		private System.Nullable<System.DateTime> _NGAYBAN;
		
		private string _TRANGTHAI;
		
		private System.Nullable<float> _TONGTIEN;
		
		private System.Nullable<int> _SOLUONG;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
		private EntityRef<SUATCHIEU> _SUATCHIEU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAVEChanging(int value);
    partial void OnMAVEChanged();
    partial void OnMAKHChanging(System.Nullable<int> value);
    partial void OnMAKHChanged();
    partial void OnMASUATChanging(System.Nullable<int> value);
    partial void OnMASUATChanged();
    partial void OnNGAYBANChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYBANChanged();
    partial void OnTRANGTHAIChanging(string value);
    partial void OnTRANGTHAIChanged();
    partial void OnTONGTIENChanging(System.Nullable<float> value);
    partial void OnTONGTIENChanged();
    partial void OnSOLUONGChanging(System.Nullable<int> value);
    partial void OnSOLUONGChanged();
    #endregion
		
		public VEXEMPHIM()
		{
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			this._SUATCHIEU = default(EntityRef<SUATCHIEU>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAVE", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MAVE
		{
			get
			{
				return this._MAVE;
			}
			set
			{
				if ((this._MAVE != value))
				{
					this.OnMAVEChanging(value);
					this.SendPropertyChanging();
					this._MAVE = value;
					this.SendPropertyChanged("MAVE");
					this.OnMAVEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKH", DbType="Int")]
		public System.Nullable<int> MAKH
		{
			get
			{
				return this._MAKH;
			}
			set
			{
				if ((this._MAKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAKHChanging(value);
					this.SendPropertyChanging();
					this._MAKH = value;
					this.SendPropertyChanged("MAKH");
					this.OnMAKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASUAT", DbType="Int")]
		public System.Nullable<int> MASUAT
		{
			get
			{
				return this._MASUAT;
			}
			set
			{
				if ((this._MASUAT != value))
				{
					if (this._SUATCHIEU.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMASUATChanging(value);
					this.SendPropertyChanging();
					this._MASUAT = value;
					this.SendPropertyChanged("MASUAT");
					this.OnMASUATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYBAN", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYBAN
		{
			get
			{
				return this._NGAYBAN;
			}
			set
			{
				if ((this._NGAYBAN != value))
				{
					this.OnNGAYBANChanging(value);
					this.SendPropertyChanging();
					this._NGAYBAN = value;
					this.SendPropertyChanged("NGAYBAN");
					this.OnNGAYBANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANGTHAI", DbType="NChar(10)")]
		public string TRANGTHAI
		{
			get
			{
				return this._TRANGTHAI;
			}
			set
			{
				if ((this._TRANGTHAI != value))
				{
					this.OnTRANGTHAIChanging(value);
					this.SendPropertyChanging();
					this._TRANGTHAI = value;
					this.SendPropertyChanged("TRANGTHAI");
					this.OnTRANGTHAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TONGTIEN", DbType="Real")]
		public System.Nullable<float> TONGTIEN
		{
			get
			{
				return this._TONGTIEN;
			}
			set
			{
				if ((this._TONGTIEN != value))
				{
					this.OnTONGTIENChanging(value);
					this.SendPropertyChanging();
					this._TONGTIEN = value;
					this.SendPropertyChanged("TONGTIEN");
					this.OnTONGTIENChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONG", DbType="Int")]
		public System.Nullable<int> SOLUONG
		{
			get
			{
				return this._SOLUONG;
			}
			set
			{
				if ((this._SOLUONG != value))
				{
					this.OnSOLUONGChanging(value);
					this.SendPropertyChanging();
					this._SOLUONG = value;
					this.SendPropertyChanged("SOLUONG");
					this.OnSOLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_VEXEMPHIM", Storage="_KHACHHANG", ThisKey="MAKH", OtherKey="MAKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.VEXEMPHIMs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.VEXEMPHIMs.Add(this);
						this._MAKH = value.MAKH;
					}
					else
					{
						this._MAKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHACHHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SUATCHIEU_VEXEMPHIM", Storage="_SUATCHIEU", ThisKey="MASUAT", OtherKey="MASUAT", IsForeignKey=true)]
		public SUATCHIEU SUATCHIEU
		{
			get
			{
				return this._SUATCHIEU.Entity;
			}
			set
			{
				SUATCHIEU previousValue = this._SUATCHIEU.Entity;
				if (((previousValue != value) 
							|| (this._SUATCHIEU.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SUATCHIEU.Entity = null;
						previousValue.VEXEMPHIMs.Remove(this);
					}
					this._SUATCHIEU.Entity = value;
					if ((value != null))
					{
						value.VEXEMPHIMs.Add(this);
						this._MASUAT = value.MASUAT;
					}
					else
					{
						this._MASUAT = default(Nullable<int>);
					}
					this.SendPropertyChanged("SUATCHIEU");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591