using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using Pronexus.VBVoice;

namespace csLanguage
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Pronexus.VBVoice.VBVFrame vbvFrame1;
		internal Pronexus.VBVoice.LineGroup LineGroup1;
		internal Pronexus.VBVoice.OnHook OnHook1;
		internal Pronexus.VBVoice.GetDigits GetDigits1;
		internal Pronexus.VBVoice.PlayGreeting PlayNewNumber;
		internal Pronexus.VBVoice.Lang French;
		internal Pronexus.VBVoice.Lang Italian;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.Button btnStop;
		internal System.Windows.Forms.Button btnStart;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.vbvFrame1 = new Pronexus.VBVoice.VBVFrame();
			this.LineGroup1 = new Pronexus.VBVoice.LineGroup();
			this.OnHook1 = new Pronexus.VBVoice.OnHook();
			this.GetDigits1 = new Pronexus.VBVoice.GetDigits();
			this.PlayNewNumber = new Pronexus.VBVoice.PlayGreeting();
			this.French = new Pronexus.VBVoice.Lang();
			this.Italian = new Pronexus.VBVoice.Lang();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).BeginInit();
			this.vbvFrame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LineGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OnHook1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GetDigits1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PlayNewNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.French)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Italian)).BeginInit();
			this.SuspendLayout();
			// 
			// vbvFrame1
			// 
			this.vbvFrame1.Controls.Add(this.LineGroup1);
			this.vbvFrame1.Controls.Add(this.OnHook1);
			this.vbvFrame1.Controls.Add(this.GetDigits1);
			this.vbvFrame1.Controls.Add(this.PlayNewNumber);
			this.vbvFrame1.Controls.Add(this.French);
			this.vbvFrame1.Controls.Add(this.Italian);
			this.vbvFrame1.Location = new System.Drawing.Point(0, 0);
			this.vbvFrame1.Name = "vbvFrame1";
			this.vbvFrame1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vbvFrame1.OcxState")));
			this.vbvFrame1.Size = new System.Drawing.Size(512, 200);
			this.vbvFrame1.TabIndex = 0;
			// 
			// LineGroup1
			// 
			this.LineGroup1.ContainingControl = this;
			this.LineGroup1.Location = new System.Drawing.Point(16, 64);
			this.LineGroup1.Name = "LineGroup1";
			this.LineGroup1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LineGroup1.OcxState")));
			this.LineGroup1.Size = new System.Drawing.Size(65, 110);
			this.LineGroup1.TabIndex = 7;
			// 
			// OnHook1
			// 
			this.OnHook1.ContainingControl = this;
			this.OnHook1.Location = new System.Drawing.Point(432, 40);
			this.OnHook1.Name = "OnHook1";
			this.OnHook1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("OnHook1.OcxState")));
			this.OnHook1.Size = new System.Drawing.Size(56, 56);
			this.OnHook1.TabIndex = 8;
			// 
			// GetDigits1
			// 
			this.GetDigits1.ContainingControl = this;
			this.GetDigits1.Location = new System.Drawing.Point(104, 72);
			this.GetDigits1.Name = "GetDigits1";
			this.GetDigits1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("GetDigits1.OcxState")));
			this.GetDigits1.Size = new System.Drawing.Size(59, 80);
			this.GetDigits1.TabIndex = 9;
			// 
			// PlayNewNumber
			// 
			this.PlayNewNumber.ContainingControl = this;
			this.PlayNewNumber.Location = new System.Drawing.Point(304, 120);
			this.PlayNewNumber.Name = "PlayNewNumber";
			this.PlayNewNumber.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PlayNewNumber.OcxState")));
			this.PlayNewNumber.Size = new System.Drawing.Size(89, 65);
			this.PlayNewNumber.TabIndex = 10;
			// 
			// French
			// 
			this.French.ContainingControl = this;
			this.French.Location = new System.Drawing.Point(208, 32);
			this.French.Name = "French";
			this.French.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("French.OcxState")));
			this.French.Size = new System.Drawing.Size(58, 56);
			this.French.TabIndex = 11;
			this.French.Number += new AxVBVoiceLib._DLangEvents_NumberEventHandler(this.French_Number);
			// 
			// Italian
			// 
			this.Italian.ContainingControl = this;
			this.Italian.Location = new System.Drawing.Point(208, 88);
			this.Italian.Name = "Italian";
			this.Italian.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Italian.OcxState")));
			this.Italian.Size = new System.Drawing.Size(58, 56);
			this.Italian.TabIndex = 12;
			// 
			// Label3
			// 
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.Location = new System.Drawing.Point(8, 328);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(496, 48);
			this.Label3.TabIndex = 17;
			this.Label3.Text = @"Please note that the Language control is an add-on component to VBVoice.  As such, this example will only work properly if this control has been enabled.  If you are not in possession of this add-on control, please consult Pronexus for pricing information.";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(8, 288);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(496, 32);
			this.Label2.TabIndex = 16;
			this.Label2.Text = "The use of system phrases (after a language has been selected), will require a co" +
				"py of the system .vap files in each language directory. ";
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(8, 240);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(496, 48);
			this.Label1.TabIndex = 15;
			this.Label1.Text = "This example shows how the language control can be used to change languages, with" +
				"out having to duplicte the callflow.  In this case if the user selects french we" +
				" have changed the way the number 234 is spoken.";
			// 
			// Timer1
			// 
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 500;
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(80, 208);
			this.btnStop.Name = "btnStop";
			this.btnStop.TabIndex = 14;
			this.btnStop.Text = "Stop";
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(0, 208);
			this.btnStart.Name = "btnStart";
			this.btnStart.TabIndex = 13;
			this.btnStart.Text = "Start";
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 389);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.vbvFrame1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).EndInit();
			this.vbvFrame1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LineGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OnHook1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GetDigits1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PlayNewNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.French)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Italian)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnStart_Click(object sender, System.EventArgs e)
		{
			if (! vbvFrame1.SystemStarted())
			{
				vbvFrame1.StartSystem(true);
			}
		}

		private void btnStop_Click(object sender, System.EventArgs e)
		{
			if (vbvFrame1.SystemStarted())
			{
				vbvFrame1.StopSystem(true);
			}		
		}

		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			this.btnStart.Enabled = ! vbvFrame1.SystemStarted();
			this.btnStop.Enabled = vbvFrame1.SystemStarted();
		}

		private void French_Number(object sender, AxVBVoiceLib._DLangEvents_NumberEvent e)
		{
			// This code highlights the power of the language control.
			// in the dialog box of the language control we specified that
			// we wanted number events.
			//
			// Whenever a number is spoken this event is fired.
			// The PhrsValue is the number to be spoken.  Within this event we can redefine
			// this number to be any phrase
			//
			// In this example we change the way 234 is spoken
			// (the following just portrays the mechanics of this control and does
			// not have any practical merit)

			Debug.WriteLine("French Number event has been entered");

			if (e.phrsValue == "234")
			{
				// say 2 using SayNumber
				French.PhraseData1 = "2";
				French.PhraseData2 = "M"; // number flags, optional
				French.AddType = (short)VBVoiceLib.vbvSysPhraseConstants.vbvSayNumber;

				// say and using a named phrase
				French.FileName = "vbvoice30.vap";
				French.PhraseName = "and";
				French.AddType = (short)VBVoiceLib.vbvSysPhraseConstants.vbvVAPPhrase;

				// say 3 using a named phrase
				French.FileName = "vbvoice30.vap";
				French.PhraseName = "three";
				French.AddType = (short)VBVoiceLib.vbvSysPhraseConstants.vbvVAPPhrase;

				// say and using a named phrase
				French.FileName = "vbvoice30.vap";
				French.PhraseName = "and";
				French.AddType = (short)VBVoiceLib.vbvSysPhraseConstants.vbvVAPPhrase;

				// say 4 using an phrase by index
				French.FileName = "vbvoice30.vap";
				French.PhraseIndex = 4;
				French.AddType = (short)VBVoiceLib.vbvSysPhraseConstants.vbvVAPPhraseIndex;

				//  override the default with this definition
				e.useDefault = 1;
			}				
		
		}
	}
}
