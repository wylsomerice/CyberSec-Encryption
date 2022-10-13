using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using System.Security.Cryptography;
using System.Numerics;
using System.IO;

namespace EncryptionLabs
{
    
    public partial class RsaCipherForm : Form
    {
        public RsaCipherForm()
        {
            InitializeComponent();
        }
        private static Random rng = new Random(Environment.TickCount);

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Генерация  числа заданной длинны 
        long GetNumber(object objlength)
        {
            int length = Convert.ToInt32(objlength);
            long number = Convert.ToInt64(rng.NextDouble().ToString("0.000000000000").Substring(2, length));
            return number;
        }



        private readonly Random _random = new Random();

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Генерация простого числа заданной длинны 
        public long Generate(int s)
        {

            long number = 4;
            while (!IsPrime(number))
            {
                unchecked
                {
                    number = GetNumber(s);
                }
            }
            return number;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Проверка на простое число
        private static bool IsPrime(long number)
        {
            if ((number & 1) == 0) return (number == 2);

            var limit = (uint)Math.Sqrt(number);
            for (uint i = 3; i <= limit; i += 2)
            {
                if ((number % i) == 0) return false;
            }
            return true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Вычисляем d
        BigInteger d, y;
        public BigInteger[] CalcD(BigInteger e, BigInteger b, BigInteger c)
        {
            BigInteger s;
            if (b == 0)
            {
                c = e;
                d = 1;
                y = 0;

                return new BigInteger[] { d, y };
            }

            CalcD(b, e % b, c);

            s = y;
            y = d - (e / b) * y;
            d = s;

            return new BigInteger[] { d, y };
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Событие генерация значений ключей

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Расшифровка

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Шифрование
        private void button2_Click_1(object sender, EventArgs e)
        {
            string startPath = @"text.txt";
            string encryptPath = @"enc.txt";

            string startText = File.ReadAllText(startPath);

            string alph = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!.,";

            for (int i = 0; i < startText.Length; i++)
            {
                if (alph.Contains(startText[i]))
                {
                    BigInteger a = alph.IndexOf(startText[i]);

                    BigInteger b = BigInteger.ModPow(a, BigInteger.Parse(eValue.Text), BigInteger.Parse(nValue.Text));//i^e(mod n)

                    File.AppendAllText(encryptPath, b.ToString() + " ");
                }
            }
        }

        private void DECRYPT_BUTTON_Click(object sender, EventArgs e)
        {
            string decryptPath = @"dec.txt";
            string encryptPath = @"enc.txt";
            string alph = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!.,";

            string encryptText = File.ReadAllText(encryptPath);
            List<BigInteger> arr = new List<BigInteger>();
            int k = -1;
            for (int i = 0; i < encryptText.Length; i++)
            {
                if (encryptText[i] == ' ')
                {
                    string str = "";
                    for (int j = k + 1; j < i; j++)
                    {
                        str += encryptText[j];
                    }

                    arr.Add(BigInteger.Parse(str));
                    k = i;
                }
            }
            for (int i = 0; i < arr.Count; i++)
            {
                BigInteger a = BigInteger.ModPow(arr[i], BigInteger.Abs(BigInteger.Parse(dValue.Text)), BigInteger.Parse(nValue.Text));//e^d(mod n)
                if (a < int.MaxValue)
                {
                    string str2 = alph[int.Parse(a.ToString())].ToString();
                    File.AppendAllText(decryptPath, str2);
                }
                else
                {
                    MessageBox.Show("Ошибка! Приватный ключ не подошел!");
                    File.AppendAllText(decryptPath, "Ошибка! Приватный ключ не подошел!");
                    break;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            do
            {
                BigInteger ex;
                BigInteger p = Generate(12);
                BigInteger q = Generate(12);
                BigInteger n = BigInteger.Multiply(q, p);
                BigInteger m = (p - 1) * (q - 1);

                do
                {
                    ex = Generate(12);
                } while (BigInteger.GreatestCommonDivisor(ex, m) != 1);


                d = CalcD(ex, m, 1)[0];
                y = CalcD(ex, m, 1)[1];


                pValue.Text = p.ToString();
                qValue.Text = q.ToString();
                dValue.Text = d.ToString();
                yValue.Text = y.ToString();
                nValue.Text = n.ToString();
                eValue.Text = ex.ToString();
            } while (d <= 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            File.WriteAllText(@"dec.txt", string.Empty);
            File.WriteAllText(@"enc.txt", string.Empty);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Очистка файлов
    

    }
}
