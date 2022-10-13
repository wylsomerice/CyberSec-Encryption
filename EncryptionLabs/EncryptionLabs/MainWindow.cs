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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

           
        }

        #region Шифр Гронсфельда
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GronsfeldCipherForm gronsfeldCipher = new GronsfeldCipherForm();
            gronsfeldCipher.Show();
        }
        #endregion
        #region RSA-шифрование
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RsaCipherForm rsaCipher = new RsaCipherForm();
            rsaCipher.Show();
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AlGamalCipherForm alGamal = new AlGamalCipherForm();
            alGamal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BinaryBlockCipherForm bbcf = new BinaryBlockCipherForm();
            bbcf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RightSendCheckForm frscf = new RightSendCheckForm();
            frscf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FileCompressionForm fcf = new FileCompressionForm();
            fcf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PasswordHashForm phf = new PasswordHashForm();
            phf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageEncryptionForm mef = new MessageEncryptionForm();
            mef.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ExcercisesForm excercises = new ExcercisesForm();
            excercises.Show();
        }
    }
}
