﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionLabs
{
    public partial class FileCompressionForm : Form
    {
        public FileCompressionForm()
        {
            InitializeComponent();
        }

        List<ArithmeticCoder.symbol> alph =
            new List<ArithmeticCoder.symbol>
            {
                new ArithmeticCoder.symbol('1',0,1),//1
                new ArithmeticCoder.symbol('0',1,2),//2             
            };

        private void button1_Click(object sender, EventArgs e)
        {


            string input = textBox1.Text;
            HuffmanTree huffmanTree = new HuffmanTree();


            huffmanTree.Build(input);

            // Кодирование
            BitArray encoded = huffmanTree.Encode(input);

            richTextBox1.Text += " Хаффман кодировка: ";
            foreach (bool bit in encoded)
            {
                richTextBox1.Text += ((bit ? 1 : 0) + "");
            }
            richTextBox1.Text += "\n";

            #region Арифметическое сжатие
            string test, expand_test, compressed = "";

            System.IO.MemoryStream mem_test = new System.IO.MemoryStream();

            ArithmeticCoder c;

            test = ToDigitString(encoded);
            MessageBox.Show(test);

            c = new ArithmeticCoder(alph);

            c.Scale = 2;

            mem_test = c.compress(test);

            foreach (byte b in mem_test.ToArray())
                compressed += b.ToString();

            expand_test = c.expand(mem_test, test.Length);

            richTextBox1.Text += " Арифметическое сжатие \n До сжатия :" + test;
            richTextBox1.Text += "\n Сжатие (" + mem_test.Length + " bytes) :\n " + compressed;
            richTextBox1.Text += "\n Распаковка :" + expand_test;
            #endregion


            Byte[] eh = new Byte[expand_test.Length];
            eh = Encoding.UTF8.GetBytes(expand_test);

            BitArray encoded2 = new BitArray(eh);

            // Декодировка
            string decoded = huffmanTree.Decode(encoded);

            richTextBox1.Text += ("\n Хаффман декодировка: " + decoded);

            Console.ReadLine();
        }

        public string ToDigitString(BitArray array)
        {
            var builder = new StringBuilder();
            foreach (var bit in array.Cast<bool>())
                builder.Append(bit ? "1" : "0");
            return builder.ToString();
        }

        public static byte[] ToByteArray(object obj)
        {
            int len = Marshal.SizeOf(obj);
            byte[] arr = new byte[len];
            IntPtr ptr = Marshal.AllocHGlobal(len);
            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, len);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            HuffmanTree huffmanTree = new HuffmanTree();


            huffmanTree.Build(input);

            // Кодирование
            BitArray encoded = huffmanTree.Encode(input);

            richTextBox1.Text += " Хаффман кодировка: ";
            foreach (bool bit in encoded)
            {
                richTextBox1.Text += ((bit ? 1 : 0) + "");
            }
            richTextBox1.Text += "\n";

            #region Арифметическое сжатие
            string test, expand_test, compressed = "";

            System.IO.MemoryStream mem_test = new System.IO.MemoryStream();

            ArithmeticCoder c;

            test = ToDigitString(encoded);
            MessageBox.Show(test);

            c = new ArithmeticCoder(alph);

            c.Scale = 2;

            mem_test = c.compress(test);

            foreach (byte b in mem_test.ToArray())
                compressed += b.ToString();

            expand_test = c.expand(mem_test, test.Length);

            richTextBox1.Text += " Арифметическое сжатие \n До сжатия :" + test;
            richTextBox1.Text += "\n Сжатие (" + mem_test.Length + " bytes) :\n " + compressed;
            richTextBox1.Text += "\n Распаковка :" + expand_test;
            #endregion


            Byte[] eh = new Byte[expand_test.Length];
            eh = Encoding.UTF8.GetBytes(expand_test);

            BitArray encoded2 = new BitArray(eh);

            // Декодировка
            string decoded = huffmanTree.Decode(encoded);

            richTextBox1.Text += ("\n Хаффман декодировка: " + decoded);

            Console.ReadLine();
        }
    }
}
