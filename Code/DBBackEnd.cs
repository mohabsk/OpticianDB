// 
//  Copyright (c) 2011 Geoffrey Prytherch
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy of  this
//  software and associated documentation files (the "Software"), to deal in the Software
//  without restriction, including without limitation the rights to use, copy, modify, merge,
//  publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
//  to whom the Software is furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in all copies or
//  substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//  INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
//  PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
//  FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
//  OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//  DEALINGS IN THE SOFTWARE.
//  
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using OpticianDB.Adaptor;

namespace OpticianDB
{
    /// <summary>
    ///   A class providing several inbuilt methods for performing queries on the database
    /// </summary>
    public class DBBackEnd : IDisposable
    {
        private DBAdaptor adaptor;
        private SQLiteConnection connection;
        private string connectionString;

        /// <summary>
        ///   Initializes a new instance of the <see cref = "DBBackEnd" /> class.
        ///   Connects to the database and creates one if it is not found.
        /// </summary>
        public DBBackEnd()
        {
            connectionString = "DbLinqProvider=Sqlite;Data Source=OpticianDB.db3";
            connection = new SQLiteConnection(connectionString);
            RefreshAdaptor();

            if (!File.Exists("OpticianDB.db3"))
            {
                CreateNewDB();
            }
        }

        /// <summary>
        ///   Gets a list of usernames in the database.
        /// </summary>
        /// <value>The user name list.</value>
        public IQueryable<string> UserNameList
        {
            get
            {
                return from user in adaptor.Users
                       select user.Username;
            }
        }

        public IQueryable<string> ConditionsList
        {
            get
            {
                return from cnds in adaptor.Conditions
                       orderby cnds.Condition ascending
                       select cnds.Condition;
            }
        }

        public IQueryable<string> PatientListWithNhsNumber
        {
            get
            {
                IOrderedQueryable<Patients> q = from pnts in adaptor.Patients
                                                orderby pnts.Name , pnts.NhsnUmber ascending
                                                select pnts;
                List<string> resultsList = new List<string>();
                foreach (Patients patient in q)
                {
                    string resultString = patient.NhsnUmber + " - " + patient.Name;
                    resultsList.Add(resultString);
                }

                return resultsList.AsQueryable();
            }
        }

        public IQueryable<PatientRecalls> TodaysRecalls
        {
            get
            {
                DateTime today = DateTime.Today;
                DateTime tomorrow = DateTime.Today.AddDays(1).AddMilliseconds(-1); // TODO: does this find dates after?
                return from q in adaptor.PatientRecalls
                       where q.DateAndPrefTime > today
                       where q.DateAndPrefTime.Value < tomorrow
                       select q;
            }
        }

        public IQueryable<PatientRecalls> RecallList
        {
            get
            {
                return from q in adaptor.PatientRecalls
                       orderby q.DateAndPrefTime
                       select q;
            }
        }

        // TODO: to be added
        public IQueryable<string> EmailList
        {
            get
            {
                return from q in adaptor.Emails
                       orderby q.Name
                       select q.Name;
            }
        }

        /// <summary>
        ///   Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        ///   Creates a new database and adds a default user with username/password admin/admin
        /// </summary>
        public void CreateNewDB()
        {
            Stream resourceStream =
                Assembly.GetExecutingAssembly().GetManifestResourceStream("OpticianDB.Resources.blankdb.sql");
            StreamReader textStream = new StreamReader(resourceStream);
            string newDb = textStream.ReadToEnd();

            adaptor.ExecuteCommand(newDb, null);

            CreateNewUser("admin", "admin", "Default Administrator", HashMethods.Sha1);
            // TODO: messagebox to show addition of a new user?
        }

        public IQueryable<PatientRecalls> GetRecalls(DateTime? startDate, DateTime? endDate)
        {
            if (!startDate.HasValue && endDate.HasValue)
            {
                endDate = endDate.Value.AddDays(1).AddMilliseconds(-1);
                return from q in adaptor.PatientRecalls
                       where q.DateAndPrefTime < endDate
                       orderby q.DateAndPrefTime
                       select q;
            }
            else if (startDate.HasValue && !endDate.HasValue)
            {
                return from q in adaptor.PatientRecalls
                       where q.DateAndPrefTime > startDate
                       orderby q.DateAndPrefTime
                       select q;
            }
            else if (startDate.HasValue && endDate.HasValue)
            {
                endDate = endDate.Value.AddDays(1).AddMilliseconds(-1);
                return from q in adaptor.PatientRecalls
                       where q.DateAndPrefTime < endDate
                       where q.DateAndPrefTime > startDate
                       orderby q.DateAndPrefTime
                       select q;
            }
            else
            {
                return RecallList;
            }
        }

        public bool LogOn(string userName, string password)
        {
            IQueryable<Users> q = from user in adaptor.Users
                                  where user.Username == userName
                                  select user;

            if (q.Count() == 0)
            {
                return false;
            }

            Users foundUser = q.First();

            string storedPwd = foundUser.Password;
            HashMethods hashMethod = (HashMethods) foundUser.PasswordHashMethod;
            string hashedPwd = Hashing.GetHash(password, hashMethod);

            return storedPwd == hashedPwd;
        }

        public bool CreateNewUser(string userName, string password, string fullName, HashMethods passwordHashMethod)
        {
            if (UserExists(userName))
            {
                return false;
            }

            Users newuser = new Users
                                {
                                    Fullname = fullName,
                                    Password = Hashing.GetHash(password, HashMethods.Sha1),
                                    Username = userName,
                                    PasswordHashMethod = (int) passwordHashMethod
                                };

            adaptor.Users.InsertOnSubmit(newuser);
            adaptor.SubmitChanges();

            return true;
        }

        public bool AmendUser(string editedUser, string newUserName, string password, string fullName
            /*, HashMethods hashMethod*/)
        {
            if (editedUser != newUserName && UserExists(newUserName))
            {
                return false;
            }

            Users userRec = (from uq in adaptor.Users
                             where uq.Username == editedUser
                             select uq).First();

            if (string.IsNullOrEmpty(password))
            {
                // HashMethods hashingMethod = hashMethod; // TODO: WHAAAAT??????
                HashMethods hashingMethod = HashMethods.Sha1;
                string pwHash = Hashing.GetHash(password, hashingMethod);
                if (pwHash != password)
                {
                    userRec.Password = pwHash;
                }
            }

            if (editedUser != newUserName)
            {
                userRec.Username = newUserName;
            }

            userRec.Fullname = fullName;

            adaptor.SubmitChanges();
            return true;
        }

        public Users GetUserInfo(string userName)
        {
            return (from q in adaptor.Users
                    where q.Username == userName
                    select q).First();
        }

        public int PatientIdByNhsNumber(string nhsNumber)
        {
            return (from pnts in adaptor.Patients
                    where pnts.NhsnUmber == nhsNumber
                    select pnts.PatientID).First();
        }

        public bool UserExists(string userName)
        {
            if (adaptor.Users.Count() != 0)
            {
                IQueryable<Users> existingUsers = from user in adaptor.Users
                                                  where user.Username == userName
                                                  select user;
                if (existingUsers.Count() != 0)
                {
                    return true;
                }
            }

            return false;
        }

        // rtns -1 if record exists or returns recid
        public int AddPatient(string name, string address, string telNum, DateTime dateOfBirth, string nhsNumber,
                              string email, RecallMethods preferredrecallmethod)
        {
            if (NhsNumberExists(nhsNumber))
            {
                return -1;
            }

            Patients pRec = new Patients
                                {
                                    Name = name,
                                    Address = address,
                                    TelNum = telNum,
                                    DateOfBirth = dateOfBirth,
                                    NhsnUmber = nhsNumber,
                                    Email = email,
                                    PreferredRecallMethod = (int) preferredrecallmethod
                                };

            adaptor.Patients.InsertOnSubmit(pRec);
            adaptor.SubmitChanges();

            return pRec.PatientID;
        }

        // assumes exists
        public Patients PatientRecord(int id)
        {
            return (from q in adaptor.Patients
                    where q.PatientID == id
                    select q).First();
        }

        public int AddCondition(string conditionName) // TODO: Description?
        {
            Conditions cnd = new Conditions();

            if (ConditionExists(conditionName))
            {
                return -1;
            }

            cnd.Condition = conditionName;
            adaptor.Conditions.InsertOnSubmit(cnd);
            adaptor.SubmitChanges();

            return cnd.ConditionID;
        }

        public void RemoveConditionByName(string conditionName, int patientID) // FIXME
        {
            RefreshAdaptor();
            PatientConditions condition = (from q in adaptor.PatientConditions
                                           where q.Conditions.Condition == conditionName
                                           where q.PatientID == patientID
                                           select q).First();
            adaptor.PatientConditions.DeleteOnSubmit(condition);
            //// patient.PatientConditions.Remove(condition);
            adaptor.SubmitChanges();
        }

        public bool ConditionExists(string conditionName)
        {
            int conTable = (from q in adaptor.Conditions
                            where q.Condition == conditionName
                            select q).Count();
            return conTable != 0;
        }

        public bool CanPatientBePosted(Patients value)
        {
            return !string.IsNullOrEmpty(value.Address);
        }

        public bool CanPatientBePhoned(Patients value)
        {
            return !string.IsNullOrEmpty(value.TelNum);
        }

        public bool CanPatientBeEmailed(Patients value) // TODO: remove
        {
            return !string.IsNullOrEmpty(value.Email);
        }

        public RecallMethods PatientRecallMethod(int patientId) // TODO: is this needed?
        {
            return (RecallMethods) PatientRecord(patientId).PreferredRecallMethod;
        }

        public RecallMethods PatientRecallMethod(Patients patient)
        {
            return (RecallMethods) patient.PreferredRecallMethod;
        }

        public string GetConditionName(int conditionID)
        {
            return (from q in adaptor.Conditions
                    where q.ConditionID == conditionID
                    select q.Condition).First();
        }

        public int ConditionID(string conditionName)
        {
            return (from q in adaptor.Conditions
                    where q.Condition == conditionName
                    select q.ConditionID).First();
        }

        public IQueryable<PatientConditions> PatientConditionList(int patientID)
        {
            return from q in adaptor.PatientConditions
                   where q.PatientID == patientID
                   select q;
        }

        public void AttachCondition(int patientID, int conditionID) // FIXME
        {
            PatientConditions pCond = new PatientConditions {PatientID = patientID, ConditionID = conditionID};
            adaptor.PatientConditions.InsertOnSubmit(pCond);
            adaptor.SubmitChanges();
        }

        public bool AmendPatient(int patientID, string name, string address, string telNum, DateTime dateOfBirth,
                                 string nhsNumber, string email, RecallMethods preferredrecallmethod)
        {
            Patients pRecord = PatientRecord(patientID);
            pRecord.Name = name;
            pRecord.Address = address;
            pRecord.TelNum = telNum;
            pRecord.DateOfBirth = dateOfBirth;
            if (pRecord.NhsnUmber != nhsNumber && NhsNumberExists(nhsNumber))
            {
                return false;
            }

            pRecord.NhsnUmber = nhsNumber;
            pRecord.Email = email;
            pRecord.PreferredRecallMethod = (int) preferredrecallmethod;

            adaptor.SubmitChanges();
            return true;
        }

        public bool NhsNumberExists(string nhsNumber)
        {
            int q = (from qr in adaptor.Patients
                     where qr.NhsnUmber == nhsNumber
                     select qr).Count();
            return q == 1;
        }

        public void RefreshAdaptor()
        {
            if (adaptor != null)
            {
                adaptor.Dispose();
            }

            adaptor = new DBAdaptor(connection);
#if DEBUG
            //fixme
            adaptor.Log = Console.Out;
#endif
        }

        public bool OutstandingRecall(int patientId)
        {
            int rclq = (from q in adaptor.PatientRecalls
                        where q.PatientID == patientId
                        select q).Count();
            return rclq != 0;
        }

        public PatientRecalls GetRecall(int patientId)
        {
            return (from q in adaptor.PatientRecalls
                    where q.PatientID == patientId
                    select q).First();
        }

        public PatientRecalls GetRecallByRclId(int recallId)
        {
            return (from q in adaptor.PatientRecalls
                    where q.RecallID == recallId
                    select q).First();
        }

        public void DeletePatient(int patientId)
        {
            Patients pRec = PatientRecord(patientId);
            adaptor.PatientRecalls.DeleteAllOnSubmit(pRec.PatientRecalls);
            adaptor.PatientConditions.DeleteAllOnSubmit(pRec.PatientConditions);
            adaptor.PatientAppointments.DeleteAllOnSubmit(pRec.PatientAppointments);
            adaptor.PatientTestResults.DeleteAllOnSubmit(pRec.PatientTestResults);
            adaptor.Patients.DeleteOnSubmit(pRec);
            adaptor.SubmitChanges();
        }

        public void DeleteRecall(int patientId)
        {
            adaptor.PatientRecalls.DeleteOnSubmit(GetRecall(patientId));
            adaptor.SubmitChanges();
        }

        public void SaveRecall(int patientId, DateTime dateAndPrefTime, string reason, RecallMethods method)
        {
            if (OutstandingRecall(patientId))
            {
                DeleteRecall(patientId);
            }

            PatientRecalls pr1 = new PatientRecalls
                                     {
                                         PatientID = patientId,
                                         DateAndPrefTime = dateAndPrefTime,
                                         Reason = reason,
                                         Method = (int) method
                                     };
            adaptor.PatientRecalls.InsertOnSubmit(pr1);
            adaptor.SubmitChanges();
        }

        public void AmendRecall(int patientId, DateTime dateAndPrefTime, string reason, RecallMethods method)
        {
            PatientRecalls pr1 = GetRecall(patientId);
            pr1.DateAndPrefTime = dateAndPrefTime;
            pr1.Reason = reason;
            pr1.Method = (int) method;
            adaptor.SubmitChanges();
        }

        public bool DoesEmailExist(string emailName)
        {
            int elist = (from q in adaptor.Emails
                         where q.Name == emailName
                         select q).Count();
            return elist != 0;
        }

        public bool SaveEmailRecord(string name, string emailtext)
        {
            int elist = (from q in adaptor.Emails
                         where q.Name == name
                         select q).Count();
            if (elist != 0)
            {
                return false;
            }

            Emails emailrec = new Emails {Name = name, Value = emailtext};
            adaptor.Emails.InsertOnSubmit(emailrec);
            adaptor.SubmitChanges();
            return true;
        }

        public bool AmendEmailRecord(int recordId, string name, string emailtext)
        {
            IQueryable<Emails> elist = from q in adaptor.Emails
                                       // TODO: goto does email exist
                                       where q.Name == name
                                       where q.EmailID != recordId
                                       select q;
            if (elist.Count() != 0)
            {
                return false;
            }

            Emails email = (from q in adaptor.Emails
                            // TODO: goto does email exist
                            where q.EmailID == recordId
                            select q).First();
            email.Name = name;
            email.Value = emailtext;
            adaptor.SubmitChanges();
            return true;
        }

        public Emails GetEmailRecord(string emailName)
        {
            return (from q in adaptor.Emails
                    where q.Name == emailName
                    select q).First();
        }

        public void DeleteEmailRecord(int recordId)
        {
            Emails elist = (from q in adaptor.Emails
                            where q.EmailID == recordId
                            select q).First();
            adaptor.Emails.DeleteOnSubmit(elist);
            adaptor.SubmitChanges();
        }

        public string GetUsersFullName(string userName)
        {
            return GetUserInfo(userName).Fullname;
        }

        public void SaveAppointment(DateTime startDate, DateTime endDate, string userName, int patientId, string remarks)
            // TODO: FAIL IF INTERSECTS ANOTHER APPOINTMENT
        {
            PatientAppointments pa1 = new PatientAppointments();
            Users userInfo = GetUserInfo(userName);
            pa1.UserID = userInfo.UserID;
            Patients patientRec = PatientRecord(patientId);
            pa1.PatientID = patientRec.PatientID;
            pa1.Remarks = remarks;
            pa1.StartDateTime = startDate;
            pa1.EndDateTime = endDate;
            adaptor.PatientAppointments.InsertOnSubmit(pa1);
            adaptor.SubmitChanges();
        }

        public IQueryable<PatientAppointments> GetAppointmentsByDateAndUser(string username, DateTime date)
        {
            date = date.Date;
            DateTime enddate = date.AddDays(1).AddMilliseconds(-1);
            return from q in adaptor.PatientAppointments
                   where q.StartDateTime > date
                   where q.StartDateTime < enddate
                   where q.Users.Username == username
                   select q;
        }

        public PatientAppointments GetAppointmentByDtAndPatient(string patientName, DateTime startDateTime)
        {
            return (from q in adaptor.PatientAppointments
                    where q.StartDateTime == startDateTime
                    where q.Patients.Name == patientName
                    select q).First();
        }

        public PatientAppointments GetAppointmentById(int appointmentId)
        {
            return (from q in adaptor.PatientAppointments
                    where q.AppointmentID == appointmentId
                    select q).First();
        }

        public void StoreTestResults(int appointmentId, string rSph, string lSph, string rVa1, string rVa2, string lVa1,
                                     string lVa2, string rCyl, string rAxis, string lCyl, string lAxis, string remarks)
        {
            PatientAppointments ap1 = GetAppointmentById(appointmentId);
            PatientTestResults pt1 = new PatientTestResults
                                         {
                                             TestID = appointmentId,
                                             Date = DateTime.Now.Date,
                                             PatientID = ap1.PatientID,
                                             UserID = ap1.UserID,
                                             RSpH = rSph,
                                             LSpH = lSph,
                                             RvA1 = rVa1,
                                             RvA2 = rVa2,
                                             LVA1 = lVa1,
                                             LVA2 = lVa2,
                                             RcYL = rCyl,
                                             RAxis = rAxis,
                                             LcYL = lCyl,
                                             LaxIs = lAxis,
                                             Remarks = remarks
                                         };
            adaptor.PatientTestResults.InsertOnSubmit(pt1);
            adaptor.PatientAppointments.DeleteOnSubmit(ap1);
            adaptor.SubmitChanges();
        }

        public void AmendTestResults(int userId, int testId, DateTime Date, string rSph, string lSph, string rVa1,
                                     string rVa2, string lVa1,
                                     string lVa2, string rCyl, string rAxis, string lCyl, string lAxis, string remarks)
        {
            PatientTestResults pt1 = GetTestResult(testId);
            pt1.UserID = userId;
            pt1.Date = Date;
            pt1.RSpH = rSph;
            pt1.LSpH = lSph;
            pt1.RvA1 = rVa1;
            pt1.RvA2 = rVa2;
            pt1.LVA1 = lVa1;
            pt1.LVA2 = lVa2;
            pt1.RcYL = rCyl;
            pt1.RAxis = rAxis;
            pt1.LcYL = lCyl;
            pt1.LaxIs = lAxis;
            pt1.Remarks = remarks;

            adaptor.SubmitChanges();
        }

        public void DeleteTestResult(int testId)
        {
            PatientTestResults pt1 = GetTestResult(testId);
            adaptor.PatientTestResults.DeleteOnSubmit(pt1);
            adaptor.SubmitChanges();
        }

        public void DeleteAppointment(int appointmentId)
        {
            PatientAppointments pt1 = GetAppointmentById(appointmentId);
            adaptor.PatientAppointments.DeleteOnSubmit(pt1);
            adaptor.SubmitChanges();
        }

        public void AmendAppointment(int appointmentId, DateTime startTime, DateTime endTime, string remarks, int userId)
        {
            PatientAppointments pt1 = GetAppointmentById(appointmentId);
            pt1.StartDateTime = startTime;
            pt1.EndDateTime = endTime;
            pt1.Remarks = remarks;
            pt1.UserID = userId;
            adaptor.SubmitChanges();
        }

        public PatientTestResults GetTestResult(int testId)
        {
            return (from q in adaptor.PatientTestResults
                    where q.TestID == testId
                    select q).First();
        }

        public IQueryable<PatientAppointments> GetAppointmentsOnPatient(int patientId)
        {
            return from q in adaptor.PatientAppointments
                   where q.PatientID == patientId
                   select q;
        }

        public IQueryable<PatientTestResults> GetTestResults(int patientId)
        {
            return from q in adaptor.PatientTestResults
                   where q.PatientID == patientId
                   select q;
        }

        public List<string> TestResults(int patientId)
        {
            List<string> sl1 = new List<string>();
            foreach (PatientTestResults pt1 in GetTestResults(patientId))
            {
                StringBuilder sb1 = new StringBuilder();
                sb1.Append("#");
                sb1.Append(pt1.TestID);
                sb1.Append(":");
                sb1.Append(pt1.Date.Value.ToShortDateString());
                sl1.Add(sb1.ToString());
            }
            return sl1;
        }

        /// <summary>
        ///   Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name = "disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                adaptor.Dispose();
                connection.Dispose();
            }
            // free native resources if there are any.
        }
    }
}