namespace Assignment8ex2
{
    public class MathSolutions
    {

        public delegate void MyDelegate(double a, double b);

       //public static double a = 0;
       // public static double b = 0;

       /* public double GetSum(double x, double y)
        {
            return x + y;
        }
        

        /*
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
       */
        public static void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            MyDelegate d1 = new MyDelegate(MathSolutions.GetSmaller);
            d1(5, 4);

         
            // create a class object
            /*MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
           // Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");
            //Console.WriteLine($" {num1} + {num2} = {answer.GetProduct(num1, num2)}");
            answer.GetSmaller(num1, num2);
            */

            Action<double, double> calcResult = delegate (double x, double y) { Console.WriteLine($"The result is {x + y}"); };
            calcResult(5, 5);

            Func<double, double, double> calcResult2 = (a, b) => (a * b);
             Console.WriteLine($"The product is  {calcResult2(10.00, 10.00)}"); 




        }
    }
}