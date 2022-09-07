using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionLabs
{
    public partial class GronsfeldCipherForm_1 : Form
    {
        public GronsfeldCipherForm_1()
        {
            InitializeComponent();
        }

        private void GronsfeldCipher()
        {
            textBox3.Text = "";
            int key = 0;
            string[] array = new string[] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };

            try
            {
                key = Convert.ToInt32(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("Установите шаг шифрования!");
                return;
            }

            string[] array2;
            array2 = array.Skip(key).Concat(array.Take(key)).ToArray();

            //Данная функция смещает по кругу ячейки массива. Для расшифровки меняет ключ на противоположный знак
            foreach (string element in array2)
            {

            }

            string text = textBox2.Text;
            foreach (char letter in text)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (letter.ToString().ToLower() == array[i])
                    {
                        textBox3.Text += array2[i];
                        break;
                    }
                    else
                    {// эти знаки печатаются без зашифровки
                        if (letter.ToString() == " " || letter.ToString() == "." ||
                        letter.ToString() == "," || letter.ToString() == ":" ||
                        letter.ToString() == ";" || letter.ToString() == "?" ||
                        letter.ToString() == "!")
                        {
                            textBox3.Text += " ";
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GronsfeldCipher();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
