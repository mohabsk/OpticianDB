// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from OpticianDB on 2011-03-08 19:19:34Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace OpticianDB.Adaptor
{
	using System;
	using System.ComponentModel;
	using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class DBAdaptor : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public DBAdaptor(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public DBAdaptor(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public DBAdaptor(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<Conditions> Conditions
		{
			get
			{
				return this.GetTable<Conditions>();
			}
		}
		
		public Table<PatientAppointments> PatientAppointments
		{
			get
			{
				return this.GetTable<PatientAppointments>();
			}
		}
		
		public Table<PatientConditions> PatientConditions
		{
			get
			{
				return this.GetTable<PatientConditions>();
			}
		}
		
		public Table<PatientRecallDates> PatientRecallDates
		{
			get
			{
				return this.GetTable<PatientRecallDates>();
			}
		}
		
		public Table<Patients> Patients
		{
			get
			{
				return this.GetTable<Patients>();
			}
		}
		
		public Table<PatientTestResults> PatientTestResults
		{
			get
			{
				return this.GetTable<PatientTestResults>();
			}
		}
		
		public Table<Settings> Settings
		{
			get
			{
				return this.GetTable<Settings>();
			}
		}
		
		public Table<Users> Users
		{
			get
			{
				return this.GetTable<Users>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class OpticianDb
	{
		
		public OpticianDb(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class DBAdaptor
	{
		
		public DBAdaptor(IDbConnection connection) : 
				base(connection, new DbLinq.Sqlite.SqliteVendor())
		{
			this.OnCreated();
		}
		
		public DBAdaptor(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public DBAdaptor(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="main.Conditions")]
	public partial class Conditions : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _condition;
		
		private int _conditionID;
		
		private EntitySet<PatientConditions> _patientConditions;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnConditionChanged();
		
		partial void OnConditionChanging(string value);
		
		partial void OnConditionIDChanged();
		
		partial void OnConditionIDChanging(int value);
		#endregion
		
		
		public Conditions()
		{
			_patientConditions = new EntitySet<PatientConditions>(new Action<PatientConditions>(this.PatientConditions_Attach), new Action<PatientConditions>(this.PatientConditions_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_condition", Name="Condition", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Condition
		{
			get
			{
				return this._condition;
			}
			set
			{
				if (((_condition == value) 
							== false))
				{
					this.OnConditionChanging(value);
					this.SendPropertyChanging();
					this._condition = value;
					this.SendPropertyChanged("Condition");
					this.OnConditionChanged();
				}
			}
		}
		
		[Column(Storage="_conditionID", Name="ConditionID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ConditionID
		{
			get
			{
				return this._conditionID;
			}
			set
			{
				if ((_conditionID != value))
				{
					this.OnConditionIDChanging(value);
					this.SendPropertyChanging();
					this._conditionID = value;
					this.SendPropertyChanged("ConditionID");
					this.OnConditionIDChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_patientConditions", OtherKey="ConditionID", ThisKey="ConditionID", Name="fk_PatientConditions_0")]
		[DebuggerNonUserCode()]
		public EntitySet<PatientConditions> PatientConditions
		{
			get
			{
				return this._patientConditions;
			}
			set
			{
				this._patientConditions = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void PatientConditions_Attach(PatientConditions entity)
		{
			this.SendPropertyChanging();
			entity.Conditions = this;
		}
		
		private void PatientConditions_Detach(PatientConditions entity)
		{
			this.SendPropertyChanging();
			entity.Conditions = null;
		}
		#endregion
	}
	
	[Table(Name="main.PatientAppointments")]
	public partial class PatientAppointments : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _appointmentID;
		
		private System.Nullable<System.DateTime> _dateTime;
		
		private int _patientID;
		
		private EntityRef<Patients> _patients = new EntityRef<Patients>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAppointmentIDChanged();
		
		partial void OnAppointmentIDChanging(int value);
		
		partial void OnDateTimeChanged();
		
		partial void OnDateTimeChanging(System.Nullable<System.DateTime> value);
		
		partial void OnPatientIDChanged();
		
		partial void OnPatientIDChanging(int value);
		#endregion
		
		
		public PatientAppointments()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_appointmentID", Name="AppointmentID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AppointmentID
		{
			get
			{
				return this._appointmentID;
			}
			set
			{
				if ((_appointmentID != value))
				{
					this.OnAppointmentIDChanging(value);
					this.SendPropertyChanging();
					this._appointmentID = value;
					this.SendPropertyChanged("AppointmentID");
					this.OnAppointmentIDChanged();
				}
			}
		}
		
		[Column(Storage="_dateTime", Name="DateTime", DbType="DATETIME", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateTime
		{
			get
			{
				return this._dateTime;
			}
			set
			{
				if ((_dateTime != value))
				{
					this.OnDateTimeChanging(value);
					this.SendPropertyChanging();
					this._dateTime = value;
					this.SendPropertyChanged("DateTime");
					this.OnDateTimeChanged();
				}
			}
		}
		
		[Column(Storage="_patientID", Name="PatientID", DbType="INTEGER", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PatientID
		{
			get
			{
				return this._patientID;
			}
			set
			{
				if ((_patientID != value))
				{
					if (_patients.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPatientIDChanging(value);
					this.SendPropertyChanging();
					this._patientID = value;
					this.SendPropertyChanged("PatientID");
					this.OnPatientIDChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_patients", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientAppointments_0", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Patients Patients
		{
			get
			{
				return this._patients.Entity;
			}
			set
			{
				if (((this._patients.Entity == value) 
							== false))
				{
					if ((this._patients.Entity != null))
					{
						Patients previousPatients = this._patients.Entity;
						this._patients.Entity = null;
						previousPatients.PatientAppointments.Remove(this);
					}
					this._patients.Entity = value;
					if ((value != null))
					{
						value.PatientAppointments.Add(this);
						_patientID = value.PatientID;
					}
					else
					{
						_patientID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.PatientConditions")]
	public partial class PatientConditions : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _conditionID;
		
		private int _patientConditionID;
		
		private int _patientID;
		
		private EntityRef<Conditions> _conditions = new EntityRef<Conditions>();
		
		private EntityRef<Patients> _patients = new EntityRef<Patients>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnConditionIDChanged();
		
		partial void OnConditionIDChanging(int value);
		
		partial void OnPatientConditionIDChanged();
		
		partial void OnPatientConditionIDChanging(int value);
		
		partial void OnPatientIDChanged();
		
		partial void OnPatientIDChanging(int value);
		#endregion
		
		
		public PatientConditions()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_conditionID", Name="ConditionID", DbType="INTEGER", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ConditionID
		{
			get
			{
				return this._conditionID;
			}
			set
			{
				if ((_conditionID != value))
				{
					if (_conditions.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnConditionIDChanging(value);
					this.SendPropertyChanging();
					this._conditionID = value;
					this.SendPropertyChanged("ConditionID");
					this.OnConditionIDChanged();
				}
			}
		}
		
		[Column(Storage="_patientConditionID", Name="PatientConditionID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PatientConditionID
		{
			get
			{
				return this._patientConditionID;
			}
			set
			{
				if ((_patientConditionID != value))
				{
					this.OnPatientConditionIDChanging(value);
					this.SendPropertyChanging();
					this._patientConditionID = value;
					this.SendPropertyChanged("PatientConditionID");
					this.OnPatientConditionIDChanged();
				}
			}
		}
		
		[Column(Storage="_patientID", Name="PatientID", DbType="INTEGER", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PatientID
		{
			get
			{
				return this._patientID;
			}
			set
			{
				if ((_patientID != value))
				{
					if (_patients.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPatientIDChanging(value);
					this.SendPropertyChanging();
					this._patientID = value;
					this.SendPropertyChanged("PatientID");
					this.OnPatientIDChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_conditions", OtherKey="ConditionID", ThisKey="ConditionID", Name="fk_PatientConditions_0", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Conditions Conditions
		{
			get
			{
				return this._conditions.Entity;
			}
			set
			{
				if (((this._conditions.Entity == value) 
							== false))
				{
					if ((this._conditions.Entity != null))
					{
						Conditions previousConditions = this._conditions.Entity;
						this._conditions.Entity = null;
						previousConditions.PatientConditions.Remove(this);
					}
					this._conditions.Entity = value;
					if ((value != null))
					{
						value.PatientConditions.Add(this);
						_conditionID = value.ConditionID;
					}
					else
					{
						_conditionID = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_patients", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientConditions_1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Patients Patients
		{
			get
			{
				return this._patients.Entity;
			}
			set
			{
				if (((this._patients.Entity == value) 
							== false))
				{
					if ((this._patients.Entity != null))
					{
						Patients previousPatients = this._patients.Entity;
						this._patients.Entity = null;
						previousPatients.PatientConditions.Remove(this);
					}
					this._patients.Entity = value;
					if ((value != null))
					{
						value.PatientConditions.Add(this);
						_patientID = value.PatientID;
					}
					else
					{
						_patientID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.PatientRecallDates")]
	public partial class PatientRecallDates : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _date;
		
		private int _patientID;
		
		private int _recallID;
		
		private EntityRef<Patients> _patients = new EntityRef<Patients>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateChanged();
		
		partial void OnDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnPatientIDChanged();
		
		partial void OnPatientIDChanging(int value);
		
		partial void OnRecallIDChanged();
		
		partial void OnRecallIDChanging(int value);
		#endregion
		
		
		public PatientRecallDates()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_date", Name="Date", DbType="DATETIME", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((_date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[Column(Storage="_patientID", Name="PatientID", DbType="INTEGER", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PatientID
		{
			get
			{
				return this._patientID;
			}
			set
			{
				if ((_patientID != value))
				{
					if (_patients.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPatientIDChanging(value);
					this.SendPropertyChanging();
					this._patientID = value;
					this.SendPropertyChanged("PatientID");
					this.OnPatientIDChanged();
				}
			}
		}
		
		[Column(Storage="_recallID", Name="RecallID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int RecallID
		{
			get
			{
				return this._recallID;
			}
			set
			{
				if ((_recallID != value))
				{
					this.OnRecallIDChanging(value);
					this.SendPropertyChanging();
					this._recallID = value;
					this.SendPropertyChanged("RecallID");
					this.OnRecallIDChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_patients", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientRecallDates_0", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Patients Patients
		{
			get
			{
				return this._patients.Entity;
			}
			set
			{
				if (((this._patients.Entity == value) 
							== false))
				{
					if ((this._patients.Entity != null))
					{
						Patients previousPatients = this._patients.Entity;
						this._patients.Entity = null;
						previousPatients.PatientRecallDates.Remove(this);
					}
					this._patients.Entity = value;
					if ((value != null))
					{
						value.PatientRecallDates.Add(this);
						_patientID = value.PatientID;
					}
					else
					{
						_patientID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Patients")]
	public partial class Patients : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _address;
		
		private System.Nullable<System.DateTime> _dateOfBirth;
		
		private string _email;
		
		private string _name;
		
		private string _nhsnUmber;
		
		private int _patientID;
		
		private string _telNum;
		
		private EntitySet<PatientAppointments> _patientAppointments;
		
		private EntitySet<PatientConditions> _patientConditions;
		
		private EntitySet<PatientRecallDates> _patientRecallDates;
		
		private EntitySet<PatientTestResults> _patientTestResults;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAddressChanged();
		
		partial void OnAddressChanging(string value);
		
		partial void OnDateOfBirthChanged();
		
		partial void OnDateOfBirthChanging(System.Nullable<System.DateTime> value);
		
		partial void OnEmailChanged();
		
		partial void OnEmailChanging(string value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnNhsnUmberChanged();
		
		partial void OnNhsnUmberChanging(string value);
		
		partial void OnPatientIDChanged();
		
		partial void OnPatientIDChanging(int value);
		
		partial void OnTelNumChanged();
		
		partial void OnTelNumChanging(string value);
		#endregion
		
		
		public Patients()
		{
			_patientAppointments = new EntitySet<PatientAppointments>(new Action<PatientAppointments>(this.PatientAppointments_Attach), new Action<PatientAppointments>(this.PatientAppointments_Detach));
			_patientConditions = new EntitySet<PatientConditions>(new Action<PatientConditions>(this.PatientConditions_Attach), new Action<PatientConditions>(this.PatientConditions_Detach));
			_patientRecallDates = new EntitySet<PatientRecallDates>(new Action<PatientRecallDates>(this.PatientRecallDates_Attach), new Action<PatientRecallDates>(this.PatientRecallDates_Detach));
			_patientTestResults = new EntitySet<PatientTestResults>(new Action<PatientTestResults>(this.PatientTestResults_Attach), new Action<PatientTestResults>(this.PatientTestResults_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_address", Name="Address", DbType="NTEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Address
		{
			get
			{
				return this._address;
			}
			set
			{
				if (((_address == value) 
							== false))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[Column(Storage="_dateOfBirth", Name="DateOfBirth", DbType="DATETIME", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._dateOfBirth;
			}
			set
			{
				if ((_dateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._dateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[Column(Storage="_email", Name="Email", DbType="NTEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				if (((_email == value) 
							== false))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="Name", DbType="NTEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_nhsnUmber", Name="NHSNumber", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string NhsnUmber
		{
			get
			{
				return this._nhsnUmber;
			}
			set
			{
				if (((_nhsnUmber == value) 
							== false))
				{
					this.OnNhsnUmberChanging(value);
					this.SendPropertyChanging();
					this._nhsnUmber = value;
					this.SendPropertyChanged("NhsnUmber");
					this.OnNhsnUmberChanged();
				}
			}
		}
		
		[Column(Storage="_patientID", Name="PatientID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PatientID
		{
			get
			{
				return this._patientID;
			}
			set
			{
				if ((_patientID != value))
				{
					this.OnPatientIDChanging(value);
					this.SendPropertyChanging();
					this._patientID = value;
					this.SendPropertyChanged("PatientID");
					this.OnPatientIDChanged();
				}
			}
		}
		
		[Column(Storage="_telNum", Name="TelNum", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string TelNum
		{
			get
			{
				return this._telNum;
			}
			set
			{
				if (((_telNum == value) 
							== false))
				{
					this.OnTelNumChanging(value);
					this.SendPropertyChanging();
					this._telNum = value;
					this.SendPropertyChanged("TelNum");
					this.OnTelNumChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_patientAppointments", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientAppointments_0")]
		[DebuggerNonUserCode()]
		public EntitySet<PatientAppointments> PatientAppointments
		{
			get
			{
				return this._patientAppointments;
			}
			set
			{
				this._patientAppointments = value;
			}
		}
		
		[Association(Storage="_patientConditions", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientConditions_1")]
		[DebuggerNonUserCode()]
		public EntitySet<PatientConditions> PatientConditions
		{
			get
			{
				return this._patientConditions;
			}
			set
			{
				this._patientConditions = value;
			}
		}
		
		[Association(Storage="_patientRecallDates", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientRecallDates_0")]
		[DebuggerNonUserCode()]
		public EntitySet<PatientRecallDates> PatientRecallDates
		{
			get
			{
				return this._patientRecallDates;
			}
			set
			{
				this._patientRecallDates = value;
			}
		}
		
		[Association(Storage="_patientTestResults", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientTestResults_0")]
		[DebuggerNonUserCode()]
		public EntitySet<PatientTestResults> PatientTestResults
		{
			get
			{
				return this._patientTestResults;
			}
			set
			{
				this._patientTestResults = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void PatientAppointments_Attach(PatientAppointments entity)
		{
			this.SendPropertyChanging();
			entity.Patients = this;
		}
		
		private void PatientAppointments_Detach(PatientAppointments entity)
		{
			this.SendPropertyChanging();
			entity.Patients = null;
		}
		
		private void PatientConditions_Attach(PatientConditions entity)
		{
			this.SendPropertyChanging();
			entity.Patients = this;
		}
		
		private void PatientConditions_Detach(PatientConditions entity)
		{
			this.SendPropertyChanging();
			entity.Patients = null;
		}
		
		private void PatientRecallDates_Attach(PatientRecallDates entity)
		{
			this.SendPropertyChanging();
			entity.Patients = this;
		}
		
		private void PatientRecallDates_Detach(PatientRecallDates entity)
		{
			this.SendPropertyChanging();
			entity.Patients = null;
		}
		
		private void PatientTestResults_Attach(PatientTestResults entity)
		{
			this.SendPropertyChanging();
			entity.Patients = this;
		}
		
		private void PatientTestResults_Detach(PatientTestResults entity)
		{
			this.SendPropertyChanging();
			entity.Patients = null;
		}
		#endregion
	}
	
	[Table(Name="main.PatientTestResults")]
	public partial class PatientTestResults : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _date;
		
		private int _patientID;
		
		private string _results;
		
		private int _testID;
		
		private int _userID;
		
		private EntityRef<Patients> _patients = new EntityRef<Patients>();
		
		private EntityRef<Users> _users = new EntityRef<Users>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateChanged();
		
		partial void OnDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnPatientIDChanged();
		
		partial void OnPatientIDChanging(int value);
		
		partial void OnResultsChanged();
		
		partial void OnResultsChanging(string value);
		
		partial void OnTestIDChanged();
		
		partial void OnTestIDChanging(int value);
		
		partial void OnUserIDChanged();
		
		partial void OnUserIDChanging(int value);
		#endregion
		
		
		public PatientTestResults()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_date", Name="Date", DbType="DATETIME", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((_date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[Column(Storage="_patientID", Name="PatientID", DbType="INTEGER", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PatientID
		{
			get
			{
				return this._patientID;
			}
			set
			{
				if ((_patientID != value))
				{
					if (_patients.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPatientIDChanging(value);
					this.SendPropertyChanging();
					this._patientID = value;
					this.SendPropertyChanged("PatientID");
					this.OnPatientIDChanged();
				}
			}
		}
		
		[Column(Storage="_results", Name="Results", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Results
		{
			get
			{
				return this._results;
			}
			set
			{
				if (((_results == value) 
							== false))
				{
					this.OnResultsChanging(value);
					this.SendPropertyChanging();
					this._results = value;
					this.SendPropertyChanged("Results");
					this.OnResultsChanged();
				}
			}
		}
		
		[Column(Storage="_testID", Name="TestID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TestID
		{
			get
			{
				return this._testID;
			}
			set
			{
				if ((_testID != value))
				{
					this.OnTestIDChanging(value);
					this.SendPropertyChanging();
					this._testID = value;
					this.SendPropertyChanged("TestID");
					this.OnTestIDChanged();
				}
			}
		}
		
		[Column(Storage="_userID", Name="UserID", DbType="INTEGER", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int UserID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					if (_users.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_patients", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientTestResults_0", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Patients Patients
		{
			get
			{
				return this._patients.Entity;
			}
			set
			{
				if (((this._patients.Entity == value) 
							== false))
				{
					if ((this._patients.Entity != null))
					{
						Patients previousPatients = this._patients.Entity;
						this._patients.Entity = null;
						previousPatients.PatientTestResults.Remove(this);
					}
					this._patients.Entity = value;
					if ((value != null))
					{
						value.PatientTestResults.Add(this);
						_patientID = value.PatientID;
					}
					else
					{
						_patientID = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_users", OtherKey="UserID", ThisKey="UserID", Name="fk_PatientTestResults_1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Users Users
		{
			get
			{
				return this._users.Entity;
			}
			set
			{
				if (((this._users.Entity == value) 
							== false))
				{
					if ((this._users.Entity != null))
					{
						Users previousUsers = this._users.Entity;
						this._users.Entity = null;
						previousUsers.PatientTestResults.Remove(this);
					}
					this._users.Entity = value;
					if ((value != null))
					{
						value.PatientTestResults.Add(this);
						_userID = value.UserID;
					}
					else
					{
						_userID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Settings")]
	public partial class Settings : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _name;
		
		private int _settingID;
		
		private string _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnSettingIDChanged();
		
		partial void OnSettingIDChanging(int value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(string value);
		#endregion
		
		
		public Settings()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_name", Name="Name", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_settingID", Name="SettingID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SettingID
		{
			get
			{
				return this._settingID;
			}
			set
			{
				if ((_settingID != value))
				{
					this.OnSettingIDChanging(value);
					this.SendPropertyChanging();
					this._settingID = value;
					this.SendPropertyChanged("SettingID");
					this.OnSettingIDChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="Value", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (((_value == value) 
							== false))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="main.Users")]
	public partial class Users : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _fullname;
		
		private string _password;
		
		private string _passwordHashMethod;
		
		private int _userID;
		
		private string _username;
		
		private EntitySet<PatientTestResults> _patientTestResults;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnFullnameChanged();
		
		partial void OnFullnameChanging(string value);
		
		partial void OnPasswordChanged();
		
		partial void OnPasswordChanging(string value);
		
		partial void OnPasswordHashMethodChanged();
		
		partial void OnPasswordHashMethodChanging(string value);
		
		partial void OnUserIDChanged();
		
		partial void OnUserIDChanging(int value);
		
		partial void OnUsernameChanged();
		
		partial void OnUsernameChanging(string value);
		#endregion
		
		
		public Users()
		{
			_patientTestResults = new EntitySet<PatientTestResults>(new Action<PatientTestResults>(this.PatientTestResults_Attach), new Action<PatientTestResults>(this.PatientTestResults_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_fullname", Name="Fullname", DbType="NTEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Fullname
		{
			get
			{
				return this._fullname;
			}
			set
			{
				if (((_fullname == value) 
							== false))
				{
					this.OnFullnameChanging(value);
					this.SendPropertyChanging();
					this._fullname = value;
					this.SendPropertyChanged("Fullname");
					this.OnFullnameChanged();
				}
			}
		}
		
		[Column(Storage="_password", Name="Password", DbType="NTEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				if (((_password == value) 
							== false))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[Column(Storage="_passwordHashMethod", Name="PasswordHashMethod", DbType="TEXT( 4 )", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PasswordHashMethod
		{
			get
			{
				return this._passwordHashMethod;
			}
			set
			{
				if (((_passwordHashMethod == value) 
							== false))
				{
					this.OnPasswordHashMethodChanging(value);
					this.SendPropertyChanging();
					this._passwordHashMethod = value;
					this.SendPropertyChanged("PasswordHashMethod");
					this.OnPasswordHashMethodChanged();
				}
			}
		}
		
		[Column(Storage="_userID", Name="UserID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int UserID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((_userID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[Column(Storage="_username", Name="Username", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Username
		{
			get
			{
				return this._username;
			}
			set
			{
				if (((_username == value) 
							== false))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_patientTestResults", OtherKey="UserID", ThisKey="UserID", Name="fk_PatientTestResults_1")]
		[DebuggerNonUserCode()]
		public EntitySet<PatientTestResults> PatientTestResults
		{
			get
			{
				return this._patientTestResults;
			}
			set
			{
				this._patientTestResults = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void PatientTestResults_Attach(PatientTestResults entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void PatientTestResults_Detach(PatientTestResults entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
		#endregion
	}
}
