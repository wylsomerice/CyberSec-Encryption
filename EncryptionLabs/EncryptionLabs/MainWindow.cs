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
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
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

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ExcercisesForm excercises = new ExcercisesForm();
            excercises.Show();
        }
    }
}
