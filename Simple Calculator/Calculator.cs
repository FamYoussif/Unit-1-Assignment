namespace Simple_Calculator
{
    public class Calculator
    {
        public IOperation operation { get; set; }

        public Calculator(IOperation operation)
        {
            this.operation = operation;
        }

        public double Calculate(double a, double b)
        {
            return operation.Execute(a, b);
        }
    }
}
