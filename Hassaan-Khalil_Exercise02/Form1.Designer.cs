namespace Hassaan_Khalil_Exercise02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loanAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.interestRate = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.factorialBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loanOutput = new System.Windows.Forms.Label();
            this.factorialOutput = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.factorialOutput);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.factorialBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Asynchronously";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loanOutput);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.duration);
            this.groupBox2.Controls.Add(this.interestRate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.loanAmount);
            this.groupBox2.Location = new System.Drawing.Point(269, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Loan Calculator";
            // 
            // loanAmount
            // 
            this.loanAmount.Location = new System.Drawing.Point(97, 46);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Size = new System.Drawing.Size(131, 20);
            this.loanAmount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Get Factorial of: ";
            // 
            // interestRate
            // 
            this.interestRate.Location = new System.Drawing.Point(97, 91);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(131, 20);
            this.interestRate.TabIndex = 4;
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(97, 134);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(131, 20);
            this.duration.TabIndex = 5;
            // 
            // factorialBox
            // 
            this.factorialBox.Location = new System.Drawing.Point(111, 50);
            this.factorialBox.Name = "factorialBox";
            this.factorialBox.Size = new System.Drawing.Size(114, 20);
            this.factorialBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate Interest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Calculate Factorial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loanOutput
            // 
            this.loanOutput.AutoSize = true;
            this.loanOutput.Location = new System.Drawing.Point(24, 190);
            this.loanOutput.Name = "loanOutput";
            this.loanOutput.Size = new System.Drawing.Size(0, 13);
            this.loanOutput.TabIndex = 7;
            // 
            // factorialOutput
            // 
            this.factorialOutput.AutoSize = true;
            this.factorialOutput.Location = new System.Drawing.Point(20, 186);
            this.factorialOutput.Name = "factorialOutput";
            this.factorialOutput.Size = new System.Drawing.Size(0, 13);
            this.factorialOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Asynchronous Programming";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox factorialBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.TextBox interestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loanAmount;
        private System.Windows.Forms.Label factorialOutput;
        private System.Windows.Forms.Label loanOutput;
    }
}

