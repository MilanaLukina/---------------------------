using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace information_security_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Шифрование текста (листенер)
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textbox_encrypt_input_message.Text;
            int verticalCount = (int) numericupdown_encrypt_vertical.Value;
            int horizontalCount = (int) numericupdown_encrypt_horizontal.Value;
            if (text.Length > verticalCount * horizontalCount)
            {
                MessageBox.Show("Введенный текст не помещается на брусок");
            } else
            {
                textbox_encrypt_result.Text = Crypto.encrypt(text, verticalCount, horizontalCount);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textbox_decrypt_input_message.Text;
            int verticalCount = (int)numericupdown_decrypt_vertical.Value;
            int horizontalCount = (int)numericupdown_decrypt_horizontal.Value;
            if (text.Length > verticalCount * horizontalCount)
            {
                MessageBox.Show("Введенный текст не помещается на брусок");
            }
            else
            {
                textbox_decrypt_result.Text = Crypto.decrypt(text, verticalCount, horizontalCount);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textbox_hack_input_message.Text;
            textbox_hack_result.Text = Crypto.hack(text);
        }
    }
}
