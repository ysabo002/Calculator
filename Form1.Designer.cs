
using System;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnsubstract = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnGoToCero = new System.Windows.Forms.Button();
            this.btnRightParenthesis = new System.Windows.Forms.Button();
            this.btnLeftParenthesis = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(113, 556);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(100, 75);
            this.btnNum0.TabIndex = 1;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(213, 556);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(100, 75);
            this.btnDecimal.TabIndex = 2;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.ForeColor = System.Drawing.Color.Crimson;
            this.btnEqual.Location = new System.Drawing.Point(314, 478);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(100, 153);
            this.btnEqual.TabIndex = 3;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSum.Location = new System.Drawing.Point(314, 402);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(100, 75);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btn_OperatorClick);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(213, 479);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(100, 75);
            this.btnNum3.TabIndex = 6;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(113, 479);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(100, 75);
            this.btnNum2.TabIndex = 5;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(12, 479);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(100, 75);
            this.btnNum1.TabIndex = 4;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnsubstract
            // 
            this.btnsubstract.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsubstract.Location = new System.Drawing.Point(314, 325);
            this.btnsubstract.Name = "btnsubstract";
            this.btnsubstract.Size = new System.Drawing.Size(100, 75);
            this.btnsubstract.TabIndex = 11;
            this.btnsubstract.Text = "-";
            this.btnsubstract.UseVisualStyleBackColor = true;
            this.btnsubstract.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(213, 402);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(100, 75);
            this.btnNum6.TabIndex = 10;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(113, 402);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(100, 75);
            this.btnNum5.TabIndex = 9;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(12, 402);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(100, 75);
            this.btnNum4.TabIndex = 8;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMult.Location = new System.Drawing.Point(314, 249);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(100, 75);
            this.btnMult.TabIndex = 15;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(213, 325);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(100, 75);
            this.btnNum9.TabIndex = 14;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(113, 325);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(100, 75);
            this.btnNum8.TabIndex = 13;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(12, 325);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(100, 75);
            this.btnNum7.TabIndex = 12;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(213, 249);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(100, 75);
            this.btnDiv.TabIndex = 19;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGoToCero
            // 
            this.btnGoToCero.Location = new System.Drawing.Point(12, 556);
            this.btnGoToCero.Name = "btnGoToCero";
            this.btnGoToCero.Size = new System.Drawing.Size(100, 75);
            this.btnGoToCero.TabIndex = 18;
            this.btnGoToCero.Text = "C";
            this.btnGoToCero.UseVisualStyleBackColor = true;
            this.btnGoToCero.Click += new System.EventHandler(this.btnGoToCero_Click);
            // 
            // btnRightParenthesis
            // 
            this.btnRightParenthesis.Location = new System.Drawing.Point(113, 249);
            this.btnRightParenthesis.Name = "btnRightParenthesis";
            this.btnRightParenthesis.Size = new System.Drawing.Size(100, 75);
            this.btnRightParenthesis.TabIndex = 17;
            this.btnRightParenthesis.Text = ")";
            this.btnRightParenthesis.UseVisualStyleBackColor = true;
            this.btnRightParenthesis.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnLeftParenthesis
            // 
            this.btnLeftParenthesis.Location = new System.Drawing.Point(12, 249);
            this.btnLeftParenthesis.Name = "btnLeftParenthesis";
            this.btnLeftParenthesis.Size = new System.Drawing.Size(100, 75);
            this.btnLeftParenthesis.TabIndex = 16;
            this.btnLeftParenthesis.Text = "(";
            this.btnLeftParenthesis.UseVisualStyleBackColor = true;
            this.btnLeftParenthesis.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(325, 195);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 25);
            this.lblOutput.TabIndex = 20;
            this.lblOutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.AllowDrop = true;
            this.txtOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOutput.Location = new System.Drawing.Point(13, 10);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(400, 154);
            this.txtOutput.TabIndex = 21;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(314, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 75);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(213, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 75);
            this.button1.TabIndex = 24;
            this.button1.Text = "^2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnPowOf2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 642);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnGoToCero);
            this.Controls.Add(this.btnRightParenthesis);
            this.Controls.Add(this.btnLeftParenthesis);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnsubstract);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNum0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnsubstract;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnGoToCero;
        private System.Windows.Forms.Button btnRightParenthesis;
        private System.Windows.Forms.Button btnLeftParenthesis;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

