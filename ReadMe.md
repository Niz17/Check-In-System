* Navigations for the Project :
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


*  To Run the program :
    * Things needed to install :
        * WPF (.NET Framework)
        * Dapper Extension and csv helper (NuGetPackages)
        * SQL extension

* How to clone the Database:
    *  Install Database and SQL frameworks for VisualStudio.
    *  Open Project ISC Database and use Tools/Sql/SchemaComparision to compare the existing Databse project to the databse server.
    *  Compare and Update the Schema.



      




        
