namespace EncryptionLabs
{
    partial class AlGamalCipherForm
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
            this.rTxtBOut = new System.Windows.Forms.TextBox();
            this.lblTest = new System.Windows.Forms.TextBox();
            this.txtBTest = new System.Windows.Forms.TextBox();
            this.txtBPublicKey = new System.Windows.Forms.TextBox();
            this.txtBPrivateKey = new System.Windows.Forms.TextBox();
            this.txtBIn = new System.Windows.Forms.TextBox();
            this.numP = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.SuspendLayout();
            // 
            // rTxtBOut
            // 
            this.rTxtBOut.Location = new System.Drawing.Point(32, 32);
            this.rTxtBOut.Name = "rTxtBOut";
            this.rTxtBOut.Size = new System.Drawing.Size(100, 22);
            this.rTxtBOut.TabIndex = 0;
            // 
            // lblTest
            // 
            this.lblTest.Location = new System.Drawing.Point(32, 82);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(100, 22);
            this.lblTest.TabIndex = 1;
            // 
            // txtBTest
            // 
            this.txtBTest.Location = new System.Drawing.Point(32, 144);
            this.txtBTest.Name = "txtBTest";
            this.txtBTest.Size = new System.Drawing.Size(100, 22);
            this.txtBTest.TabIndex = 2;
            // 
            // txtBPublicKey
            // 
            this.txtBPublicKey.Location = new System.Drawing.Point(32, 203);
            this.txtBPublicKey.Name = "txtBPublicKey";
            this.txtBPublicKey.Size = new System.Drawing.Size(100, 22);
            this.txtBPublicKey.TabIndex = 3;
            // 
            // txtBPrivateKey
            // 
            this.txtBPrivateKey.Location = new System.Drawing.Point(32, 267);
            this.txtBPrivateKey.Name = "txtBPrivateKey";
            this.txtBPrivateKey.Size = new System.Drawing.Size(100, 22);
            this.txtBPrivateKey.TabIndex = 4;
            // 
            // txtBIn
            // 
            this.txtBIn.Location = new System.Drawing.Point(305, 32);
            this.txtBIn.Name = "txtBIn";
            this.txtBIn.Size = new System.Drawing.Size(100, 22);
            this.txtBIn.TabIndex = 5;
            // 
            // numP
            // 
            this.numP.Location = new System.Drawing.Point(438, 167);
            this.numP.Name = "numP";
            this.numP.Size = new System.Drawing.Size(120, 22);
            this.numP.TabIndex = 6;
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(438, 215);
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(120, 22);
            this.numG.TabIndex = 7;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(438, 268);
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(120, 22);
            this.numX.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlGamalCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.numG);
            this.Controls.Add(this.numP);
            this.Controls.Add(this.txtBIn);
            this.Controls.Add(this.txtBPrivateKey);
            this.Controls.Add(this.txtBPublicKey);
            this.Controls.Add(this.txtBTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.rTxtBOut);
            this.Name = "AlGamalCipherForm";
            this.Text = "AlGamalCipher";
            this.Load += new System.EventHandler(this.AlGamalCipherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rTxtBOut;
        private System.Windows.Forms.TextBox lblTest;
        private System.Windows.Forms.TextBox txtBTest;
        private System.Windows.Forms.TextBox txtBPublicKey;
        private System.Windows.Forms.TextBox txtBPrivateKey;
        private System.Windows.Forms.TextBox txtBIn;
        private System.Windows.Forms.NumericUpDown numP;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.Button button1;
    }
}