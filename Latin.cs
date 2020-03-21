using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    class Latin : ITrasnlate
    {
        public string InputText { get; set; }
        public string OutputText { get; set; }
        public string vowel = "AEIOUaeiou";
        public string regEx = "^[0-9(!@#$%/^&*.,;:)$";
        

        public string GetTranslation(string word)
        {
            int index = GetIndex(word);
            string ay = "ay";
            string way = "way";

            if(word.Length >= 3)
            {
                if (index == 0)
                {
                    word += way;
                }
                else
                {
                    word = word.Substring(index) + word.Substring(0, index) + ay;
                }
            }
            else
            {
                word += " ";
            }
      
            return word;
        }

        public String Translate(TextBox textBox)
        {
            string input = textBox.Text;
            string pgTranslaton = " ";
            string[] arr = input.Split(' ');

            for(int i = 0; i < arr.Length; i++)
            {
                pgTranslaton += GetTranslation(arr[i]) + " ";
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


        public bool isFirstVowel(char letter)
        {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                {
                    return true;
                }

            return false;
        }

        public int IsCapital(string word)
        {
            int index = 0;


            return index;
        }
    }
}
