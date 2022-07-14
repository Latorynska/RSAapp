namespace RSAapp
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
            this.GKey_button = new System.Windows.Forms.Button();
            this.ENCKey_button = new System.Windows.Forms.Button();
            this.DECKey_button = new System.Windows.Forms.Button();
            this.GBKeyGen = new System.Windows.Forms.GroupBox();
            this.GenKey_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GK_Q_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GK_P_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NKey_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EKey_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DKey_txt = new System.Windows.Forms.TextBox();
            this.SetKey_btn = new System.Windows.Forms.Button();
            this.GBKeyInf = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PhKey_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KKey_txt = new System.Windows.Forms.TextBox();
            this.GBTextInp = new System.Windows.Forms.GroupBox();
            this.raw_input_txt = new System.Windows.Forms.RichTextBox();
            this.Calc_text_btn = new System.Windows.Forms.Button();
            this.GBTextOut = new System.Windows.Forms.GroupBox();
            this.output_txt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.warning_lbl = new System.Windows.Forms.Label();
            this.GBKeyGen.SuspendLayout();
            this.GBKeyInf.SuspendLayout();
            this.GBTextInp.SuspendLayout();
            this.GBTextOut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GKey_button
            // 
            this.GKey_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GKey_button.Location = new System.Drawing.Point(12, 24);
            this.GKey_button.Name = "GKey_button";
            this.GKey_button.Size = new System.Drawing.Size(193, 75);
            this.GKey_button.TabIndex = 0;
            this.GKey_button.Text = "Generate Key";
            this.GKey_button.UseVisualStyleBackColor = true;
            this.GKey_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // ENCKey_button
            // 
            this.ENCKey_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENCKey_button.Location = new System.Drawing.Point(211, 24);
            this.ENCKey_button.Name = "ENCKey_button";
            this.ENCKey_button.Size = new System.Drawing.Size(193, 75);
            this.ENCKey_button.TabIndex = 1;
            this.ENCKey_button.Text = "Encrpyt Text";
            this.ENCKey_button.UseVisualStyleBackColor = true;
            this.ENCKey_button.Click += new System.EventHandler(this.ENCKey_button_Click);
            // 
            // DECKey_button
            // 
            this.DECKey_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DECKey_button.Location = new System.Drawing.Point(410, 24);
            this.DECKey_button.Name = "DECKey_button";
            this.DECKey_button.Size = new System.Drawing.Size(193, 75);
            this.DECKey_button.TabIndex = 2;
            this.DECKey_button.Text = "Decrypt Text";
            this.DECKey_button.UseVisualStyleBackColor = true;
            this.DECKey_button.Click += new System.EventHandler(this.DECKey_button_Click);
            // 
            // GBKeyGen
            // 
            this.GBKeyGen.Controls.Add(this.GenKey_btn);
            this.GBKeyGen.Controls.Add(this.label2);
            this.GBKeyGen.Controls.Add(this.GK_Q_txt);
            this.GBKeyGen.Controls.Add(this.label1);
            this.GBKeyGen.Controls.Add(this.GK_P_txt);
            this.GBKeyGen.Enabled = false;
            this.GBKeyGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBKeyGen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GBKeyGen.Location = new System.Drawing.Point(12, 119);
            this.GBKeyGen.Name = "GBKeyGen";
            this.GBKeyGen.Size = new System.Drawing.Size(578, 168);
            this.GBKeyGen.TabIndex = 4;
            this.GBKeyGen.TabStop = false;
            this.GBKeyGen.Text = "Key Generate";
            // 
            // GenKey_btn
            // 
            this.GenKey_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenKey_btn.Location = new System.Drawing.Point(288, 49);
            this.GenKey_btn.Name = "GenKey_btn";
            this.GenKey_btn.Size = new System.Drawing.Size(193, 75);
            this.GenKey_btn.TabIndex = 4;
            this.GenKey_btn.Text = "Generate";
            this.GenKey_btn.UseVisualStyleBackColor = true;
            this.GenKey_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Q";
            // 
            // GK_Q_txt
            // 
            this.GK_Q_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GK_Q_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GK_Q_txt.Location = new System.Drawing.Point(45, 90);
            this.GK_Q_txt.Name = "GK_Q_txt";
            this.GK_Q_txt.Size = new System.Drawing.Size(203, 38);
            this.GK_Q_txt.TabIndex = 2;
            this.GK_Q_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GK_Q_txt_KeyPress);
            this.GK_Q_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GK_Q_txt_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "P";
            // 
            // GK_P_txt
            // 
            this.GK_P_txt.BackColor = System.Drawing.Color.White;
            this.GK_P_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GK_P_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GK_P_txt.Location = new System.Drawing.Point(45, 46);
            this.GK_P_txt.Name = "GK_P_txt";
            this.GK_P_txt.Size = new System.Drawing.Size(203, 38);
            this.GK_P_txt.TabIndex = 0;
            this.GK_P_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GK_P_txt_KeyPress);
            this.GK_P_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GK_P_txt_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "N";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NKey_txt
            // 
            this.NKey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NKey_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NKey_txt.Location = new System.Drawing.Point(63, 42);
            this.NKey_txt.Name = "NKey_txt";
            this.NKey_txt.Size = new System.Drawing.Size(203, 38);
            this.NKey_txt.TabIndex = 5;
            this.NKey_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "e";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EKey_txt
            // 
            this.EKey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EKey_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EKey_txt.Location = new System.Drawing.Point(63, 174);
            this.EKey_txt.Name = "EKey_txt";
            this.EKey_txt.Size = new System.Drawing.Size(203, 38);
            this.EKey_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "d";
            // 
            // DKey_txt
            // 
            this.DKey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DKey_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DKey_txt.Location = new System.Drawing.Point(63, 218);
            this.DKey_txt.Name = "DKey_txt";
            this.DKey_txt.Size = new System.Drawing.Size(203, 38);
            this.DKey_txt.TabIndex = 9;
            // 
            // SetKey_btn
            // 
            this.SetKey_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetKey_btn.Location = new System.Drawing.Point(306, 42);
            this.SetKey_btn.Name = "SetKey_btn";
            this.SetKey_btn.Size = new System.Drawing.Size(193, 122);
            this.SetKey_btn.TabIndex = 11;
            this.SetKey_btn.Text = "Set";
            this.SetKey_btn.UseVisualStyleBackColor = true;
            this.SetKey_btn.Click += new System.EventHandler(this.SetKey_btn_Click);
            // 
            // GBKeyInf
            // 
            this.GBKeyInf.Controls.Add(this.label7);
            this.GBKeyInf.Controls.Add(this.PhKey_txt);
            this.GBKeyInf.Controls.Add(this.label6);
            this.GBKeyInf.Controls.Add(this.KKey_txt);
            this.GBKeyInf.Controls.Add(this.SetKey_btn);
            this.GBKeyInf.Controls.Add(this.label5);
            this.GBKeyInf.Controls.Add(this.NKey_txt);
            this.GBKeyInf.Controls.Add(this.DKey_txt);
            this.GBKeyInf.Controls.Add(this.label3);
            this.GBKeyInf.Controls.Add(this.label4);
            this.GBKeyInf.Controls.Add(this.EKey_txt);
            this.GBKeyInf.Enabled = false;
            this.GBKeyInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBKeyInf.Location = new System.Drawing.Point(12, 293);
            this.GBKeyInf.Name = "GBKeyInf";
            this.GBKeyInf.Size = new System.Drawing.Size(578, 308);
            this.GBKeyInf.TabIndex = 5;
            this.GBKeyInf.TabStop = false;
            this.GBKeyInf.Text = "Key Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Φ";
            // 
            // PhKey_txt
            // 
            this.PhKey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhKey_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhKey_txt.Location = new System.Drawing.Point(63, 86);
            this.PhKey_txt.Name = "PhKey_txt";
            this.PhKey_txt.ReadOnly = true;
            this.PhKey_txt.Size = new System.Drawing.Size(203, 38);
            this.PhKey_txt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "k";
            // 
            // KKey_txt
            // 
            this.KKey_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KKey_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KKey_txt.Location = new System.Drawing.Point(63, 130);
            this.KKey_txt.Name = "KKey_txt";
            this.KKey_txt.ReadOnly = true;
            this.KKey_txt.Size = new System.Drawing.Size(203, 38);
            this.KKey_txt.TabIndex = 12;
            // 
            // GBTextInp
            // 
            this.GBTextInp.Controls.Add(this.raw_input_txt);
            this.GBTextInp.Enabled = false;
            this.GBTextInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTextInp.Location = new System.Drawing.Point(622, 119);
            this.GBTextInp.Name = "GBTextInp";
            this.GBTextInp.Size = new System.Drawing.Size(628, 168);
            this.GBTextInp.TabIndex = 6;
            this.GBTextInp.TabStop = false;
            this.GBTextInp.Text = "Text Input";
            // 
            // raw_input_txt
            // 
            this.raw_input_txt.Location = new System.Drawing.Point(6, 28);
            this.raw_input_txt.Name = "raw_input_txt";
            this.raw_input_txt.Size = new System.Drawing.Size(616, 134);
            this.raw_input_txt.TabIndex = 0;
            this.raw_input_txt.Text = "";
            // 
            // Calc_text_btn
            // 
            this.Calc_text_btn.Enabled = false;
            this.Calc_text_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_text_btn.Location = new System.Drawing.Point(846, 293);
            this.Calc_text_btn.Name = "Calc_text_btn";
            this.Calc_text_btn.Size = new System.Drawing.Size(193, 75);
            this.Calc_text_btn.TabIndex = 7;
            this.Calc_text_btn.Text = "Calculate";
            this.Calc_text_btn.UseVisualStyleBackColor = true;
            this.Calc_text_btn.Click += new System.EventHandler(this.Calc_text_btn_Click);
            // 
            // GBTextOut
            // 
            this.GBTextOut.Controls.Add(this.output_txt);
            this.GBTextOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTextOut.Location = new System.Drawing.Point(622, 374);
            this.GBTextOut.Name = "GBTextOut";
            this.GBTextOut.Size = new System.Drawing.Size(628, 228);
            this.GBTextOut.TabIndex = 8;
            this.GBTextOut.TabStop = false;
            this.GBTextOut.Text = "Text Output";
            // 
            // output_txt
            // 
            this.output_txt.Location = new System.Drawing.Point(12, 37);
            this.output_txt.Name = "output_txt";
            this.output_txt.ReadOnly = true;
            this.output_txt.Size = new System.Drawing.Size(610, 171);
            this.output_txt.TabIndex = 1;
            this.output_txt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.warning_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(622, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 89);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warning Message";
            // 
            // warning_lbl
            // 
            this.warning_lbl.AutoSize = true;
            this.warning_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning_lbl.Location = new System.Drawing.Point(15, 34);
            this.warning_lbl.Name = "warning_lbl";
            this.warning_lbl.Size = new System.Drawing.Size(0, 24);
            this.warning_lbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBTextOut);
            this.Controls.Add(this.Calc_text_btn);
            this.Controls.Add(this.GBTextInp);
            this.Controls.Add(this.GBKeyInf);
            this.Controls.Add(this.GBKeyGen);
            this.Controls.Add(this.ENCKey_button);
            this.Controls.Add(this.GKey_button);
            this.Controls.Add(this.DECKey_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBKeyGen.ResumeLayout(false);
            this.GBKeyGen.PerformLayout();
            this.GBKeyInf.ResumeLayout(false);
            this.GBKeyInf.PerformLayout();
            this.GBTextInp.ResumeLayout(false);
            this.GBTextOut.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GKey_button;
        private System.Windows.Forms.Button ENCKey_button;
        private System.Windows.Forms.Button DECKey_button;
        private System.Windows.Forms.GroupBox GBKeyGen;
        private System.Windows.Forms.Button GenKey_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GK_Q_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GK_P_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EKey_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NKey_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DKey_txt;
        private System.Windows.Forms.Button SetKey_btn;
        private System.Windows.Forms.GroupBox GBKeyInf;
        private System.Windows.Forms.GroupBox GBTextInp;
        private System.Windows.Forms.Button Calc_text_btn;
        private System.Windows.Forms.GroupBox GBTextOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PhKey_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KKey_txt;
        private System.Windows.Forms.RichTextBox raw_input_txt;
        private System.Windows.Forms.RichTextBox output_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label warning_lbl;
    }
}

