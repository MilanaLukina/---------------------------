using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace inform_sec_lab3_Milanochka
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Функция берет строку (длиной от 1 до 4 символов), склеивает биты первых 2 и последних 2 символов
        // Конвертирует полученные биты в uint32 числа и возвращает массив из этих двух чисел
        static List<UInt32> ConcatenateBits(string input)
        {
            // Получаем битовые представления для первых двух и последних двух символов
            string binaryA = input.Length > 0 ? Convert.ToString(input[0], 2).PadLeft(16, '0') : new string('0', 16);
            string binaryB = input.Length > 1 ? Convert.ToString(input[1], 2).PadLeft(16, '0') : new string('0', 16);
            string binaryC = input.Length > 2 ? Convert.ToString(input[2], 2).PadLeft(16, '0') : new string('0', 16);
            string binaryD = input.Length > 3 ? Convert.ToString(input[3], 2).PadLeft(16, '0') : new string('0', 16);
            // Склеиваем биты
            string concatenatedBits1 = binaryA + binaryB;
            string concatenatedBits2 = binaryC + binaryD;

            return new List<UInt32> { 
                Convert.ToUInt32(concatenatedBits1, 2), 
                Convert.ToUInt32(concatenatedBits2, 2) 
            };
        }


        // Функция строит из строки длиной 16 символов ключ длиной 8 символов (по 32 бита)
        static List<UInt32> BuildKey(string inputKey)
        {
            List<UInt32> key = new List<UInt32>();
            for (int i = 0; i<inputKey.Length; i+=2)
            {
                // Склеиваем биты левой и правой частей
                string binaryL = Convert.ToString(inputKey[i], 2).PadLeft(16, '0');
                string binaryR = Convert.ToString(inputKey[i+1], 2).PadLeft(16, '0');
                // Конвертируем в число
                key.Add(Convert.ToUInt32(binaryL+binaryR, 2));
            }
            key.Reverse();
            return key;
        }

        // Функция принимает побитовое разложение в виде строки binaryString и делит его на 
        // несколько побитовых разложений размером blockSize 
        static List<string> SplitIntoBlocks(string binaryString, int blockSize)
        {
            List<string> blocks = new List<string>();
            for (int i = 0; i < binaryString.Length; i += blockSize)
            {
                int length = Math.Min(blockSize, binaryString.Length - i);
                string block = binaryString.Substring(i, length);
                blocks.Add(block);
            }
            return blocks;
        }

        // Функция принимает на вход массив из побитовых разложений чисел
        // Конвертирует каждое разложение в число и возвращает массив из получившихся чисел
        static List<UInt32> ConvertBlocksToNumbers(List<string> bitBlocks)
        {
            List<UInt32> result = new List<UInt32>();
            foreach (var block in bitBlocks)
            {
                // Перевод числа
                UInt32 num = Convert.ToUInt32(block, 2);
                result.Add(num);
            }

            return result;
        }

        // Функция конвертирует побитовые разложения в виде строки в символы utf16
        static string ConvertBlocksToSymbols(List<string> bitBlocks)
        {
            string result = "";
            foreach (var block in bitBlocks)
            {
                UInt16 num = Convert.ToUInt16(block, 2);
                result += Convert.ToChar(num);
            }
            return result;
        }

        // Таблица замены
        private static byte[,] ReplaceTable = {
            {0x4, 0xA, 0x9, 0x2, 0xD, 0x8, 0x0, 0xE, 0x6, 0xB, 0x1, 0xC, 0x7, 0xF, 0x5, 0x3},
            {0xE, 0xB, 0x4, 0xC, 0x6, 0xD, 0xF, 0xA, 0x2, 0x3, 0x8, 0x1, 0x0, 0x7, 0x5, 0x9},
            {0x5, 0x8, 0x1, 0xD, 0xA, 0x3, 0x4, 0x2, 0xE, 0xF, 0xC, 0x7, 0x6, 0x0, 0x9, 0xB},
            {0x7, 0xD, 0xA, 0x1, 0x0, 0x8, 0x9, 0xF, 0xE, 0x4, 0x6, 0xC, 0xB, 0x2, 0x5, 0x3},
            {0x6, 0xC, 0x7, 0x1, 0x5, 0xF, 0xD, 0x8, 0x4, 0xA, 0x9, 0xE, 0x0, 0x3, 0xB, 0x2},
            {0x4, 0xB, 0xA, 0x0, 0x7, 0x2, 0x1, 0xD, 0x3, 0x6, 0x8, 0x5, 0x9, 0xC, 0xF, 0xE},
            {0xD, 0xB, 0x4, 0x1, 0x3, 0xF, 0x5, 0x9, 0x0, 0xA, 0xE, 0x7, 0x6, 0x8, 0x2, 0xC},
            {0x1, 0xF, 0xD, 0x0, 0x5, 0x7, 0xA, 0x4, 0x9, 0x2, 0x3, 0xE, 0x6, 0xB, 0x8, 0xC}
        };

        // Функция заменяет биты числа number в соответствии с таблицей ReplaceTable
        private static UInt32 ReplaceAccordTable(UInt32 number)
        {
            // Преобразование числа в двоичное представление
            string binaryRepresentation = Convert.ToString(number, 2);
            // Добавление ведущих нулей, если нужно
            binaryRepresentation = binaryRepresentation.PadLeft(32, '0');
            // Разбиение двоичного представления на блоки по 4 бита
            List<string> bitBlocksString = SplitIntoBlocks(binaryRepresentation, 4);
            // Конвертируем блоки в числа
            List<UInt32> bitBlocksNumbers = ConvertBlocksToNumbers(bitBlocksString);
            List<string> newBitBlocks = new List<string>();
            bitBlocksNumbers.Reverse();
            // Заменяем биты в соответствии с таблицей 
            for (int i = 0; i < bitBlocksNumbers.Count; i++)
            {
                newBitBlocks.Add(Convert.ToString(ReplaceTable[i, bitBlocksNumbers[i]], 2).PadLeft(4, '0'));
            }
            newBitBlocks.Reverse();
            return Convert.ToUInt32(string.Join("", newBitBlocks), 2);

        }

        // Шифр
        private void button1_Click(object sender, EventArgs e)
        {
            if (encryptionKey.Text.Length != 16)
            {
                MessageBox.Show("Длина ключа должна составлять 16 символов (256 бит)!");
                return;
            }
            List<UInt32> key = BuildKey(encryptionKey.Text);
            string result = "";
            char[] inputTextArray = encryptionText.Text.ToCharArray();
            while (inputTextArray.Length > 0)
            {
                string chunkFromInputText = string.Join("", inputTextArray.Take(4));
                inputTextArray = inputTextArray.Skip(4).ToArray();
                int i = 1;
                // Склеиваем пары символов и получаем 2 32 битовых числа
                List<UInt32> LR = ConcatenateBits(chunkFromInputText);
                for (int blockIndex = 0; blockIndex < LR.Count; blockIndex += 2)
                {
                    // Работаем с левой и правой частью
                    UInt32 l = LR[blockIndex];
                    UInt32 r = LR[blockIndex + 1];
                    UInt32 v;
                    while (i <= 32)
                    {
                        v = r;
                        int j = i < 25 ? (i - 1) % 8 : (32 - i) % 8;
                        r = (r + key[j]) % UInt32.MaxValue;
                        r = ReplaceAccordTable(r);
                        r = (r << 11) | (r >> (32 - 11));
                        r = r ^ l;
                        l = v;
                        i++;
                    }
                    // Склеиваем биты правой и левой частей
                    string resultBits = Convert.ToString(r, 2).PadLeft(32, '0') + Convert.ToString(l, 2).PadLeft(32, '0');
                    // Получаем из битов 4 символа в utf-16
                    List<string> bitBlocksString = SplitIntoBlocks(resultBits, 16);
                    result += ConvertBlocksToSymbols(bitBlocksString);
                }
            }
            encryptionResult.Text = result;
        }


        // Расшифр
        private void button2_Click(object sender, EventArgs e)
        {
            if (decryptionKey.Text.Length != 16)
            {
                MessageBox.Show("Длина ключа должна составлять 16 символов (256 бит)!");
                return;
            }
            List<UInt32> key = BuildKey(decryptionKey.Text);
            string result = "";
            char[] inputTextArray = decryptionText.Text.ToCharArray();
            while (inputTextArray.Length > 0)
            {
                int i = 1;
                string chunkFromInputText = string.Join("", inputTextArray.Take(4));
                inputTextArray = inputTextArray.Skip(4).ToArray();
                List<UInt32> LR = ConcatenateBits(chunkFromInputText);
                for (int blockIndex = 0; blockIndex < LR.Count; blockIndex += 2)
                {
                    UInt32 l = LR[blockIndex];
                    UInt32 r = LR[blockIndex + 1];
                    UInt32 v;
                    while (i <= 32)
                    {
                        v = r;
                        int j = i <= 8 ? (i - 1) % 8 : (32 - i) % 8;
                        r = (r + key[j]) % UInt32.MaxValue;
                        r = ReplaceAccordTable(r);
                        r = (r << 11) | (r >> (32 - 11));
                        r = r ^ l;
                        l = v;
                        i++;
                    }
                    string resultBits = Convert.ToString(r, 2).PadLeft(32, '0') + Convert.ToString(l, 2).PadLeft(32, '0');
                    List<string> bitBlocksString = SplitIntoBlocks(resultBits, 16);
                    result += ConvertBlocksToSymbols(bitBlocksString);
                }
            }
            decryptionResult.Text = result;
        }
    }
}
