﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Detective.subnetClass
{
    public partial class showSubnetOpt : Form
    {
        public showSubnetOpt()
        {
            InitializeComponent();
            printValidMasks();
        }

        public void printValidMasks()
        {
            showMaskTextBox.Text += @"
--- Subnet --- 
Note: (Previous From requires the Network Bits [Eg: \24, \8 or \16])

/8	255.0.0.0	
/9	255.128.0.0	
/10	255.192.0.0	 
/11	255.224.0.0	
/12	255.240.0.0	
/13	255.248.0.0
/14	255.252.0.0
/15	255.254.0.0
/16	255.255.0.0
/17	255.255.128.0
/18	255.255.192.0
/19	255.255.224.0
/20	255.255.240.0
/21	255.255.248.0
/22	255.255.252.0
/23	255.255.254.0
/24	255.255.255.0
/25	255.255.255.128
/26	255.255.255.192
/27	255.255.255.224
/28	255.255.255.240	
/29	255.255.255.248
/30	255.255.255.252


            ";
        }
    }
}
