// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from OpticianDB on 2011-03-27 19:34:26Z.
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
		
		public Table<Emails> Emails
		{
			get
			{
				return this.GetTable<Emails>();
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
		
		public Table<PatientRecalls> PatientRecalls
		{
			get
			{
				return this.GetTable<PatientRecalls>();
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
	
	[Table(Name="main.Emails")]
	public partial class Emails : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _emailID;
		
		private string _name;
		
		private string _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnEmailIDChanged();
		
		partial void OnEmailIDChanging(int value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(string value);
		#endregion
		
		
		public Emails()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_emailID", Name="EmailID", DbType="INTEGER", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int EmailID
		{
			get
			{
				return this._emailID;
			}
			set
			{
				if ((_emailID != value))
				{
					this.OnEmailIDChanging(value);
					this.SendPropertyChanging();
					this._emailID = value;
					this.SendPropertyChanged("EmailID");
					this.OnEmailIDChanged();
				}
			}
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
	
	[Table(Name="main.PatientAppointments")]
	public partial class PatientAppointments : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _appointmentID;
		
		private System.DateTime _endDateTime;
		
		private int _patientID;
		
		private string _remarks;
		
		private System.DateTime _startDateTime;
		
		private int _userID;
		
		private EntityRef<Users> _users = new EntityRef<Users>();
		
		private EntityRef<Patients> _patients = new EntityRef<Patients>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAppointmentIDChanged();
		
		partial void OnAppointmentIDChanging(int value);
		
		partial void OnEndDateTimeChanged();
		
		partial void OnEndDateTimeChanging(System.DateTime value);
		
		partial void OnPatientIDChanged();
		
		partial void OnPatientIDChanging(int value);
		
		partial void OnRemarksChanged();
		
		partial void OnRemarksChanging(string value);
		
		partial void OnStartDateTimeChanged();
		
		partial void OnStartDateTimeChanging(System.DateTime value);
		
		partial void OnUserIDChanged();
		
		partial void OnUserIDChanging(int value);
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
		
		[Column(Storage="_endDateTime", Name="EndDateTime", DbType="DATETIME", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime EndDateTime
		{
			get
			{
				return this._endDateTime;
			}
			set
			{
				if ((_endDateTime != value))
				{
					this.OnEndDateTimeChanging(value);
					this.SendPropertyChanging();
					this._endDateTime = value;
					this.SendPropertyChanged("EndDateTime");
					this.OnEndDateTimeChanged();
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
		
		[Column(Storage="_remarks", Name="Remarks", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Remarks
		{
			get
			{
				return this._remarks;
			}
			set
			{
				if (((_remarks == value) 
							== false))
				{
					this.OnRemarksChanging(value);
					this.SendPropertyChanging();
					this._remarks = value;
					this.SendPropertyChanged("Remarks");
					this.OnRemarksChanged();
				}
			}
		}
		
		[Column(Storage="_startDateTime", Name="StartDateTime", DbType="DATETIME", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime StartDateTime
		{
			get
			{
				return this._startDateTime;
			}
			set
			{
				if ((_startDateTime != value))
				{
					this.OnStartDateTimeChanging(value);
					this.SendPropertyChanging();
					this._startDateTime = value;
					this.SendPropertyChanged("StartDateTime");
					this.OnStartDateTimeChanged();
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
		[Association(Storage="_users", OtherKey="UserID", ThisKey="UserID", Name="fk_PatientAppointments_0", IsForeignKey=true)]
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
						previousUsers.PatientAppointments.Remove(this);
					}
					this._users.Entity = value;
					if ((value != null))
					{
						value.PatientAppointments.Add(this);
						_userID = value.UserID;
					}
					else
					{
						_userID = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_patients", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientAppointments_1", IsForeignKey=true)]
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
	
	[Table(Name="main.PatientRecalls")]
	public partial class PatientRecalls : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _dateAndPrefTime;
		
		private int _method;
		
		private int _patientID;
		
		private string _reason;
		
		private int _recallID;
		
		private EntityRef<Patients> _patients = new EntityRef<Patients>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAndPrefTimeChanged();
		
		partial void OnDateAndPrefTimeChanging(System.Nullable<System.DateTime> value);
		
		partial void OnMethodChanged();
		
		partial void OnMethodChanging(int value);
		
		partial void OnPatientIDChanged();
		
		partial void OnPatientIDChanging(int value);
		
		partial void OnReasonChanged();
		
		partial void OnReasonChanging(string value);
		
		partial void OnRecallIDChanged();
		
		partial void OnRecallIDChanging(int value);
		#endregion
		
		
		public PatientRecalls()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAndPrefTime", Name="DateAndPrefTime", DbType="DATETIME", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateAndPrefTime
		{
			get
			{
				return this._dateAndPrefTime;
			}
			set
			{
				if ((_dateAndPrefTime != value))
				{
					this.OnDateAndPrefTimeChanging(value);
					this.SendPropertyChanging();
					this._dateAndPrefTime = value;
					this.SendPropertyChanged("DateAndPrefTime");
					this.OnDateAndPrefTimeChanged();
				}
			}
		}
		
		[Column(Storage="_method", Name="Method", DbType="INTEGER", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Method
		{
			get
			{
				return this._method;
			}
			set
			{
				if ((_method != value))
				{
					this.OnMethodChanging(value);
					this.SendPropertyChanging();
					this._method = value;
					this.SendPropertyChanged("Method");
					this.OnMethodChanged();
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
		
		[Column(Storage="_reason", Name="Reason", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				if (((_reason == value) 
							== false))
				{
					this.OnReasonChanging(value);
					this.SendPropertyChanging();
					this._reason = value;
					this.SendPropertyChanged("Reason");
					this.OnReasonChanged();
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
		[Association(Storage="_patients", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientRecalls_0", IsForeignKey=true)]
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
						previousPatients.PatientRecalls.Remove(this);
					}
					this._patients.Entity = value;
					if ((value != null))
					{
						value.PatientRecalls.Add(this);
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
		
		private int _preferredRecallMethod;
		
		private string _telNum;
		
		private EntitySet<PatientAppointments> _patientAppointments;
		
		private EntitySet<PatientConditions> _patientConditions;
		
		private EntitySet<PatientRecalls> _patientRecalls;
		
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
		
		partial void OnPreferredRecallMethodChanged();
		
		partial void OnPreferredRecallMethodChanging(int value);
		
		partial void OnTelNumChanged();
		
		partial void OnTelNumChanging(string value);
		#endregion
		
		
		public Patients()
		{
			_patientAppointments = new EntitySet<PatientAppointments>(new Action<PatientAppointments>(this.PatientAppointments_Attach), new Action<PatientAppointments>(this.PatientAppointments_Detach));
			_patientConditions = new EntitySet<PatientConditions>(new Action<PatientConditions>(this.PatientConditions_Attach), new Action<PatientConditions>(this.PatientConditions_Detach));
			_patientRecalls = new EntitySet<PatientRecalls>(new Action<PatientRecalls>(this.PatientRecalls_Attach), new Action<PatientRecalls>(this.PatientRecalls_Detach));
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
		
		[Column(Storage="_nhsnUmber", Name="NHSNumber", DbType="TEXT( 10 )", AutoSync=AutoSync.Never)]
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
		
		[Column(Storage="_preferredRecallMethod", Name="PreferredRecallMethod", DbType="INTEGER", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PreferredRecallMethod
		{
			get
			{
				return this._preferredRecallMethod;
			}
			set
			{
				if ((_preferredRecallMethod != value))
				{
					this.OnPreferredRecallMethodChanging(value);
					this.SendPropertyChanging();
					this._preferredRecallMethod = value;
					this.SendPropertyChanged("PreferredRecallMethod");
					this.OnPreferredRecallMethodChanged();
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
		[Association(Storage="_patientAppointments", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientAppointments_1")]
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
		
		[Association(Storage="_patientRecalls", OtherKey="PatientID", ThisKey="PatientID", Name="fk_PatientRecalls_0")]
		[DebuggerNonUserCode()]
		public EntitySet<PatientRecalls> PatientRecalls
		{
			get
			{
				return this._patientRecalls;
			}
			set
			{
				this._patientRecalls = value;
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
		
		private void PatientRecalls_Attach(PatientRecalls entity)
		{
			this.SendPropertyChanging();
			entity.Patients = this;
		}
		
		private void PatientRecalls_Detach(PatientRecalls entity)
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
		
		private string _laxIs;
		
		private string _lcYl;
		
		private string _lsPH;
		
		private string _lva1;
		
		private string _lva2;
		
		private int _patientID;
		
		private string _raXis;
		
		private string _rcYl;
		
		private string _results;
		
		private string _rsPH;
		
		private string _rvA1;
		
		private string _rvA2;
		
		private int _testID;
		
		private int _userID;
		
		private EntityRef<Patients> _patients = new EntityRef<Patients>();
		
		private EntityRef<Users> _users = new EntityRef<Users>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateChanged();
		
		partial void OnDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLaxIsChanged();
		
		partial void OnLaxIsChanging(string value);
		
		partial void OnLcYLChanged();
		
		partial void OnLcYLChanging(string value);
		
		partial void OnLSpHChanged();
		
		partial void OnLSpHChanging(string value);
		
		partial void OnLVA1Changed();
		
		partial void OnLVA1Changing(string value);
		
		partial void OnLVA2Changed();
		
		partial void OnLVA2Changing(string value);
		
		partial void OnPatientIDChanged();
		
		partial void OnPatientIDChanging(int value);
		
		partial void OnRAxisChanged();
		
		partial void OnRAxisChanging(string value);
		
		partial void OnRcYLChanged();
		
		partial void OnRcYLChanging(string value);
		
		partial void OnResultsChanged();
		
		partial void OnResultsChanging(string value);
		
		partial void OnRSpHChanged();
		
		partial void OnRSpHChanging(string value);
		
		partial void OnRvA1Changed();
		
		partial void OnRvA1Changing(string value);
		
		partial void OnRvA2Changed();
		
		partial void OnRvA2Changing(string value);
		
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
		
		[Column(Storage="_laxIs", Name="LAXIS", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LaxIs
		{
			get
			{
				return this._laxIs;
			}
			set
			{
				if (((_laxIs == value) 
							== false))
				{
					this.OnLaxIsChanging(value);
					this.SendPropertyChanging();
					this._laxIs = value;
					this.SendPropertyChanged("LaxIs");
					this.OnLaxIsChanged();
				}
			}
		}
		
		[Column(Storage="_lcYl", Name="LCYL", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LcYL
		{
			get
			{
				return this._lcYl;
			}
			set
			{
				if (((_lcYl == value) 
							== false))
				{
					this.OnLcYLChanging(value);
					this.SendPropertyChanging();
					this._lcYl = value;
					this.SendPropertyChanged("LcYL");
					this.OnLcYLChanged();
				}
			}
		}
		
		[Column(Storage="_lsPH", Name="LSPH", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LSpH
		{
			get
			{
				return this._lsPH;
			}
			set
			{
				if (((_lsPH == value) 
							== false))
				{
					this.OnLSpHChanging(value);
					this.SendPropertyChanging();
					this._lsPH = value;
					this.SendPropertyChanged("LSpH");
					this.OnLSpHChanged();
				}
			}
		}
		
		[Column(Storage="_lva1", Name="LVA1", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LVA1
		{
			get
			{
				return this._lva1;
			}
			set
			{
				if (((_lva1 == value) 
							== false))
				{
					this.OnLVA1Changing(value);
					this.SendPropertyChanging();
					this._lva1 = value;
					this.SendPropertyChanged("LVA1");
					this.OnLVA1Changed();
				}
			}
		}
		
		[Column(Storage="_lva2", Name="LVA2", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string LVA2
		{
			get
			{
				return this._lva2;
			}
			set
			{
				if (((_lva2 == value) 
							== false))
				{
					this.OnLVA2Changing(value);
					this.SendPropertyChanging();
					this._lva2 = value;
					this.SendPropertyChanged("LVA2");
					this.OnLVA2Changed();
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
		
		[Column(Storage="_raXis", Name="RAXIS", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RAxis
		{
			get
			{
				return this._raXis;
			}
			set
			{
				if (((_raXis == value) 
							== false))
				{
					this.OnRAxisChanging(value);
					this.SendPropertyChanging();
					this._raXis = value;
					this.SendPropertyChanged("RAxis");
					this.OnRAxisChanged();
				}
			}
		}
		
		[Column(Storage="_rcYl", Name="RCYL", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RcYL
		{
			get
			{
				return this._rcYl;
			}
			set
			{
				if (((_rcYl == value) 
							== false))
				{
					this.OnRcYLChanging(value);
					this.SendPropertyChanging();
					this._rcYl = value;
					this.SendPropertyChanged("RcYL");
					this.OnRcYLChanged();
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
		
		[Column(Storage="_rsPH", Name="RSPH", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RSpH
		{
			get
			{
				return this._rsPH;
			}
			set
			{
				if (((_rsPH == value) 
							== false))
				{
					this.OnRSpHChanging(value);
					this.SendPropertyChanging();
					this._rsPH = value;
					this.SendPropertyChanged("RSpH");
					this.OnRSpHChanged();
				}
			}
		}
		
		[Column(Storage="_rvA1", Name="RVA1", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RvA1
		{
			get
			{
				return this._rvA1;
			}
			set
			{
				if (((_rvA1 == value) 
							== false))
				{
					this.OnRvA1Changing(value);
					this.SendPropertyChanging();
					this._rvA1 = value;
					this.SendPropertyChanged("RvA1");
					this.OnRvA1Changed();
				}
			}
		}
		
		[Column(Storage="_rvA2", Name="RVA2", DbType="TEXT", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RvA2
		{
			get
			{
				return this._rvA2;
			}
			set
			{
				if (((_rvA2 == value) 
							== false))
				{
					this.OnRvA2Changing(value);
					this.SendPropertyChanging();
					this._rvA2 = value;
					this.SendPropertyChanged("RvA2");
					this.OnRvA2Changed();
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
		
		private int _passwordHashMethod;
		
		private int _userID;
		
		private string _username;
		
		private EntitySet<PatientAppointments> _patientAppointments;
		
		private EntitySet<PatientTestResults> _patientTestResults;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnFullnameChanged();
		
		partial void OnFullnameChanging(string value);
		
		partial void OnPasswordChanged();
		
		partial void OnPasswordChanging(string value);
		
		partial void OnPasswordHashMethodChanged();
		
		partial void OnPasswordHashMethodChanging(int value);
		
		partial void OnUserIDChanged();
		
		partial void OnUserIDChanging(int value);
		
		partial void OnUsernameChanged();
		
		partial void OnUsernameChanging(string value);
		#endregion
		
		
		public Users()
		{
			_patientAppointments = new EntitySet<PatientAppointments>(new Action<PatientAppointments>(this.PatientAppointments_Attach), new Action<PatientAppointments>(this.PatientAppointments_Detach));
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
		
		[Column(Storage="_passwordHashMethod", Name="PasswordHashMethod", DbType="INTEGER", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PasswordHashMethod
		{
			get
			{
				return this._passwordHashMethod;
			}
			set
			{
				if ((_passwordHashMethod != value))
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
		[Association(Storage="_patientAppointments", OtherKey="UserID", ThisKey="UserID", Name="fk_PatientAppointments_0")]
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
		private void PatientAppointments_Attach(PatientAppointments entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void PatientAppointments_Detach(PatientAppointments entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
		
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
