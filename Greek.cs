using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    class Greek : ITrasnlate
    {
        public string InputText { get; set; }
        public string OutputText { get; set; }

        public string GetTranslation(string word)
        {
            int index = GetIndex(word);
            string omatos = "omatos ";
            string oi = "oi ";

            if (word.Length >= 3)
            {
                if (index == 0)
                {
                    word += oi;
                }
                else
                {
                    word = word.Substring(index) + word.Substring(0, index) + omatos;
                }
            }
            else
            {
                word += " ";
            }

            return word;
        }

        public bool IsVowel(char letter)
        {

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y' || letter == 'y')
            {
                return true;
            }
            else
            {
                return false;

            }

        }

        public String Translate(TextBox textBox)
        {
            string input = textBox.Text;
            string pgTranslaton = " ";
            string[] arr = input.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                pgTranslaton += GetTranslation(arr[i]);
            }
            return pgTranslaton;
        }

        public int GetIndex(string word)
        {
            int index = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (IsVowel(word[i]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
