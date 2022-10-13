namespace EncryptionLabs
{
    partial class RsaCipherForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.eValue = new System.Windows.Forms.TextBox();
            this.nValue = new System.Windows.Forms.TextBox();
            this.DECRYPT_BUTTON = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dValue = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.qValue = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.pValue = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 198);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 55);
            this.button4.TabIndex = 45;
            this.button4.Text = "Очистить файлы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // eValue
            // 
            this.eValue.Location = new System.Drawing.Point(46, 98);
            this.eValue.Name = "eValue";
            this.eValue.Size = new System.Drawing.Size(140, 22);
            this.eValue.TabIndex = 44;
            // 
            // nValue
            // 
            this.nValue.Location = new System.Drawing.Point(46, 13);
            this.nValue.Margin = new System.Windows.Forms.Padding(4);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(140, 22);
            this.nValue.TabIndex = 43;
            // 
            // DECRYPT_BUTTON
            // 
            this.DECRYPT_BUTTON.Location = new System.Drawing.Point(171, 139);
            this.DECRYPT_BUTTON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DECRYPT_BUTTON.Name = "DECRYPT_BUTTON";
            this.DECRYPT_BUTTON.Size = new System.Drawing.Size(140, 55);
            this.DECRYPT_BUTTON.TabIndex = 42;
            this.DECRYPT_BUTTON.Text = "Расшифровать";
            this.DECRYPT_BUTTON.UseVisualStyleBackColor = true;
            this.DECRYPT_BUTTON.Click += new System.EventHandler(this.DECRYPT_BUTTON_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 139);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 55);
            this.button2.TabIndex = 41;
            this.button2.Text = "Зашифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 40;
            this.label4.Text = " y =";
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(46, 71);
            this.yValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(140, 22);
            this.yValue.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 55);
            this.button1.TabIndex = 38;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 276);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 39);
            this.button3.TabIndex = 37;
            this.button3.Text = "<<Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dValue
            // 
            this.dValue.Location = new System.Drawing.Point(46, 43);
            this.dValue.Margin = new System.Windows.Forms.Padding(4);
            this.dValue.Name = "dValue";
            this.dValue.Size = new System.Drawing.Size(140, 22);
            this.dValue.TabIndex = 36;
            // 
            // labelD
            // 
            this.labelD.Location = new System.Drawing.Point(24, 46);
            this.labelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelD.Name = "labelD";
            this.labelD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelD.Size = new System.Drawing.Size(55, 18);
            this.labelD.TabIndex = 35;
            this.labelD.Text = "d =";
            // 
            // labelN
            // 
            this.labelN.Location = new System.Drawing.Point(22, 16);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(55, 18);
            this.labelN.TabIndex = 34;
            this.labelN.Text = " n=";
            // 
            // labelE
            // 
            this.labelE.Location = new System.Drawing.Point(24, 98);
            this.labelE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(55, 18);
            this.labelE.TabIndex = 33;
            this.labelE.Text = "e=";
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(284, 48);
            this.qValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(169, 18);
            this.qValue.TabIndex = 32;
            // 
            // labelQ
            // 
            this.labelQ.Location = new System.Drawing.Point(221, 48);
            this.labelQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(55, 18);
            this.labelQ.TabIndex = 31;
            this.labelQ.Text = "q=";
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(284, 16);
            this.pValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(169, 18);
            this.pValue.TabIndex = 30;
            // 
            // labelP
            // 
            this.labelP.Location = new System.Drawing.Point(221, 16);
            this.labelP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(55, 18);
            this.labelP.TabIndex = 29;
            this.labelP.Text = "p=";
            // 
            // RsaCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 383);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.eValue);
            this.Controls.Add(this.nValue);
            this.Controls.Add(this.DECRYPT_BUTTON);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dValue);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.labelP);
            this.Name = "RsaCipherForm";
            this.Text = "RSA шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox eValue;
        private System.Windows.Forms.TextBox nValue;
        private System.Windows.Forms.Button DECRYPT_BUTTON;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox dValue;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label qValue;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label pValue;
        private System.Windows.Forms.Label labelP;
    }
}