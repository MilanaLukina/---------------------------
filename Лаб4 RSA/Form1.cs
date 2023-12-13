using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Меняем n и фи при вводе p или q
        private void textBox1_Leave(object sender, EventArgs e)
        {
            int p, q;
            if (Int32.TryParse(enterP.Text, out p) && Int32.TryParse(enterQ.Text, out q))
            {
                outN.Text = (p * q).ToString();
                outFi.Text = ((p - 1) * (q - 1)).ToString();
            }
        }

        private void enterQ_Leave(object sender, EventArgs e)
        {
            int p, q;
            if (Int32.TryParse(enterP.Text, out p) && Int32.TryParse(enterQ.Text, out q))
            {
                outN.Text = (p * q).ToString();
                outFi.Text = ((p - 1) * (q - 1)).ToString();
            }
        }

        // Функция ищет значение (baseValue ^ exponent) % modulus
        static BigInteger ModPow(BigInteger baseValue, BigInteger exponent, BigInteger modulus)
        {
            if (modulus == 1)
                return 0;

            BigInteger result = 1;
            baseValue = baseValue % modulus;

            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    result = (result * baseValue) % modulus;

                exponent >>= 1;
                baseValue = (baseValue * baseValue) % modulus;
            }

            return result;
        }

        // Является ли number простым числом
        static bool IsPrime(BigInteger number)
        {
            if (number <= 1)
                return false;
            if (number == 2 || number == 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;
            for (BigInteger i = 5; i * i <= number; i += 1)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        // Поиск наибольшего общего делителя 
        private BigInteger findNOD(BigInteger a, BigInteger b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        // Функция проверяет, удовлетворяют ли исходные данные условиям
        // Если нет, то возвращает false и выводит соответствующее сообщение
        private bool validateData(BigInteger p, BigInteger q, BigInteger fi, BigInteger e, BigInteger d)
        {
            if (p == q)
            {
                MessageBox.Show("P не должен быть равен q");
                return false;
            }    
            if (!IsPrime(p) || !IsPrime(q))
            {
                MessageBox.Show("P и Q должны быть простыми");
                return false;
            }
            if (e >= fi || findNOD(e, fi) != 1)
            {
                MessageBox.Show("Не выполнено условие: НОД(e, φ(n)) = 1");
                return false;
            }
            if (BigInteger.Remainder(d * e, fi) != 1)
            {
                MessageBox.Show("Не выполнено условие: e*d = 1(mod(φ(n))");
                return false;
            }
            return true;
        }

        // Зашифровать сообщение
        private void button1_Click(object sender, EventArgs even)
        {
            string text = enterText1.Text;
            BigInteger p = BigInteger.Parse(enterP.Text);
            BigInteger q = BigInteger.Parse(enterQ.Text);
            BigInteger n = BigInteger.Parse(outN.Text);
            BigInteger fi = BigInteger.Parse(outFi.Text);
            BigInteger e = BigInteger.Parse(enterE.Text);
            BigInteger d = BigInteger.Parse(enterD1.Text);
            // Проверяем, удовлетворяют ли исходные данные условиям
            if (validateData(p, q, fi, e, d))
            {
                outText1.Text = "";
                for (int i = 0; i < text.Length; i++)
                {
                    // s = (m^e)%n
                    BigInteger m = new BigInteger(text[i]);
                    BigInteger s = ModPow(m, e, n);
                    outText1.Text += char.ConvertFromUtf32((int)s);
                }
            }
        }

        // Дешифровать сообщение
        private void button2_Click(object sender, EventArgs e)
        {
            string text = enterText2.Text;
            BigInteger d = BigInteger.Parse(enterD2.Text);
            BigInteger n = BigInteger.Parse(enterN.Text);
            outText2.Text = "";
            outVariants.Items.Clear();
            for (int i = 0; i < text.Length; i++)
            {
                // m' = (s^d)%n
                BigInteger s = new BigInteger(text[i]);
                BigInteger m = ModPow(s, d, n);
                outText2.Text += char.ConvertFromUtf32((int)m);
            }
            // Если у оригинального сообщения могло быть несколько вариантов
            if ((long)n < Math.Pow(2, 15))
            {
                int step = (int)n;
                // Исходный вариант дешифровки
                char[] originalSymbols = outText2.Text.ToCharArray();
                // Добавляем к оригинальному варианту варианты с теми же кодами, но +n, +2n, +3n..
                for (int i = 0; i < Math.Pow(2, 15); i += step)
                {
                    string newDecodeVariant = "";
                    foreach (char originalSymbol in originalSymbols)
                    {
                        newDecodeVariant += char.ConvertFromUtf32((int)originalSymbol + i);
                    }
                    outVariants.Items.Add(newDecodeVariant);
                }
            }
        }
    }
}
