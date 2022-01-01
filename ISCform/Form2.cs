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
    public partial class LoginPage : Form
    {        
        public LoginPage()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearTextbox()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginId = textBox2.Text;
            var password = textBox1.Text;

            try
            {
                var conn = new DatabaseConnector();
                bool success = conn.CheckLogin(loginId, password);
                if (success)
                {
                    homepage chk = new homepage();
                    chk.Show();
                    ClearTextbox();
                }
                else
                {
                    message.Text = "Login Failed";
                }
            }
            catch (Exception ex)
            {
                message.Text = ex.Message;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
