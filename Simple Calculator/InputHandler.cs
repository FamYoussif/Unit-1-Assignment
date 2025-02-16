namespace Simple_Calculator
{
    public class InputHandler
    {
        public double GetValidNumber(string prompt)
        {
            double number;
            bool isValidInput;

            do
            {
                Console.Write(prompt);
                isValidInput = double.TryParse(Console.ReadLine(), out number);
                if (!isValidInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValidInput);

            return number;
        }

        public char GetValidOperation()
        {
            char operation;
            bool isValidOperation;

            do
            {
                Console.Write("Choose an operation (+, -, *, /): ");
                operation = Convert.ToChar(Console.ReadLine());
                isValidOperation = operation == '+' || operation == '-' || operation == '*' || operation == '/';
                if (!isValidOperation)
                {
                    Console.WriteLine("Invalid operation. Please choose a valid operation.");
                }
            } while (!isValidOperation);

            return operation;
        }
    }
}