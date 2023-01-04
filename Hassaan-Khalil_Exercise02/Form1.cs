using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hassaan_Khalil_Exercise02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(factorialBox.Text);

            factorialOutput.Text = "Calculating....";

            Task<BigInteger> fibonacciTask = Task.Run(() => Fibonacci(number));

            await fibonacciTask;

            factorialOutput.Text = fibonacciTask.Result.ToString();

        }
        public BigInteger Fibonacci(BigInteger n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loan = int.Parse(loanAmount.Text);
            int interest = int.Parse(interestRate.Text);
            int dura = int.Parse(duration.Text);
            loanOutput.Text = (loan*interest*dura).ToString();

        }
    }
}
