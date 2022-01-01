using FinalProjectISC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCform
{
    public partial class trackvisit : Form
    {
        int totalStudents, uniqueStudents, studentsLastMonth;
        int totalOthers, uniqueOthers, othersLastMonth;
        public trackvisit()
        {
            InitializeComponent();
            try
            {
                var newconn = new DatabaseConnector();
                totalStudents = newconn.CalculateStudentVisitors();
                uniqueStudents = newconn.CalculateStudentUniqueVisitors();
                studentsLastMonth = newconn.CalculateStudentsLastMonth();
                label1.Text = "Total Students Visits = " + totalStudents.ToString() +
                    "\n Unique Students Visitors = " + uniqueStudents.ToString() +
                    "\n LastMonth Students Visitors = " + studentsLastMonth.ToString();

                employeeStats.Text = "Total Extra Visits = 0" +
                   "\n Unique Extra Visitors = 0"+
                   "\n LastMonth Extra Visitors = 0";

                totalOthers = newconn.CalculateOtherVisitors();
                uniqueOthers = newconn.CalculateOtherUniqueVisitors();
                othersLastMonth = newconn.CalculateOthersLastMonth();
                otherDetails.Text = "Total Emloyee Visits = " + totalOthers.ToString() +
                   "\n Unique Employee Visitors = " + uniqueOthers.ToString() +
                   "\n LastMonth Employee Visitors = " + othersLastMonth.ToString();

                stats.Text = "Total Extra Visits = " + (totalStudents + totalOthers).ToString() +
                   "\n Unique Extra Visitors = " + (uniqueStudents + uniqueOthers).ToString() +
                   "\n LastMonth Extra Visitors = " + (studentsLastMonth + othersLastMonth).ToString();
            }
            catch (Exception ex)
            {
                message.Text = ex.Message;
            }

        }

        private void EmployeeVisitsButton_Click(object sender, EventArgs e)
        {
            message.Text = "Succesfully exported Employee Visits.";
        }

        private void trackvisit_Load(object sender, EventArgs e)
        {

        }

        private void StudentVisitsButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newconn = new DatabaseConnector();
                newconn.GetStudentVisits();
                message.Text = "Succesfully exported Student Visits.";
            }
            catch(Exception ex)
            {
                message.Text = ex.Message;
            }
        }

        private void OtherVisitsButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newconn = new DatabaseConnector();
                newconn.GetVisitorVisits();
                message.Text = "Succesfully exported Other Visits.";
            }
            catch (Exception ex)
            {
                message.Text = ex.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
