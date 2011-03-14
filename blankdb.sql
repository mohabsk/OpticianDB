-- Table: Users
CREATE TABLE Users ( 
    UserID             INTEGER    NOT NULL
                                  PRIMARY KEY AUTOINCREMENT,
    Username           TEXT,
    Password           NTEXT,
    Fullname           NTEXT,
    PasswordHashMethod TEXT( 4 ) 
);


-- Table: Conditions
CREATE TABLE Conditions ( 
    ConditionID INTEGER NOT NULL
                        PRIMARY KEY AUTOINCREMENT,
    Condition   TEXT 
);


-- Table: Patients
CREATE TABLE Patients ( 
    PatientID   INTEGER     NOT NULL
                            PRIMARY KEY AUTOINCREMENT,
    Name        NTEXT,
    Address     NTEXT,
    TelNum      TEXT,
    DateOfBirth DATETIME,
    NHSNumber   TEXT( 10 ),
    Email       NTEXT 
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
    Results   TEXT 
);


-- Table: PatientAppointments
CREATE TABLE PatientAppointments ( 
    AppointmentID INTEGER  NOT NULL
                           PRIMARY KEY AUTOINCREMENT,
    PatientID     INTEGER  NOT NULL
                           REFERENCES Patients ( PatientID ),
    DateTime      DATETIME 
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
    RecallID  INTEGER  NOT NULL
                       PRIMARY KEY AUTOINCREMENT,
    PatientID INTEGER  NOT NULL
                       REFERENCES Patients ( PatientID ),
    Date      DATETIME 
);


-- Table: Settings
CREATE TABLE Settings ( 
    SettingID INTEGER NOT NULL
                      PRIMARY KEY AUTOINCREMENT,
    Name      TEXT,
    Value     TEXT 
);



