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

namespace Inteligentna_Ksiazka_Kucharska
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Przepisy")]
	public partial class PrzepisyDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPrzepis(Przepis instance);
    partial void UpdatePrzepis(Przepis instance);
    partial void DeletePrzepis(Przepis instance);
    partial void InsertProdukt(Produkt instance);
    partial void UpdateProdukt(Produkt instance);
    partial void DeleteProdukt(Produkt instance);
    partial void InsertSklad(Sklad instance);
    partial void UpdateSklad(Sklad instance);
    partial void DeleteSklad(Sklad instance);
    partial void InsertLista(Lista instance);
    partial void UpdateLista(Lista instance);
    partial void DeleteLista(Lista instance);
    partial void InsertHistoria(Historia instance);
    partial void UpdateHistoria(Historia instance);
    partial void DeleteHistoria(Historia instance);
    #endregion
		
		public PrzepisyDatabaseDataContext() : 
				base(global::Inteligentna_Ksiazka_Kucharska.Properties.Settings.Default.PrzepisyConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public PrzepisyDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PrzepisyDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PrzepisyDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PrzepisyDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Przepis> Przepis
		{
			get
			{
				return this.GetTable<Przepis>();
			}
		}
		
		public System.Data.Linq.Table<Produkt> Produkt
		{
			get
			{
				return this.GetTable<Produkt>();
			}
		}
		
		public System.Data.Linq.Table<Sklad> Sklad
		{
			get
			{
				return this.GetTable<Sklad>();
			}
		}
		
		public System.Data.Linq.Table<Lista> Lista
		{
			get
			{
				return this.GetTable<Lista>();
			}
		}
		
		public System.Data.Linq.Table<Historia> Historia
		{
			get
			{
				return this.GetTable<Historia>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Przepis")]
	public partial class Przepis : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_przepisu;
		
		private string _Nazwa;
		
		private System.Nullable<System.TimeSpan> _Czas_przygotowania;
		
		private string _Instrukcje;
		
		private System.Data.Linq.Binary _Zdjecie;
		
		private EntitySet<Sklad> _Sklad;
		
		private EntitySet<Historia> _Historia;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_przepisuChanging(int value);
    partial void OnId_przepisuChanged();
    partial void OnNazwaChanging(string value);
    partial void OnNazwaChanged();
    partial void OnCzas_przygotowaniaChanging(System.Nullable<System.TimeSpan> value);
    partial void OnCzas_przygotowaniaChanged();
    partial void OnInstrukcjeChanging(string value);
    partial void OnInstrukcjeChanged();
    partial void OnZdjecieChanging(System.Data.Linq.Binary value);
    partial void OnZdjecieChanged();
    #endregion
		
		public Przepis()
		{
			this._Sklad = new EntitySet<Sklad>(new Action<Sklad>(this.attach_Sklad), new Action<Sklad>(this.detach_Sklad));
			this._Historia = new EntitySet<Historia>(new Action<Historia>(this.attach_Historia), new Action<Historia>(this.detach_Historia));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_przepisu", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id_przepisu
		{
			get
			{
				return this._Id_przepisu;
			}
			set
			{
				if ((this._Id_przepisu != value))
				{
					this.OnId_przepisuChanging(value);
					this.SendPropertyChanging();
					this._Id_przepisu = value;
					this.SendPropertyChanged("Id_przepisu");
					this.OnId_przepisuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazwa", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Nazwa
		{
			get
			{
				return this._Nazwa;
			}
			set
			{
				if ((this._Nazwa != value))
				{
					this.OnNazwaChanging(value);
					this.SendPropertyChanging();
					this._Nazwa = value;
					this.SendPropertyChanged("Nazwa");
					this.OnNazwaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Czas_przygotowania", DbType="Time")]
		public System.Nullable<System.TimeSpan> Czas_przygotowania
		{
			get
			{
				return this._Czas_przygotowania;
			}
			set
			{
				if ((this._Czas_przygotowania != value))
				{
					this.OnCzas_przygotowaniaChanging(value);
					this.SendPropertyChanging();
					this._Czas_przygotowania = value;
					this.SendPropertyChanged("Czas_przygotowania");
					this.OnCzas_przygotowaniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Instrukcje", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string Instrukcje
		{
			get
			{
				return this._Instrukcje;
			}
			set
			{
				if ((this._Instrukcje != value))
				{
					this.OnInstrukcjeChanging(value);
					this.SendPropertyChanging();
					this._Instrukcje = value;
					this.SendPropertyChanged("Instrukcje");
					this.OnInstrukcjeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zdjecie", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Zdjecie
		{
			get
			{
				return this._Zdjecie;
			}
			set
			{
				if ((this._Zdjecie != value))
				{
					this.OnZdjecieChanging(value);
					this.SendPropertyChanging();
					this._Zdjecie = value;
					this.SendPropertyChanged("Zdjecie");
					this.OnZdjecieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Przepis_Sklad", Storage="_Sklad", ThisKey="Id_przepisu", OtherKey="przepis_ID")]
		public EntitySet<Sklad> Sklad
		{
			get
			{
				return this._Sklad;
			}
			set
			{
				this._Sklad.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Przepis_Historia", Storage="_Historia", ThisKey="Id_przepisu", OtherKey="przepis_ID")]
		public EntitySet<Historia> Historia
		{
			get
			{
				return this._Historia;
			}
			set
			{
				this._Historia.Assign(value);
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
		
		private void attach_Sklad(Sklad entity)
		{
			this.SendPropertyChanging();
			entity.Przepis = this;
		}
		
		private void detach_Sklad(Sklad entity)
		{
			this.SendPropertyChanging();
			entity.Przepis = null;
		}
		
		private void attach_Historia(Historia entity)
		{
			this.SendPropertyChanging();
			entity.Przepis = this;
		}
		
		private void detach_Historia(Historia entity)
		{
			this.SendPropertyChanging();
			entity.Przepis = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Produkt")]
	public partial class Produkt : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_produktu;
		
		private string _Nazwa;
		
		private string _Kalorie;
		
		private string _Białko;
		
		private string _Węglowodany;
		
		private string _Tłuszcze;
		
		private EntitySet<Sklad> _Sklad;
		
		private EntitySet<Lista> _Lista;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_produktuChanging(int value);
    partial void OnId_produktuChanged();
    partial void OnNazwaChanging(string value);
    partial void OnNazwaChanged();
    partial void OnKalorieChanging(string value);
    partial void OnKalorieChanged();
    partial void OnBiałkoChanging(string value);
    partial void OnBiałkoChanged();
    partial void OnWęglowodanyChanging(string value);
    partial void OnWęglowodanyChanged();
    partial void OnTłuszczeChanging(string value);
    partial void OnTłuszczeChanged();
    #endregion
		
		public Produkt()
		{
			this._Sklad = new EntitySet<Sklad>(new Action<Sklad>(this.attach_Sklad), new Action<Sklad>(this.detach_Sklad));
			this._Lista = new EntitySet<Lista>(new Action<Lista>(this.attach_Lista), new Action<Lista>(this.detach_Lista));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_produktu", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id_produktu
		{
			get
			{
				return this._Id_produktu;
			}
			set
			{
				if ((this._Id_produktu != value))
				{
					this.OnId_produktuChanging(value);
					this.SendPropertyChanging();
					this._Id_produktu = value;
					this.SendPropertyChanged("Id_produktu");
					this.OnId_produktuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazwa", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Nazwa
		{
			get
			{
				return this._Nazwa;
			}
			set
			{
				if ((this._Nazwa != value))
				{
					this.OnNazwaChanging(value);
					this.SendPropertyChanging();
					this._Nazwa = value;
					this.SendPropertyChanged("Nazwa");
					this.OnNazwaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kalorie", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Kalorie
		{
			get
			{
				return this._Kalorie;
			}
			set
			{
				if ((this._Kalorie != value))
				{
					this.OnKalorieChanging(value);
					this.SendPropertyChanging();
					this._Kalorie = value;
					this.SendPropertyChanged("Kalorie");
					this.OnKalorieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Białko", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Białko
		{
			get
			{
				return this._Białko;
			}
			set
			{
				if ((this._Białko != value))
				{
					this.OnBiałkoChanging(value);
					this.SendPropertyChanging();
					this._Białko = value;
					this.SendPropertyChanged("Białko");
					this.OnBiałkoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Węglowodany", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Węglowodany
		{
			get
			{
				return this._Węglowodany;
			}
			set
			{
				if ((this._Węglowodany != value))
				{
					this.OnWęglowodanyChanging(value);
					this.SendPropertyChanging();
					this._Węglowodany = value;
					this.SendPropertyChanged("Węglowodany");
					this.OnWęglowodanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tłuszcze", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Tłuszcze
		{
			get
			{
				return this._Tłuszcze;
			}
			set
			{
				if ((this._Tłuszcze != value))
				{
					this.OnTłuszczeChanging(value);
					this.SendPropertyChanging();
					this._Tłuszcze = value;
					this.SendPropertyChanged("Tłuszcze");
					this.OnTłuszczeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produkt_Sklad", Storage="_Sklad", ThisKey="Id_produktu", OtherKey="product_id")]
		public EntitySet<Sklad> Sklad
		{
			get
			{
				return this._Sklad;
			}
			set
			{
				this._Sklad.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produkt_Lista", Storage="_Lista", ThisKey="Id_produktu", OtherKey="product_id")]
		public EntitySet<Lista> Lista
		{
			get
			{
				return this._Lista;
			}
			set
			{
				this._Lista.Assign(value);
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
		
		private void attach_Sklad(Sklad entity)
		{
			this.SendPropertyChanging();
			entity.Produkt = this;
		}
		
		private void detach_Sklad(Sklad entity)
		{
			this.SendPropertyChanging();
			entity.Produkt = null;
		}
		
		private void attach_Lista(Lista entity)
		{
			this.SendPropertyChanging();
			entity.Produkt = this;
		}
		
		private void detach_Lista(Lista entity)
		{
			this.SendPropertyChanging();
			entity.Produkt = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sklad")]
	public partial class Sklad : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _sklad_ID;
		
		private int _przepis_ID;
		
		private int _product_id;
		
		private string _Ilosc;
		
		private EntityRef<Produkt> _Produkt;
		
		private EntityRef<Przepis> _Przepis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsklad_IDChanging(int value);
    partial void Onsklad_IDChanged();
    partial void Onprzepis_IDChanging(int value);
    partial void Onprzepis_IDChanged();
    partial void Onproduct_idChanging(int value);
    partial void Onproduct_idChanged();
    partial void OnIloscChanging(string value);
    partial void OnIloscChanged();
    #endregion
		
		public Sklad()
		{
			this._Produkt = default(EntityRef<Produkt>);
			this._Przepis = default(EntityRef<Przepis>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sklad_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int sklad_ID
		{
			get
			{
				return this._sklad_ID;
			}
			set
			{
				if ((this._sklad_ID != value))
				{
					this.Onsklad_IDChanging(value);
					this.SendPropertyChanging();
					this._sklad_ID = value;
					this.SendPropertyChanged("sklad_ID");
					this.Onsklad_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_przepis_ID", DbType="Int NOT NULL")]
		public int przepis_ID
		{
			get
			{
				return this._przepis_ID;
			}
			set
			{
				if ((this._przepis_ID != value))
				{
					if (this._Przepis.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onprzepis_IDChanging(value);
					this.SendPropertyChanging();
					this._przepis_ID = value;
					this.SendPropertyChanged("przepis_ID");
					this.Onprzepis_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_product_id", DbType="Int NOT NULL")]
		public int product_id
		{
			get
			{
				return this._product_id;
			}
			set
			{
				if ((this._product_id != value))
				{
					if (this._Produkt.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onproduct_idChanging(value);
					this.SendPropertyChanging();
					this._product_id = value;
					this.SendPropertyChanged("product_id");
					this.Onproduct_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ilosc", DbType="VarChar(15)")]
		public string Ilosc
		{
			get
			{
				return this._Ilosc;
			}
			set
			{
				if ((this._Ilosc != value))
				{
					this.OnIloscChanging(value);
					this.SendPropertyChanging();
					this._Ilosc = value;
					this.SendPropertyChanged("Ilosc");
					this.OnIloscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produkt_Sklad", Storage="_Produkt", ThisKey="product_id", OtherKey="Id_produktu", IsForeignKey=true)]
		public Produkt Produkt
		{
			get
			{
				return this._Produkt.Entity;
			}
			set
			{
				Produkt previousValue = this._Produkt.Entity;
				if (((previousValue != value) 
							|| (this._Produkt.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Produkt.Entity = null;
						previousValue.Sklad.Remove(this);
					}
					this._Produkt.Entity = value;
					if ((value != null))
					{
						value.Sklad.Add(this);
						this._product_id = value.Id_produktu;
					}
					else
					{
						this._product_id = default(int);
					}
					this.SendPropertyChanged("Produkt");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Przepis_Sklad", Storage="_Przepis", ThisKey="przepis_ID", OtherKey="Id_przepisu", IsForeignKey=true)]
		public Przepis Przepis
		{
			get
			{
				return this._Przepis.Entity;
			}
			set
			{
				Przepis previousValue = this._Przepis.Entity;
				if (((previousValue != value) 
							|| (this._Przepis.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Przepis.Entity = null;
						previousValue.Sklad.Remove(this);
					}
					this._Przepis.Entity = value;
					if ((value != null))
					{
						value.Sklad.Add(this);
						this._przepis_ID = value.Id_przepisu;
					}
					else
					{
						this._przepis_ID = default(int);
					}
					this.SendPropertyChanged("Przepis");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lista")]
	public partial class Lista : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _lista_ID;
		
		private int _product_id;
		
		private EntityRef<Produkt> _Produkt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onlista_IDChanging(int value);
    partial void Onlista_IDChanged();
    partial void Onproduct_idChanging(int value);
    partial void Onproduct_idChanged();
    #endregion
		
		public Lista()
		{
			this._Produkt = default(EntityRef<Produkt>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lista_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int lista_ID
		{
			get
			{
				return this._lista_ID;
			}
			set
			{
				if ((this._lista_ID != value))
				{
					this.Onlista_IDChanging(value);
					this.SendPropertyChanging();
					this._lista_ID = value;
					this.SendPropertyChanged("lista_ID");
					this.Onlista_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_product_id", DbType="Int NOT NULL")]
		public int product_id
		{
			get
			{
				return this._product_id;
			}
			set
			{
				if ((this._product_id != value))
				{
					if (this._Produkt.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onproduct_idChanging(value);
					this.SendPropertyChanging();
					this._product_id = value;
					this.SendPropertyChanged("product_id");
					this.Onproduct_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produkt_Lista", Storage="_Produkt", ThisKey="product_id", OtherKey="Id_produktu", IsForeignKey=true)]
		public Produkt Produkt
		{
			get
			{
				return this._Produkt.Entity;
			}
			set
			{
				Produkt previousValue = this._Produkt.Entity;
				if (((previousValue != value) 
							|| (this._Produkt.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Produkt.Entity = null;
						previousValue.Lista.Remove(this);
					}
					this._Produkt.Entity = value;
					if ((value != null))
					{
						value.Lista.Add(this);
						this._product_id = value.Id_produktu;
					}
					else
					{
						this._product_id = default(int);
					}
					this.SendPropertyChanged("Produkt");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Historia")]
	public partial class Historia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _history_id;
		
		private int _przepis_ID;
		
		private EntityRef<Przepis> _Przepis;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onhistory_idChanging(int value);
    partial void Onhistory_idChanged();
    partial void Onprzepis_IDChanging(int value);
    partial void Onprzepis_IDChanged();
    #endregion
		
		public Historia()
		{
			this._Przepis = default(EntityRef<Przepis>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_history_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int history_id
		{
			get
			{
				return this._history_id;
			}
			set
			{
				if ((this._history_id != value))
				{
					this.Onhistory_idChanging(value);
					this.SendPropertyChanging();
					this._history_id = value;
					this.SendPropertyChanged("history_id");
					this.Onhistory_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_przepis_ID", DbType="Int NOT NULL")]
		public int przepis_ID
		{
			get
			{
				return this._przepis_ID;
			}
			set
			{
				if ((this._przepis_ID != value))
				{
					if (this._Przepis.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onprzepis_IDChanging(value);
					this.SendPropertyChanging();
					this._przepis_ID = value;
					this.SendPropertyChanged("przepis_ID");
					this.Onprzepis_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Przepis_Historia", Storage="_Przepis", ThisKey="przepis_ID", OtherKey="Id_przepisu", IsForeignKey=true)]
		public Przepis Przepis
		{
			get
			{
				return this._Przepis.Entity;
			}
			set
			{
				Przepis previousValue = this._Przepis.Entity;
				if (((previousValue != value) 
							|| (this._Przepis.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Przepis.Entity = null;
						previousValue.Historia.Remove(this);
					}
					this._Przepis.Entity = value;
					if ((value != null))
					{
						value.Historia.Add(this);
						this._przepis_ID = value.Id_przepisu;
					}
					else
					{
						this._przepis_ID = default(int);
					}
					this.SendPropertyChanged("Przepis");
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