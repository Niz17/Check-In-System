/* /////////////////////////////////////////////////////////////////////////
 * 
 * Names: Nirjal Shakya, Satish Parajuli, Ayush Bharati
 * Date: 12/16/2021
 * Copyright @ Nirjal, Satish, Ayush 2021
 * Database Final Project
 * International Student Center Check-In System
 * 
*/ /////////////////////////////////////////////////////////////////////////

using CsvHelper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectISC
{
    public class DatabaseConnector
    {
        // Settting up connection with the SQL Server
        public SqlConnection connection;

        // Initializes a class that establishes a connection with the local database (here the ISC database)
        public DatabaseConnector()
        {
            connection = new SqlConnection("Data Source =LAPTOP-B6M8UUTC; Initial Catalog =ISC; Integrated Security=SSPI");
            connection.Open();
        }

        // Insertion Queries:

        // Uses the CsvWriter Nuget Extension to export the queried table from database into a .csv file
        // Initializes the path variable for the file destination
        //  and saves the .csv file into the file destination. 
        static void CreateCSV(string path, IEnumerable<object> obj)
        {
            var writer = new StreamWriter("F:\\ISC_CSV\\" + path + ".csv");
            var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(obj);
            writer.Close();
        }

        // Uses Dapper Nuget Extension to execute the stored procedure built into the database. 
        // Uses the established connection to execute the usp_AddStudent query, which inserts a new student into 
        //  the database
        public void AddStudent(int id, string name, string email, string purpose = "")
        {
            connection.Execute(
                "usp_AddStudent",
                param: new { id, name, email, purpose },
                commandType: CommandType.StoredProcedure);
        }

        // Uses Dapper Nuget Extension to execute the stored procedure built into the database. 
        // Uses the established connection to execute the usp_AddVisitor query, which inserts a new visitor into 
        //  the database
        public void AddVisitor(string name, string email, string purpose = "")
        {
            connection.Execute(
                "usp_AddVisitor",
                param: new {name, email, purpose},
                commandType: CommandType.StoredProcedure);
        }

        // Getter Queries:

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_GetStudents query, which lists all students that have visited the ISC
        // Calls the CreateCSV() function to export the results into a .csv file
        public void GetStudents()
        {
            var studentList = connection.Query<Student>(
                "usp_GetStudents",
                commandType: CommandType.StoredProcedure).ToList();
            CreateCSV("Students", studentList);
        }

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_GetStudentsVisits query, which lists all students that have visited the ISC
        // Calls the CreateCSV() function to export the results into a .csv file
        public void GetStudentVisits()
        {
            var visitsList = connection.Query<Visits>(
                "usp_GetStudentVisits",
                commandType: CommandType.StoredProcedure).ToList();
            CreateCSV("StudentsVisits", visitsList);
        }

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_GetVisitorVists query, which lists all students that have visited the ISC
        // Calls the CreateCSV() function to export the results into a .csv file
        public void GetVisitorVisits()
        {
            var visitsList = connection.Query<Visits>(
                "usp_GetVisitorVisits",
                commandType: CommandType.StoredProcedure).ToList();
            CreateCSV("VisitorVisits", visitsList);
        }

        /*
        public Events[] GetEvents()
        {
            var eventslist = connection.Query<Events>(
                "usp_GetEvents",
                commandType: CommandType.StoredProcedure);
            return eventslist.ToArray();
        }
        */

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_GetClubs query, which lists all students that have visited the ISC
        // returs the array of tuples of the query result
        public Clubs[] GetClubs()
        {
            var clubsList = connection.Query<Clubs>(
                "usp_GetClubs",
                commandType: CommandType.StoredProcedure);
            return clubsList.ToArray();
        }

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_CheckLogin query, which checks if the inputted LoginCredentials are in 
        //  the database or not. 
        // returns boolean value in loginInfo that signifies if that loginId exists or not
        // returns the array of tuples of the query result
        public bool CheckLogin(string id, string pwd)
        {
            var loginInfo = connection.QueryFirstOrDefault<bool>(
                "usp_CheckLogin", 
                param: new { id, pwd },
                commandType: CommandType.StoredProcedure);
                return loginInfo;
        }

        // Calculation Queries

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_CalculateStudentVisitors query, which calculates the total number of student 
        //  visitors 
        // returns the total number of student visitors
        public int CalculateStudentVisitors()
        {
            var totalStudentVisits = connection.QueryFirstOrDefault<int>(
                "usp_CalculateStudentVisitors",
                commandType: CommandType.StoredProcedure);
            return totalStudentVisits;
        }

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_CalculateStudentUniqueVisitors query, which calculates the total unique number of student 
        //  visitors 
        // returns the total number of unique student visitors
        public int CalculateStudentUniqueVisitors()
        {
            var totalStudentVisits = connection.QueryFirstOrDefault<int>(
                "usp_CalculateUniqueStudentVisitors",
                commandType: CommandType.StoredProcedure);
            return totalStudentVisits;
        }

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_CalculateStudentLastMonth query, which calculates the total number of student 
        //  visitors in the last month
        // returns the total number of student visitors per month
        public int CalculateStudentsLastMonth()
        {
            var totalStudentVisits = connection.QueryFirstOrDefault<int>(
                "usp_CalculateStudentsLastMonth",
                commandType: CommandType.StoredProcedure);
            return totalStudentVisits;
        }

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_CalculateOtherVisitors query, which calculates the total number of other 
        //  visitors 
        // returns the total number of other visitors
        public int CalculateOVisitors()
        {
            var totalotherVisits = connection.QueryFirstOrDefault<int>(
                "usp_CalculateOtherVisitors",
                commandType: CommandType.StoredProcedure);
            return totalotherVisits;
        }

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_CalculateOtherUniqueVisitors query, which calculates the total unique number of other
        //  visitors 
        // returns the total number of unique other visitors ok nice
        public int CalculateOtherUniqueVisitors()
        {
            var totalOtherVisits = connection.QueryFirstOrDefault<int>(
                "usp_CalculateUniqueOtherVisitors",
                commandType: CommandType.StoredProcedure);
            return totalOtherVisits;
        }

        // Uses Dapper Nuget Extension to run the query placed in the stored procedure in database. 
        // Uses the established connection to execute the usp_CalculateOtherLastMonth query, which calculates the total number of other 
        //  visitors in the last month
        // returns the total number of other visitors per month
        public int CalculateOthersLastMonth()
        {
            var totalOtherVisits = connection.QueryFirstOrDefault<int>(
                "usp_CalculateOthersLastMonth",
                commandType: CommandType.StoredProcedure);
            return totalOtherVisits;
        }
    }
}
