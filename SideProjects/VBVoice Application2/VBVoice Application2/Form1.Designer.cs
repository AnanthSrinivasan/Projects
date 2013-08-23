namespace VBVoice_Application2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vbvFrame1 = new Pronexus.VBVoice.VBVFrame();
            this.lineGroup1 = new Pronexus.VBVoice.LineGroup();
            this.onHook1 = new Pronexus.VBVoice.OnHook();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).BeginInit();
            this.vbvFrame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onHook1)).BeginInit();
            this.SuspendLayout();
            // 
            // vbvFrame1
            // 
            this.vbvFrame1.Controls.Add(this.onHook1);
            this.vbvFrame1.Controls.Add(this.lineGroup1);
            this.vbvFrame1.Location = new System.Drawing.Point(12, 12);
            this.vbvFrame1.Name = "vbvFrame1";
            this.vbvFrame1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vbvFrame1.OcxState")));
            this.vbvFrame1.Size = new System.Drawing.Size(400, 199);
            this.vbvFrame1.TabIndex = 0;
            // 
            // lineGroup1
            // 
            this.lineGroup1.Location = new System.Drawing.Point(19, 52);
            this.lineGroup1.Name = "lineGroup1";
            this.lineGroup1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("lineGroup1.OcxState")));
            this.lineGroup1.Size = new System.Drawing.Size(61, 110);
            this.lineGroup1.TabIndex = 0;
            // 
            // onHook1
            // 
            this.onHook1.Location = new System.Drawing.Point(315, 67);
            this.onHook1.Name = "onHook1";
            this.onHook1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("onHook1.OcxState")));
            this.onHook1.Size = new System.Drawing.Size(54, 56);
            this.onHook1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(17, 235);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "StartSystem";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(98, 235);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "StopSystem";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 281);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.vbvFrame1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vbvFrame1)).EndInit();
            this.vbvFrame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onHook1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Pronexus.VBVoice.VBVFrame vbvFrame1;
        private Pronexus.VBVoice.OnHook onHook1;
        private Pronexus.VBVoice.LineGroup lineGroup1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}

