-- Table: Users
CREATE TABLE Users ( 
	UserID             INTEGER NOT NULL
							   PRIMARY KEY AUTOINCREMENT,
	Username           TEXT,
	Password           NTEXT,
	Fullname           NTEXT,
	PasswordHashMethod INTEGER NOT NULL 
);


-- Table: Conditions
CREATE TABLE Conditions ( 
	ConditionID INTEGER NOT NULL
						PRIMARY KEY AUTOINCREMENT,
	Condition   TEXT 
);


-- Table: Patients
CREATE TABLE Patients ( 
	PatientID             INTEGER     NOT NULL
									  PRIMARY KEY AUTOINCREMENT,
	Name                  NTEXT,
	Address               NTEXT,
	TelNum                TEXT,
	DateOfBirth           DATETIME NOT NULL,
	NHSNumber             TEXT( 10 ),
	Email                 NTEXT,
	PreferredRecallMethod INTEGER     NOT NULL 
);


-- Table: PatientTestResults
CREATE TABLE PatientTestResults ( 
	TestID    INTEGER  NOT NULL
					   PRIMARY KEY AUTOINCREMENT,
	UserID    INTEGER  NOT NULL
					   REFERENCES Users ( UserID ),
	PatientID INTEGER  NOT NULL
					   REFERENCES Patients ( PatientID ),
	Date      DATETIME,
	Remarks   TEXT,
	LSPH         TEXT,
	RSPH         TEXT,
	LVA1         TEXT,
	LVA2         TEXT,
	RVA1         TEXT,
	RVA2         TEXT,
	LCYL         TEXT,
	RCYL         TEXT,
	LAXIS         TEXT,
	RAXIS         TEXT
);


-- Table: PatientAppointments
CREATE TABLE PatientAppointments ( 
	AppointmentID INTEGER  NOT NULL
						   PRIMARY KEY AUTOINCREMENT,
	PatientID     INTEGER  NOT NULL
						   REFERENCES Patients ( PatientID ),
	UserID        INTEGER  NOT NULL
						   REFERENCES Users ( UserID ),
	Remarks       TEXT,
	StartDateTime      DATETIME NOT NULL,
	EndDateTime        DATETIME NOT NULL
);


-- Table: PatientConditions
CREATE TABLE PatientConditions ( 
	PatientConditionID INTEGER NOT NULL
							   PRIMARY KEY AUTOINCREMENT,
	PatientID          INTEGER NOT NULL
							   REFERENCES Patients ( PatientID ),
	ConditionID        INTEGER NOT NULL
							   REFERENCES Conditions ( ConditionID ) 
);


-- Table: PatientRecalls
CREATE TABLE PatientRecalls ( 
	RecallID        INTEGER  NOT NULL
							 PRIMARY KEY AUTOINCREMENT,
	PatientID       INTEGER  NOT NULL
							 REFERENCES Patients ( PatientID ),
	DateAndPrefTime DATETIME,
	Reason          TEXT,
	Method          INTEGER  NOT NULL 
);


-- Table: Settings
CREATE TABLE Settings ( 
	SettingID INTEGER NOT NULL
					  PRIMARY KEY AUTOINCREMENT,
	Name      TEXT,
	Value     TEXT 
);


-- Table: Emails
CREATE TABLE Emails ( 
	EmailID INTEGER NOT NULL
					PRIMARY KEY AUTOINCREMENT,
	Name    TEXT,
	Value   TEXT 
);



