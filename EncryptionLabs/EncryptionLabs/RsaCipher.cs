using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionLabs
{
    public partial class RsaCipher : Form
    {
        RSAParameters privateKey;
        RSAParameters publicKey;
        public RsaCipher()
        {
            InitializeComponent();
            //Пункт 1
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            //Пункт 2
            privateKey = RSA.ExportParameters(true);
            publicKey = RSA.ExportParameters(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            string base64string = Convert.ToBase64String(Encoding.UTF8.GetBytes(textBox1.Text));
            byte[] input = Convert.FromBase64String(base64string);
            byte[] output;
            //Пункт 3
            output = RSAEncrypt(input, publicKey, false);

            textBox2.Text = Convert.ToBase64String(output);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            string base64string = Convert.ToBase64String(Encoding.UTF8.GetBytes(textBox2.Text));
            byte[] input = Convert.FromBase64String(textBox2.Text);
            //Пункт 4
            byte[] output = RSADecrypt(input, privateKey, false);

            textBox4.Text = Convert.ToBase64String(output);
            MessageBox.Show(Convert.ToBase64String(output));
        }

        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            //Create a new instance of RSACryptoServiceProvider.
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            //Import the RSA Key information. This only needs
            //toinclude the public key information.
            RSA.ImportParameters(RSAKeyInfo);

            //Encrypt the passed byte array and specify OAEP padding.  
            //OAEP padding is only available on Microsoft Windows XP or
            //later.  
            return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
        }

        static public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            //Create a new instance of RSACryptoServiceProvider.
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            //Import the RSA Key information. This needs
            //to include the private key information.
            RSA.ImportParameters(RSAKeyInfo);

            //Decrypt the passed byte array and specify OAEP padding.  
            //OAEP padding is only available on Microsoft Windows XP or
            //later.  
            return RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
