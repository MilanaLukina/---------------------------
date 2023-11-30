
namespace information_security_lab1
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
            System.Windows.Forms.Button button3;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericupdown_encrypt_horizontal = new System.Windows.Forms.NumericUpDown();
            this.numericupdown_encrypt_vertical = new System.Windows.Forms.NumericUpDown();
            this.textbox_encrypt_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_encrypt_input_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericupdown_decrypt_horizontal = new System.Windows.Forms.NumericUpDown();
            this.numericupdown_decrypt_vertical = new System.Windows.Forms.NumericUpDown();
            this.textbox_decrypt_result = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textbox_decrypt_input_message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textbox_hack_input_message = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_hack_result = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_encrypt_horizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_encrypt_vertical)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_decrypt_horizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_decrypt_vertical)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericupdown_encrypt_horizontal);
            this.tabPage1.Controls.Add(this.numericupdown_encrypt_vertical);
            this.tabPage1.Controls.Add(this.textbox_encrypt_result);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textbox_encrypt_input_message);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зашифровать";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericupdown_encrypt_horizontal
            // 
            this.numericupdown_encrypt_horizontal.Location = new System.Drawing.Point(295, 239);
            this.numericupdown_encrypt_horizontal.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericupdown_encrypt_horizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericupdown_encrypt_horizontal.Name = "numericupdown_encrypt_horizontal";
            this.numericupdown_encrypt_horizontal.Size = new System.Drawing.Size(120, 23);
            this.numericupdown_encrypt_horizontal.TabIndex = 9;
            this.numericupdown_encrypt_horizontal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericupdown_encrypt_vertical
            // 
            this.numericupdown_encrypt_vertical.Location = new System.Drawing.Point(295, 163);
            this.numericupdown_encrypt_vertical.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericupdown_encrypt_vertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericupdown_encrypt_vertical.Name = "numericupdown_encrypt_vertical";
            this.numericupdown_encrypt_vertical.Size = new System.Drawing.Size(120, 23);
            this.numericupdown_encrypt_vertical.TabIndex = 8;
            this.numericupdown_encrypt_vertical.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textbox_encrypt_result
            // 
            this.textbox_encrypt_result.Location = new System.Drawing.Point(224, 351);
            this.textbox_encrypt_result.Name = "textbox_encrypt_result";
            this.textbox_encrypt_result.Size = new System.Drawing.Size(275, 23);
            this.textbox_encrypt_result.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_encrypt_input_message
            // 
            this.textbox_encrypt_input_message.Location = new System.Drawing.Point(295, 85);
            this.textbox_encrypt_input_message.Name = "textbox_encrypt_input_message";
            this.textbox_encrypt_input_message.Size = new System.Drawing.Size(131, 23);
            this.textbox_encrypt_input_message.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество букв, помещаемых по горизонтали:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество букв, помещаемых по вертикали:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходное сообщение:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericupdown_decrypt_horizontal);
            this.tabPage2.Controls.Add(this.numericupdown_decrypt_vertical);
            this.tabPage2.Controls.Add(this.textbox_decrypt_result);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textbox_decrypt_input_message);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расшифровать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericupdown_decrypt_horizontal
            // 
            this.numericupdown_decrypt_horizontal.Location = new System.Drawing.Point(318, 248);
            this.numericupdown_decrypt_horizontal.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericupdown_decrypt_horizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericupdown_decrypt_horizontal.Name = "numericupdown_decrypt_horizontal";
            this.numericupdown_decrypt_horizontal.Size = new System.Drawing.Size(120, 23);
            this.numericupdown_decrypt_horizontal.TabIndex = 17;
            this.numericupdown_decrypt_horizontal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericupdown_decrypt_vertical
            // 
            this.numericupdown_decrypt_vertical.Location = new System.Drawing.Point(318, 172);
            this.numericupdown_decrypt_vertical.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericupdown_decrypt_vertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericupdown_decrypt_vertical.Name = "numericupdown_decrypt_vertical";
            this.numericupdown_decrypt_vertical.Size = new System.Drawing.Size(120, 23);
            this.numericupdown_decrypt_vertical.TabIndex = 16;
            this.numericupdown_decrypt_vertical.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textbox_decrypt_result
            // 
            this.textbox_decrypt_result.Location = new System.Drawing.Point(247, 360);
            this.textbox_decrypt_result.Name = "textbox_decrypt_result";
            this.textbox_decrypt_result.Size = new System.Drawing.Size(275, 23);
            this.textbox_decrypt_result.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textbox_decrypt_input_message
            // 
            this.textbox_decrypt_input_message.Location = new System.Drawing.Point(318, 94);
            this.textbox_decrypt_input_message.Name = "textbox_decrypt_input_message";
            this.textbox_decrypt_input_message.Size = new System.Drawing.Size(131, 23);
            this.textbox_decrypt_input_message.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество букв, помещаемых по горизонтали:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество букв, помещаемых по вертикали:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Зашифрованное сообщение:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textbox_hack_result);
            this.tabPage3.Controls.Add(button3);
            this.tabPage3.Controls.Add(this.textbox_hack_input_message);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Взломать";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textbox_hack_input_message
            // 
            this.textbox_hack_input_message.Location = new System.Drawing.Point(317, 99);
            this.textbox_hack_input_message.Name = "textbox_hack_input_message";
            this.textbox_hack_input_message.Size = new System.Drawing.Size(131, 23);
            this.textbox_hack_input_message.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Зашифрованное сообщение:";
            // 
            // textbox_hack_result
            // 
            this.textbox_hack_result.Location = new System.Drawing.Point(246, 218);
            this.textbox_hack_result.Name = "textbox_hack_result";
            this.textbox_hack_result.Size = new System.Drawing.Size(275, 23);
            this.textbox_hack_result.TabIndex = 17;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(317, 163);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(120, 23);
            button3.TabIndex = 16;
            button3.Text = "Взломать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лабораторная 1. Табличный шифр";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_encrypt_horizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_encrypt_vertical)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_decrypt_horizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdown_decrypt_vertical)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numericupdown_encrypt_horizontal;
        private System.Windows.Forms.NumericUpDown numericupdown_encrypt_vertical;
        private System.Windows.Forms.TextBox textbox_encrypt_result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_encrypt_input_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numericupdown_decrypt_horizontal;
        private System.Windows.Forms.NumericUpDown numericupdown_decrypt_vertical;
        private System.Windows.Forms.TextBox textbox_decrypt_result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textbox_decrypt_input_message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_hack_result;
        private System.Windows.Forms.TextBox textbox_hack_input_message;
        private System.Windows.Forms.Label label7;
    }
}

