namespace Simple_Calculator
{
    public class Division : IOperation 
    {
        public double Execute(double a, double b)
        {

            return b == 0 ? throw new DivideByZeroException("Division by zero not allowed"): a / b;
        }
    }
}
