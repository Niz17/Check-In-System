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
    public partial class CheckIn : Form
    {
        bool isStudent;
        public CheckIn()
        {
            InitializeComponent();
            isStudent = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClearTextbox()
        {
            emailTextBox.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            purposeTextbox.Text = string.Empty;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var newconn = new DatabaseConnector();
            var email = emailTextBox.Text;
            var name = textBox2.Text;
            var id = textBox3.Text;
            var purpose = purposeTextbox.Text; 
            try
            {
                if (isStudent)
                {
                    newconn.AddStudent(Int32.Parse(id), name, email, purpose);
                    ClearTextbox();
                    bottomMessage.Text = "Succesfully added " + name;
                }
                else
                {

                        newconn.AddVisitor(name, email, purpose);
                        ClearTextbox();
                        bottomMessage.Text = "Succesfully added " + name;
  
                }
            }
            catch (Exception ex)
            {
                bottomMessage.Text = ex.Message;
            }

        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            LoginPage f2 = new LoginPage();
            f2.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isStudent = !isStudent;
        }

        private void purposeTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
