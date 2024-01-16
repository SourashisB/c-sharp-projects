namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;        // String storing user input
        string operand1 = string.Empty;     // String storing first operand
        string operand2 = string.Empty;     // String storing second operand
        char operation;                     // Char for operation
        double result = 0.0;                // Calculated result
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == ".") // Handle decimal point
            {
                if (!input.Contains("."))
                {
                    if (input == string.Empty)
                    {
                        input += "0.";
                    }
                    else
                    {
                        input += ".";
                    }
                }
            }
            else // Handle numbers
            {
                input += button.Text;
            }
            displayBox.Text = input;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonEqual.PerformClick();
                operation = button.Text[0];
                operand1 = result.ToString();
                input = string.Empty;
            }
            else
            {
                operation = button.Text[0];
                operand1 = input;
                input = string.Empty;
            }
        }

        private void buttonEqualsClick(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.displayBox.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;

            try {
                switch (operation)
                {

                    case '+':
                        result = num1 + num2;
                        displayBox.Text = result.ToString();
                        break;
                    case '-':
                        result = num1 - num2;
                        displayBox.Text = result.ToString();
                        break;
                    case '*':
                        result = num1 * num2;
                        displayBox.Text = result.ToString();
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            displayBox.Text = result.ToString();
                        }
                        else
                        {
                            displayBox.Text = "DIV/Zero!";
                        }
                        break;
                    default:
                        break;
                }

            } catch (Exception ex) 
                {
                HandleCalculationError(ex);
                }

    }

        private void HandleCalculationError(Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.ToString());

            MessageBox.Show("An error occurred during the calculation. Please check the input and try again.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        
        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "0")
            {
                
            }
        }

        private void buttonClearClick(object sender, EventArgs e)
        {
            this.displayBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
    }
}
