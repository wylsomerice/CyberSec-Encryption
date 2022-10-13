using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

using System.Windows.Forms;

namespace EncryptionLabs
{
    public partial class AlGamalCipherForm : Form
    {
        public AlGamalCipherForm()
        {
            InitializeComponent();
        }

        private static readonly Random rng = new Random(Environment.TickCount);

        public static BigInteger ToBigInteger(string value)
        {
            BigInteger result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result = result * 10 + (value[i] - '0');
            }
            return result;
        }
        private static bool IsPrime(BigInteger number)
        {
            if ((number & 1) == 0) return (number == 2);

            var limit = Math.Sqrt((double)number);
            for (uint i = 3; i <= limit; i += 2)
            {
                if ((number % i) == 0) return false;
            }
            return true;
        }
        public BigInteger GenerateNumber(int objlength)
        {
            int length = Convert.ToInt32(objlength);
            BigInteger number = ToBigInteger(rng.NextDouble().ToString("0.000000000000000000000").Substring(2, length));
            return number;
        }
        public BigInteger GeneratePrime()
        {

            BigInteger number = 4;
            while (!IsPrime(number))
            {
                unchecked
                {
                    number = GenerateNumber(12);
                }
            }

            return number;
        }
        private void WriteArrayToFile(string fileName, string[] array)
        {
            TextWriter file = File.CreateText(fileName);
            for (int i = 0; i < array.Length; i++)
            {
                file.WriteLine(array[i]);
            }
            file.Close();
        }

        private void Decrypt(BigInteger x, BigInteger p)
        {
            List<string> strings = new List<string>();
            TextReader file = File.OpenText("EncryptedTextLab3.txt");
            string s = file.ReadLine();
            while (s != null)
            {
                strings.Add(s);
                s = file.ReadLine();
            }
            file.Close();
            string[] a = strings.ToArray();
            s = "";
            for (int i = 0; i < a.Length; i += 2)
            {
                BigInteger a_ = ToBigInteger(a[i]);
                BigInteger b_ = ToBigInteger(a[i + 1]);
                BigInteger m1 = BigInteger.Pow(a_, (int)(p - 1 - x));
                BigInteger m2 = BigInteger.Multiply(m1, b_);
                BigInteger m3 = BigInteger.ModPow(m2, 1, p);
                string ms = m3.ToString();
                int m = Convert.ToInt32(ms);
                char c = (char)m3;
                s += c;
            }
            TextWriter file1 = File.CreateText("DecryptedTextLab3.txt");
            file1.WriteLine(s);
            file1.Close();
        }

        private void Encrypt(string a, BigInteger g, BigInteger k, BigInteger p, BigInteger y)
        {
            int j = 0;
            string[] strings = new string[a.Length * 2];
            for (int i = 0; i < strings.Length; i += 2)
            {
                BigInteger a_ = BigInteger.ModPow(g, k, p);
                strings[i] = a_.ToString();
                int m = Convert.ToInt32(a[j]);
                BigInteger b_ = BigInteger.ModPow(BigInteger.Multiply(BigInteger.Pow(y, (int)k), m), 1, p);
                strings[i + 1] = b_.ToString();
                j++;
            }
            WriteArrayToFile("EncryptedTextLab3.txt", strings);
        }
        private void generate_button_Click_1(object sender, EventArgs e)
        {
            BigInteger p = 12655517791775452577;
            BigInteger g = GeneratePrime();
            BigInteger x = 0;
            while (x == 0 || p - x > 10000 || p - x < 2)
            {
                int z = rng.Next(100, 10000);
                x = p - z;
            }
            pValue.Text = p.ToString();
            gValue.Text = g.ToString();
            xValue.Text = x.ToString();
            BigInteger y = BigInteger.ModPow(g, x, p);
            BigInteger k = 9;
            string message = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure d";
            yValue.Text = y.ToString();
            Encrypt(message, g, k, p, y);
            Decrypt(x, p);
        }
    }
}
