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

namespace LinQtesting
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="test")]
	public partial class LinQERDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertdbo_MemberDetail(dbo_MemberDetail instance);
    partial void Updatedbo_MemberDetail(dbo_MemberDetail instance);
    partial void Deletedbo_MemberDetail(dbo_MemberDetail instance);
    #endregion
		
		public LinQERDataContext() : 
				base(global::LinQtesting.Properties.Settings.Default.testConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinQERDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQERDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQERDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQERDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<dbo_MemberDetail> dbo_MemberDetails
		{
			get
			{
				return this.GetTable<dbo_MemberDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[dbo.MemberDetails]")]
	public partial class dbo_MemberDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NAME;
		
		private int _AGE;
		
		private System.Nullable<char> _GENDER;
		
		private string _CITY;
		
		private int _POSTALCODE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnAGEChanging(int value);
    partial void OnAGEChanged();
    partial void OnGENDERChanging(System.Nullable<char> value);
    partial void OnGENDERChanged();
    partial void OnCITYChanging(string value);
    partial void OnCITYChanged();
    partial void OnPOSTALCODEChanging(int value);
    partial void OnPOSTALCODEChanged();
    #endregion
		
		public dbo_MemberDetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AGE", DbType="Int NOT NULL")]
		public int AGE
		{
			get
			{
				return this._AGE;
			}
			set
			{
				if ((this._AGE != value))
				{
					this.OnAGEChanging(value);
					this.SendPropertyChanging();
					this._AGE = value;
					this.SendPropertyChanged("AGE");
					this.OnAGEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GENDER", DbType="Char(1)")]
		public System.Nullable<char> GENDER
		{
			get
			{
				return this._GENDER;
			}
			set
			{
				if ((this._GENDER != value))
				{
					this.OnGENDERChanging(value);
					this.SendPropertyChanging();
					this._GENDER = value;
					this.SendPropertyChanged("GENDER");
					this.OnGENDERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CITY", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CITY
		{
			get
			{
				return this._CITY;
			}
			set
			{
				if ((this._CITY != value))
				{
					this.OnCITYChanging(value);
					this.SendPropertyChanging();
					this._CITY = value;
					this.SendPropertyChanged("CITY");
					this.OnCITYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_POSTALCODE", DbType="Int NOT NULL")]
		public int POSTALCODE
		{
			get
			{
				return this._POSTALCODE;
			}
			set
			{
				if ((this._POSTALCODE != value))
				{
					this.OnPOSTALCODEChanging(value);
					this.SendPropertyChanging();
					this._POSTALCODE = value;
					this.SendPropertyChanged("POSTALCODE");
					this.OnPOSTALCODEChanged();
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
