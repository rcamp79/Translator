using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        Latin latin = new Latin();
        Greek greek = new Greek();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            if (radioButtonLatin.Checked)
            {
                textBoxTranslation.Text = latin.Translate(textBoxOriginal);
            }
            else
            {
                textBoxTranslation.Text = greek.Translate(textBoxOriginal);
            }
            
        }

        private void textBoxTranslation_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOriginal.Clear();
            textBoxTranslation.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
