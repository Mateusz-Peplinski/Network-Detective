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
    public partial class subnetScanHelpForm : Form
    {
        public subnetScanHelpForm()
        {
            InitializeComponent();
            showHelpInfo();
        }

        public void showHelpInfo()
        {
            const String helpText = @"How this works:
An IPv4 Address is made of 32 binary bits that are broken into four octets (8bits). 
This subnet Scanner uses a 255.255.255.0 subnet mask meaning that only the last octet of the address is changed from 2 – 255. 
So to get the program to run correctly you must only write the first 3 octets of your IP address Eg: 192.168.1 or 192.168.5 . 
The form will also display all IP address that your computer has from different network adapters yours may only display one if your computer has only one network adapter.
";
            helpTextBox.Text += helpText;
        }
    }
}
