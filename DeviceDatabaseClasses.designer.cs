﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.32559
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeviceManagerService
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DeviceDatabase")]
	public partial class DeviceDatabaseClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNode(Node instance);
    partial void UpdateNode(Node instance);
    partial void DeleteNode(Node instance);
    partial void InsertFolder(Folder instance);
    partial void UpdateFolder(Folder instance);
    partial void DeleteFolder(Folder instance);
    partial void InsertConnectionType(ConnectionType instance);
    partial void UpdateConnectionType(ConnectionType instance);
    partial void DeleteConnectionType(ConnectionType instance);
    partial void InsertDevice(Device instance);
    partial void UpdateDevice(Device instance);
    partial void DeleteDevice(Device instance);
    partial void InsertDeviceType(DeviceType instance);
    partial void UpdateDeviceType(DeviceType instance);
    partial void DeleteDeviceType(DeviceType instance);
    partial void InsertDocument(Document instance);
    partial void UpdateDocument(Document instance);
    partial void DeleteDocument(Document instance);
    partial void InsertConnection(Connection instance);
    partial void UpdateConnection(Connection instance);
    partial void DeleteConnection(Connection instance);
    #endregion
		
		public DeviceDatabaseClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DeviceDatabaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DeviceDatabaseClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DeviceDatabaseClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DeviceDatabaseClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DeviceDatabaseClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Node> Nodes
		{
			get
			{
				return this.GetTable<Node>();
			}
		}
		
		public System.Data.Linq.Table<Folder> Folders
		{
			get
			{
				return this.GetTable<Folder>();
			}
		}
		
		public System.Data.Linq.Table<ConnectionType> ConnectionTypes
		{
			get
			{
				return this.GetTable<ConnectionType>();
			}
		}
		
		public System.Data.Linq.Table<Device> Devices
		{
			get
			{
				return this.GetTable<Device>();
			}
		}
		
		public System.Data.Linq.Table<DeviceType> DeviceTypes
		{
			get
			{
				return this.GetTable<DeviceType>();
			}
		}
		
		public System.Data.Linq.Table<Document> Documents
		{
			get
			{
				return this.GetTable<Document>();
			}
		}
		
		public System.Data.Linq.Table<Connection> Connections
		{
			get
			{
				return this.GetTable<Connection>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Node")]
	public partial class Node : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.Nullable<int> _ParentID;
		
		private System.Nullable<int> _DeviceID;
		
		private System.Nullable<int> _FolderID;
		
		private EntitySet<Node> _Nodes;
		
		private EntitySet<Document> _Documents;
		
		private EntityRef<Node> _Node1;
		
		private EntityRef<Folder> _Folder;
		
		private EntityRef<Device> _Device;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnParentIDChanging(System.Nullable<int> value);
    partial void OnParentIDChanged();
    partial void OnDeviceIDChanging(System.Nullable<int> value);
    partial void OnDeviceIDChanged();
    partial void OnFolderIDChanging(System.Nullable<int> value);
    partial void OnFolderIDChanged();
    #endregion
		
		public Node()
		{
			this._Nodes = new EntitySet<Node>(new Action<Node>(this.attach_Nodes), new Action<Node>(this.detach_Nodes));
			this._Documents = new EntitySet<Document>(new Action<Document>(this.attach_Documents), new Action<Document>(this.detach_Documents));
			this._Node1 = default(EntityRef<Node>);
			this._Folder = default(EntityRef<Folder>);
			this._Device = default(EntityRef<Device>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentID", DbType="Int")]
		public System.Nullable<int> ParentID
		{
			get
			{
				return this._ParentID;
			}
			set
			{
				if ((this._ParentID != value))
				{
					if (this._Node1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnParentIDChanging(value);
					this.SendPropertyChanging();
					this._ParentID = value;
					this.SendPropertyChanged("ParentID");
					this.OnParentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeviceID", DbType="Int")]
		public System.Nullable<int> DeviceID
		{
			get
			{
				return this._DeviceID;
			}
			set
			{
				if ((this._DeviceID != value))
				{
					if (this._Device.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDeviceIDChanging(value);
					this.SendPropertyChanging();
					this._DeviceID = value;
					this.SendPropertyChanged("DeviceID");
					this.OnDeviceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FolderID", DbType="Int")]
		public System.Nullable<int> FolderID
		{
			get
			{
				return this._FolderID;
			}
			set
			{
				if ((this._FolderID != value))
				{
					if (this._Folder.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFolderIDChanging(value);
					this.SendPropertyChanging();
					this._FolderID = value;
					this.SendPropertyChanged("FolderID");
					this.OnFolderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Node_Node", Storage="_Nodes", ThisKey="ID", OtherKey="ParentID")]
		public EntitySet<Node> Nodes
		{
			get
			{
				return this._Nodes;
			}
			set
			{
				this._Nodes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Node_Document", Storage="_Documents", ThisKey="ID", OtherKey="NodeID")]
		public EntitySet<Document> Documents
		{
			get
			{
				return this._Documents;
			}
			set
			{
				this._Documents.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Node_Node", Storage="_Node1", ThisKey="ParentID", OtherKey="ID", IsForeignKey=true)]
		public Node Node1
		{
			get
			{
				return this._Node1.Entity;
			}
			set
			{
				Node previousValue = this._Node1.Entity;
				if (((previousValue != value) 
							|| (this._Node1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Node1.Entity = null;
						previousValue.Nodes.Remove(this);
					}
					this._Node1.Entity = value;
					if ((value != null))
					{
						value.Nodes.Add(this);
						this._ParentID = value.ID;
					}
					else
					{
						this._ParentID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Node1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Folder_Node", Storage="_Folder", ThisKey="FolderID", OtherKey="ID", IsForeignKey=true)]
		public Folder Folder
		{
			get
			{
				return this._Folder.Entity;
			}
			set
			{
				Folder previousValue = this._Folder.Entity;
				if (((previousValue != value) 
							|| (this._Folder.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Folder.Entity = null;
						previousValue.Nodes.Remove(this);
					}
					this._Folder.Entity = value;
					if ((value != null))
					{
						value.Nodes.Add(this);
						this._FolderID = value.ID;
					}
					else
					{
						this._FolderID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Folder");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Device_Node", Storage="_Device", ThisKey="DeviceID", OtherKey="ID", IsForeignKey=true)]
		public Device Device
		{
			get
			{
				return this._Device.Entity;
			}
			set
			{
				Device previousValue = this._Device.Entity;
				if (((previousValue != value) 
							|| (this._Device.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Device.Entity = null;
						previousValue.Nodes.Remove(this);
					}
					this._Device.Entity = value;
					if ((value != null))
					{
						value.Nodes.Add(this);
						this._DeviceID = value.ID;
					}
					else
					{
						this._DeviceID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Device");
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
		
		private void attach_Nodes(Node entity)
		{
			this.SendPropertyChanging();
			entity.Node1 = this;
		}
		
		private void detach_Nodes(Node entity)
		{
			this.SendPropertyChanging();
			entity.Node1 = null;
		}
		
		private void attach_Documents(Document entity)
		{
			this.SendPropertyChanging();
			entity.Node = this;
		}
		
		private void detach_Documents(Document entity)
		{
			this.SendPropertyChanging();
			entity.Node = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Folder")]
	public partial class Folder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private EntitySet<Node> _Nodes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Folder()
		{
			this._Nodes = new EntitySet<Node>(new Action<Node>(this.attach_Nodes), new Action<Node>(this.detach_Nodes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Folder_Node", Storage="_Nodes", ThisKey="ID", OtherKey="FolderID")]
		public EntitySet<Node> Nodes
		{
			get
			{
				return this._Nodes;
			}
			set
			{
				this._Nodes.Assign(value);
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
		
		private void attach_Nodes(Node entity)
		{
			this.SendPropertyChanging();
			entity.Folder = this;
		}
		
		private void detach_Nodes(Node entity)
		{
			this.SendPropertyChanging();
			entity.Folder = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ConnectionType")]
	public partial class ConnectionType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private EntitySet<Connection> _Connections;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public ConnectionType()
		{
			this._Connections = new EntitySet<Connection>(new Action<Connection>(this.attach_Connections), new Action<Connection>(this.detach_Connections));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ConnectionType_Connection", Storage="_Connections", ThisKey="ID", OtherKey="ConnectionTypeID")]
		public EntitySet<Connection> Connections
		{
			get
			{
				return this._Connections;
			}
			set
			{
				this._Connections.Assign(value);
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
		
		private void attach_Connections(Connection entity)
		{
			this.SendPropertyChanging();
			entity.ConnectionType = this;
		}
		
		private void detach_Connections(Connection entity)
		{
			this.SendPropertyChanging();
			entity.ConnectionType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Device")]
	public partial class Device : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private int _DeviceTypeID;
		
		private System.Nullable<int> _ConnectionID;
		
		private EntitySet<Node> _Nodes;
		
		private EntityRef<DeviceType> _DeviceType;
		
		private EntityRef<Connection> _Connection;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDeviceTypeIDChanging(int value);
    partial void OnDeviceTypeIDChanged();
    partial void OnConnectionIDChanging(System.Nullable<int> value);
    partial void OnConnectionIDChanged();
    #endregion
		
		public Device()
		{
			this._Nodes = new EntitySet<Node>(new Action<Node>(this.attach_Nodes), new Action<Node>(this.detach_Nodes));
			this._DeviceType = default(EntityRef<DeviceType>);
			this._Connection = default(EntityRef<Connection>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeviceTypeID", DbType="Int NOT NULL")]
		public int DeviceTypeID
		{
			get
			{
				return this._DeviceTypeID;
			}
			set
			{
				if ((this._DeviceTypeID != value))
				{
					if (this._DeviceType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDeviceTypeIDChanging(value);
					this.SendPropertyChanging();
					this._DeviceTypeID = value;
					this.SendPropertyChanged("DeviceTypeID");
					this.OnDeviceTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConnectionID", DbType="Int")]
		public System.Nullable<int> ConnectionID
		{
			get
			{
				return this._ConnectionID;
			}
			set
			{
				if ((this._ConnectionID != value))
				{
					if (this._Connection.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnConnectionIDChanging(value);
					this.SendPropertyChanging();
					this._ConnectionID = value;
					this.SendPropertyChanged("ConnectionID");
					this.OnConnectionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Device_Node", Storage="_Nodes", ThisKey="ID", OtherKey="DeviceID")]
		public EntitySet<Node> Nodes
		{
			get
			{
				return this._Nodes;
			}
			set
			{
				this._Nodes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DeviceType_Device", Storage="_DeviceType", ThisKey="DeviceTypeID", OtherKey="ID", IsForeignKey=true)]
		public DeviceType DeviceType
		{
			get
			{
				return this._DeviceType.Entity;
			}
			set
			{
				DeviceType previousValue = this._DeviceType.Entity;
				if (((previousValue != value) 
							|| (this._DeviceType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DeviceType.Entity = null;
						previousValue.Devices.Remove(this);
					}
					this._DeviceType.Entity = value;
					if ((value != null))
					{
						value.Devices.Add(this);
						this._DeviceTypeID = value.ID;
					}
					else
					{
						this._DeviceTypeID = default(int);
					}
					this.SendPropertyChanged("DeviceType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Connection_Device", Storage="_Connection", ThisKey="ConnectionID", OtherKey="ID", IsForeignKey=true)]
		public Connection Connection
		{
			get
			{
				return this._Connection.Entity;
			}
			set
			{
				Connection previousValue = this._Connection.Entity;
				if (((previousValue != value) 
							|| (this._Connection.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Connection.Entity = null;
						previousValue.Devices.Remove(this);
					}
					this._Connection.Entity = value;
					if ((value != null))
					{
						value.Devices.Add(this);
						this._ConnectionID = value.ID;
					}
					else
					{
						this._ConnectionID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Connection");
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
		
		private void attach_Nodes(Node entity)
		{
			this.SendPropertyChanging();
			entity.Device = this;
		}
		
		private void detach_Nodes(Node entity)
		{
			this.SendPropertyChanging();
			entity.Device = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DeviceType")]
	public partial class DeviceType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private bool _CanHaveChildren;
		
		private EntitySet<Device> _Devices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCanHaveChildrenChanging(bool value);
    partial void OnCanHaveChildrenChanged();
    #endregion
		
		public DeviceType()
		{
			this._Devices = new EntitySet<Device>(new Action<Device>(this.attach_Devices), new Action<Device>(this.detach_Devices));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanHaveChildren", DbType="Bit NOT NULL")]
		public bool CanHaveChildren
		{
			get
			{
				return this._CanHaveChildren;
			}
			set
			{
				if ((this._CanHaveChildren != value))
				{
					this.OnCanHaveChildrenChanging(value);
					this.SendPropertyChanging();
					this._CanHaveChildren = value;
					this.SendPropertyChanged("CanHaveChildren");
					this.OnCanHaveChildrenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DeviceType_Device", Storage="_Devices", ThisKey="ID", OtherKey="DeviceTypeID")]
		public EntitySet<Device> Devices
		{
			get
			{
				return this._Devices;
			}
			set
			{
				this._Devices.Assign(value);
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
		
		private void attach_Devices(Device entity)
		{
			this.SendPropertyChanging();
			entity.DeviceType = this;
		}
		
		private void detach_Devices(Device entity)
		{
			this.SendPropertyChanging();
			entity.DeviceType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Document")]
	public partial class Document : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.Data.Linq.Binary _Data;
		
		private int _NodeID;
		
		private EntityRef<Node> _Node;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDataChanging(System.Data.Linq.Binary value);
    partial void OnDataChanged();
    partial void OnNodeIDChanging(int value);
    partial void OnNodeIDChanged();
    #endregion
		
		public Document()
		{
			this._Node = default(EntityRef<Node>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NodeID", DbType="Int NOT NULL")]
		public int NodeID
		{
			get
			{
				return this._NodeID;
			}
			set
			{
				if ((this._NodeID != value))
				{
					if (this._Node.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNodeIDChanging(value);
					this.SendPropertyChanging();
					this._NodeID = value;
					this.SendPropertyChanged("NodeID");
					this.OnNodeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Node_Document", Storage="_Node", ThisKey="NodeID", OtherKey="ID", IsForeignKey=true)]
		public Node Node
		{
			get
			{
				return this._Node.Entity;
			}
			set
			{
				Node previousValue = this._Node.Entity;
				if (((previousValue != value) 
							|| (this._Node.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Node.Entity = null;
						previousValue.Documents.Remove(this);
					}
					this._Node.Entity = value;
					if ((value != null))
					{
						value.Documents.Add(this);
						this._NodeID = value.ID;
					}
					else
					{
						this._NodeID = default(int);
					}
					this.SendPropertyChanged("Node");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Connection")]
	public partial class Connection : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _ConnectionTypeID;
		
		private EntitySet<Device> _Devices;
		
		private EntityRef<ConnectionType> _ConnectionType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnConnectionTypeIDChanging(int value);
    partial void OnConnectionTypeIDChanged();
    #endregion
		
		public Connection()
		{
			this._Devices = new EntitySet<Device>(new Action<Device>(this.attach_Devices), new Action<Device>(this.detach_Devices));
			this._ConnectionType = default(EntityRef<ConnectionType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConnectionTypeID", DbType="Int NOT NULL")]
		public int ConnectionTypeID
		{
			get
			{
				return this._ConnectionTypeID;
			}
			set
			{
				if ((this._ConnectionTypeID != value))
				{
					if (this._ConnectionType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnConnectionTypeIDChanging(value);
					this.SendPropertyChanging();
					this._ConnectionTypeID = value;
					this.SendPropertyChanged("ConnectionTypeID");
					this.OnConnectionTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Connection_Device", Storage="_Devices", ThisKey="ID", OtherKey="ConnectionID")]
		public EntitySet<Device> Devices
		{
			get
			{
				return this._Devices;
			}
			set
			{
				this._Devices.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ConnectionType_Connection", Storage="_ConnectionType", ThisKey="ConnectionTypeID", OtherKey="ID", IsForeignKey=true)]
		public ConnectionType ConnectionType
		{
			get
			{
				return this._ConnectionType.Entity;
			}
			set
			{
				ConnectionType previousValue = this._ConnectionType.Entity;
				if (((previousValue != value) 
							|| (this._ConnectionType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ConnectionType.Entity = null;
						previousValue.Connections.Remove(this);
					}
					this._ConnectionType.Entity = value;
					if ((value != null))
					{
						value.Connections.Add(this);
						this._ConnectionTypeID = value.ID;
					}
					else
					{
						this._ConnectionTypeID = default(int);
					}
					this.SendPropertyChanged("ConnectionType");
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
		
		private void attach_Devices(Device entity)
		{
			this.SendPropertyChanging();
			entity.Connection = this;
		}
		
		private void detach_Devices(Device entity)
		{
			this.SendPropertyChanging();
			entity.Connection = null;
		}
	}
}
#pragma warning restore 1591
