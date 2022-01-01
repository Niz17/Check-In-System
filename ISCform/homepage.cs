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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            CheckIn f1 = new CheckIn();
            f1.Show();
        }
        private void trackVisitButton_Click(object sender, EventArgs e)
        {
            trackvisit t1 = new trackvisit();
            t1.Show();
        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void viewEventsButton_Click(object sender, EventArgs e)
        {
            var cldr = new Calender();
            cldr.Show();
        }
    }
}
