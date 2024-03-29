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

namespace Suplidores3.Data.Dbcontext
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LP2")]
	public partial class AppDbContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSuplidore(Suplidore instance);
    partial void UpdateSuplidore(Suplidore instance);
    #endregion
		
		public AppDbContextDataContext() : 
				base(global::Suplidores3.Properties.Settings.Default.LP2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AppDbContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AppDbContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AppDbContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AppDbContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Suplidore> Suplidores
		{
			get
			{
				return this.GetTable<Suplidore>();
			}
		}
		
		private void DeleteSuplidore(Suplidore obj)
		{
			this.SoftDelete(obj.RNC);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SoftDelete")]
		public int SoftDelete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(15)")] string rnc)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), rnc);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Suplidores")]
	public partial class Suplidore : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpresaId;
		
		private string _NombreEmpresa;
		
		private string _PersonaRepresentante;
		
		private string _RNC;
		
		private string _Direccion;
		
		private string _Telefono;
		
		private bool _ProveedorEstado;
		
		private string _RegistroProveedor;
		
		private System.Nullable<bool> _Estado;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpresaIdChanging(int value);
    partial void OnEmpresaIdChanged();
    partial void OnNombreEmpresaChanging(string value);
    partial void OnNombreEmpresaChanged();
    partial void OnPersonaRepresentanteChanging(string value);
    partial void OnPersonaRepresentanteChanged();
    partial void OnRNCChanging(string value);
    partial void OnRNCChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnProveedorEstadoChanging(bool value);
    partial void OnProveedorEstadoChanged();
    partial void OnRegistroProveedorChanging(string value);
    partial void OnRegistroProveedorChanged();
    partial void OnEstadoChanging(System.Nullable<bool> value);
    partial void OnEstadoChanged();
    #endregion
		
		public Suplidore()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpresaId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmpresaId
		{
			get
			{
				return this._EmpresaId;
			}
			set
			{
				if ((this._EmpresaId != value))
				{
					this.OnEmpresaIdChanging(value);
					this.SendPropertyChanging();
					this._EmpresaId = value;
					this.SendPropertyChanged("EmpresaId");
					this.OnEmpresaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreEmpresa", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string NombreEmpresa
		{
			get
			{
				return this._NombreEmpresa;
			}
			set
			{
				if ((this._NombreEmpresa != value))
				{
					this.OnNombreEmpresaChanging(value);
					this.SendPropertyChanging();
					this._NombreEmpresa = value;
					this.SendPropertyChanged("NombreEmpresa");
					this.OnNombreEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonaRepresentante", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string PersonaRepresentante
		{
			get
			{
				return this._PersonaRepresentante;
			}
			set
			{
				if ((this._PersonaRepresentante != value))
				{
					this.OnPersonaRepresentanteChanging(value);
					this.SendPropertyChanging();
					this._PersonaRepresentante = value;
					this.SendPropertyChanged("PersonaRepresentante");
					this.OnPersonaRepresentanteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RNC", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string RNC
		{
			get
			{
				return this._RNC;
			}
			set
			{
				if ((this._RNC != value))
				{
					this.OnRNCChanging(value);
					this.SendPropertyChanging();
					this._RNC = value;
					this.SendPropertyChanged("RNC");
					this.OnRNCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(15)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProveedorEstado", DbType="Bit NOT NULL")]
		public bool ProveedorEstado
		{
			get
			{
				return this._ProveedorEstado;
			}
			set
			{
				if ((this._ProveedorEstado != value))
				{
					this.OnProveedorEstadoChanging(value);
					this.SendPropertyChanging();
					this._ProveedorEstado = value;
					this.SendPropertyChanged("ProveedorEstado");
					this.OnProveedorEstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistroProveedor", DbType="VarChar(50)")]
		public string RegistroProveedor
		{
			get
			{
				return this._RegistroProveedor;
			}
			set
			{
				if ((this._RegistroProveedor != value))
				{
					this.OnRegistroProveedorChanging(value);
					this.SendPropertyChanging();
					this._RegistroProveedor = value;
					this.SendPropertyChanged("RegistroProveedor");
					this.OnRegistroProveedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="Bit")]
		public System.Nullable<bool> Estado
		{
			get
			{
				return this._Estado;
			}
			set
			{
				if ((this._Estado != value))
				{
					this.OnEstadoChanging(value);
					this.SendPropertyChanging();
					this._Estado = value;
					this.SendPropertyChanged("Estado");
					this.OnEstadoChanged();
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
