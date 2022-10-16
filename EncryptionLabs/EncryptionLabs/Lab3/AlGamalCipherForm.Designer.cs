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
            this.yValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generate_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelE = new System.Windows.Forms.Label();
            this.gValue = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.pValue = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(826, 81);
            this.yValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(243, 18);
            this.yValue.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(476, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 34);
            this.label2.TabIndex = 62;
            this.label2.Text = "Приватный ключ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(476, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "Открытый ключ";
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(520, 158);
            this.xValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(169, 18);
            this.xValue.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(800, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "y=";
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(36, 242);
            this.generate_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(233, 55);
            this.generate_button.TabIndex = 58;
            this.generate_button.Text = "Выполнить шифрование/расшифровку";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 399);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 39);
            this.button3.TabIndex = 57;
            this.button3.Text = "<<Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelE
            // 
            this.labelE.Location = new System.Drawing.Point(481, 158);
            this.labelE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(55, 18);
            this.labelE.TabIndex = 56;
            this.labelE.Text = "x=";
            // 
            // gValue
            // 
            this.gValue.Location = new System.Drawing.Point(542, 81);
            this.gValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gValue.Name = "gValue";
            this.gValue.Size = new System.Drawing.Size(169, 18);
            this.gValue.TabIndex = 55;
            // 
            // labelQ
            // 
            this.labelQ.Location = new System.Drawing.Point(479, 81);
            this.labelQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(55, 18);
            this.labelQ.TabIndex = 54;
            this.labelQ.Text = "g=";
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(96, 81);
            this.pValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pValue.Name = "pValue";
            this.pValue.Size = new System.Drawing.Size(169, 18);
            this.pValue.TabIndex = 53;
            // 
            // labelP
            // 
            this.labelP.Location = new System.Drawing.Point(33, 81);
            this.labelP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(55, 18);
            this.labelP.TabIndex = 52;
            this.labelP.Text = "p=";
            // 
            // AlGamalCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 458);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.gValue);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.labelP);
            this.Name = "AlGamalCipherForm";
            this.Text = "AlGamalCipher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label yValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label gValue;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label pValue;
        private System.Windows.Forms.Label labelP;
    }
}