using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ip_monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPHostEntry IPentry = Dns.GetHostEntry(Dns.GetHostName());
            string ipList = IPentry.AddressList[0].ToString();
            System.Net.IPAddress[] addressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;
            if (addressList.Length > 1)
            {
                lblLIP.Text = addressList[0].ToString();
                lblSIP.Text = addressList[1].ToString();
            }
            else
            {
                lblLIP.Text = addressList[0].ToString();
                lblSIP.Text = ipList;
            }
        }
    }
}
