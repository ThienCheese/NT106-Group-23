namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double first;
        string Operation;
        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "1";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "2";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
            first = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "+";
       
        }

        private void button19_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "-";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "/";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }
        private void button15_Click(object sender, EventArgs e)
        {
                richTextBox1.Text = richTextBox1.Text + ".";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double second;
            double result;

            second = Convert.ToDouble(richTextBox1.Text);

            if (Operation == "+")
            {
                result = (first + second);
                richTextBox1.Text = Convert.ToString(result);
                first = result;
            }
            if (Operation == "-")
            {
                result = (first - second);
                richTextBox1.Text = Convert.ToString(result);
                first = result;
            }
            if (Operation == "*")
            {
                result = (first * second);
                richTextBox1.Text = Convert.ToString(result);
                first = result;
            }
            if (Operation == "/")
            {
                if (second == 0)
                {
                    richTextBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    result = (first / second);
                    richTextBox1.Text = Convert.ToString(result);
                    first = result;
                }
            }

        }
        private void equalButtonrep()
        {
            double second;
            double result;

            second = Convert.ToDouble(richTextBox1.Text);

            if (Operation == "+")
            {
                result = (first + second);
                richTextBox1.Text = Convert.ToString(result);
                first = result;
            }
            if (Operation == "-")
            {
                result = (first - second);
                richTextBox1.Text = Convert.ToString(result);
                first = result;
            }
            if (Operation == "*")
            {
                result = (first * second);
                richTextBox1.Text = Convert.ToString(result);
                first = result;
            }
            if (Operation == "/")
            {
                if (second == 0)
                {
                    richTextBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    result = (first / second);
                    richTextBox1.Text = Convert.ToString(result);
                    first = result;
                }
            }
        }
    }
}
