using System;

namespace BasicCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double currentNumber = 0;

        bool isOverwriteable = false;

        char currentSign = ' ';

        double oldNumber = 0.2897452975;

        void addNumber(string input)
        {
            if (Clear_Button.Text == "AC") Clear_Button.Text = "C";
            if (label1.Text == "0"||isOverwriteable)
            {
                label1.Text = input;
                isOverwriteable = false;
            } else
            {
                label1.Text = label1.Text + input;
            }
            double.TryParse(label1.Text, out currentNumber);
        }

        double doMaths() 
        {
            if (oldNumber != 0.2897452975)
            {
                if (currentSign == '/')
                {
                    try
                    {
                        divide_button.BackColor = Color.White;
                        return oldNumber / currentNumber;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        label1.Text = "Too Long!";
                    }
                }
                else if (currentSign == 'x') 
                {
                    try
                    {
                        multiplication_button.BackColor = Color.White;
                        return oldNumber * currentNumber;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        label1.Text = "Too Long!";
                    }
                }
                else if (currentSign == '+')
                {
                    try
                    {
                        Addition_button.BackColor = Color.White;
                        return oldNumber + currentNumber;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        label1.Text = "Too Long!";
                    }
                }
                else if (currentSign == '-')
                {
                    try
                    {
                        subtraction_button.BackColor = Color.White;
                        return oldNumber - currentNumber;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        label1.Text = "Too Long!";
                    }
                }
                else if (currentSign == '%')
                {
                    try
                    {
                        Percent_button.BackColor = Color.White;
                        return currentNumber * oldNumber;
                    } 
                    catch(Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        label1.Text = "Too Long!";
                    }
                    
                }
                else
                {
                    throw new Exception("Your coding sucks");
                }
            }
            return currentNumber;
        }
        // Ignore :/
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Clear Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (Clear_Button.Text == "AC")
            {
                oldNumber= 0.2897452975;
                label1.Text = "0";
            } else
            {
                currentNumber= 0;
                label1.Text = "0";
                Clear_Button.Text= "AC";
            }
        }
        // Negative Switch
        private void button2_Click(object sender, EventArgs e)
        {
            currentNumber = -currentNumber;
            label1.Text = currentNumber.ToString();
        }



        // Operators
            // Percent
            private void button3_Click(object sender, EventArgs e)
            {
                label1.Text = (currentNumber/100).ToString();
                oldNumber = (currentNumber/100);
                currentSign = '%';
                Percent_button.BackColor = Color.LightGray;
                isOverwriteable = true;
            }
            // Addition
            private void button4_Click(object sender, EventArgs e)
            {
            if (oldNumber == 0.2897452975)
            {
                label1.Text = "0";
                oldNumber = currentNumber;
                currentNumber= 0;
                isOverwriteable = true;
                currentSign = '+';
                Addition_button.BackColor = Color.LightGray;
            } else
            {
                oldNumber = oldNumber + currentNumber;
                label1.Text = oldNumber.ToString();
                currentNumber = 0;
                isOverwriteable= true;
            }
            }     
            // Subtraction
            private void button8_Click(object sender, EventArgs e)
            {
                if (oldNumber == 0.2897452975)
                {
                    label1.Text = "0";
                    oldNumber = currentNumber;
                    currentNumber= 0;
                    isOverwriteable = true;
                    currentSign = '-';
                    subtraction_button.BackColor = Color.LightGray;
                }
                else
                {
                    oldNumber = oldNumber - currentNumber;
                    label1.Text = oldNumber.ToString();
                    currentNumber = 0;
                    isOverwriteable= true;
                }
            }
            // Multiplication
            private void button12_Click(object sender, EventArgs e)
            {
                if (oldNumber == 0.2897452975)
                {
                    label1.Text = "0";
                    oldNumber = currentNumber;
                    currentNumber= 0;
                    isOverwriteable = true;
                    currentSign = 'x';
                    multiplication_button.BackColor = Color.LightGray;
                }
                else
                {
                    oldNumber = oldNumber * currentNumber;
                    label1.Text = oldNumber.ToString();
                    currentNumber = 0;
                    isOverwriteable= true;
                }
            }
        // Division
            private void button16_Click(object sender, EventArgs e)
            {
                if (oldNumber == 0.2897452975)
                {
                    label1.Text = "0";
                    oldNumber = currentNumber;
                    currentNumber= 0;
                    isOverwriteable = true;
                    currentSign = '/';
                    divide_button.BackColor = Color.LightGray;
                }
                else
                {
                    oldNumber = oldNumber / currentNumber;
                    label1.Text = oldNumber.ToString();
                    currentNumber = 0;
                    isOverwriteable= true;
                }
            }
        // Equals
            private void button19_Click(object sender, EventArgs e)
                {
                    double result = doMaths();
                    oldNumber = result;
                    label1.Text = result.ToString();
                    currentNumber = oldNumber;
                    oldNumber = 0.2897452975;
                    isOverwriteable = true;
                }




        // Numbers
            // Zero
            private void button17_Click(object sender, EventArgs e)
            {
                addNumber("0");
            }           
            // One
            private void button13_Click(object sender, EventArgs e)
            {
                addNumber("1");
            }
            // Two
            private void button14_Click(object sender, EventArgs e)
            {
                addNumber("2");
            }
            // Three
            private void button15_Click(object sender, EventArgs e)
            {
                addNumber("3");
            }            
            // Four
            private void button9_Click(object sender, EventArgs e)
            {
                addNumber("4");
            }
            // Five
            private void button10_Click(object sender, EventArgs e)
            {
                addNumber("5");
            }
            // Six
            private void button11_Click(object sender, EventArgs e)
            {
                addNumber("6");
            }
            // Seven
            private void button5_Click(object sender, EventArgs e)
            {
                addNumber("7");
            }
            // Eight
            private void button6_Click(object sender, EventArgs e)
            {
                addNumber("8");

            }
            // Nine
            private void button7_Click(object sender, EventArgs e)
            {
                addNumber("9");
            }
            // Decimal
            private void button18_Click(object sender, EventArgs e)
            {
                addNumber(".");
            }


    }
}