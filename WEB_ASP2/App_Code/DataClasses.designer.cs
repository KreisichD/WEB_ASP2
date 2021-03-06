﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataBase")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertkurs(kurs instance);
  partial void Updatekurs(kurs instance);
  partial void Deletekurs(kurs instance);
  partial void Insertuzytkownik(uzytkownik instance);
  partial void Updateuzytkownik(uzytkownik instance);
  partial void Deleteuzytkownik(uzytkownik instance);
  partial void Insertkurs_uzytkownik(kurs_uzytkownik instance);
  partial void Updatekurs_uzytkownik(kurs_uzytkownik instance);
  partial void Deletekurs_uzytkownik(kurs_uzytkownik instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<kurs> kurs
	{
		get
		{
			return this.GetTable<kurs>();
		}
	}
	
	public System.Data.Linq.Table<uzytkownik> uzytkownik
	{
		get
		{
			return this.GetTable<uzytkownik>();
		}
	}
	
	public System.Data.Linq.Table<kurs_uzytkownik> kurs_uzytkownik
	{
		get
		{
			return this.GetTable<kurs_uzytkownik>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.kurs")]
public partial class kurs : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private string _Description;
	
	private System.Data.Linq.Binary _Photo;
	
	private float _Cost;
	
	private EntitySet<kurs_uzytkownik> _kurs_uzytkownik;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPhotoChanging(System.Data.Linq.Binary value);
    partial void OnPhotoChanged();
    partial void OnCostChanging(float value);
    partial void OnCostChanged();
    #endregion
	
	public kurs()
	{
		this._kurs_uzytkownik = new EntitySet<kurs_uzytkownik>(new Action<kurs_uzytkownik>(this.attach_kurs_uzytkownik), new Action<kurs_uzytkownik>(this.detach_kurs_uzytkownik));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
	public string Description
	{
		get
		{
			return this._Description;
		}
		set
		{
			if ((this._Description != value))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._Description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="Image", UpdateCheck=UpdateCheck.Never)]
	public System.Data.Linq.Binary Photo
	{
		get
		{
			return this._Photo;
		}
		set
		{
			if ((this._Photo != value))
			{
				this.OnPhotoChanging(value);
				this.SendPropertyChanging();
				this._Photo = value;
				this.SendPropertyChanged("Photo");
				this.OnPhotoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Real NOT NULL")]
	public float Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this.OnCostChanging(value);
				this.SendPropertyChanging();
				this._Cost = value;
				this.SendPropertyChanged("Cost");
				this.OnCostChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="kurs_kurs_uzytkownik", Storage="_kurs_uzytkownik", ThisKey="Id", OtherKey="IdKursu")]
	public EntitySet<kurs_uzytkownik> kurs_uzytkownik
	{
		get
		{
			return this._kurs_uzytkownik;
		}
		set
		{
			this._kurs_uzytkownik.Assign(value);
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
	
	private void attach_kurs_uzytkownik(kurs_uzytkownik entity)
	{
		this.SendPropertyChanging();
		entity.kurs = this;
	}
	
	private void detach_kurs_uzytkownik(kurs_uzytkownik entity)
	{
		this.SendPropertyChanging();
		entity.kurs = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.uzytkownik")]
public partial class uzytkownik : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _FirstName;
	
	private string _LastName;
	
	private System.DateTime _DateOfBirth;
	
	private string _Email;
	
	private string _Password;
	
	private string _Phone;
	
	private EntitySet<kurs_uzytkownik> _kurs_uzytkownik;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnDateOfBirthChanging(System.DateTime value);
    partial void OnDateOfBirthChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
	
	public uzytkownik()
	{
		this._kurs_uzytkownik = new EntitySet<kurs_uzytkownik>(new Action<kurs_uzytkownik>(this.attach_kurs_uzytkownik), new Action<kurs_uzytkownik>(this.detach_kurs_uzytkownik));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string FirstName
	{
		get
		{
			return this._FirstName;
		}
		set
		{
			if ((this._FirstName != value))
			{
				this.OnFirstNameChanging(value);
				this.SendPropertyChanging();
				this._FirstName = value;
				this.SendPropertyChanged("FirstName");
				this.OnFirstNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string LastName
	{
		get
		{
			return this._LastName;
		}
		set
		{
			if ((this._LastName != value))
			{
				this.OnLastNameChanging(value);
				this.SendPropertyChanging();
				this._LastName = value;
				this.SendPropertyChanged("LastName");
				this.OnLastNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="Date NOT NULL")]
	public System.DateTime DateOfBirth
	{
		get
		{
			return this._DateOfBirth;
		}
		set
		{
			if ((this._DateOfBirth != value))
			{
				this.OnDateOfBirthChanging(value);
				this.SendPropertyChanging();
				this._DateOfBirth = value;
				this.SendPropertyChanged("DateOfBirth");
				this.OnDateOfBirthChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50)")]
	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="uzytkownik_kurs_uzytkownik", Storage="_kurs_uzytkownik", ThisKey="Id", OtherKey="IdUzytkownika")]
	public EntitySet<kurs_uzytkownik> kurs_uzytkownik
	{
		get
		{
			return this._kurs_uzytkownik;
		}
		set
		{
			this._kurs_uzytkownik.Assign(value);
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
	
	private void attach_kurs_uzytkownik(kurs_uzytkownik entity)
	{
		this.SendPropertyChanging();
		entity.uzytkownik = this;
	}
	
	private void detach_kurs_uzytkownik(kurs_uzytkownik entity)
	{
		this.SendPropertyChanging();
		entity.uzytkownik = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.kurs_uzytkownik")]
public partial class kurs_uzytkownik : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _IdKursu;
	
	private int _IdUzytkownika;
	
	private EntityRef<kurs> _kurs;
	
	private EntityRef<uzytkownik> _uzytkownik;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdKursuChanging(int value);
    partial void OnIdKursuChanged();
    partial void OnIdUzytkownikaChanging(int value);
    partial void OnIdUzytkownikaChanged();
    #endregion
	
	public kurs_uzytkownik()
	{
		this._kurs = default(EntityRef<kurs>);
		this._uzytkownik = default(EntityRef<uzytkownik>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdKursu", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int IdKursu
	{
		get
		{
			return this._IdKursu;
		}
		set
		{
			if ((this._IdKursu != value))
			{
				if (this._kurs.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIdKursuChanging(value);
				this.SendPropertyChanging();
				this._IdKursu = value;
				this.SendPropertyChanged("IdKursu");
				this.OnIdKursuChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUzytkownika", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int IdUzytkownika
	{
		get
		{
			return this._IdUzytkownika;
		}
		set
		{
			if ((this._IdUzytkownika != value))
			{
				if (this._uzytkownik.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIdUzytkownikaChanging(value);
				this.SendPropertyChanging();
				this._IdUzytkownika = value;
				this.SendPropertyChanged("IdUzytkownika");
				this.OnIdUzytkownikaChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="kurs_kurs_uzytkownik", Storage="_kurs", ThisKey="IdKursu", OtherKey="Id", IsForeignKey=true)]
	public kurs kurs
	{
		get
		{
			return this._kurs.Entity;
		}
		set
		{
			kurs previousValue = this._kurs.Entity;
			if (((previousValue != value) 
						|| (this._kurs.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._kurs.Entity = null;
					previousValue.kurs_uzytkownik.Remove(this);
				}
				this._kurs.Entity = value;
				if ((value != null))
				{
					value.kurs_uzytkownik.Add(this);
					this._IdKursu = value.Id;
				}
				else
				{
					this._IdKursu = default(int);
				}
				this.SendPropertyChanged("kurs");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="uzytkownik_kurs_uzytkownik", Storage="_uzytkownik", ThisKey="IdUzytkownika", OtherKey="Id", IsForeignKey=true)]
	public uzytkownik uzytkownik
	{
		get
		{
			return this._uzytkownik.Entity;
		}
		set
		{
			uzytkownik previousValue = this._uzytkownik.Entity;
			if (((previousValue != value) 
						|| (this._uzytkownik.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._uzytkownik.Entity = null;
					previousValue.kurs_uzytkownik.Remove(this);
				}
				this._uzytkownik.Entity = value;
				if ((value != null))
				{
					value.kurs_uzytkownik.Add(this);
					this._IdUzytkownika = value.Id;
				}
				else
				{
					this._IdUzytkownika = default(int);
				}
				this.SendPropertyChanged("uzytkownik");
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
#pragma warning restore 1591
