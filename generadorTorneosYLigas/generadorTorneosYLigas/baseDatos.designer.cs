﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18051
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace generadorTorneosYLigas
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
	
	
	public partial class baseDatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertTorneos(Torneos instance);
    partial void UpdateTorneos(Torneos instance);
    partial void DeleteTorneos(Torneos instance);
    partial void InsertParticipantes(Participantes instance);
    partial void UpdateParticipantes(Participantes instance);
    partial void DeleteParticipantes(Participantes instance);
    partial void InsertResultados(Resultados instance);
    partial void UpdateResultados(Resultados instance);
    partial void DeleteResultados(Resultados instance);
    #endregion
		
		public baseDatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
        //public baseDatosDataContext(System.Data.IDbConnection connection) : 
        //        base(connection, mappingSource)
        //{
        //    OnCreated();
        //}
		
		public baseDatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
        //public baseDatosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
        //        base(connection, mappingSource)
        //{
        //    OnCreated();
        //}
		
		public System.Data.Linq.Table<Torneos> Torneos
		{
			get
			{
				return this.GetTable<Torneos>();
			}
		}
		
		public System.Data.Linq.Table<Participantes> Participantes
		{
			get
			{
				return this.GetTable<Participantes>();
			}
		}
		
		public System.Data.Linq.Table<Resultados> Resultados
		{
			get
			{
				return this.GetTable<Resultados>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Torneos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _fechaTorneo;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnfechaTorneoChanging(System.DateTime value);
    partial void OnfechaTorneoChanged();
    #endregion
		
		public Torneos()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaTorneo")]
		public System.DateTime fechaTorneo
		{
			get
			{
				return this._fechaTorneo;
			}
			set
			{
				if ((this._fechaTorneo != value))
				{
					this.OnfechaTorneoChanging(value);
					this.SendPropertyChanging();
					this._fechaTorneo = value;
					this.SendPropertyChanged("fechaTorneo");
					this.OnfechaTorneoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Participantes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Data.Linq.Link<int> _Id;
		
		private int _Id_Torneo;
		
		private string _nom_participante;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnId_TorneoChanging(int value);
    partial void OnId_TorneoChanged();
    partial void Onnom_participanteChanging(string value);
    partial void Onnom_participanteChanged();
    #endregion
		
		public Participantes()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id.Value;
			}
			set
			{
				if ((this._Id.Value != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id.Value = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Torneo")]
		public int Id_Torneo
		{
			get
			{
				return this._Id_Torneo;
			}
			set
			{
				if ((this._Id_Torneo != value))
				{
					this.OnId_TorneoChanging(value);
					this.SendPropertyChanging();
					this._Id_Torneo = value;
					this.SendPropertyChanged("Id_Torneo");
					this.OnId_TorneoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nom_participante", CanBeNull=false)]
		public string nom_participante
		{
			get
			{
				return this._nom_participante;
			}
			set
			{
				if ((this._nom_participante != value))
				{
					this.Onnom_participanteChanging(value);
					this.SendPropertyChanging();
					this._nom_participante = value;
					this.SendPropertyChanged("nom_participante");
					this.Onnom_participanteChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Resultados : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Id_Torneo;
		
		private string _Id_Participante;
		
		private string _Puntaje;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnId_TorneoChanging(string value);
    partial void OnId_TorneoChanged();
    partial void OnId_ParticipanteChanging(string value);
    partial void OnId_ParticipanteChanged();
    partial void OnPuntajeChanging(string value);
    partial void OnPuntajeChanged();
    #endregion
		
		public Resultados()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Torneo", CanBeNull=false)]
		public string Id_Torneo
		{
			get
			{
				return this._Id_Torneo;
			}
			set
			{
				if ((this._Id_Torneo != value))
				{
					this.OnId_TorneoChanging(value);
					this.SendPropertyChanging();
					this._Id_Torneo = value;
					this.SendPropertyChanged("Id_Torneo");
					this.OnId_TorneoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Participante", CanBeNull=false)]
		public string Id_Participante
		{
			get
			{
				return this._Id_Participante;
			}
			set
			{
				if ((this._Id_Participante != value))
				{
					this.OnId_ParticipanteChanging(value);
					this.SendPropertyChanging();
					this._Id_Participante = value;
					this.SendPropertyChanged("Id_Participante");
					this.OnId_ParticipanteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Puntaje", CanBeNull=false)]
		public string Puntaje
		{
			get
			{
				return this._Puntaje;
			}
			set
			{
				if ((this._Puntaje != value))
				{
					this.OnPuntajeChanging(value);
					this.SendPropertyChanging();
					this._Puntaje = value;
					this.SendPropertyChanged("Puntaje");
					this.OnPuntajeChanged();
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