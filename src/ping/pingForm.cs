using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Detective
{
    public partial class pingForm : Form
    {
        public pingForm()
        {
            InitializeComponent();
        }

        private void startPingButton_Click(object sender, EventArgs e)
        {

            //Fix Crash with empty text box
            if (userIPAddrBox == null)
            {
                MessageBox.Show("Enter Text", "Error");
            }
            pingClass pingObj = new pingClass();

            String IPAddr = userIPAddrBox.Text;
            bool status = pingObj.tryPing(IPAddr);
            statusBox.Clear();

            if (status == true)
            {
                statusBox.ForeColor = Color.LawnGreen;
                statusBox.Text += "Success";
            }
            else
            {
                statusBox.ForeColor = Color.Crimson;
                statusBox.Text += "Failed";
            }
        }

        private void testLoopbackButton_Click(object sender, EventArgs e)
        {
            loopbackForm loopbackForm = new loopbackForm();
            loopbackForm.Show();
        }
    }
}
