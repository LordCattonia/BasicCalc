using System.Numerics;

namespace BasicCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int currentNumber = 0;

        char currentSign = ' ';

        int[] currentCalcs = new int[] { };

        int doMaths() 
        {
            if (currentCalcs.Length > 0)
            {
                if (currentSign == '/')
                {
                    return currentCalcs[currentCalcs.Length - 1] / currentNumber;
                }
                else if (currentSign == 'x') 
                {
                    return currentCalcs[currentCalcs.Length - 1] * currentNumber;
                }
                else if (currentSign == '+')
                {
                    return currentCalcs[currentCalcs.Length - 1] + currentNumber;
                }
                else if (currentSign == '-')
                {
                    return currentCalcs[currentCalcs.Length - 1] - currentNumber;
                }
                else if (currentSign == '%')
                {
                    return (currentNumber / 100) * currentCalcs[currentCalcs.Length - 1];
                }
                else
                {
                    throw new Exception("Your coding sucks");
                }
            }
        }
        // Ignore :/
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Clear Button
        private void button1_Click(object sender, EventArgs e)
        {

        }
        // Negative Switch
        private void button2_Click(object sender, EventArgs e)
        {

        }



        // Operators
            // Percent
            private void button3_Click(object sender, EventArgs e)
            {

            }
            // Addition
            private void button4_Click(object sender, EventArgs e)
            {

            }     
            // Subtraction
            private void button8_Click(object sender, EventArgs e)
            {

            }
            // Multiplication
            private void button12_Click(object sender, EventArgs e)
            {

            }
            // Division
            private void button16_Click(object sender, EventArgs e)
            {
    
            }
            // Equals
            private void button19_Click(object sender, EventArgs e)
            {

            }




        // Numbers
            // Zero
            private void button17_Click(object sender, EventArgs e)
            {

            }           
            // One
            private void button13_Click(object sender, EventArgs e)
            {

            }
            // Two
            private void button14_Click(object sender, EventArgs e)
            {

            }
            // Three
            private void button15_Click(object sender, EventArgs e)
            {

            }            
            // Four
            private void button9_Click(object sender, EventArgs e)
            {

            }
            // Five
            private void button10_Click(object sender, EventArgs e)
            {

            }
            // Six
            private void button11_Click(object sender, EventArgs e)
            {

            }
            // Seven
            private void button5_Click(object sender, EventArgs e)
            {

            }
            // Eight
            private void button6_Click(object sender, EventArgs e)
            {

            }
            // Nine
            private void button7_Click(object sender, EventArgs e)
            {

            }
            // Decimal
            private void button18_Click(object sender, EventArgs e)
            {

            }


    }
}