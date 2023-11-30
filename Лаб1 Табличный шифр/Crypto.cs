using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace information_security_lab1
{
    static class Crypto
    {
        // Шифрование
        public static string encrypt(string text, int veritcalCount, int horizontalCount)
        {
            string result = "";
            for (int i = 0; i < horizontalCount; i++)
                for (int j = 0; j < veritcalCount; j++)
                    if (i + j * horizontalCount < text.Length)
                        result += text[i + j * horizontalCount];
                    else
                        result += " ";
            // Убираем лишние пробелы
            return result.Trim();
        }

        // Дешифрование
        public static string decrypt(string text, int veritcalCount, int horizontalCount)
        {
            string result = "";
            for (int i = 0; i < veritcalCount; i++)
                for (int j = 0; j < horizontalCount; j++)
                    if (i + j * veritcalCount < text.Length)
                        result += text[i + j * veritcalCount];
            return result.Trim();
        }

        private static List<string> findAllWordsInDictionary(string text)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            List<string> result = new List<string>();
            // Define the pattern for special characters
            string pattern = "[^а-яА-Я ]";
            // Use Regex to replace special characters with an empty string
            var textWithoutSpecSymbols = new List<string>(Regex.Replace(text, pattern, "").Split(" "));
            var srcEncoding = Encoding.GetEncoding(1251);
            var sr = new System.IO.StreamReader("russian.txt", encoding:srcEncoding);
            // Iterating the file
            while (sr.Peek() >= 0)
            {
                string currentStroke = sr.ReadLine().Trim();
                var foundWords = textWithoutSpecSymbols.FindAll(e => e.ToLower() == currentStroke.ToLower());
                result.AddRange(foundWords);
            }
            return result;
        }

        private static int wordsLettersCount(List<string> words)
        {
            int arrayWordCounter = 0;
            foreach (var word in words)
                arrayWordCounter += word.Length;
            return arrayWordCounter;
        }

        // Взлом шифра
        public static string hack(string text)
        {
            string result = "";
            int maxWordCount = 0;
            Dictionary<string, int> addedVariants = new Dictionary<string, int>();
            string pattern = "[^а-яА-Я]";
            // Use Regex to replace special characters with an empty string
            for (int i = 0; i<text.Length; i++)
                for (int j = 0; j<text.Length; j++)
                    if (text.Length <= i*j)
                    {
                        // Перебираем все варианты дешифровки
                        string decrypted_text = decrypt(text, i, j);
                        if (!addedVariants.ContainsKey(decrypted_text))
                        {
                            // Получаем все осмысленные слова из текущей расшифровки
                            var words = findAllWordsInDictionary(decrypted_text);
                            var textWithoutSpecSymbols = Regex.Replace(decrypted_text, pattern, "");
                            var lettersCount = wordsLettersCount(words);
                            // Если все буквы из расшифрованных слов покрывают все буквы из текста, то сразу возвращаем
                            if (textWithoutSpecSymbols.Length == lettersCount)
                                return decrypted_text;
                            addedVariants.Add(decrypted_text, lettersCount);
                        }
                    }
            // Ищем вариант с максимальным покрытием букв
            foreach (KeyValuePair<string, int> entry in addedVariants)
                if (entry.Value > maxWordCount)
                {
                    result = entry.Key;
                    maxWordCount = entry.Value;
                }
            return result.Trim();
        }
    }
}
