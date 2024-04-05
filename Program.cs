namespace Assignment8ex2
{
    class Program
    {

        public class MathSolutions
        {
            public delegate double Product(double a, double b);
            public static double GetSum(double x, double y)
            {
                return x + y;
            }
            public static double GetProduct(double a, double b)
            {
                return a * b;
            }
            public static void GetSmaller(double a, double b)
            {
                if (a < b)
                    Console.WriteLine($"{a} is smaller than {b}");
                else if (b < a)
                    Console.WriteLine($"{b} is smaller than {a}");
                else
                    Console.WriteLine($"{b} is equal to {a}");
            }
            static void Main(string[] args)
            {
                // create a class object
                MathSolutions answer = new MathSolutions();
                Random r = new Random();
                double num1 = Math.Round(r.NextDouble() * 100);
                double num2 = Math.Round(r.NextDouble() * 100);
                Console.WriteLine($"Num1: {num1}");
                Console.WriteLine($"Num1: {num2}");
                Console.WriteLine();

                Func<double, double, double> sum = GetSum;
                Console.WriteLine($"Sum: {sum(num1, num2)}");
                Console.WriteLine();

                Product mult = GetProduct;
                Console.WriteLine($"Product: {mult(num1, num2)}");
                Console.WriteLine();

                Action<double, double> small = GetSmaller;
                small(num1, num2);
            }
        }
    }
}