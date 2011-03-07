-- Table: Users
CREATE TABLE Users ( 
    UserID             INTEGER    PRIMARY KEY AUTOINCREMENT,
    Username           TEXT,
    Password           NTEXT,
    Fullname           NTEXT,
    PasswordHashMethod TEXT( 4 ) 
);


-- Table: Conditions
CREATE TABLE Conditions ( 
    ConditionID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    Condition   TEXT 
);


-- Table: Patients
CREATE TABLE Patients ( 
    PatientID   INTEGER NOT NULL  PRIMARY KEY AUTOINCREMENT,
    Name        NTEXT,
    Address     NTEXT,
    TelNum      TEXT,
    DateOfBirth DATETIME,
    NHSNumber   TEXT,
    Email       NTEXT 
);


-- Table: PatientTestResults
CREATE TABLE PatientTestResults ( 
    TestID    INTEGER  PRIMARY KEY AUTOINCREMENT,
    UserID    INTEGER  REFERENCES Users ( UserID ),
    PatientID INTEGER  NOT NULL REFERENCES Patients ( PatientID ),
    Date      DATETIME,
    Results   TEXT 
);


-- Table: PatientAppointments
CREATE TABLE PatientAppointments ( 
    AppointmentID INTEGER  PRIMARY KEY AUTOINCREMENT,
    PatientID     INTEGER NOT NULL  REFERENCES Patients ( PatientID ),
    DateTime      DATETIME 
);


-- Table: PatientConditions
CREATE TABLE PatientConditions ( 
    PatientConditionID INTEGER PRIMARY KEY AUTOINCREMENT,
    PatientID          INTEGER NOT NULL REFERENCES Patients ( PatientID ),
    ConditionID        INTEGER NOT NULL REFERENCES Conditions ( ConditionID )
);


-- Table: PatientRecallDates
CREATE TABLE PatientRecallDates ( 
    RecallID  INTEGER  PRIMARY KEY AUTOINCREMENT,
    PatientID INTEGER NOT NULL  REFERENCES Patients ( PatientID ),
    Date      DATETIME 
);
