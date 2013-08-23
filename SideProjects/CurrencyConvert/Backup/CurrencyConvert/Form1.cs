using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CurrencyConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Payment is Done. Thanks for using Paypal", "PayPal");
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            
        }
    }
}
