/*
 * Created by SharpDevelop.
 * User: pry09099729
 * Date: 21/03/2011
 * Time: 13:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using System.IO;

namespace SQLCreate
{
	class Program
	{
		public static void Main(string[] args)
		{
			if (args.Length != 1)
			{
				Console.WriteLine("The syntax of the command is incorrect.");
				return;
			}
			FileInfo fi1 = new FileInfo(args[0]);
			string newdb;
			using (StreamReader sr1 = fi1.OpenText())
			{
				newdb = sr1.ReadToEnd();
			}
			string sqlname = fi1.FullName.Replace(fi1.Extension,".db3");
			FileInfo fi2 = new FileInfo(sqlname);
			try {
				fi2.Delete(); //FIXME:
			}
			catch (Exception) //TODO: Needed?
			{
				
			}
			string connectionString = "DbLinqProvider=Sqlite;Data Source=" + fi2.Name;
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            
            connection.Open();
            SQLiteCommand sqc = connection.CreateCommand();
            sqc.CommandText = newdb;
            sqc.Connection = connection;
            sqc.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Database created successfully.");
		}
	}
}