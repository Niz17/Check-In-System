#############################################################################################

# Check-In System for the Intercultural Student Center at Whitworth University
 Contributions made by: Nirjal Shakya, Satish Parajuli, Ayush Bharati
 
#############################################################################################

# Description :
   This application is a prototype of the check-in system built for the Intercultural Student Center (ISC) at Whitworth University integrating of Embedded SQL and SQL Server. The purpose of this application is to check-in (sign-in) into the system, track the number of people (students and visitors) visiting the ISC for events/any other purposes. It will also hold the events that clubs are hosting in the ISC, and the participating clubs.  
   The application was built on C# (.NET Framework) on Visual Studio 2019, using the WPF (Windows Presentation Foundation) framework for frontend design. Two extensions from NuGet – Dapper and CsvHelper were used. These extensions can be found within Tools>>NuGet Package Manager>>Manage NuGet Packages for Connection (Both Dapper and CsvHelper). The chosen embedded SQL for this app is the .NET Framework alongside Microsoft SQL Server as our DBMS.  

# Design :
There were three components to the application: 
* Frontend :
   * The .NET framework was chosen after weeks of considering various frontend designs. The group finally decided on the WPF framework within the C# (.NET), which proved to be a convenient way of displaying/interacting wtih the backend and the database. 
   * There were several forms implemented, including,  
      * Login page for admin 
      * Check-in page for visitors 
      * Track Visitors 
      * Track the number of student/employee/other visitors visits the ISC. 
      * View Clubs 
      * View Events 

* Backend :
   * The connection in the program was setup btween Visual Studio 2019 and SQL Server (the project was also created in SQL mode, which helped with easier access and connection to SQL).  
   * Schema Mapping was used to create, update, and delete Database tables and stored procedures from the database.  
   * Based on the functionality, Dapper was used to execute stored procedures from the database.  
   * The input from frontend was collected, processed, and put into the database using stored procedures.  
   * Developed functions and included extensions to connect the backend with the database (SQL Server), frontend (WPF), and CsvHelper (exporting tracking visitors).  
   * Implemented constraints for the front-end & DBMS on the backend.  
      * The admin can only login if their credentials match the ones in the database.  
      * It doesn’t allow the visitor/admin to submit an empty field (except for purpose).  
      * The password field is in * to ,protect the admin’s credentials from being displayed.  

* DBMS :
   * Created a database on SQL Server.  
   * Created tables using the Create Procedure methods.  
   * Created stored procedures for:  
      * Insertion queries 
      * Update queries 
      * Calculation queries 
      * Getter queries 

# ------------------------------------------------------------------

# Navigations for the Project :
    * List of Folders 
        *  Final project ISC : ( all tables from databases are separate classes and have respective objects)
            *  Clubs.cs : individual clubs 
            * - DatabaseConnector.cs : connects our database to C# . Embedded SQL
            * - Department.cs : a table for Employees
            * - ISC_Staff : table for
            * - LoginInfo.cs : stores login information for visitors/students
            * - Student.cs : a table storing student information
            * - Visits.cs : a table with visitor that stores the visitors visting ISC
        *  ISC Database : a folder that uses create and stored proceudre for functions like recording the total number of visits
            * The stored procedures and tables can be found in dbo folder inside here.
        *  ISC Form : WPF(.NET frameworks for all the form for front end)
            *  Calendar.cs : a form that imports the calendar
            *  Form1 : form for the check-in
            *  Form2 : form for the administrator
            *  homepage : the main page that prints the buttons
            *  trackvisit : a form for trackvisits


# To Run the program :
    * Things needed to install :
        * Visual Studio 2019
           * WPF (.NET Framework)
           * Dapper Extension and csv helper (NuGetPackages)
           * SQL extension
        * Microsoft SQL Server

# How to clone the Database:
    *  Install Database and SQL frameworks for VisualStudio.
    *  Open Project ISC Database and use Tools/Sql/SchemaComparision to compare the existing Databse project to the databse server.
    *  Compare and Update the Schema.



      




        
