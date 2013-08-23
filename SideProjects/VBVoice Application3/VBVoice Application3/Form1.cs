using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VBVoice_Application3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // start the system
            if (!this.vbvFrame1.SystemStarted())
            {
                this.vbvFrame1.StartSystem(true);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // stop the system
            if (this.vbvFrame1.SystemStarted())
            {
                this.vbvFrame1.StopSystem(true);
            }
        }
    }
}