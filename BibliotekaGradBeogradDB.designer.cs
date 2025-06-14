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

namespace BibliotekaProjekat2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BibliotekaGradBeograd")]
	public partial class BibliotekaGradBeogradDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertClanovi(Clanovi instance);
    partial void UpdateClanovi(Clanovi instance);
    partial void DeleteClanovi(Clanovi instance);
    partial void InsertPozajmice(Pozajmice instance);
    partial void UpdatePozajmice(Pozajmice instance);
    partial void DeletePozajmice(Pozajmice instance);
    partial void InsertRadnici(Radnici instance);
    partial void UpdateRadnici(Radnici instance);
    partial void DeleteRadnici(Radnici instance);
    partial void InsertKnjige(Knjige instance);
    partial void UpdateKnjige(Knjige instance);
    partial void DeleteKnjige(Knjige instance);
    #endregion
		
		public BibliotekaGradBeogradDBDataContext() : 
				base(global::BibliotekaProjekat2.Properties.Settings.Default.BibliotekaGradBeogradConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BibliotekaGradBeogradDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BibliotekaGradBeogradDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BibliotekaGradBeogradDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BibliotekaGradBeogradDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Clanovi> Clanovis
		{
			get
			{
				return this.GetTable<Clanovi>();
			}
		}
		
		public System.Data.Linq.Table<Pozajmice> Pozajmices
		{
			get
			{
				return this.GetTable<Pozajmice>();
			}
		}
		
		public System.Data.Linq.Table<Radnici> Radnicis
		{
			get
			{
				return this.GetTable<Radnici>();
			}
		}
		
		public System.Data.Linq.Table<Knjige> Knjiges
		{
			get
			{
				return this.GetTable<Knjige>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertPozajmica")]
		public int InsertPozajmica([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ClanID", DbType="Int")] System.Nullable<int> clanID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KnjigaID", DbType="Int")] System.Nullable<int> knjigaID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RadnikID", DbType="Int")] System.Nullable<int> radnikID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DatumPozajmice", DbType="DateTime")] System.Nullable<System.DateTime> datumPozajmice, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DatumIstekaPozajmice", DbType="DateTime")] System.Nullable<System.DateTime> datumIstekaPozajmice, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DatumVracanja", DbType="DateTime")] System.Nullable<System.DateTime> datumVracanja)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), clanID, knjigaID, radnikID, datumPozajmice, datumIstekaPozajmice, datumVracanja);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateDatumPozajmica")]
		public int UpdateDatumPozajmica([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PozajmicaID", DbType="Int")] System.Nullable<int> pozajmicaID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DatumVracanja", DbType="Date")] System.Nullable<System.DateTime> datumVracanja)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pozajmicaID, datumVracanja);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdatePozajmica")]
		public int UpdatePozajmica([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PozajmicaID", DbType="Int")] System.Nullable<int> pozajmicaID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="KnjigaID", DbType="Int")] System.Nullable<int> knjigaID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RadnikID", DbType="Int")] System.Nullable<int> radnikID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ClanID", DbType="Int")] System.Nullable<int> clanID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DatumPozajmice", DbType="DateTime")] System.Nullable<System.DateTime> datumPozajmice, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DatumIstekaPozajmice", DbType="DateTime")] System.Nullable<System.DateTime> datumIstekaPozajmice, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DatumVracanja", DbType="DateTime")] System.Nullable<System.DateTime> datumVracanja)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pozajmicaID, knjigaID, radnikID, clanID, datumPozajmice, datumIstekaPozajmice, datumVracanja);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeletePozajmica")]
		public int DeletePozajmica([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PozajmicaID", DbType="Int")] System.Nullable<int> pozajmicaID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pozajmicaID);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Administracija.Clanovi")]
	public partial class Clanovi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ClanID;
		
		private string _Ime;
		
		private string _Prezime;
		
		private string _Email;
		
		private string _BrojTelefona;
		
		private string _Adresa;
		
		private EntitySet<Pozajmice> _Pozajmices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClanIDChanging(int value);
    partial void OnClanIDChanged();
    partial void OnImeChanging(string value);
    partial void OnImeChanged();
    partial void OnPrezimeChanging(string value);
    partial void OnPrezimeChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnBrojTelefonaChanging(string value);
    partial void OnBrojTelefonaChanged();
    partial void OnAdresaChanging(string value);
    partial void OnAdresaChanged();
    #endregion
		
		public Clanovi()
		{
			this._Pozajmices = new EntitySet<Pozajmice>(new Action<Pozajmice>(this.attach_Pozajmices), new Action<Pozajmice>(this.detach_Pozajmices));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClanID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ClanID
		{
			get
			{
				return this._ClanID;
			}
			set
			{
				if ((this._ClanID != value))
				{
					this.OnClanIDChanging(value);
					this.SendPropertyChanging();
					this._ClanID = value;
					this.SendPropertyChanged("ClanID");
					this.OnClanIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ime", DbType="NVarChar(50)")]
		public string Ime
		{
			get
			{
				return this._Ime;
			}
			set
			{
				if ((this._Ime != value))
				{
					this.OnImeChanging(value);
					this.SendPropertyChanging();
					this._Ime = value;
					this.SendPropertyChanged("Ime");
					this.OnImeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prezime", DbType="NVarChar(50)")]
		public string Prezime
		{
			get
			{
				return this._Prezime;
			}
			set
			{
				if ((this._Prezime != value))
				{
					this.OnPrezimeChanging(value);
					this.SendPropertyChanging();
					this._Prezime = value;
					this.SendPropertyChanged("Prezime");
					this.OnPrezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrojTelefona", DbType="NVarChar(20)")]
		public string BrojTelefona
		{
			get
			{
				return this._BrojTelefona;
			}
			set
			{
				if ((this._BrojTelefona != value))
				{
					this.OnBrojTelefonaChanging(value);
					this.SendPropertyChanging();
					this._BrojTelefona = value;
					this.SendPropertyChanged("BrojTelefona");
					this.OnBrojTelefonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adresa", DbType="NVarChar(255)")]
		public string Adresa
		{
			get
			{
				return this._Adresa;
			}
			set
			{
				if ((this._Adresa != value))
				{
					this.OnAdresaChanging(value);
					this.SendPropertyChanging();
					this._Adresa = value;
					this.SendPropertyChanged("Adresa");
					this.OnAdresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clanovi_Pozajmice", Storage="_Pozajmices", ThisKey="ClanID", OtherKey="ClanID")]
		public EntitySet<Pozajmice> Pozajmices
		{
			get
			{
				return this._Pozajmices;
			}
			set
			{
				this._Pozajmices.Assign(value);
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
		
		private void attach_Pozajmices(Pozajmice entity)
		{
			this.SendPropertyChanging();
			entity.Clanovi = this;
		}
		
		private void detach_Pozajmices(Pozajmice entity)
		{
			this.SendPropertyChanging();
			entity.Clanovi = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Administracija.Pozajmice")]
	public partial class Pozajmice : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PozajmicaID;
		
		private int _ClanID;
		
		private int _KnjigaID;
		
		private int _RadnikID;
		
		private System.DateTime _DatumPozajmice;
		
		private System.DateTime _DatumIstekaPozajmice;
		
		private System.Nullable<System.DateTime> _DatumVracanja;
		
		private EntityRef<Clanovi> _Clanovi;
		
		private EntityRef<Radnici> _Radnici;
		
		private EntityRef<Knjige> _Knjige;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPozajmicaIDChanging(int value);
    partial void OnPozajmicaIDChanged();
    partial void OnClanIDChanging(int value);
    partial void OnClanIDChanged();
    partial void OnKnjigaIDChanging(int value);
    partial void OnKnjigaIDChanged();
    partial void OnRadnikIDChanging(int value);
    partial void OnRadnikIDChanged();
    partial void OnDatumPozajmiceChanging(System.DateTime value);
    partial void OnDatumPozajmiceChanged();
    partial void OnDatumIstekaPozajmiceChanging(System.DateTime value);
    partial void OnDatumIstekaPozajmiceChanged();
    partial void OnDatumVracanjaChanging(System.Nullable<System.DateTime> value);
    partial void OnDatumVracanjaChanged();
    #endregion
		
		public Pozajmice()
		{
			this._Clanovi = default(EntityRef<Clanovi>);
			this._Radnici = default(EntityRef<Radnici>);
			this._Knjige = default(EntityRef<Knjige>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PozajmicaID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PozajmicaID
		{
			get
			{
				return this._PozajmicaID;
			}
			set
			{
				if ((this._PozajmicaID != value))
				{
					this.OnPozajmicaIDChanging(value);
					this.SendPropertyChanging();
					this._PozajmicaID = value;
					this.SendPropertyChanged("PozajmicaID");
					this.OnPozajmicaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClanID", DbType="Int NOT NULL")]
		public int ClanID
		{
			get
			{
				return this._ClanID;
			}
			set
			{
				if ((this._ClanID != value))
				{
					if (this._Clanovi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClanIDChanging(value);
					this.SendPropertyChanging();
					this._ClanID = value;
					this.SendPropertyChanged("ClanID");
					this.OnClanIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KnjigaID", DbType="Int NOT NULL")]
		public int KnjigaID
		{
			get
			{
				return this._KnjigaID;
			}
			set
			{
				if ((this._KnjigaID != value))
				{
					if (this._Knjige.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKnjigaIDChanging(value);
					this.SendPropertyChanging();
					this._KnjigaID = value;
					this.SendPropertyChanged("KnjigaID");
					this.OnKnjigaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RadnikID", DbType="Int NOT NULL")]
		public int RadnikID
		{
			get
			{
				return this._RadnikID;
			}
			set
			{
				if ((this._RadnikID != value))
				{
					if (this._Radnici.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRadnikIDChanging(value);
					this.SendPropertyChanging();
					this._RadnikID = value;
					this.SendPropertyChanged("RadnikID");
					this.OnRadnikIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatumPozajmice", DbType="DateTime NOT NULL")]
		public System.DateTime DatumPozajmice
		{
			get
			{
				return this._DatumPozajmice;
			}
			set
			{
				if ((this._DatumPozajmice != value))
				{
					this.OnDatumPozajmiceChanging(value);
					this.SendPropertyChanging();
					this._DatumPozajmice = value;
					this.SendPropertyChanged("DatumPozajmice");
					this.OnDatumPozajmiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatumIstekaPozajmice", DbType="DateTime NOT NULL")]
		public System.DateTime DatumIstekaPozajmice
		{
			get
			{
				return this._DatumIstekaPozajmice;
			}
			set
			{
				if ((this._DatumIstekaPozajmice != value))
				{
					this.OnDatumIstekaPozajmiceChanging(value);
					this.SendPropertyChanging();
					this._DatumIstekaPozajmice = value;
					this.SendPropertyChanged("DatumIstekaPozajmice");
					this.OnDatumIstekaPozajmiceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatumVracanja", DbType="DateTime")]
		public System.Nullable<System.DateTime> DatumVracanja
		{
			get
			{
				return this._DatumVracanja;
			}
			set
			{
				if ((this._DatumVracanja != value))
				{
					this.OnDatumVracanjaChanging(value);
					this.SendPropertyChanging();
					this._DatumVracanja = value;
					this.SendPropertyChanged("DatumVracanja");
					this.OnDatumVracanjaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clanovi_Pozajmice", Storage="_Clanovi", ThisKey="ClanID", OtherKey="ClanID", IsForeignKey=true)]
		public Clanovi Clanovi
		{
			get
			{
				return this._Clanovi.Entity;
			}
			set
			{
				Clanovi previousValue = this._Clanovi.Entity;
				if (((previousValue != value) 
							|| (this._Clanovi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Clanovi.Entity = null;
						previousValue.Pozajmices.Remove(this);
					}
					this._Clanovi.Entity = value;
					if ((value != null))
					{
						value.Pozajmices.Add(this);
						this._ClanID = value.ClanID;
					}
					else
					{
						this._ClanID = default(int);
					}
					this.SendPropertyChanged("Clanovi");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Radnici_Pozajmice", Storage="_Radnici", ThisKey="RadnikID", OtherKey="RadnikID", IsForeignKey=true)]
		public Radnici Radnici
		{
			get
			{
				return this._Radnici.Entity;
			}
			set
			{
				Radnici previousValue = this._Radnici.Entity;
				if (((previousValue != value) 
							|| (this._Radnici.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Radnici.Entity = null;
						previousValue.Pozajmices.Remove(this);
					}
					this._Radnici.Entity = value;
					if ((value != null))
					{
						value.Pozajmices.Add(this);
						this._RadnikID = value.RadnikID;
					}
					else
					{
						this._RadnikID = default(int);
					}
					this.SendPropertyChanged("Radnici");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Knjige_Pozajmice", Storage="_Knjige", ThisKey="KnjigaID", OtherKey="KnjigaID", IsForeignKey=true)]
		public Knjige Knjige
		{
			get
			{
				return this._Knjige.Entity;
			}
			set
			{
				Knjige previousValue = this._Knjige.Entity;
				if (((previousValue != value) 
							|| (this._Knjige.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Knjige.Entity = null;
						previousValue.Pozajmices.Remove(this);
					}
					this._Knjige.Entity = value;
					if ((value != null))
					{
						value.Pozajmices.Add(this);
						this._KnjigaID = value.KnjigaID;
					}
					else
					{
						this._KnjigaID = default(int);
					}
					this.SendPropertyChanged("Knjige");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Administracija.Radnici")]
	public partial class Radnici : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RadnikID;
		
		private string _Ime;
		
		private string _Prezime;
		
		private string _Pozicija;
		
		private EntitySet<Pozajmice> _Pozajmices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRadnikIDChanging(int value);
    partial void OnRadnikIDChanged();
    partial void OnImeChanging(string value);
    partial void OnImeChanged();
    partial void OnPrezimeChanging(string value);
    partial void OnPrezimeChanged();
    partial void OnPozicijaChanging(string value);
    partial void OnPozicijaChanged();
    #endregion
		
		public Radnici()
		{
			this._Pozajmices = new EntitySet<Pozajmice>(new Action<Pozajmice>(this.attach_Pozajmices), new Action<Pozajmice>(this.detach_Pozajmices));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RadnikID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RadnikID
		{
			get
			{
				return this._RadnikID;
			}
			set
			{
				if ((this._RadnikID != value))
				{
					this.OnRadnikIDChanging(value);
					this.SendPropertyChanging();
					this._RadnikID = value;
					this.SendPropertyChanged("RadnikID");
					this.OnRadnikIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ime", DbType="NVarChar(50)")]
		public string Ime
		{
			get
			{
				return this._Ime;
			}
			set
			{
				if ((this._Ime != value))
				{
					this.OnImeChanging(value);
					this.SendPropertyChanging();
					this._Ime = value;
					this.SendPropertyChanged("Ime");
					this.OnImeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prezime", DbType="NVarChar(50)")]
		public string Prezime
		{
			get
			{
				return this._Prezime;
			}
			set
			{
				if ((this._Prezime != value))
				{
					this.OnPrezimeChanging(value);
					this.SendPropertyChanging();
					this._Prezime = value;
					this.SendPropertyChanged("Prezime");
					this.OnPrezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pozicija", DbType="NVarChar(50)")]
		public string Pozicija
		{
			get
			{
				return this._Pozicija;
			}
			set
			{
				if ((this._Pozicija != value))
				{
					this.OnPozicijaChanging(value);
					this.SendPropertyChanging();
					this._Pozicija = value;
					this.SendPropertyChanged("Pozicija");
					this.OnPozicijaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Radnici_Pozajmice", Storage="_Pozajmices", ThisKey="RadnikID", OtherKey="RadnikID")]
		public EntitySet<Pozajmice> Pozajmices
		{
			get
			{
				return this._Pozajmices;
			}
			set
			{
				this._Pozajmices.Assign(value);
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
		
		private void attach_Pozajmices(Pozajmice entity)
		{
			this.SendPropertyChanging();
			entity.Radnici = this;
		}
		
		private void detach_Pozajmices(Pozajmice entity)
		{
			this.SendPropertyChanging();
			entity.Radnici = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="Biblioteka.Knjige")]
	public partial class Knjige : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KnjigaID;
		
		private string _Naziv;
		
		private string _Autor;
		
		private System.Nullable<int> _GodinaIzdavanja;
		
		private System.Nullable<int> _DostupneKopije;
		
		private EntitySet<Pozajmice> _Pozajmices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKnjigaIDChanging(int value);
    partial void OnKnjigaIDChanged();
    partial void OnNazivChanging(string value);
    partial void OnNazivChanged();
    partial void OnAutorChanging(string value);
    partial void OnAutorChanged();
    partial void OnGodinaIzdavanjaChanging(System.Nullable<int> value);
    partial void OnGodinaIzdavanjaChanged();
    partial void OnDostupneKopijeChanging(System.Nullable<int> value);
    partial void OnDostupneKopijeChanged();
    #endregion
		
		public Knjige()
		{
			this._Pozajmices = new EntitySet<Pozajmice>(new Action<Pozajmice>(this.attach_Pozajmices), new Action<Pozajmice>(this.detach_Pozajmices));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KnjigaID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int KnjigaID
		{
			get
			{
				return this._KnjigaID;
			}
			set
			{
				if ((this._KnjigaID != value))
				{
					this.OnKnjigaIDChanging(value);
					this.SendPropertyChanging();
					this._KnjigaID = value;
					this.SendPropertyChanged("KnjigaID");
					this.OnKnjigaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naziv", DbType="NVarChar(255)")]
		public string Naziv
		{
			get
			{
				return this._Naziv;
			}
			set
			{
				if ((this._Naziv != value))
				{
					this.OnNazivChanging(value);
					this.SendPropertyChanging();
					this._Naziv = value;
					this.SendPropertyChanged("Naziv");
					this.OnNazivChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Autor", DbType="NVarChar(100)")]
		public string Autor
		{
			get
			{
				return this._Autor;
			}
			set
			{
				if ((this._Autor != value))
				{
					this.OnAutorChanging(value);
					this.SendPropertyChanging();
					this._Autor = value;
					this.SendPropertyChanged("Autor");
					this.OnAutorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GodinaIzdavanja", DbType="Int")]
		public System.Nullable<int> GodinaIzdavanja
		{
			get
			{
				return this._GodinaIzdavanja;
			}
			set
			{
				if ((this._GodinaIzdavanja != value))
				{
					this.OnGodinaIzdavanjaChanging(value);
					this.SendPropertyChanging();
					this._GodinaIzdavanja = value;
					this.SendPropertyChanged("GodinaIzdavanja");
					this.OnGodinaIzdavanjaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DostupneKopije", DbType="Int")]
		public System.Nullable<int> DostupneKopije
		{
			get
			{
				return this._DostupneKopije;
			}
			set
			{
				if ((this._DostupneKopije != value))
				{
					this.OnDostupneKopijeChanging(value);
					this.SendPropertyChanging();
					this._DostupneKopije = value;
					this.SendPropertyChanged("DostupneKopije");
					this.OnDostupneKopijeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Knjige_Pozajmice", Storage="_Pozajmices", ThisKey="KnjigaID", OtherKey="KnjigaID")]
		public EntitySet<Pozajmice> Pozajmices
		{
			get
			{
				return this._Pozajmices;
			}
			set
			{
				this._Pozajmices.Assign(value);
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
		
		private void attach_Pozajmices(Pozajmice entity)
		{
			this.SendPropertyChanging();
			entity.Knjige = this;
		}
		
		private void detach_Pozajmices(Pozajmice entity)
		{
			this.SendPropertyChanging();
			entity.Knjige = null;
		}
	}
}
#pragma warning restore 1591
