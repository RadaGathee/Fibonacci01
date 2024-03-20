using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jango01
{
    public partial class Bado : Form
    {
        public Bado()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            input1.Text = string.Empty;
            input2.Text = string.Empty; 
        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = Convert.ToInt32(input1.Text);
                var num2 = Convert.ToInt32(input2.Text);

                int sum = num1 + num2;
                MessageBox.Show("The Sum is: "+ sum);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input! Enter digits!");
            }
        
        
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = Convert.ToInt32(input1.Text);
                var num2 = Convert.ToInt32(input2.Text);

                int multi = num1 * num2;
                MessageBox.Show("The Product is: " + multi);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input! Enter digits!");
            }
        }

        private void FiboBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var start = Convert.ToInt32(input1.Text);
                var count = Convert.ToInt32(input2.Text);
                string fibonacciResult = CalculateFibonacci(start, count);

                MessageBox.Show($"Fibonacci Sequence starting from {start} and having {count} numbers: \n\n {fibonacciResult}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input! Enter digits!");
            }
        }

        private string CalculateFibonacci(int start, int count)
        {
            if (count < 2)
            {
                return "Note: To best see the Fibonacci Sequence progression, the Value 2 should be greater than or equal to 2.";
            }
            try
            {
                int[] fibonacciResult = new int[count];
                fibonacciResult[0] = start;
                fibonacciResult[1] = start;

                //F(n) = F(n-2) + F(n-1) for  n>=2 here n replaced by i

                for (int i = 2; i < count; i++) 
                {
                    fibonacciResult[i] = fibonacciResult[i - 1] + fibonacciResult[i - 2];
                }
                return string.Join(", ", fibonacciResult);

            }
            catch (FormatException)
            {
                return "Invalid Input! Enter digits.";
            }
        }


    }
}
