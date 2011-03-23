/*
 * Copyright (c) 2011 Geoffrey Prytherch
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

namespace OpticianDB
{
    using System;
    using System.Collections.Generic;
    using System.Data.SQLite;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using OpticianDB.Adaptor;

    public class DBBackEnd : IDisposable
    {
        private DBAdaptor adaptor;
        private SQLiteConnection connection;
        private string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="DBBackEnd"/> class.
        /// </summary>
        public DBBackEnd()
        {
            this.connectionString = "DbLinqProvider=Sqlite;Data Source=OpticianDB.db3";
            this.connection = new SQLiteConnection(this.connectionString);
            this.RefreshAdaptor();

            if (!File.Exists("OpticianDB.db3"))
            {
                this.CreateNewDB();
            }
        }

        public IQueryable<string> UserNameList
        {
            get
            {
                return from user in this.adaptor.Users
                       select user.Username;
            }
        }

        public IQueryable<string> ConditionsList
        {
            get
            {
                return from cnds in this.adaptor.Conditions
                       orderby cnds.Condition ascending
                       select cnds.Condition;
            }
        }

        public IQueryable<string> PatientListWithNhsNumber
        {
            get
            {
                var q = from pnts in this.adaptor.Patients
                        orderby pnts.Name, pnts.NhsnUmber ascending
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

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void CreateNewDB()
        {
            Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("OpticianDB.blankdb.sql");
            StreamReader textStream = new StreamReader(resourceStream);
            string newDb = textStream.ReadToEnd();

            this.adaptor.ExecuteCommand(newDb, null);

            this.CreateNewUser("admin", "admin", "Default Administrator", Enums.HashMethods.sha1); // TODO: messagebox to show addition of a new user?
        }

        public bool LogOn(string userName, string password)
        {
            var q = from user in this.adaptor.Users
                    where user.Username == userName
                    select user;

            if (q.Count() == 0)
            {
                return false;
            }

            Users foundUser = q.First();

            string storedPwd = foundUser.Password;
            Enums.HashMethods hashMethod = (Enums.HashMethods)foundUser.PasswordHashMethod;
            string hashedPwd = Hashing.GetHash(password, hashMethod);

            return storedPwd == hashedPwd;
        }

        public bool CreateNewUser(string userName, string password, string fullName, Enums.HashMethods passwordHashMethod)
        {
            if (this.UserExists(userName))
            {
                return false;
            }

            Users newuser = new Users();

            newuser.Fullname = fullName;
            newuser.Password = Hashing.GetHash(password, Enums.HashMethods.sha1);
            newuser.Username = userName;
            newuser.PasswordHashMethod = (int)passwordHashMethod;

            this.adaptor.Users.InsertOnSubmit(newuser);
            this.adaptor.SubmitChanges();

            return true;
        }

        public bool AmendUser(string editedUser, string newUserName, string password, string fullName, Enums.HashMethods hashMethod)
        {
            if (editedUser != newUserName && this.UserExists(newUserName))
            {
                return false;
            }

            Users userRec = (from uq in this.adaptor.Users
                           where uq.Username == editedUser
                           select uq).First();

            if (string.IsNullOrEmpty(password))
            {
            	Enums.HashMethods hashingMethod = hashMethod; //TODO: WHAAAAT??????
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

            if (fullName != userRec.Fullname)
            {
                userRec.Fullname = fullName;
            }

            this.adaptor.SubmitChanges();
            return true;
        }

        public Users GetUserInfo(string userName)
        {
            Users user = (from q in this.adaptor.Users
                        where q.Username == userName
                        select q).First();
            return user;
        }

        public int PatientIdByNhsNumber(string nhsNumber)
        {
            return (from pnts in this.adaptor.Patients
                          where pnts.NhsnUmber == nhsNumber
                          select pnts.PatientID).First();
        }

        public bool UserExists(string userName)
        {
            if (this.adaptor.Users.Count() != 0)
            {
                var existingUsers = from user in this.adaptor.Users
                                    where user.Username == userName
                                    select user;
                if (existingUsers.Count() != 0)
                {
                    return true;
                }
            }

            return false;
        }

        //rtns -1 if record exists or returns recid
        public int AddPatient(string name, string address, string telNum, DateTime dateOfBirth, string nhsNumber, string email, Enums.RecallMethods preferredrecallmethod)
        {
            if (NhsNumberExists(nhsNumber))
            {
                return -1;
            }

            Patients pRec = new Patients();
            pRec.Name = name;
            pRec.Address = address;
            pRec.TelNum = telNum;
            pRec.DateOfBirth = dateOfBirth;
            pRec.NhsnUmber = nhsNumber;
            pRec.Email = email;
                        pRec.PreferredRecallMethod = (int)preferredrecallmethod;

            this.adaptor.Patients.InsertOnSubmit(pRec);
            this.adaptor.SubmitChanges();

            return pRec.PatientID;
        }

        //assumes exists
        public Patients PatientRecord(int id)
        {
            return (from q in this.adaptor.Patients
                      where q.PatientID == id
                      select q).First();
        }

        public int AddCondition(string conditionName)
        {
            Conditions cnd = new Conditions();

            if (this.ConditionExists(conditionName))
            {
                return -1;
            }

            cnd.Condition = conditionName;
            this.adaptor.Conditions.InsertOnSubmit(cnd);
            this.adaptor.SubmitChanges();

            return cnd.ConditionID;
            //TODO: Description?
        }

        public void RemoveConditionByName(string conditionName, int patientID) //FIXME
        {
            this.RefreshAdaptor();
            //Patients patient = this.PatientRecord(patientID);
            //var condition = (from q in patient.PatientConditions
            //                 where q.Conditions.Condition == conditionName
            //                 select q).First();

            PatientConditions condition = (from q in this.adaptor.PatientConditions
                             where q.Conditions.Condition == conditionName
                             where q.PatientID == patientID
                             select q).First();
            this.adaptor.PatientConditions.DeleteOnSubmit(condition);
            //patient.PatientConditions.Remove(condition);
            this.adaptor.SubmitChanges();
        }

        public bool ConditionExists(string conditionName)
        {
            var conTable = (from q in this.adaptor.Conditions
                            where q.Condition == conditionName
                            select q).Count();
        	return (conTable != 0);
        }

        public bool CanPatientBePosted(Patients value)
        {
            return (!string.IsNullOrEmpty(value.Address));
        }

        public bool CanPatientBePhoned(Patients value)
        {
            return (!string.IsNullOrEmpty(value.TelNum));
        }

        public bool CanPatientBeEmailed(Patients value)
        {
            return (!string.IsNullOrEmpty(value.Email));
        }

        public Enums.RecallMethods PatientRecallMethod(int patientId) //TODO: is this needed?
        {
            return (Enums.RecallMethods)PatientRecord(patientId).PreferredRecallMethod;
        }
        public Enums.RecallMethods PatientRecallMethod(Patients patient)
        {
            return (Enums.RecallMethods)patient.PreferredRecallMethod;
        }

        public string GetConditionName(int conditionID)
        {
            return (from q in this.adaptor.Conditions
                       where q.ConditionID == conditionID
                       select q.Condition).First();
        }

        public int ConditionID(string conditionName)
        {
            return (from q in this.adaptor.Conditions
                       where q.Condition == conditionName
                       select q.ConditionID).First();
        }

        public IQueryable<PatientConditions> PatientConditionList(int patientID)
        {
            return from q in this.adaptor.PatientConditions
                      where q.PatientID == patientID
                      select q;
        }

        public void AttachCondition(int patientID, int conditionID) //FIXME
        {
            PatientConditions pCond = new PatientConditions();
            pCond.PatientID = patientID;
            pCond.ConditionID = conditionID;
            this.adaptor.PatientConditions.InsertOnSubmit(pCond);
            this.adaptor.SubmitChanges();
        }

        public bool AmendPatient(int patientID, string name, string address, string telNum, DateTime dateOfBirth, string nhsNumber, string email, Enums.RecallMethods preferredrecallmethod)
        {
            var pRecord = this.PatientRecord(patientID);
            pRecord.Name = name;
            pRecord.Address = address;
            pRecord.TelNum = telNum;
            pRecord.DateOfBirth = dateOfBirth;
            if (pRecord.NhsnUmber != nhsNumber)
            {
                if (NhsNumberExists(nhsNumber))
                    return false;
            }
            pRecord.NhsnUmber = nhsNumber;
            pRecord.Email = email;
            pRecord.PreferredRecallMethod = (int)preferredrecallmethod;

            this.adaptor.SubmitChanges();
            return true;
        }

        public bool NhsNumberExists(string nhsNumber)
        {
            var q = (from qr in this.adaptor.Patients
                     where qr.NhsnUmber == nhsNumber
                     select qr).Count();
            return (q == 1);
        }

        public void RefreshAdaptor()
        {
            if (this.adaptor != null)
            {
                this.adaptor.Dispose();
            }

            this.adaptor = new DBAdaptor(this.connection);
#if DEBUG //fixme
            this.adaptor.Log = Console.Out;
#endif
        }

        public bool OutstandingRecall(int patientId)
        {
            var rclq = (from q in this.adaptor.PatientRecalls
                       where q.PatientID == patientId
                       select q).Count();
            return (rclq == 0);
        }

        public PatientRecalls GetRecall(int patientId) 
        {
            return (from q in this.adaptor.PatientRecalls
                    where q.PatientID == patientId
                    select q).First();
        }

        public PatientRecalls GetRecallByRclId(int recallId) 
        {
            return (from q in this.adaptor.PatientRecalls
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

        public void SaveRecall(int patientId, DateTime dateAndPrefTime, string reason, Enums.RecallMethods method)
        {
            if (OutstandingRecall(patientId))
            {
                DeleteRecall(patientId);
            }
            PatientRecalls pr1 = new PatientRecalls();
            pr1.PatientID = patientId; //FIXME use add
            pr1.DateAndPrefTime = dateAndPrefTime;
            pr1.Reason = reason;
            pr1.Method = (int)method;
            adaptor.PatientRecalls.InsertOnSubmit(pr1);
            adaptor.SubmitChanges();
        }

        public void AmendRecall(int patientId, DateTime dateAndPrefTime, string reason, Enums.RecallMethods method)
        {
            PatientRecalls pr1 = GetRecall(patientId);
            pr1.DateAndPrefTime = dateAndPrefTime;
            pr1.Reason = reason;
            pr1.Method = (int)method;
            adaptor.SubmitChanges();
        }

        public IQueryable<PatientRecalls> TodaysRecalls
        {
            get
            {
                DateTime today = DateTime.Today;
                DateTime tomorrow = DateTime.Today.AddDays(1); //TODO: does this find dates after?
                return from q in this.adaptor.PatientRecalls
                              where q.DateAndPrefTime > today
                              where q.DateAndPrefTime.Value < tomorrow
                              select q;
            }
        }

        public IQueryable<PatientRecalls> RecallList
        {
            get
            {

                return from q in this.adaptor.PatientRecalls
                              orderby q.DateAndPrefTime
                              select q;
            }
        }

        public IQueryable<PatientRecalls> GetRecalls(DateTime? startDate, DateTime? endDate)
        {
            if (startDate.HasValue == false && endDate.HasValue == true)
            {
                return from q in this.adaptor.PatientRecalls
                              where q.DateAndPrefTime < endDate
                              orderby q.DateAndPrefTime
                              select q;
            }
            else if (startDate.HasValue == true && endDate.HasValue == false)
            {
                startDate = startDate.Value.AddDays(1); //TODO: does this find dates after?
                return from q in this.adaptor.PatientRecalls
                              where q.DateAndPrefTime > startDate
                              orderby q.DateAndPrefTime
                              select q;
            }
            else if (startDate.HasValue == true && endDate.HasValue == true)
            {
                startDate = startDate.Value.AddDays(1); //TODO: does this find dates after?
                return from q in this.adaptor.PatientRecalls
                              where q.DateAndPrefTime < endDate
                              where q.DateAndPrefTime > startDate
                              orderby q.DateAndPrefTime
                              select q;
            }
            return RecallList;

        }
        
        //TODO: to be added
        public IQueryable<string> EmailList
        {
        	get {
        		return from q in this.adaptor.Emails
        			orderby q.Name
        			select q.Name;
        	}
        }
        
        public bool DoesEmailExist(string emailName)
        {
        	var elist = (from q in this.adaptor.Emails
        		where q.Name == emailName
        		select q).Count();
        	return (elist != 0);

        }
        
        public bool SaveEmailRecord(string name, string emailtext)
        {
        	var elist = from q in this.adaptor.Emails
        		where q.Name == name
        		select q;
        	if (elist.Count() != 0)
        		return false;
        	Emails emailrec = new Emails();
        	emailrec.Name = name;
        	emailrec.Value = emailtext;
        	this.adaptor.Emails.InsertOnSubmit(emailrec);
        	this.adaptor.SubmitChanges();
        	return true;
        }
        
        public bool AmendEmailRecord(int recordId, string name, string emailtext)
        {
        	var elist = from q in this.adaptor.Emails //TODO: goto does email exist
        		where q.Name == name
        		where q.EmailID != recordId
        		select q;
        	if (elist.Count() != 0)
        		return false;
        	Emails email = (from q in this.adaptor.Emails //TODO: goto does email exist
        		where q.EmailID == recordId
        		select q).First();
        	email.Name = name;
        	email.Value = emailtext;
        	this.adaptor.SubmitChanges();
        	return true;
        }
        
        public Emails GetEmailRecord(string emailName)
        {
        	return (from q in this.adaptor.Emails
        	        where q.Name == emailName
        	        select q).First();
        }
        
        public void DeleteEmailRecord(int recordId)
        {
        	Emails elist = (from q in this.adaptor.Emails
        	             where q.EmailID == recordId
        	             select q).First();
        	this.adaptor.Emails.DeleteOnSubmit(elist);
        	this.adaptor.SubmitChanges();
        }

        

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                this.adaptor.Dispose();
                this.connection.Dispose();
            }
            // free native resources if there are any.
        }
    }
}
