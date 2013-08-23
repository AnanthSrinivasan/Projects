using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Combined
{
    public partial class Form1 : Form
    {
        static int itnx;
        static int iocc;
        static int ifan;
        static int icdnx;
        static int icunx;
        static int icpmnx;
        static int icpmspnx;
        static int icpmlmnx;
        static int icpmblnx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gblcddisp.Visible = true;
            gbuseraccess.Visible = false;
            gbparameters.Visible = false;
            gbparamsetpt.Visible = false;
            gbparamlimit.Visible = false;
            gbparambal.Visible = false;
            gbfirst.Visible = true;
            gbbtone.Visible = true;
            gbbttwo.Visible = false;
            gbbtthree.Visible = false;
            gbbtpmstpt.Visible = false;
            gbbtpmsplmbl.Visible = false;
            lblhmdity.Visible = false;
            lbltime.Visible = false;
            //				lbltimeval.Visible = false;
            //				lbltimeam.Visible = false;
            //				lbltimepm.Visible = false;
            lblmin.Visible = false;
            lblhour.Visible = false;
            lblcolon.Visible = false;
            lblam.Visible = false;
            lblpm.Visible = false;
            lblhmdval.Visible = false;
            //for values of different label displays
            lbluahmdval.Visible = false;
            lbluaco2val.Visible = false;
            lbluatmpval.Visible = false;
            lbluasysval.Visible = false;

            lblpmsphmdval.Visible = false;
            lblpmspco2val.Visible = false;
            lblpmsphtval.Visible = false;
            lblpmspclval.Visible = false;

            lblpmlmthival.Visible = false;
            lblpmlmtloval.Visible = false;

            lblpmblhtdctval.Visible = false;
            lblpmblcldctval.Visible = false;
            lblpmblhtfloval.Visible = false;
            lblpmblclfloval.Visible = false;

            //tenant mode
            gb1.Visible = true;
            gb1disp.Visible = true;
            gb2disp.Visible = false;
            gb2.Visible = false;

            //occ images
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = true;

            lblthmd.Visible = false;
            lblthmdval.Visible = false;
            lblttime.Visible = false;
            lbltrem.Visible = false;
            //			 lblttmval.Visible = false;
            //			 lblttmam.Visible = false;
            //			 lblttmpm.Visible = false;
            lblthour.Visible = false;
            lbltcolon.Visible = false;
            lbltmin.Visible = false;
            lbltam.Visible = false;
            lbltpm.Visible = false;

            lbltper.Visible = false;
            lblthmdy.Visible = false;
            lbltco2.Visible = false;
            //fan images
            pbfanauto.Visible = false;
            pbfanbar1.Visible = false;
            pbfanbar2.Visible = false;
            pbfanbar3.Visible = false;
            pbfanoff.Visible = true;
            //other labels
            lbltHumidval.Visible = false;
            lbltCo2val.Visible = false;
            lbltHmdspval.Visible = false;

        }

        private void cmdcontractor_Click(object sender, EventArgs e)
        {
            gbcontractor.Visible = true;
            gbtenant.Visible = false;

        }

        private void cmdtenant_Click(object sender, EventArgs e)
        {
            //occ images
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = true;
            //fan images
            pbfanauto.Visible = false;
            pbfanbar1.Visible = false;
            pbfanbar2.Visible = false;
            pbfanbar3.Visible = false;
            pbfanoff.Visible = true;

            //from contractor done:
            if (lblrmtmp.Visible == true && lbloutside.Visible == true && lblstpt.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                //					lbloutval.Text = "45";
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;

                lbltot.Visible = true;
                lbltotval.Visible = true;
                lbltotdeg.Visible = true;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lbltper.Visible = false;

                lbltrmval.Text = "65";
                lbltotval.Text = "45";
                lbltspval.Text = lblstptval.Text;

                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lblrmtmp.Visible == true && lblhmdity.Visible == true && lblstpt.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                lblhmdval.Text = lblpmsphmdval.Text;
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltper.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lblthmd.Visible = true;
                lblthmdval.Visible = true;

                lbltrmval.Text = "65";
                lbltspval.Text = lblstptval.Text;
                lblthmdval.Text = lblpmsphmdval.Text;
                //					lbltHumidval.Text = lblpmsphmdval.Text;
                if (lbluahmdval.Text == "YES")
                {
                    lblthmdval.Text = lbltHumidval.Text;
                }
                //					lblthmdval.Text = lblpmsphmdval.Text;

                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;

            }
            else if (lblrmtmp.Visible == true && lblstpt.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                //					lblhmdval.Text = "45";
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltrmval.Text = "65";
                lbltspval.Text = lblstptval.Text;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lbltper.Visible = false;
                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;

            }
            else if (lblrmtmp.Visible == true && lbloutside.Visible == true && lbltime.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                //					lbloutval.Text = "45";
                //					lbltimeval.Text = "07:12";
                //					lbltimeam.Visible = true;

                lbltrmval.Text = "65";
                lbltotval.Text = "45";
                //					lblttmval.Text = "07:12";
                lblthour.Text = "07";
                lbltmin.Text = "12";
                lblthour.Visible = true;
                lbltcolon.Visible = true;
                lbltmin.Visible = true;
                lbltpm.Visible = false;
                lbltam.Visible = true;
                //					lblttmam.Visible = true;
                //					lblttmval.Visible = true;
                lblttime.Visible = true;
                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltsp.Visible = false;
                lbltspval.Visible = false;
                lbltdeg.Visible = false;
                lbltper.Visible = false;
                lbltot.Visible = true;
                lbltotval.Visible = true;
                lbltotdeg.Visible = true;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lbloutside.Visible == true && lblstpt.Visible == true)
            {
                //					lbloutval.Text = "65";
                //      			lblhmdval.Text = "45";
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltot.Visible = true;
                lbltsp.Visible = true;
                lbltotval.Visible = true;
                lbltotdeg.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lbltper.Visible = false;

                lbltotval.Text = "65";
                lbltspval.Text = lblstptval.Text;

                lbltrm.Visible = false;
                lbltrmval.Visible = false;
                lbltrmdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lblrmtmp.Visible == true && lbltime.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                //					lblhmdval.Text = "45";
                //					lbltimeval.Text = "07:12";
                //					lbltimeam.Visible = true;

                lbltrmval.Text = "65";
                lblthour.Text = "07";
                lbltmin.Text = "12";
                //					lblttmval.Text = "07:12";
                //					lblttmam.Visible = true;
                //					lblttmval.Visible = true;
                lblttime.Visible = true;
                lblthour.Visible = true;
                lbltcolon.Visible = true;
                lbltmin.Visible = true;
                lbltam.Visible = true;
                lbltpm.Visible = false;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltsp.Visible = false;
                lbltspval.Visible = false;
                lbltper.Visible = false;
                lbltdeg.Visible = false;
                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lblstpt.Visible == true)
            {
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltper.Visible = false;
                lbltdeg.Visible = true;
                lbltspval.Text = lblstptval.Text;

                lbltrm.Visible = false;
                lbltrmval.Visible = false;
                lbltrmdeg.Visible = false;
                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else
            {
                //Message("");
            }

            gbcontractor.Visible = false;
            gbtenant.Visible = true;

            gb2.Visible = false;
            gb2disp.Visible = false;
            gb1disp.Visible = true;
            gb1.Visible = true;


        }

        private void cmduaup_Click(object sender, EventArgs e)
        {
			 cmduadown.Enabled = true;

			 if(lbluahmd.Visible == true)
			 {lbluahmdval.Text = "YES";}
			 else if(lbluaco2.Visible == true)
			 {lbluaco2val.Text = "YES";}
			 else if(lbluatmpadj.Visible == true)
			 {lbluatmpval.Text = "YES";
			 cmdtup.Enabled = true;
			 cmdtdown.Enabled = true;}
			 else if(lbluasysmde.Visible == true)
			 {lbluasysval.Text = "YES";}

//			 if (lbltspval.Visible == true && (System.Convert.ToByte(lbltspval.Text)) < (System.Convert.ToByte(lblpmlmthival.Text)))
			else if (lblmin.Visible == true && lblhour.Visible == true && lblcolon.Visible ==true)
			{	lblmin.Text = System.Convert.ToString(System.Convert.ToUInt32(lblmin.Text) + 1) ;
				if(System.Convert.ToUInt32(lblmin.Text)>59)
				{lblmin.Text = "00";
				lblhour.Text = System.Convert.ToString(System.Convert.ToUInt32(lblhour.Text) + 1) ;}
				if(System.Convert.ToUInt32(lblmin.Text) <10)
				{lblmin.Text = "0" + System.Convert.ToString(System.Convert.ToUInt32(lblmin.Text)) ;}
				if(System.Convert.ToUInt32(lblhour.Text) <10)
				{lblhour.Text = "0" + System.Convert.ToString(System.Convert.ToUInt32(lblhour.Text)) ;}
				if(System.Convert.ToUInt32(lblhour.Text) >23)
				{lblhour.Text = "00";}

				if(System.Convert.ToUInt32(lblhour.Text) >11 && System.Convert.ToUInt32(lblhour.Text)<=24)
				{lblam.Visible = false;
				lblpm.Visible = true;}
				if(System.Convert.ToUInt32(lblhour.Text)<12)
				{lblam.Visible = true;
				lblpm.Visible = false;}
			 }

			 else if(lblstptval.Visible == true && (System.Convert.ToByte(lblstptval.Text)) < (System.Convert.ToByte(lblpmlmthival.Text)))
			 {lblstptval.Text = System.Convert.ToString(System.Convert.ToByte (lblstptval.Text) + 1);}
			 
//			 else if(lbltimeval.Visible == true)
//			 {lbltimeval.Text = System.Convert.ToString(lbltimeval.Text));}

			 else if(lblpmsphmdval.Visible == true && System.Convert.ToByte(lblpmsphmdval.Text) < 95)
			 {lblpmsphmdval.Text = System.Convert.ToString(System.Convert.ToByte (lblpmsphmdval.Text) + 1);}
			 else if(lblpmspco2val.Visible == true && System.Convert.ToInt16(lblpmspco2val.Text) < 900)
			 {lblpmspco2val.Text = System.Convert.ToString(System.Convert.ToInt16 (lblpmspco2val.Text) + 1);}
			 else if(lblpmsphtval.Visible == true && System.Convert.ToByte(lblpmsphtval.Text) < 80)
			 {lblpmsphtval.Text = System.Convert.ToString(System.Convert.ToByte (lblpmsphtval.Text) + 1);}
			 else if(lblpmspclval.Visible == true && System.Convert.ToByte(lblpmspclval.Text) < 90)
			 {lblpmspclval.Text = System.Convert.ToString(System.Convert.ToByte (lblpmspclval.Text) + 1);}
			 
			 else if(lblpmlmthival.Visible == true && System.Convert.ToByte(lblpmlmthival.Text) < 85)
			 {lblpmlmthival.Text = System.Convert.ToString(System.Convert.ToByte (lblpmlmthival.Text) + 1);}
			 else if(lblpmlmtloval.Visible == true && System.Convert.ToByte(lblpmlmtloval.Text) < 70)
			 {lblpmlmtloval.Text = System.Convert.ToString(System.Convert.ToByte (lblpmlmtloval.Text) + 1);}
			 
			 else if(lblpmblhtdctval.Visible == true && System.Convert.ToDouble(lblpmblhtdctval.Text) < 10.0)
			 {lblpmblhtdctval.Text = System.Convert.ToString(System.Convert.ToDouble (lblpmblhtdctval.Text) + 0.1);}
			 else if(lblpmblcldctval.Visible == true && System.Convert.ToDouble(lblpmblcldctval.Text) < 8.0)
			 {lblpmblcldctval.Text = System.Convert.ToString(System.Convert.ToDouble (lblpmblcldctval.Text) + 0.1);}
			 else if(lblpmblhtfloval.Visible == true && System.Convert.ToInt16(lblpmblhtfloval.Text) < 700)
			 {lblpmblhtfloval.Text = System.Convert.ToString(System.Convert.ToInt16 (lblpmblhtfloval.Text) + 1);}
			 else if(lblpmblclfloval.Visible == true && System.Convert.ToInt16(lblpmblclfloval.Text) < 700)
			 {lblpmblclfloval.Text = System.Convert.ToString(System.Convert.ToInt16 (lblpmblclfloval.Text) + 1);}

			 else
			 {cmduaup.Enabled = false;}

        }

        private void cmduadown_Click(object sender, EventArgs e)
        {
			 cmduaup.Enabled = true;

			 if(lbluahmd.Visible == true)
			 {lbluahmdval.Text = "NO";}
			 else if(lbluaco2.Visible == true)
			 {lbluaco2val.Text = "NO";}
			 else if(lbluatmpadj.Visible == true)
			 {lbluatmpval.Text = "NO";
			 cmdtup.Enabled = false;
			 cmdtdown.Enabled = false;}
			 else if(lbluasysmde.Visible == true)
			 {lbluasysval.Text = "NO";}
//			 {lbluasysval.Text = "NO";}
//			 if (lbltspval.Visible == true && (System.Convert.ToByte(lbltspval.Text)) < (System.Convert.ToByte(lblpmlmthival.Text)))

			else if (lblmin.Visible == true && lblhour.Visible == true && lblcolon.Visible ==true)
			{	
				lblmin.Text = System.Convert.ToString(System.Convert.ToUInt32(lblmin.Text) - 1) ;
				if(System.Convert.ToUInt32(lblmin.Text)<1)
				{lblmin.Text = "59";
				lblhour.Text = System.Convert.ToString(System.Convert.ToUInt32(lblhour.Text) - 1) ;}
				if(System.Convert.ToUInt32(lblmin.Text) <10)
				{lblmin.Text = "0" + System.Convert.ToString(System.Convert.ToUInt32(lblmin.Text)) ;}
				if(System.Convert.ToUInt32(lblhour.Text) <10)
				{lblhour.Text = "0" + System.Convert.ToString(System.Convert.ToUInt32(lblhour.Text)) ;}
				if(System.Convert.ToUInt32(lblhour.Text) <1)
				{lblhour.Text = "00";}

				if(System.Convert.ToUInt32(lblhour.Text) >11 && System.Convert.ToUInt32(lblhour.Text)<=24)
				{lblam.Visible = false;
				lblpm.Visible = true;}
				if(System.Convert.ToUInt32(lblhour.Text)<12)
				{lblam.Visible = true;
				lblpm.Visible = false;}
			 }
			 else if(lblstptval.Visible == true && (System.Convert.ToByte(lblstptval.Text)) > (System.Convert.ToByte(lblpmlmtloval.Text)))
			 { lblstptval.Text = System.Convert.ToString(System.Convert.ToByte (lblstptval.Text) - 1);}
			 else if(lblpmsphmdval.Visible == true && System.Convert.ToByte(lblpmsphmdval.Text) > 65)
			 {lblpmsphmdval.Text = System.Convert.ToString(System.Convert.ToByte (lblpmsphmdval.Text) - 1);}
			 else if(lblpmspco2val.Visible == true && System.Convert.ToInt16(lblpmspco2val.Text) > 700)
			 {lblpmspco2val.Text = System.Convert.ToString(System.Convert.ToInt16 (lblpmspco2val.Text) - 1);}
			 else if(lblpmsphtval.Visible == true && System.Convert.ToByte(lblpmsphtval.Text) > 50)
			 {lblpmsphtval.Text = System.Convert.ToString(System.Convert.ToByte (lblpmsphtval.Text) - 1);}
			 else if(lblpmspclval.Visible == true && System.Convert.ToByte(lblpmspclval.Text) > 60)
			 {lblpmspclval.Text = System.Convert.ToString(System.Convert.ToByte (lblpmspclval.Text) - 1);}

			 else if(lblpmlmthival.Visible == true && System.Convert.ToByte(lblpmlmthival.Text) > 75)
			 {lblpmlmthival.Text = System.Convert.ToString(System.Convert.ToByte (lblpmlmthival.Text) - 1);}
			 else if(lblpmlmtloval.Visible == true && System.Convert.ToByte(lblpmlmtloval.Text) > 60)
			 {lblpmlmtloval.Text = System.Convert.ToString(System.Convert.ToByte (lblpmlmtloval.Text) - 1);}

			 else if(lblpmblhtdctval.Visible == true && System.Convert.ToDouble(lblpmblhtdctval.Text) > 6.0)
			 {lblpmblhtdctval.Text = System.Convert.ToString(System.Convert.ToDouble (lblpmblhtdctval.Text) - 0.1);}
			 else if(lblpmblcldctval.Visible == true && System.Convert.ToDouble(lblpmblcldctval.Text) > 5.0)
			 {lblpmblcldctval.Text = System.Convert.ToString(System.Convert.ToDouble (lblpmblcldctval.Text) - 0.1);}
			 else if(lblpmblhtfloval.Visible == true && System.Convert.ToInt16(lblpmblhtfloval.Text) > 400)
			 {lblpmblhtfloval.Text = System.Convert.ToString(System.Convert.ToInt16 (lblpmblhtfloval.Text) - 1);}
			 else if(lblpmblclfloval.Visible == true && System.Convert.ToInt16(lblpmblclfloval.Text) > 400)
			 {lblpmblclfloval.Text = System.Convert.ToString(System.Convert.ToInt16 (lblpmblclfloval.Text) - 1);}

			 else
			 {cmduadown.Enabled = false;}

        }

        private void cmdtup_Click(object sender, EventArgs e)
        {
			 cmdtdown.Enabled = true;
			 if (lbltspval.Visible == true && (System.Convert.ToByte(lbltspval.Text)) < (System.Convert.ToByte(lblpmlmthival.Text)))
			 {lbltspval.Text = System.Convert.ToString(System.Convert.ToByte (lbltspval.Text) + 1);} 
//			 bTemp = bTemp + 1;
//			 label7.Text = System.Convert.ToString(bTemp); 
			 else if(lbltHumidval.Visible == true &&  System.Convert.ToByte(lbltHumidval.Text) < 80)
			 {lbltHumidval.Text = System.Convert.ToString(System.Convert.ToByte (lbltHumidval.Text) + 1);}

			 else if(lbltCo2val.Visible == true &&  System.Convert.ToInt16(lbltCo2val.Text) < 860)
			 {lbltCo2val.Text = System.Convert.ToString(System.Convert.ToInt16 (lbltCo2val.Text) + 1);}

			 else if(lbltHmdspval.Visible == true &&  System.Convert.ToByte(lbltHmdspval.Text) < 80)
			 {lbltHmdspval.Text = System.Convert.ToString(System.Convert.ToByte (lbltHmdspval.Text) + 1);}	
			 else if (lbltmin.Visible == true && lblthour.Visible == true && lbltcolon.Visible ==true)
			  {	
				lbltmin.Text = System.Convert.ToString(System.Convert.ToUInt32(lbltmin.Text) + 1) ;
				if(System.Convert.ToUInt32(lbltmin.Text)>59)
				{lbltmin.Text = "00";
				lblthour.Text = System.Convert.ToString(System.Convert.ToUInt32(lblthour.Text) + 1) ;}
				if(System.Convert.ToUInt32(lbltmin.Text) <10)
				{lbltmin.Text = "0" + System.Convert.ToString(System.Convert.ToUInt32(lbltmin.Text)) ;}
				if(System.Convert.ToUInt32(lblthour.Text) <10)
				{lblthour.Text = "0" + System.Convert.ToString(System.Convert.ToUInt32(lblthour.Text)) ;}
				if(System.Convert.ToUInt32(lblthour.Text) >23)
				{lblthour.Text = "00";}

				if(System.Convert.ToUInt32(lblthour.Text) >11 && System.Convert.ToUInt32(lblthour.Text)<=24)
				{lbltam.Visible = false;
				lbltpm.Visible = true;}
				if(System.Convert.ToUInt32(lblthour.Text)<12)
				{lbltam.Visible = true;
				lbltpm.Visible = false;}
			 }
			 else
			 {cmdtup.Enabled = false;}

        }

        private void cmdtdown_Click(object sender, EventArgs e)
        {
			 cmdtup.Enabled = true;
			 if (lbltspval.Visible == true && (System.Convert.ToByte(lbltspval.Text)) > (System.Convert.ToByte(lblpmlmtloval.Text)))
			 {lbltspval.Text = System.Convert.ToString(System.Convert.ToByte (lbltspval.Text) - 1);} 
//			 bTemp = bTemp + 1;
//			 label7.Text = System.Convert.ToString(bTemp); 
			 else if(lbltHumidval.Visible == true &&  System.Convert.ToByte(lbltHumidval.Text) > 65)
			 {lbltHumidval.Text = System.Convert.ToString(System.Convert.ToByte (lbltHumidval.Text) - 1);}

			 else if(lbltCo2val.Visible == true &&  System.Convert.ToInt16(lbltCo2val.Text) > 825)
			 {lbltCo2val.Text = System.Convert.ToString(System.Convert.ToInt16 (lbltCo2val.Text) - 1);}

			 else if(lbltHmdspval.Visible == true &&  System.Convert.ToByte(lbltHmdspval.Text) > 65)
			 {lbltHmdspval.Text = System.Convert.ToString(System.Convert.ToByte (lbltHmdspval.Text) - 1);}	
			else if (lbltmin.Visible == true && lblthour.Visible == true && lbltcolon.Visible ==true)
			 {	
				lbltmin.Text = System.Convert.ToString(System.Convert.ToUInt32(lbltmin.Text) - 1) ;
				if(System.Convert.ToUInt32(lbltmin.Text)<1)
				{lbltmin.Text = "59";
				lblthour.Text = System.Convert.ToString(System.Convert.ToUInt32(lblthour.Text) - 1) ;}
				if(System.Convert.ToUInt32(lbltmin.Text) <10)
				{lbltmin.Text = "0" + System.Convert.ToString(System.Convert.ToUInt32(lbltmin.Text)) ;}
				if(System.Convert.ToUInt32(lblthour.Text) <10)
				{lblthour.Text = "0" + System.Convert.ToString(System.Convert.ToUInt32(lblthour.Text)) ;}
				if(System.Convert.ToUInt32(lblthour.Text) <1)
				{lblthour.Text = "00";}

				if(System.Convert.ToUInt32(lblthour.Text) >11 && System.Convert.ToUInt32(lblthour.Text)<=24)
				{lbltam.Visible = false;
				lbltpm.Visible = true;}
				if(System.Convert.ToUInt32(lblthour.Text)<12)
				{lbltam.Visible = true;
				lbltpm.Visible = false;}
			 }
			 else
			 {cmdtdown.Enabled = false;}

        }

        private void cmdtcancel_Click(object sender, EventArgs e)
        {
            gb2.Visible = false;
            gb2disp.Visible = false;
            gb1disp.Visible = true;
            gb1.Visible = true;

            lbltrm.Visible = true;
            lbltot.Visible = true;
            //			 label3.Visible =true;
            lbltrmval.Visible = true;
            lbltrmdeg.Visible = true;
            lbltotval.Visible = true;
            lbltotdeg.Visible = true;
            lbltsp.Visible = true;
            //			 label8.Visible =true;
            //			 label9.Visible =true;
            lbltdeg.Visible = true;

            lblthmd.Visible = false;
            lblthmdval.Visible = false;
            lblttime.Visible = false;
            lblthour.Visible = false;
            lbltmin.Visible = false;
            lbltcolon.Visible = false;
            lbltam.Visible = false;
            lbltpm.Visible = false;
            lbltrem.Visible = false;

            lbltspval.Visible = true;
            lbltper.Visible = false;
            lblthmdy.Visible = false;
            lbltco2.Visible = false;

            lbltspval.Text = lblstptval.Text;
            lbltHumidval.Text = lblpmsphmdval.Text;
            lbltCo2val.Text = lblpmspco2val.Text;
            lbltHmdspval.Text = "70";

            lbltHumidval.Visible = false;
            lbltCo2val.Visible = false;
            lbltHmdspval.Visible = false;
            //occ images
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = true;
            //fan images
            pbfanauto.Visible = false;
            pbfanbar1.Visible = false;
            pbfanbar2.Visible = false;
            pbfanbar3.Visible = false;
            pbfanoff.Visible = true;

        }

        private void cmdtdone_Click(object sender, EventArgs e)
        {
            if (lbluatmpval.Text == "NO")
            {
                cmdtup.Enabled = false;
                cmdtdown.Enabled = false;
            }
            else
            {
                cmdtup.Enabled = true;
                cmdtdown.Enabled = true;
            }

            if (lbluahmdval.Text == "YES")
            {
                lblthmdval.Text = lbltHumidval.Text;
            }

            gb2.Visible = false;
            gb2disp.Visible = false;
            gb1disp.Visible = true;
            gb1.Visible = true;

            lbltrm.Visible = false;
            lbltot.Visible = false;
            //			 label3.Visible =true;
            lbltrmval.Visible = false;
            lbltrmdeg.Visible = false;
            lbltotval.Visible = false;
            lbltotdeg.Visible = false;
            //			 lbltsp.Visible =false;
            //			 lbltdeg.Visible =false;
            lbltper.Visible = false;

            lbltsp.Visible = true;
            lbltspval.Visible = true;
            lbltdeg.Visible = true;

            lblthmd.Visible = false;
            lblthmdval.Visible = false;
            lblttime.Visible = false;
            lbltrem.Visible = false;

            //			 lbltspval.Visible =false;

            lbltper.Visible = false;
            lblthmdy.Visible = false;
            lbltco2.Visible = false;

            lbltHumidval.Visible = false;
            lbltCo2val.Visible = false;
            lbltHmdspval.Visible = false;

            //occ images
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = true;
            //fan images
            pbfanauto.Visible = false;
            pbfanbar1.Visible = false;
            pbfanbar2.Visible = false;
            pbfanbar3.Visible = false;
            pbfanoff.Visible = true;

            //from contractor done:
            if (lblrmtmp.Visible == true && lbloutside.Visible == true && lblstpt.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                //					lbloutval.Text = "45";
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;

                lbltot.Visible = true;
                lbltotval.Visible = true;
                lbltotdeg.Visible = true;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lbltper.Visible = false;

                lbltrmval.Text = "65";
                lbltotval.Text = "45";
                lbltspval.Text = lblstptval.Text;

                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lblrmtmp.Visible == true && lblhmdity.Visible == true && lblstpt.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                lblhmdval.Text = lblpmsphmdval.Text;
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltper.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lblthmd.Visible = true;
                lblthmdval.Visible = true;

                lbltrmval.Text = "65";
                lbltspval.Text = lblstptval.Text;
                lblthmdval.Text = lblpmsphmdval.Text;
                //					lbltHumidval.Text = lblpmsphmdval.Text;
                if (lbluahmdval.Text == "YES")
                {
                    lblthmdval.Text = lbltHumidval.Text;
                }
                //					lblthmdval.Text = lblpmsphmdval.Text;

                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;

            }
            else if (lblrmtmp.Visible == true && lblstpt.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                //					lblhmdval.Text = "45";
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltrmval.Text = "65";
                lbltspval.Text = lblstptval.Text;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lbltper.Visible = false;
                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;

            }
            else if (lblrmtmp.Visible == true && lbloutside.Visible == true && lbltime.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                //					lbloutval.Text = "45";
                //					lbltimeval.Text = "07:12";
                //					lbltimeam.Visible = true;

                lbltrmval.Text = "65";
                lbltotval.Text = "45";
                //					lblttmval.Text = "07:12";
                lblthour.Text = "07";
                lbltmin.Text = "12";
                lblthour.Visible = true;
                lbltcolon.Visible = true;
                lbltmin.Visible = true;
                lbltam.Visible = true;
                lbltpm.Visible = false;
                //					lblttmam.Visible = true;
                //					lblttmval.Visible = true;
                lblttime.Visible = true;
                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltsp.Visible = false;
                lbltspval.Visible = false;
                lbltdeg.Visible = false;
                lbltper.Visible = false;
                lbltot.Visible = true;
                lbltotval.Visible = true;
                lbltotdeg.Visible = true;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lbloutside.Visible == true && lblstpt.Visible == true)
            {
                //					lbloutval.Text = "65";
                //      			lblhmdval.Text = "45";
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltot.Visible = true;
                lbltsp.Visible = true;
                lbltotval.Visible = true;
                lbltotdeg.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lbltper.Visible = false;

                lbltotval.Text = "65";
                lbltspval.Text = lblstptval.Text;

                lbltrm.Visible = false;
                lbltrmval.Visible = false;
                lbltrmdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lblrmtmp.Visible == true && lbltime.Visible == true)
            {
                //					lblrmtmpval.Text = "65";
                //					lblhmdval.Text = "45";
                //					lbltimeval.Text = "07:12";
                //					lbltimeam.Visible = true;

                lbltrmval.Text = "65";
                //					lblttmval.Text = "07:12";
                lblthour.Text = "07";
                lbltmin.Text = "12";
                lblthour.Visible = true;
                lbltcolon.Visible = true;
                lbltmin.Visible = true;
                lbltam.Visible = true;
                lbltpm.Visible = false;

                //					lblttmam.Visible = true;
                //					lblttmval.Visible = true;
                lblttime.Visible = true;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltsp.Visible = false;
                lbltspval.Visible = false;
                lbltper.Visible = false;
                lbltdeg.Visible = false;
                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lblstpt.Visible == true)
            {
                //					lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltper.Visible = false;
                lbltdeg.Visible = true;
                lbltspval.Text = lblstptval.Text;

                lbltrm.Visible = false;
                lbltrmval.Visible = false;
                lbltrmdeg.Visible = false;
                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else
            {
                //Message("");
            }


        }

        private void cmdtnext_Click(object sender, EventArgs e)
        {
            itnx = itnx + 1;
            int ctnx;
            ctnx = itnx % 3;
            switch (ctnx)
            {
                case 1:
                    gb1.Visible = false;
                    gb2.Visible = true;

                    //occ images
                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    //fan images
                    pbfanauto.Visible = false;
                    pbfanbar1.Visible = false;
                    pbfanbar2.Visible = false;
                    pbfanbar3.Visible = false;
                    pbfanoff.Visible = false;

                    lbltrm.Visible = false;
                    lbltot.Visible = false;
                    lblthmd.Visible = false;
                    lblthmdval.Visible = false;
                    lbltrmval.Visible = false;
                    lbltrmdeg.Visible = false;
                    lbltotval.Visible = false;
                    lbltotdeg.Visible = false;
                    lbltsp.Visible = false;
                    lblttime.Visible = false;
                    lbltrem.Visible = false;
                    //				lblttmval.Visible = false;
                    //				lblttmam.Visible = false;
                    //				lblttmpm.Visible = false;
                    lblthour.Visible = false;
                    lbltcolon.Visible = false;
                    lbltmin.Visible = false;
                    lbltam.Visible = false;
                    lbltpm.Visible = false;
                    lbltdeg.Visible = false;
                    lbltper.Visible = false;

                    lbltspval.Visible = false;
                    lbltHumidval.Visible = false;
                    lbltHmdspval.Visible = false;

                    lbltco2.Visible = true;
                    lbltCo2val.Visible = true;

                    lblthmdy.Visible = false;

                    cmdtup.Enabled = true;
                    cmdtdown.Enabled = true;
                    //		    	if(lbluahmdval.Text == "NO")
                    //					{cmdtup.Enabled = false;}
                    if (lbluaco2val.Text == "NO")
                    {
                        lbltCo2val.Text = lblpmspco2val.Text;
                        cmdtup.Enabled = false;
                        cmdtdown.Enabled = false;
                    }
                    //				else if(lbluatmpval.Text == "NO")
                    //					{cmdtup.Enabled = false;}
                    else
                    {
                        cmdtup.Enabled = true;
                        cmdtdown.Enabled = true;
                    }

                    break;
                case 2:
                    gb1.Visible = false;
                    gb2.Visible = true;

                    //occ images
                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    //fan images
                    pbfanauto.Visible = false;
                    pbfanbar1.Visible = false;
                    pbfanbar2.Visible = false;
                    pbfanbar3.Visible = false;
                    pbfanoff.Visible = false;

                    lbltrm.Visible = false;
                    lbltot.Visible = false;
                    lblthmd.Visible = false;
                    lblthmdval.Visible = false;
                    lbltrmval.Visible = false;
                    lbltrmdeg.Visible = false;
                    lbltotval.Visible = false;
                    lbltotdeg.Visible = false;
                    lbltsp.Visible = false;
                    lblttime.Visible = false;
                    lbltrem.Visible = false;
                    //				lblttmval.Visible = false;
                    //				lblttmam.Visible = false;
                    //				lblttmpm.Visible = false;
                    lblthour.Visible = false;
                    lbltcolon.Visible = false;
                    lbltmin.Visible = false;
                    lbltam.Visible = false;
                    lbltpm.Visible = false;
                    lbltdeg.Visible = false;
                    lbltco2.Visible = false;

                    lbltsp.Visible = true;
                    lbltspval.Visible = false;

                    lbltHmdspval.Visible = true;
                    lbltCo2val.Visible = false;
                    lbltHumidval.Visible = false;

                    lbltper.Visible = true;
                    lblthmdy.Visible = true;

                    cmdtup.Enabled = true;
                    cmdtdown.Enabled = true;
                    //		    	if(lbluahmdval.Text == "NO")
                    //					{cmdtup.Enabled = false;}
                    //				else if(lbluaco2val.Text == "NO")
                    //					{cmdtup.Enabled = false;}
                    /*				if(lbluatmpval.Text == "NO")
                                    {cmdtup.Enabled = false;
                                    cmdtdown.Enabled = false;}
                                    else
                                    {cmdtup.Enabled = true;
                                    cmdtdown.Enabled = true;}*/
                    break;
                case 0:
                    gb1.Visible = false;
                    gb2.Visible = true;
                    gb1disp.Visible = false;
                    gb2disp.Visible = true;

                    lbltrm.Visible = false;
                    lbltot.Visible = false;
                    lblthmd.Visible = false;
                    lblthmdval.Visible = false;
                    lbltrmval.Visible = false;
                    lbltrmdeg.Visible = false;
                    lbltotval.Visible = false;
                    lbltotdeg.Visible = false;
                    lbltsp.Visible = false;
                    lblttime.Visible = false;
                    lbltrem.Visible = false;
                    //			  lblttmval.Visible = false;
                    //			  lblttmam.Visible = false;
                    //			  lblttmpm.Visible = false;
                    lblthour.Visible = false;
                    lbltcolon.Visible = false;
                    lbltmin.Visible = false;
                    lbltam.Visible = false;
                    lbltpm.Visible = false;
                    lbltdeg.Visible = false;

                    lbltspval.Visible = false;
                    lbltCo2val.Visible = false;
                    lbltHmdspval.Visible = false;

                    lbltper.Visible = true;
                    lblthmdy.Visible = true;
                    lbltHumidval.Visible = true;

                    //occ images
                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    //fan images
                    pbfanauto.Visible = false;
                    pbfanbar1.Visible = false;
                    pbfanbar2.Visible = false;
                    pbfanbar3.Visible = false;
                    pbfanoff.Visible = false;

                    cmdtup.Enabled = true;
                    cmdtdown.Enabled = true;
                    if (lbluahmdval.Text == "NO")
                    {
                        cmdtup.Enabled = false;
                        cmdtdown.Enabled = false;
                    }
                    //				else if(lbluaco2val.Text == "NO")
                    //				{cmdtup.Enabled = false;}
                    //				else if(lbluatmpval.Text == "NO")
                    //				{cmdtup.Enabled = false;}
                    else
                    {
                        cmdtup.Enabled = true;
                        cmdtdown.Enabled = true;
                    }
                    break;
            }

        }

        private void cmdtocc_Click(object sender, EventArgs e)
        {
            iocc = iocc + 1;
            int tocc;
            tocc = iocc % 3;
            switch (tocc)
            {
                case 1:
                    pb1.Visible = true;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    break;
                case 2:
                    pb1.Visible = false;
                    pb2.Visible = true;
                    pb3.Visible = false;
                    break;
                case 0:
                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = true;
                    break;
            }


        }

        private void cmdtfan_Click(object sender, EventArgs e)
        {
            ifan = ifan + 1;
            int tfan;
            tfan = ifan % 5;
            switch (tfan)
            {
                case 1:
                    pbfanauto.Visible = true;
                    pbfanbar1.Visible = false;
                    pbfanbar2.Visible = false;
                    pbfanbar3.Visible = false;
                    pbfanoff.Visible = false;
                    break;
                case 2:
                    pbfanauto.Visible = false;
                    pbfanbar1.Visible = true;
                    pbfanbar2.Visible = false;
                    pbfanbar3.Visible = false;
                    pbfanoff.Visible = false;
                    break;
                case 3:
                    pbfanauto.Visible = false;
                    pbfanbar1.Visible = false;
                    pbfanbar2.Visible = true;
                    pbfanbar3.Visible = false;
                    pbfanoff.Visible = false;
                    break;
                case 4:
                    pbfanauto.Visible = false;
                    pbfanbar1.Visible = false;
                    pbfanbar2.Visible = false;
                    pbfanbar3.Visible = true;
                    pbfanoff.Visible = false;
                    break;
                case 0:
                    pbfanauto.Visible = false;
                    pbfanbar1.Visible = false;
                    pbfanbar2.Visible = false;
                    pbfanbar3.Visible = false;
                    pbfanoff.Visible = true;
                    break;
            }

        }

        private void cmdtvmore_Click(object sender, EventArgs e)
        {
            gb1.Visible = false;
            gb2.Visible = true;
            gb1disp.Visible = false;
            gb2disp.Visible = true;

            cmdtup.Enabled = true;
            cmdtdown.Enabled = true;
            if (lbluahmdval.Text == "NO")
            {
                lbltHumidval.Text = lblpmsphmdval.Text;
                lblthmdval.Text = lblpmsphmdval.Text;
                cmdtup.Enabled = false;
                cmdtdown.Enabled = false;
            }
            //		  else if(lbluaco2val.Text == "NO")
            //		  {cmdtup.Enabled = false;}
            //		  else if(lbluatmpval.Text == "NO")
            //		  {cmdtup.Enabled = false;}
            else
            {
                cmdtup.Enabled = true;
                cmdtdown.Enabled = true;
            }

            lbltrm.Visible = false;
            lbltot.Visible = false;
            lblthmd.Visible = false;
            lbltrmval.Visible = false;
            lbltrmdeg.Visible = false;
            lbltotval.Visible = false;
            lbltotdeg.Visible = false;
            lblthmdval.Visible = false;
            lbltsp.Visible = false;
            lblttime.Visible = false;
            //		  lblttmval.Visible = false;
            //		  lblttmam.Visible = false;
            //		  lblttmpm.Visible = false;
            lblthour.Visible = false;
            lbltcolon.Visible = false;
            lbltmin.Visible = false;
            lbltam.Visible = false;
            lbltpm.Visible = false;
            lbltrem.Visible = false;
            lbltdeg.Visible = false;

            lbltspval.Visible = false;
            lbltCo2val.Visible = false;
            lbltHmdspval.Visible = false;

            lbltper.Visible = true;
            lblthmdy.Visible = true;
            lbltHumidval.Visible = true;

            //occ images
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            //fan images
            pbfanauto.Visible = false;
            pbfanbar1.Visible = false;
            pbfanbar2.Visible = false;
            pbfanbar3.Visible = false;
            pbfanoff.Visible = false;

        }

        private void cmddisoptn_Click(object sender, EventArgs e)
        {
            gbsecond.Visible = true;
            gbfirst.Visible = false;
            gbthird.Visible = false;

            gbbtone.Visible = false;
            gbbttwo.Visible = true;

            lblrmtmpval.Text = "00";
            lbloutval.Text = "00";
            lblstptval.Text = "00";
            //			 lblhmdval.Text = "00";

            lblrmtmp.Visible = true;
            lblrmtmpval.Visible = true;
            lblrmdeg.Visible = true;
            lbloutside.Visible = true;
            lbloutval.Visible = true;
            lbloutdeg.Visible = true;
            lblstpt.Visible = true;
            lblstptval.Visible = true;
            lblstptdeg.Visible = true;

            lblhmdity.Visible = false;
            lblhmdval.Visible = false;
            //				lbltimeval.Visible = false;
            //				lbltimeam.Visible = false;
            //				lbltimepm.Visible = false;
            lblmin.Visible = false;
            lblhour.Visible = false;
            lblcolon.Visible = false;
            lblam.Visible = false;
            lblpm.Visible = false;
            lbltime.Visible = false;

        }

        private void cmduseracc_Click(object sender, EventArgs e)
        {
            gbuasecond.Visible = true;
            gbuafirst.Visible = false;
            gblcddisp.Visible = false;
            gbuseraccess.Visible = true;
            gbbtone.Visible = false;
            gbbttwo.Visible = false;
            gbbtthree.Visible = true;

            lbluahmd.Visible = true;
            lbluastpt.Visible = true;
            lbluahmdval.Visible = true;

            lbluaco2.Visible = false;
            lbluaco2val.Visible = false;

            lbluatmpadj.Visible = false;
            lbluatmpval.Visible = false;

            lbluasysval.Visible = false;
            lbluasysmde.Visible = false;

        }

        private void cmdparam_Click(object sender, EventArgs e)
        {
            gblcddisp.Visible = false;
            gbuseraccess.Visible = false;
            gbparameters.Visible = true;
            gbparamsetpt.Visible = false;
            gbparamlimit.Visible = false;
            gbparambal.Visible = false;
            gbbtone.Visible = false;
            gbbttwo.Visible = false;
            gbbtthree.Visible = false;
            gbbtpmstpt.Visible = true;
            gbpmfirst.Visible = true;

            lblpmstpt.Visible = true;
            lblpmbalanc.Visible = false;
            lblpmlmt.Visible = false;


        }

        private void cmdcancel_Click(object sender, EventArgs e)
        {
            gbsecond.Visible = false;
            gbfirst.Visible = true;
            gbthird.Visible = false;

            gbbtone.Visible = true;
            gbbttwo.Visible = false;

            lblrmtmpval.Text = "65";
            lbloutval.Text = "45";
            lblstptval.Text = "70";

            lblrmtmp.Visible = true;
            lblrmtmpval.Visible = true;
            lblrmdeg.Visible = true;
            lbloutside.Visible = true;
            lbloutval.Visible = true;
            lbloutdeg.Visible = true;
            lblstpt.Visible = true;
            lblstptval.Visible = true;
            lblstptdeg.Visible = true;

            lblhmdity.Visible = false;
            lblhmdval.Visible = false;
            //			 lbltimeval.Visible = false;
            //			 lbltimeam.Visible = false;
            //			 lbltimepm.Visible = false;
            lblmin.Visible = false;
            lblhour.Visible = false;
            lblcolon.Visible = false;
            lblam.Visible = false;
            lblpm.Visible = false;

            lbltime.Visible = false;

        }

        private void cmddone_Click(object sender, EventArgs e)
        {
            gblcddisp.Visible = true;

            gbbtone.Visible = true;
            gbbttwo.Visible = false;
            gbbtthree.Visible = false;

            if (lblrmtmp.Visible == true && lbloutside.Visible == true && lblstpt.Visible == true)
            {
                //					a[0]=1;
                //					a[1]=1;
                //					a[3]=1;
                lblrmtmpval.Text = "65";
                lbloutval.Text = "45";
                lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;

                lbltot.Visible = true;
                lbltotval.Visible = true;
                lbltotdeg.Visible = true;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;

                lbltrmval.Text = "65";
                lbltotval.Text = "45";
                lbltspval.Text = "70";

                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lblrmtmp.Visible == true && lblhmdity.Visible == true && lblstpt.Visible == true)
            {

                //					a[0]=1;
                //					a[2]=1;
                //					a[3]=1;
                lblrmtmpval.Text = "65";
                lblhmdval.Text = lblpmsphmdval.Text;
                lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lblthmd.Visible = true;
                lblthmdval.Visible = true;

                lbltrmval.Text = "65";
                lbltspval.Text = "70";
                lblthmdval.Text = lblpmsphmdval.Text;

                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;

            }
            else if (lblrmtmp.Visible == true && lblstpt.Visible == true)
            {
                //					a[0]=1;
                //					a[1]=1;
                ////					a[3]=true;
                lblrmtmpval.Text = "65";
                //					lblhmdval.Text = "45";
                lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltrmval.Text = "65";
                lbltspval.Text = "70";

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;

            }
            else if (lblrmtmp.Visible == true && lbloutside.Visible == true && lbltime.Visible == true)
            {
                //					a[0]=1;
                //					a[1]=1;
                //					a[4]=1;
                lblrmtmpval.Text = "65";
                lbloutval.Text = "45";
                //					lbltimeval.Text = "07:12";
                lblhour.Text = "07";
                lblmin.Text = "12";
                //					lbltimeam.Visible = true;
                lblam.Visible = true;

                lbltrmval.Text = "65";
                lbltotval.Text = "45";
                //					lblttmval.Text = "07:12";
                lblthour.Text = "07";
                lbltmin.Text = "12";
                lblthour.Visible = true;
                lbltcolon.Visible = true;
                lbltmin.Visible = true;
                lbltam.Visible = true;
                lbltpm.Visible = false;
                //					lblttmam.Visible = true;
                //					lblttmval.Visible = true;
                lblttime.Visible = true;
                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltsp.Visible = false;
                lbltspval.Visible = false;
                lbltdeg.Visible = false;
                lbltot.Visible = true;
                lbltotval.Visible = true;
                lbltotdeg.Visible = true;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lbloutside.Visible == true && lblstpt.Visible == true)
            {
                //					a[0]=true;
                //					a[1]=1;
                //					a[3]=1;
                lbloutval.Text = "65";
                //      			lblhmdval.Text = "45";
                lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;

                lbltot.Visible = true;
                lbltsp.Visible = true;
                lbltotval.Visible = true;
                lbltotdeg.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;

                lbltotval.Text = "65";
                lbltspval.Text = "70";

                lbltrm.Visible = false;
                lbltrmval.Visible = false;
                lbltrmdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lblrmtmp.Visible == true && lbltime.Visible == true)
            {
                //					a[0]=1;
                ///					a[1]=true;
                //					a[4]=1;
                lblrmtmpval.Text = "65";
                //					lblhmdval.Text = "45";
                //					lbltimeval.Text = "07:12";
                lblhour.Text = "07";
                lblmin.Text = "12";
                lblam.Visible = true;
                //					lbltimeam.Visible = true;

                lbltrmval.Text = "65";
                //					lblttmval.Text = "07:12";
                lblthour.Text = "07";
                lbltmin.Text = "12";
                lblthour.Visible = true;
                lbltcolon.Visible = true;
                lbltmin.Visible = true;
                lbltam.Visible = true;
                lbltpm.Visible = false;
                //					lblttmam.Visible = true;
                //					lblttmval.Visible = true;
                lblttime.Visible = true;

                lbltrm.Visible = true;
                lbltrmval.Visible = true;
                lbltrmdeg.Visible = true;
                lbltsp.Visible = false;
                lbltspval.Visible = false;
                lbltdeg.Visible = false;
                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else if (lblstpt.Visible == true)
            {
                //					a[0]=true;
                //					a[1]=true;
                //					a[3]=1;
                lblstptval.Text = "70";
                //					lblstptdeg.Visible = true;
                lbltsp.Visible = true;
                lbltspval.Visible = true;
                lbltdeg.Visible = true;
                lbltspval.Text = "70";

                lbltrm.Visible = false;
                lbltrmval.Visible = false;
                lbltrmdeg.Visible = false;
                lbltot.Visible = false;
                lbltotval.Visible = false;
                lbltotdeg.Visible = false;
                lblthmd.Visible = false;
                lblthmdval.Visible = false;
                lblttime.Visible = false;
                //					lblttmval.Visible = false;
                //					lblttmam.Visible = false;
                //					lblttmpm.Visible = false;
                lblthour.Visible = false;
                lbltcolon.Visible = false;
                lbltmin.Visible = false;
                lbltam.Visible = false;
                lbltpm.Visible = false;

                lblthmdy.Visible = false;
                lbltco2.Visible = false;
                lbltHumidval.Visible = false;
                lbltCo2val.Visible = false;
                lbltHmdspval.Visible = false;
            }
            else
            {
                //Message("");
            }

        }

        private void cmdnext_Click(object sender, EventArgs e)
        {
            icdnx = icdnx + 1;
            int ccdnx;
            ccdnx = icdnx % 7;
            switch (ccdnx)
            {
                case 1:
                    lblrmtmpval.Text = "00";
                    lblhmdval.Text = "00";
                    lblstptval.Text = "00";
                    lblrmtmp.Visible = true;
                    lblrmtmpval.Visible = true;
                    lblrmdeg.Visible = true;
                    lblstpt.Visible = true;
                    lblstptval.Visible = true;
                    lblstptdeg.Visible = true;
                    lblhmdity.Visible = true;
                    lblhmdval.Visible = true;
                    lbloutside.Visible = false;
                    lbloutval.Visible = false;
                    lbloutdeg.Visible = false;
                    //				lbltimeval.Visible = false;
                    //				lbltimeam.Visible = false;
                    //				lbltimepm.Visible = false;
                    lblmin.Visible = false;
                    lblhour.Visible = false;
                    lblcolon.Visible = false;
                    lblam.Visible = false;
                    lblpm.Visible = false;
                    lbltime.Visible = false;
                    break;
                case 2:
                    lblrmtmpval.Text = "00";
                    //			 lbloutval.Text = "00";
                    lblstptval.Text = "00";
                    lblrmtmp.Visible = true;
                    lblrmtmpval.Visible = true;
                    lblrmdeg.Visible = true;
                    lblstpt.Visible = true;
                    lblstptval.Visible = true;
                    lblstptdeg.Visible = true;
                    lblhmdity.Visible = false;
                    lblhmdval.Visible = false;
                    lbloutside.Visible = false;
                    lbloutval.Visible = false;
                    lbloutdeg.Visible = false;
                    //				lbltimeval.Visible = false;
                    //				lbltimeam.Visible = false;
                    //				lbltimepm.Visible = false;
                    lblmin.Visible = false;
                    lblhour.Visible = false;
                    lblcolon.Visible = false;
                    lblam.Visible = false;
                    lblpm.Visible = false;
                    lbltime.Visible = false;
                    break;
                case 3:
                    lblrmtmpval.Text = "00";
                    lbloutval.Text = "00";
                    lblmin.Text = "00";
                    lblhour.Text = "00";
                    lblrmtmp.Visible = true;
                    lblrmtmpval.Visible = true;
                    lblrmdeg.Visible = true;
                    lblstpt.Visible = false;
                    lblstptval.Visible = false;
                    lblstptdeg.Visible = false;
                    lblhmdity.Visible = false;
                    lblhmdval.Visible = false;
                    lbloutside.Visible = true;
                    lbloutval.Visible = true;
                    lbloutdeg.Visible = true;
                    //				lbltimeval.Visible = true;
                    //				lbltimeam.Visible = false;
                    //				lbltimepm.Visible = false;
                    lblmin.Visible = true;
                    lblhour.Visible = true;
                    lblcolon.Visible = true;
                    lblam.Visible = false;
                    lblpm.Visible = false;
                    lbltime.Visible = true;
                    break;
                case 4:
                    //			 lblrmtmpval.Text = "00";
                    lbloutval.Text = "00";
                    lblstptval.Text = "00";
                    lblrmtmp.Visible = false;
                    lblrmtmpval.Visible = false;
                    lblrmdeg.Visible = false;
                    lblstpt.Visible = true;
                    lblstptval.Visible = true;
                    lblstptdeg.Visible = true;
                    lblhmdity.Visible = false;
                    lblhmdval.Visible = false;
                    lbloutside.Visible = true;
                    lbloutval.Visible = true;
                    lbloutdeg.Visible = true;
                    //				lbltimeval.Visible = false;
                    //				lbltimeam.Visible = false;
                    //				lbltimepm.Visible = false;
                    lblmin.Visible = false;
                    lblhour.Visible = false;
                    lblcolon.Visible = false;
                    lblam.Visible = false;
                    lblpm.Visible = false;
                    lbltime.Visible = false;
                    break;
                case 5:
                    //			 lblrmtmpval.Text = "00";
                    //			 lbloutval.Text = "00";
                    lblstptval.Text = "00";
                    lblrmtmp.Visible = false;
                    lblrmtmpval.Visible = false;
                    lblrmdeg.Visible = false;
                    lblstpt.Visible = true;
                    lblstptval.Visible = true;
                    lblstptdeg.Visible = true;
                    lblhmdity.Visible = false;
                    lblhmdval.Visible = false;
                    lbloutside.Visible = false;
                    lbloutval.Visible = false;
                    lbloutdeg.Visible = false;
                    //				lbltimeval.Visible = false;
                    //				lbltimeam.Visible = false;
                    //				lbltimepm.Visible = false;
                    lblmin.Visible = false;
                    lblhour.Visible = false;
                    lblcolon.Visible = false;
                    lblam.Visible = false;
                    lblpm.Visible = false;
                    lbltime.Visible = false;
                    break;
                case 6:
                    lblrmtmpval.Text = "00";
                    //			 lbloutval.Text = "00";
                    //			 lbltimeval.Text = "00:00";
                    lblmin.Text = "00";
                    lblhour.Text = "00";
                    lblrmtmp.Visible = true;
                    lblrmtmpval.Visible = true;
                    lblrmdeg.Visible = true;
                    lblstpt.Visible = false;
                    lblstptval.Visible = false;
                    lblstptdeg.Visible = false;
                    lblhmdity.Visible = false;
                    lblhmdval.Visible = false;
                    lbloutside.Visible = false;
                    lbloutval.Visible = false;
                    lbloutdeg.Visible = false;
                    //				lbltimeval.Visible = true;
                    //				lbltimeam.Visible = false;
                    //				lbltimepm.Visible = false;
                    lblmin.Visible = true;
                    lblhour.Visible = true;
                    lblcolon.Visible = true;
                    lblam.Visible = false;
                    lblpm.Visible = false;
                    lbltime.Visible = true;
                    break;
                case 0:

                    lblrmtmpval.Text = "00";
                    lbloutval.Text = "00";
                    lblstptval.Text = "00";
                    //			 lblhmdval.Text = "00";
                    lblrmtmp.Visible = true;
                    lblrmtmpval.Visible = true;
                    lblrmdeg.Visible = true;
                    lblstpt.Visible = true;
                    lblstptval.Visible = true;
                    lblstptdeg.Visible = true;
                    lblhmdity.Visible = false;
                    lblhmdval.Visible = false;
                    lbloutside.Visible = true;
                    lbloutval.Visible = true;
                    lbloutdeg.Visible = true;
                    //				lbltimeval.Visible = false;
                    //				lbltimeam.Visible = false;
                    //				lbltimepm.Visible = false;
                    lblmin.Visible = false;
                    lblhour.Visible = false;
                    lblcolon.Visible = false;
                    lblam.Visible = false;
                    lblpm.Visible = false;
                    lbltime.Visible = false;
                    break;
            }

        }

        private void cmduacancel_Click(object sender, EventArgs e)
        {
            gbuasecond.Visible = false;
            gbuafirst.Visible = true;

            gbbtone.Visible = true;
            gbbttwo.Visible = false;
            gbbtthree.Visible = false;

            gblcddisp.Visible = true;
            gbuseraccess.Visible = false;

            lbluahmdval.Text = "YES";
            lbluaco2val.Text = "YES";
            lbluatmpval.Text = "YES";
            lbluasysval.Text = "YES";

        }

        private void cmduadone_Click(object sender, EventArgs e)
        {
            gbuasecond.Visible = false;
            gbuafirst.Visible = true;

            gblcddisp.Visible = true;
            gbuseraccess.Visible = false;

            gbbtone.Visible = true;
            gbbttwo.Visible = false;
            gbbtthree.Visible = false;

        }

        private void cmduanext_Click(object sender, EventArgs e)
        {
            icunx = icunx + 1;
            int ccunx;
            ccunx = icunx % 4;
            switch (ccunx)
            {
                case 1:

                    lbluaco2.Visible = true;
                    lbluaco2val.Visible = true;
                    lbluastpt.Visible = true;

                    lbluahmd.Visible = false;
                    lbluahmdval.Visible = false;

                    lbluatmpadj.Visible = false;
                    lbluatmpval.Visible = false;

                    lbluasysval.Visible = false;
                    lbluasysmde.Visible = false;
                    break;
                case 2:
                    lbluatmpadj.Visible = true;
                    lbluatmpval.Visible = true;
                    lbluastpt.Visible = true;

                    lbluaco2.Visible = false;
                    lbluaco2val.Visible = false;

                    lbluahmd.Visible = false;
                    lbluahmdval.Visible = false;

                    lbluasysval.Visible = false;
                    lbluasysmde.Visible = false;
                    break;
                case 3:
                    lbluasysval.Visible = true;
                    lbluasysmde.Visible = true;

                    lbluastpt.Visible = false;
                    lbluaco2.Visible = false;
                    lbluaco2val.Visible = false;

                    lbluahmd.Visible = false;
                    lbluahmdval.Visible = false;

                    lbluatmpadj.Visible = false;
                    lbluatmpval.Visible = false;
                    break;
                case 0:
                    lbluahmd.Visible = true;
                    lbluastpt.Visible = true;
                    lbluahmdval.Visible = true;

                    lbluaco2.Visible = false;
                    lbluaco2val.Visible = false;

                    lbluatmpadj.Visible = false;
                    lbluatmpval.Visible = false;

                    lbluasysval.Visible = false;
                    lbluasysmde.Visible = false;
                    break;
            }

        }

        private void cmdpmedit_Click(object sender, EventArgs e)
        {

            if (lblpmstpt.Visible == true)
            {
                gblcddisp.Visible = false;
                gbuseraccess.Visible = false;
                gbparameters.Visible = false;
                gbparamsetpt.Visible = true;
                gbparamlimit.Visible = false;
                gbparambal.Visible = false;
                gbbtpmstpt.Visible = false;
                gbbtpmsplmbl.Visible = true;

                cmdpmblnext.Visible = false;
                cmdpmspnext.Visible = true;
                cmdpmlmnext.Visible = false;

                lblpmspstpt.Visible = true;

                lblpmsphmd.Visible = true;
                lblpmsphmdval.Visible = true;
                lblpmsphmdper.Visible = true;

                lblpmspco2.Visible = false;
                lblpmspco2val.Visible = false;

                lblpmspht.Visible = false;
                lblpmsphtval.Visible = false;
                lblpmsphmddeg.Visible = false;

                lblpmspcl.Visible = false;
                lblpmspclval.Visible = false;
            }
            else if (lblpmlmt.Visible == true)
            {
                gblcddisp.Visible = false;
                gbuseraccess.Visible = false;
                gbparameters.Visible = false;
                gbparamsetpt.Visible = false;
                gbparamlimit.Visible = true;
                gbparambal.Visible = false;
                gbbtpmstpt.Visible = false;
                gbbtpmsplmbl.Visible = true;

                cmdpmblnext.Visible = false;
                cmdpmspnext.Visible = false;
                cmdpmlmnext.Visible = true;

                lblpmlmthi.Visible = true;
                lblpmlmthival.Visible = true;

                lblpmlmtlo.Visible = false;
                lblpmlmtloval.Visible = false;

                lblpmlmtdeg.Visible = true;
            }
            else if (lblpmbalanc.Visible == true)
            {
                gblcddisp.Visible = false;
                gbuseraccess.Visible = false;
                gbparameters.Visible = false;
                gbparamsetpt.Visible = false;
                gbparamlimit.Visible = false;
                gbparambal.Visible = true;
                gbbtpmstpt.Visible = false;
                gbbtpmsplmbl.Visible = true;

                cmdpmblnext.Visible = true;
                cmdpmspnext.Visible = false;
                cmdpmlmnext.Visible = false;

                lblpmblhtdct.Visible = true;
                lblpmblhtdctval.Visible = true;
                lblpmbldctinch.Visible = true;

                lblpmblcldct.Visible = false;
                lblpmblcldctval.Visible = false;

                lblpmblhtflo.Visible = false;
                lblpmblhtfloval.Visible = false;

                lblpmblclflo.Visible = false;
                lblpmblclfloval.Visible = false;
                lblpmblflols.Visible = false;
            }
            else
            { }

        }

        private void cmdpmdone_Click(object sender, EventArgs e)
        {
            gblcddisp.Visible = true;
            gbuseraccess.Visible = false;
            gbparamsetpt.Visible = false;
            gbparamlimit.Visible = false;
            gbparambal.Visible = false;
            gbparameters.Visible = false;
            gbbtone.Visible = true;
            gbbttwo.Visible = false;
            gbbtthree.Visible = false;
            gbbtpmstpt.Visible = false;

        }

        private void cmdpmnext_Click(object sender, EventArgs e)
        {
            icpmnx = icpmnx + 1;
            int ccpmnx;
            ccpmnx = icpmnx % 3;
            switch (ccpmnx)
            {
                case 1:
                    lblpmlmt.Visible = true;
                    lblpmbalanc.Visible = false;
                    lblpmstpt.Visible = false;
                    break;
                case 2:
                    lblpmlmt.Visible = false;
                    lblpmbalanc.Visible = true;
                    lblpmstpt.Visible = false;
                    break;
                case 0:
                    lblpmlmt.Visible = false;
                    lblpmbalanc.Visible = false;
                    lblpmstpt.Visible = true;
                    break;
            }

        }

        private void cmdpmspcancel_Click(object sender, EventArgs e)
        {
            gblcddisp.Visible = false;
            gbuseraccess.Visible = false;
            gbparameters.Visible = true;
            gbparamsetpt.Visible = false;
            gbparamlimit.Visible = false;
            gbparambal.Visible = false;

            gbbtone.Visible = false;
            gbbttwo.Visible = false;
            gbbtthree.Visible = false;
            gbbtpmstpt.Visible = true;
            gbbtpmsplmbl.Visible = false;

            lblpmsphmdval.Text = "82";
            lblpmspco2val.Text = "850";
            lblpmsphtval.Text = "65";
            lblpmspclval.Text = "77";

            lblpmlmthival.Text = "80";
            lblpmlmtloval.Text = "65";

            lblpmblhtdctval.Text = "8.5";
            lblpmblcldctval.Text = "6.0";
            lblpmblhtfloval.Text = "580";
            lblpmblclfloval.Text = "500";

        }

        private void cmdpmspdone_Click(object sender, EventArgs e)
        {
            gblcddisp.Visible = false;
            gbuseraccess.Visible = false;
            gbparameters.Visible = true;
            gbparamsetpt.Visible = false;
            gbparamlimit.Visible = false;
            gbparambal.Visible = false;

            gbbtone.Visible = false;
            gbbttwo.Visible = false;
            gbbtthree.Visible = false;
            gbbtpmstpt.Visible = true;
            gbbtpmsplmbl.Visible = false;

            lblhmdval.Text = lblpmsphmdval.Text;

        }

        private void cmdpmspnext_Click(object sender, EventArgs e)
        {
            icpmspnx = icpmspnx + 1;
            int cpmspnx;
            cpmspnx = icpmspnx % 4;
            switch (cpmspnx)
            {
                case 1:
                    lblpmspco2.Visible = true;
                    lblpmspco2val.Visible = true;
                    lblpmspstpt.Visible = true;

                    lblpmspht.Visible = false;
                    lblpmsphtval.Visible = false;
                    lblpmsphmddeg.Visible = false;

                    lblpmspcl.Visible = false;
                    lblpmspclval.Visible = false;

                    lblpmsphmd.Visible = false;
                    lblpmsphmdval.Visible = false;
                    lblpmsphmdper.Visible = false;
                    break;
                case 2:
                    lblpmspco2.Visible = false;
                    lblpmspco2val.Visible = false;
                    lblpmspstpt.Visible = true;

                    lblpmspht.Visible = true;
                    lblpmsphtval.Visible = true;
                    lblpmsphmddeg.Visible = true;

                    lblpmspcl.Visible = false;
                    lblpmspclval.Visible = false;

                    lblpmsphmd.Visible = false;
                    lblpmsphmdval.Visible = false;
                    lblpmsphmdper.Visible = false;
                    break;
                case 3:
                    lblpmspco2.Visible = false;
                    lblpmspco2val.Visible = false;
                    lblpmspstpt.Visible = true;

                    lblpmspht.Visible = false;
                    lblpmsphtval.Visible = false;
                    lblpmsphmddeg.Visible = true;

                    lblpmspcl.Visible = true;
                    lblpmspclval.Visible = true;

                    lblpmsphmd.Visible = false;
                    lblpmsphmdval.Visible = false;
                    lblpmsphmdper.Visible = false;
                    break;
                case 0:
                    lblpmspco2.Visible = false;
                    lblpmspco2val.Visible = false;
                    lblpmspstpt.Visible = true;

                    lblpmspht.Visible = false;
                    lblpmsphtval.Visible = false;
                    lblpmsphmddeg.Visible = false;

                    lblpmspcl.Visible = false;
                    lblpmspclval.Visible = false;

                    lblpmsphmd.Visible = true;
                    lblpmsphmdval.Visible = true;
                    lblpmsphmdper.Visible = true;
                    break;
            }

        }

        private void cmdpmblnext_Click(object sender, EventArgs e)
        {
            icpmblnx = icpmblnx + 1;
            int cpmblnx;
            cpmblnx = icpmblnx % 4;
            switch (cpmblnx)
            {
                case 1:
                    lblpmblhtdct.Visible = false;
                    lblpmblhtdctval.Visible = false;
                    lblpmbldctinch.Visible = true;

                    lblpmblcldct.Visible = true;
                    lblpmblcldctval.Visible = true;

                    lblpmblhtflo.Visible = false;
                    lblpmblhtfloval.Visible = false;

                    lblpmblclflo.Visible = false;
                    lblpmblclfloval.Visible = false;
                    lblpmblflols.Visible = false;
                    break;
                case 2:
                    lblpmblhtdct.Visible = false;
                    lblpmblhtdctval.Visible = false;
                    lblpmbldctinch.Visible = false;

                    lblpmblcldct.Visible = false;
                    lblpmblcldctval.Visible = false;

                    lblpmblhtflo.Visible = true;
                    lblpmblhtfloval.Visible = true;

                    lblpmblclflo.Visible = false;
                    lblpmblclfloval.Visible = false;
                    lblpmblflols.Visible = true;
                    break;
                case 3:
                    lblpmblhtdct.Visible = false;
                    lblpmblhtdctval.Visible = false;
                    lblpmbldctinch.Visible = false;

                    lblpmblcldct.Visible = false;
                    lblpmblcldctval.Visible = false;

                    lblpmblhtflo.Visible = false;
                    lblpmblhtfloval.Visible = false;

                    lblpmblclflo.Visible = true;
                    lblpmblclfloval.Visible = true;
                    lblpmblflols.Visible = true;
                    break;
                case 0:
                    lblpmblhtdct.Visible = true;
                    lblpmblhtdctval.Visible = true;
                    lblpmbldctinch.Visible = true;

                    lblpmblcldct.Visible = false;
                    lblpmblcldctval.Visible = false;

                    lblpmblhtflo.Visible = false;
                    lblpmblhtfloval.Visible = false;

                    lblpmblclflo.Visible = false;
                    lblpmblclfloval.Visible = false;
                    lblpmblflols.Visible = false;
                    break;
            }

        }

        private void cmdpmlmnext_Click(object sender, EventArgs e)
        {
            icpmlmnx = icpmlmnx + 1;
            int cpmlmnx;
            cpmlmnx = icpmlmnx % 2;
            switch (cpmlmnx)
            {
                case 1:
                    lblpmlmthi.Visible = false;
                    lblpmlmthival.Visible = false;
                    lblpmlmtdeg.Visible = true;

                    lblpmlmtlo.Visible = true;
                    lblpmlmtloval.Visible = true;
                    break;
                case 0:
                    lblpmlmthi.Visible = true;
                    lblpmlmthival.Visible = true;

                    lblpmlmtlo.Visible = false;
                    lblpmlmtloval.Visible = false;

                    lblpmlmtdeg.Visible = true;
                    break;
            }

        }
    }
}