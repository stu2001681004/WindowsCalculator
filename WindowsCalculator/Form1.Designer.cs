namespace WindowsCalculator
{
    partial class Form1
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btnM = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPLUS = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPersentage = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnOneOverX = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAddSymbol = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDisplay.Location = new System.Drawing.Point(32, 12);
            this.tbDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(428, 30);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.Text = "0";
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(32, 46);
            this.btnM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(59, 31);
            this.btnM.TabIndex = 1;
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Location = new System.Drawing.Point(110, 46);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(124, 31);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "BACKSPACE";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(260, 46);
            this.btnCE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(86, 31);
            this.btnCE.TabIndex = 3;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(374, 46);
            this.btnC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(86, 31);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(32, 91);
            this.btnMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(59, 31);
            this.btnMC.TabIndex = 5;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(32, 138);
            this.btnMR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(59, 30);
            this.btnMR.TabIndex = 6;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(32, 184);
            this.btnMS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(59, 30);
            this.btnMS.TabIndex = 7;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMPLUS
            // 
            this.btnMPLUS.Location = new System.Drawing.Point(32, 226);
            this.btnMPLUS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMPLUS.Name = "btnMPLUS";
            this.btnMPLUS.Size = new System.Drawing.Size(59, 32);
            this.btnMPLUS.TabIndex = 8;
            this.btnMPLUS.Text = "M+";
            this.btnMPLUS.UseVisualStyleBackColor = true;
            this.btnMPLUS.Click += new System.EventHandler(this.btnMPLUS_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(110, 91);
            this.btn7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(58, 31);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(178, 91);
            this.btn8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 31);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(251, 91);
            this.btn9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(59, 31);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(326, 91);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(62, 31);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(404, 91);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(56, 31);
            this.btnSqrt.TabIndex = 13;
            this.btnSqrt.Text = "SQRT";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(110, 138);
            this.btn4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 30);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(178, 138);
            this.btn5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 30);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(251, 138);
            this.btn6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(59, 30);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(326, 138);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(62, 30);
            this.btnPlus.TabIndex = 17;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnPersentage
            // 
            this.btnPersentage.Location = new System.Drawing.Point(404, 138);
            this.btnPersentage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPersentage.Name = "btnPersentage";
            this.btnPersentage.Size = new System.Drawing.Size(56, 30);
            this.btnPersentage.TabIndex = 18;
            this.btnPersentage.Text = "%";
            this.btnPersentage.UseVisualStyleBackColor = true;
            this.btnPersentage.Click += new System.EventHandler(this.btnPersentage_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(110, 184);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 30);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(178, 184);
            this.btn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 30);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(251, 184);
            this.btn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(59, 30);
            this.btn3.TabIndex = 21;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(326, 184);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(62, 30);
            this.btnMinus.TabIndex = 22;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnOneOverX
            // 
            this.btnOneOverX.Location = new System.Drawing.Point(404, 184);
            this.btnOneOverX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOneOverX.Name = "btnOneOverX";
            this.btnOneOverX.Size = new System.Drawing.Size(56, 30);
            this.btnOneOverX.TabIndex = 23;
            this.btnOneOverX.Text = "1/X";
            this.btnOneOverX.UseVisualStyleBackColor = true;
            this.btnOneOverX.Click += new System.EventHandler(this.btnOneOverX_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(178, 226);
            this.btn0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(58, 32);
            this.btn0.TabIndex = 24;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnAddSymbol
            // 
            this.btnAddSymbol.Location = new System.Drawing.Point(110, 226);
            this.btnAddSymbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSymbol.Name = "btnAddSymbol";
            this.btnAddSymbol.Size = new System.Drawing.Size(58, 32);
            this.btnAddSymbol.TabIndex = 25;
            this.btnAddSymbol.Text = "+/-";
            this.btnAddSymbol.UseVisualStyleBackColor = true;
            this.btnAddSymbol.Click += new System.EventHandler(this.btnAddSymbol_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(251, 226);
            this.btnDot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(59, 32);
            this.btnDot.TabIndex = 26;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(326, 226);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(62, 32);
            this.btnMultiply.TabIndex = 27;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(404, 226);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(56, 32);
            this.btnEqual.TabIndex = 28;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 274);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnAddSymbol);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnOneOverX);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnPersentage);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnMPLUS);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.tbDisplay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPLUS;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPersentage;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnOneOverX;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAddSymbol;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnEqual;
    }
}

