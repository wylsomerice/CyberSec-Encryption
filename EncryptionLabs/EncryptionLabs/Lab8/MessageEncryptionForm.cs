using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptionLabs
{
    public partial class MessageEncryptionForm : Form
    {
        public MessageEncryptionForm()
        {
            InitializeComponent();
        }
        string[] resXOR;
        string[] gammaBits;

        string[] GetArrBitStr(int lenBlock, string str)
        {
            byte[] byteBaseTxt = Encoding.Default.GetBytes(str);
            string strBaseTxt = string.Join("", byteBaseTxt.Select(x => Convert.ToString(x, 2)).Select(x => string.Concat(Enumerable.Repeat("0", 8 - x.Length)) + x)); 
            int countBlock = (int)Math.Ceiling(strBaseTxt.Length / (double)lenBlock); 
            string[] needBlocks = Enumerable.Range(0, countBlock).Select(x => string.Join("", strBaseTxt.Skip(x * lenBlock).Take(lenBlock))).ToArray(); 

            if (needBlocks[needBlocks.GetLength(0) - 1].Length < 48)
            {
                int ln = needBlocks[needBlocks.GetLength(0) - 1].Length;
                for (int i = 0; i < 48 - ln; i++)
                    needBlocks[needBlocks.GetLength(0) - 1] += "0";
            }
            return needBlocks;
        }

        string[] GoXOR(string[] baseTxt, string[] gammaTxt, int len)
        {
            int result = 1, N = 1;
            string[] resStr = new string[baseTxt.GetLength(0)];
            for (int i = 0; i < baseTxt.GetLength(0); i++)
            {
                for (int j = 0; j < len; j++)
                    resStr[i] += Convert.ToInt32(baseTxt[i].Substring(j, 1)) ^ Convert.ToInt32(gammaTxt[i].Substring(j, 1));
                int resNew = result + N;
            }

            return resStr;
        }
        string ConvertBitsStr(string[] arrStr)
        {
            string res = "";
            for (int i = 0; i < arrStr.GetLength(0); i++)
            {
                res += arrStr[i];
            }
            string[] arrByteStr = Enumerable.Range(0, (res.Length / 8)).Select(x => string.Join("", res.Skip(x * 8).Take(8))).ToArray(); 
            byte[] arrByte = arrByteStr.Select(x => Convert.ToByte(x, 2)).ToArray(); 
            string resStr = Encoding.Default.GetString(arrByte);
            return resStr;
        }

        private void buttonEncrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBaseText.Text != "" && textBoxGamma.Text != "")
                {
                    string[] needBlocks = GetArrBitStr(48, textBoxBaseText.Text);

                    for (int i = 0; i < needBlocks.GetLength(0); i++)
                        textBox3.Text += needBlocks[i];

                    while (textBoxBaseText.Text.Length > textBoxGamma.Text.Length)
                        textBoxGamma.Text += textBoxGamma.Text;
                    gammaBits = GetArrBitStr(48, textBoxGamma.Text);
                    for (int i = 0; i < gammaBits.GetLength(0); i++)
                        textBox4.Text += gammaBits[i];

                    resXOR = GoXOR(needBlocks, gammaBits, 48);
                    for (int i = 0; i < resXOR.GetLength(0); i++)
                        textBox1.Text += resXOR[i];
                    string resStr = ConvertBitsStr(resXOR);
                }
                else
                    MessageBox.Show("Не возможно выполнить действие!\nЗаполнены не все поля!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDecrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] resDecrypt = GoXOR(resXOR, gammaBits, 48);
                string resStr = ConvertBitsStr(resDecrypt);
                textBox2.Text += resStr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
