using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public interface ITrasnlate
    {
        String InputText { get; set; }
        String OutputText { get; set; }

        String Translate(TextBox textBox);

        String GetTranslation(String word);

        bool IsVowel(char letter);

        int GetIndex(string word);


    }
}
