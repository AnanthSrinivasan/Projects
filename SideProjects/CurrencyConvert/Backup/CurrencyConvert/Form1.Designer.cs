namespace CurrencyConvert
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
            this.xconvTab = new System.Windows.Forms.TabControl();
            this.convertTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.convertTo = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.convertFrom = new System.Windows.Forms.ComboBox();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reviewTab = new System.Windows.Forms.TabPage();
            this.reviewpaySplit = new System.Windows.Forms.SplitContainer();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdPay = new System.Windows.Forms.Button();
            this.xconvTab.SuspendLayout();
            this.convertTab.SuspendLayout();
            this.reviewTab.SuspendLayout();
            this.reviewpaySplit.Panel1.SuspendLayout();
            this.reviewpaySplit.Panel2.SuspendLayout();
            this.reviewpaySplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // xconvTab
            // 
            this.xconvTab.Controls.Add(this.convertTab);
            this.xconvTab.Controls.Add(this.reviewTab);
            this.xconvTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xconvTab.Location = new System.Drawing.Point(0, 0);
            this.xconvTab.Name = "xconvTab";
            this.xconvTab.SelectedIndex = 0;
            this.xconvTab.Size = new System.Drawing.Size(251, 283);
            this.xconvTab.TabIndex = 4;
            // 
            // convertTab
            // 
            this.convertTab.Controls.Add(this.label6);
            this.convertTab.Controls.Add(this.label5);
            this.convertTab.Controls.Add(this.convertTo);
            this.convertTab.Controls.Add(this.textBox2);
            this.convertTab.Controls.Add(this.label4);
            this.convertTab.Controls.Add(this.convertFrom);
            this.convertTab.Controls.Add(this.cmdConvert);
            this.convertTab.Controls.Add(this.textBox1);
            this.convertTab.Controls.Add(this.label1);
            this.convertTab.Location = new System.Drawing.Point(4, 22);
            this.convertTab.Name = "convertTab";
            this.convertTab.Padding = new System.Windows.Forms.Padding(3);
            this.convertTab.Size = new System.Drawing.Size(243, 257);
            this.convertTab.TabIndex = 0;
            this.convertTab.Text = "Convert";
            this.convertTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "To";
            // 
            // convertTo
            // 
            this.convertTo.FormattingEnabled = true;
            this.convertTo.Items.AddRange(new object[] {
            "AUD",
            "BRL",
            "CAD",
            "CZK",
            "DKK",
            "EUR",
            "HKD",
            "HUF",
            "ILS",
            "JPY",
            "MYR",
            "MXN",
            "NOK",
            "NZD",
            "PHP",
            "PLN",
            "GBP",
            "SGD",
            "SEK",
            "CHF",
            "TWD",
            "THB",
            "TRY",
            "USD"});
            this.convertTo.Location = new System.Drawing.Point(152, 65);
            this.convertTo.Name = "convertTo";
            this.convertTo.Size = new System.Drawing.Size(83, 21);
            this.convertTo.TabIndex = 7;
            this.convertTo.Text = "ConvertTo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "1 USD = 0.78733958 Euros";
            // 
            // convertFrom
            // 
            this.convertFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.convertFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.convertFrom.FormattingEnabled = true;
            this.convertFrom.Items.AddRange(new object[] {
            "AUD",
            "BRL",
            "CAD",
            "CZK",
            "DKK",
            "EUR",
            "HKD",
            "HUF",
            "ILS",
            "JPY",
            "MYR",
            "MXN",
            "NOK",
            "NZD",
            "PHP",
            "PLN",
            "GBP",
            "SGD",
            "SEK",
            "CHF",
            "TWD",
            "THB",
            "TRY",
            "USD"});
            this.convertFrom.Location = new System.Drawing.Point(11, 65);
            this.convertFrom.Name = "convertFrom";
            this.convertFrom.Size = new System.Drawing.Size(83, 21);
            this.convertFrom.TabIndex = 4;
            this.convertFrom.Text = "ConvertFrom";
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(152, 105);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(75, 23);
            this.cmdConvert.TabIndex = 2;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.Location = new System.Drawing.Point(59, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you wish to send the payment, please provide the mobile number or email id of " +
                "the person you wish to send the payment to";
            // 
            // reviewTab
            // 
            this.reviewTab.Controls.Add(this.reviewpaySplit);
            this.reviewTab.Location = new System.Drawing.Point(4, 22);
            this.reviewTab.Name = "reviewTab";
            this.reviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.reviewTab.Size = new System.Drawing.Size(243, 257);
            this.reviewTab.TabIndex = 1;
            this.reviewTab.Text = "Review";
            this.reviewTab.UseVisualStyleBackColor = true;
            // 
            // reviewpaySplit
            // 
            this.reviewpaySplit.BackColor = System.Drawing.Color.Transparent;
            this.reviewpaySplit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reviewpaySplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewpaySplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.reviewpaySplit.Location = new System.Drawing.Point(3, 3);
            this.reviewpaySplit.Name = "reviewpaySplit";
            this.reviewpaySplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // reviewpaySplit.Panel1
            // 
            this.reviewpaySplit.Panel1.Controls.Add(this.radioButton2);
            this.reviewpaySplit.Panel1.Controls.Add(this.radioButton1);
            this.reviewpaySplit.Panel1.Controls.Add(this.label3);
            // 
            // reviewpaySplit.Panel2
            // 
            this.reviewpaySplit.Panel2.Controls.Add(this.label2);
            this.reviewpaySplit.Panel2.Controls.Add(this.cmdPay);
            this.reviewpaySplit.Size = new System.Drawing.Size(237, 251);
            this.reviewpaySplit.SplitterDistance = 180;
            this.reviewpaySplit.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 113);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Credit Card";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 74);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Paypal Balance";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "You are going to do the payment to 9894775119. Please proceed with the payment op" +
                "tion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = " Click Pay to complete your payment";
            // 
            // cmdPay
            // 
            this.cmdPay.BackColor = System.Drawing.Color.DarkBlue;
            this.cmdPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPay.ForeColor = System.Drawing.Color.Transparent;
            this.cmdPay.Location = new System.Drawing.Point(143, 34);
            this.cmdPay.Name = "cmdPay";
            this.cmdPay.Size = new System.Drawing.Size(75, 23);
            this.cmdPay.TabIndex = 0;
            this.cmdPay.Text = "Pay";
            this.cmdPay.UseVisualStyleBackColor = false;
            this.cmdPay.Click += new System.EventHandler(this.cmdPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 283);
            this.Controls.Add(this.xconvTab);
            this.Name = "Form1";
            this.Text = "Currency Convert";
            this.xconvTab.ResumeLayout(false);
            this.convertTab.ResumeLayout(false);
            this.convertTab.PerformLayout();
            this.reviewTab.ResumeLayout(false);
            this.reviewpaySplit.Panel1.ResumeLayout(false);
            this.reviewpaySplit.Panel1.PerformLayout();
            this.reviewpaySplit.Panel2.ResumeLayout(false);
            this.reviewpaySplit.Panel2.PerformLayout();
            this.reviewpaySplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl xconvTab;
        private System.Windows.Forms.TabPage convertTab;
        private System.Windows.Forms.TabPage reviewTab;
        private System.Windows.Forms.SplitContainer reviewpaySplit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdPay;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox convertTo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox convertFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

