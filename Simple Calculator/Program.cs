namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //check valid input
        // divide by zero thriw
        // select operation

            InputHandler inputHandler = new InputHandler();
            double numberOne;
            double numberTwo;
            double result = 0;
            char choiceOperation;

            do
            {
                numberOne = inputHandler.GetValidNumber("Enter your first number: ");
                numberTwo = inputHandler.GetValidNumber("Enter your second number: ");
                choiceOperation = inputHandler.GetValidOperation();

                switch (choiceOperation)
                {
                    case '+':
                        Calculator calculator = new Calculator(new Addition());
                        result = calculator.Calculate(numberOne, numberTwo);
                        Console.WriteLine($"Addition Result = {result}");
                        break;
                    case '-':
                        Calculator calculator1 = new Calculator(new Subtraction());
                        result = calculator1.Calculate(numberOne, numberTwo);
                        Console.WriteLine($"Subtraction Result = {result}");
                        break;
                    case '*':
                        Calculator calculator2 = new Calculator(new Multiplication());
                        result = calculator2.Calculate(numberOne, numberTwo);
                        Console.WriteLine($"Multiplication Result = {result}");
                        break;
                    case '/':
                        if (numberTwo != 0)
                        {
                            Calculator calculator3 = new Calculator(new Division());
                            result = calculator3.Calculate(numberOne, numberTwo);
                            Console.WriteLine($"Division Result = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }

                Console.Write("Do you want to perform another calculation? (y/n): ");
                choiceOperation = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (choiceOperation == 'y' || choiceOperation == 'Y');
            Console.WriteLine("Calculator turned off. Goodbye!");
            Console.ReadKey();

        }
    }
}
