
namespace lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outText1 = new System.Windows.Forms.TextBox();
            this.enterText1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.outText2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.enterText2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.enterP = new System.Windows.Forms.TextBox();
            this.enterQ = new System.Windows.Forms.TextBox();
            this.outN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outFi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.enterE = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.enterD1 = new System.Windows.Forms.TextBox();
            this.enterD2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.enterN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.outVariants = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // outText1
            // 
            this.outText1.Location = new System.Drawing.Point(141, 687);
            this.outText1.Name = "outText1";
            this.outText1.Size = new System.Drawing.Size(173, 23);
            this.outText1.TabIndex = 45;
            // 
            // enterText1
            // 
            this.enterText1.Location = new System.Drawing.Point(141, 516);
            this.enterText1.Name = "enterText1";
            this.enterText1.Size = new System.Drawing.Size(173, 23);
            this.enterText1.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 644);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Зашифрованное сообщение:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Введите сообщение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Введите e:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Введите q:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Введите p:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 53;
            this.label10.Text = "ШИФРОВАНИЕ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(683, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 54;
            this.label11.Text = "ДЕШИФРОВКА";
            // 
            // outText2
            // 
            this.outText2.Location = new System.Drawing.Point(649, 399);
            this.outText2.Name = "outText2";
            this.outText2.Size = new System.Drawing.Size(167, 23);
            this.outText2.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(649, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 15);
            this.label14.TabIndex = 64;
            this.label14.Text = "Расшифрованное сообщение:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 63;
            this.button2.Text = "Дешифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // enterText2
            // 
            this.enterText2.Location = new System.Drawing.Point(649, 257);
            this.enterText2.Name = "enterText2";
            this.enterText2.Size = new System.Drawing.Size(167, 23);
            this.enterText2.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(646, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 15);
            this.label12.TabIndex = 59;
            this.label12.Text = "Зашифрованное сообщение:";
            // 
            // enterP
            // 
            this.enterP.Location = new System.Drawing.Point(173, 108);
            this.enterP.Name = "enterP";
            this.enterP.Size = new System.Drawing.Size(112, 23);
            this.enterP.TabIndex = 68;
            this.enterP.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // enterQ
            // 
            this.enterQ.Location = new System.Drawing.Point(173, 174);
            this.enterQ.Name = "enterQ";
            this.enterQ.Size = new System.Drawing.Size(112, 23);
            this.enterQ.TabIndex = 69;
            this.enterQ.Leave += new System.EventHandler(this.enterQ_Leave);
            // 
            // outN
            // 
            this.outN.Enabled = false;
            this.outN.Location = new System.Drawing.Point(92, 244);
            this.outN.Name = "outN";
            this.outN.Size = new System.Drawing.Size(112, 23);
            this.outN.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 70;
            this.label3.Text = "n:";
            // 
            // outFi
            // 
            this.outFi.Enabled = false;
            this.outFi.Location = new System.Drawing.Point(256, 244);
            this.outFi.Name = "outFi";
            this.outFi.Size = new System.Drawing.Size(112, 23);
            this.outFi.TabIndex = 73;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(295, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 15);
            this.label18.TabIndex = 72;
            this.label18.Text = "φ:";
            // 
            // enterE
            // 
            this.enterE.Location = new System.Drawing.Point(173, 338);
            this.enterE.Name = "enterE";
            this.enterE.Size = new System.Drawing.Size(112, 23);
            this.enterE.TabIndex = 74;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(193, 390);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(63, 15);
            this.labelD.TabIndex = 75;
            this.labelD.Text = "Введите d:";
            // 
            // enterD1
            // 
            this.enterD1.Location = new System.Drawing.Point(173, 433);
            this.enterD1.Name = "enterD1";
            this.enterD1.Size = new System.Drawing.Size(112, 23);
            this.enterD1.TabIndex = 76;
            // 
            // enterD2
            // 
            this.enterD2.Location = new System.Drawing.Point(672, 108);
            this.enterD2.Name = "enterD2";
            this.enterD2.Size = new System.Drawing.Size(112, 23);
            this.enterD2.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(692, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 77;
            this.label6.Text = "Введите d:";
            // 
            // enterN
            // 
            this.enterN.Location = new System.Drawing.Point(672, 174);
            this.enterN.Name = "enterN";
            this.enterN.Size = new System.Drawing.Size(112, 23);
            this.enterN.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 79;
            this.label9.Text = "Введите n:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(621, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 15);
            this.label13.TabIndex = 81;
            this.label13.Text = "Или же один из следующих вариантов:";
            // 
            // outVariants
            // 
            this.outVariants.FormattingEnabled = true;
            this.outVariants.Location = new System.Drawing.Point(649, 500);
            this.outVariants.Name = "outVariants";
            this.outVariants.Size = new System.Drawing.Size(167, 23);
            this.outVariants.TabIndex = 82;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 792);
            this.Controls.Add(this.outVariants);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.enterN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.enterD2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.enterD1);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.enterE);
            this.Controls.Add(this.outFi);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.outN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enterQ);
            this.Controls.Add(this.enterP);
            this.Controls.Add(this.outText2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.enterText2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.outText1);
            this.Controls.Add(this.enterText1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox outText1;
        private System.Windows.Forms.TextBox enterText1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox outText2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox enterText2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox enterP;
        private System.Windows.Forms.TextBox enterQ;
        private System.Windows.Forms.TextBox outN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outFi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox enterE;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.TextBox enterD1;
        private System.Windows.Forms.TextBox enterD2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enterN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox outVariants;
    }
}

