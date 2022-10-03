namespace EncryptionLabs
{
    partial class BinaryBlockCipherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDecodeKeyWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEncodeKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDecodeKeyWord
            // 
            this.textBoxDecodeKeyWord.Location = new System.Drawing.Point(46, 203);
            this.textBoxDecodeKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDecodeKeyWord.Name = "textBoxDecodeKeyWord";
            this.textBoxDecodeKeyWord.Size = new System.Drawing.Size(148, 22);
            this.textBoxDecodeKeyWord.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18F);
            this.label2.Location = new System.Drawing.Point(42, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ключ декодирования";
            // 
            // textBoxEncodeKeyWord
            // 
            this.textBoxEncodeKeyWord.Location = new System.Drawing.Point(46, 104);
            this.textBoxEncodeKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEncodeKeyWord.Name = "textBoxEncodeKeyWord";
            this.textBoxEncodeKeyWord.Size = new System.Drawing.Size(145, 22);
            this.textBoxEncodeKeyWord.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18F);
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ключ кодирования \r\n(16 бит / 2 символа UTF-8)\r\n";
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Location = new System.Drawing.Point(326, 166);
            this.buttonDecipher.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(149, 59);
            this.buttonDecipher.TabIndex = 8;
            this.buttonDecipher.Text = "Расшифровать";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click_1);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(330, 69);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(145, 57);
            this.buttonEncrypt.TabIndex = 7;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "<<Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BinaryBlockCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDecodeKeyWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEncodeKeyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "BinaryBlockCipherForm";
            this.Text = "BinaryBlockCipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDecodeKeyWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEncodeKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button button1;
    }
}