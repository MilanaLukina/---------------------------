
namespace inform_sec_lab3_Milanochka
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
            this.button1 = new System.Windows.Forms.Button();
            this.encryptionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptionKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptionResult = new System.Windows.Forms.TextBox();
            this.decryptionResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptionKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptionText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // encryptionText
            // 
            this.encryptionText.Location = new System.Drawing.Point(84, 78);
            this.encryptionText.Name = "encryptionText";
            this.encryptionText.Size = new System.Drawing.Size(166, 23);
            this.encryptionText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходное сообщение:";
            // 
            // encryptionKey
            // 
            this.encryptionKey.Location = new System.Drawing.Point(84, 161);
            this.encryptionKey.Name = "encryptionKey";
            this.encryptionKey.Size = new System.Drawing.Size(166, 23);
            this.encryptionKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите ключ (16 символов):";
            // 
            // encryptionResult
            // 
            this.encryptionResult.Location = new System.Drawing.Point(84, 335);
            this.encryptionResult.Name = "encryptionResult";
            this.encryptionResult.Size = new System.Drawing.Size(166, 23);
            this.encryptionResult.TabIndex = 5;
            // 
            // decryptionResult
            // 
            this.decryptionResult.Location = new System.Drawing.Point(395, 335);
            this.decryptionResult.Name = "decryptionResult";
            this.decryptionResult.Size = new System.Drawing.Size(166, 23);
            this.decryptionResult.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите ключ (16 символов):";
            // 
            // decryptionKey
            // 
            this.decryptionKey.Location = new System.Drawing.Point(398, 161);
            this.decryptionKey.Name = "decryptionKey";
            this.decryptionKey.Size = new System.Drawing.Size(166, 23);
            this.decryptionKey.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Закодированное сообщение:";
            // 
            // decryptionText
            // 
            this.decryptionText.Location = new System.Drawing.Point(398, 78);
            this.decryptionText.Name = "decryptionText";
            this.decryptionText.Size = new System.Drawing.Size(166, 23);
            this.decryptionText.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Закодированное сообщение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Исходное сообщение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decryptionResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptionKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptionText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.encryptionResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptionKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptionText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Лабораторная №3. Алгоритм ГОСТ 28147-89";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox encryptionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptionKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptionResult;
        private System.Windows.Forms.TextBox decryptionResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decryptionKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptionText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

