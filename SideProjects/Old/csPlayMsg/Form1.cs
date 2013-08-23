using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace csPlayMsg
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Pronexus.VBVoice.VBVFrame vbvFrame1;
		private Pronexus.VBVoice.LineGroup lineGroup1;
		private Pronexus.VBVoice.OnHook onHook1;
		private Pronexus.VBVoice.GetDigits gdInput;
		private Pronexus.VBVoice.PlayGreeting playGreeting1;
		private Pronexus.VBVoice.Record RecordMsg;
		private Pronexus.VBVoice.PlayMsgs PlayMsgs1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer timer1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vbvFrame1 = new Pronexus.VBVoice.VBVFrame();
            this.lineGroup1 = new Pronexus.VBVoice.LineGroup();
            this.onHook1 = new Pronexus.VBVoice.OnHook();
            this.gdInput = new Pronexus.VBVoice.GetDigits();
            this.RecordMsg = new Pronexus.VBVoice.Record();
            this.PlayMsgs1 = new Pronexus.VBVoice.PlayMsgs();
            this.playGreeting1 = new Pronexus.VBVoice.PlayGreeting();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).BeginInit();
            this.vbvFrame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onHook1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayMsgs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGreeting1)).BeginInit();
            this.SuspendLayout();
            // 
            // vbvFrame1
            // 
            this.vbvFrame1.Controls.Add(this.lineGroup1);
            this.vbvFrame1.Controls.Add(this.onHook1);
            this.vbvFrame1.Controls.Add(this.gdInput);
            this.vbvFrame1.Controls.Add(this.RecordMsg);
            this.vbvFrame1.Controls.Add(this.PlayMsgs1);
            this.vbvFrame1.Controls.Add(this.playGreeting1);
            this.vbvFrame1.Location = new System.Drawing.Point(0, 0);
            this.vbvFrame1.Name = "vbvFrame1";
            this.vbvFrame1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vbvFrame1.OcxState")));
            this.vbvFrame1.Size = new System.Drawing.Size(512, 248);
            this.vbvFrame1.TabIndex = 0;
            // 
            // lineGroup1
            // 
            this.lineGroup1.Location = new System.Drawing.Point(16, 48);
            this.lineGroup1.Name = "lineGroup1";
            this.lineGroup1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("lineGroup1.OcxState")));
            this.lineGroup1.Size = new System.Drawing.Size(61, 110);
            this.lineGroup1.TabIndex = 1;
            // 
            // onHook1
            // 
            this.onHook1.Location = new System.Drawing.Point(448, 104);
            this.onHook1.Name = "onHook1";
            this.onHook1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("onHook1.OcxState")));
            this.onHook1.Size = new System.Drawing.Size(54, 56);
            this.onHook1.TabIndex = 2;
            // 
            // gdInput
            // 
            this.gdInput.Location = new System.Drawing.Point(224, 64);
            this.gdInput.Name = "gdInput";
            this.gdInput.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gdInput.OcxState")));
            this.gdInput.Size = new System.Drawing.Size(80, 80);
            this.gdInput.TabIndex = 3;
            // 
            // RecordMsg
            // 
            this.RecordMsg.Location = new System.Drawing.Point(360, 40);
            this.RecordMsg.Name = "RecordMsg";
            this.RecordMsg.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("RecordMsg.OcxState")));
            this.RecordMsg.Size = new System.Drawing.Size(65, 80);
            this.RecordMsg.TabIndex = 4;
            // 
            // PlayMsgs1
            // 
            this.PlayMsgs1.Location = new System.Drawing.Point(360, 160);
            this.PlayMsgs1.Name = "PlayMsgs1";
            this.PlayMsgs1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PlayMsgs1.OcxState")));
            this.PlayMsgs1.Size = new System.Drawing.Size(61, 76);
            this.PlayMsgs1.TabIndex = 6;
            // 
            // playGreeting1
            // 
            this.playGreeting1.Location = new System.Drawing.Point(104, 56);
            this.playGreeting1.Name = "playGreeting1";
            this.playGreeting1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playGreeting1.OcxState")));
            this.playGreeting1.Size = new System.Drawing.Size(75, 65);
            this.playGreeting1.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 256);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(96, 256);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(192, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "System can only be started if voice card installed,  right click on LineGroup1 an" +
                "d choose start test if no voice card.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Voicemail functionality revolves around the interaction between the Record and Pl" +
                "ayMsgs controls.";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(520, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.vbvFrame1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).EndInit();
            this.vbvFrame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onHook1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayMsgs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playGreeting1)).EndInit();
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
			if (!vbvFrame1.SystemStarted())
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

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.btnStart.Enabled = ! this.vbvFrame1.SystemStarted();
			this.btnStop.Enabled = this.vbvFrame1.SystemStarted();
		}
	}
}
