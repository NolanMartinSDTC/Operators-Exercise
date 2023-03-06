namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            int a = 17;
            int b = 4;

            //Console.WriteLine($"Addition: {a+b}");

            //Console.WriteLine($"Subtraction: {a-b}");

            //Console.WriteLine($"Multiplication: {a*b}");
            
            int quotient = a / b;
            int remainder = a % b;

            //Console.WriteLine($"Division: {quotient}");
            //Console.WriteLine($"Modulus: {remainder}");

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");


            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse((Console.ReadLine()));
            double AreaOfCircle = Math.PI*Math.Pow(radius,2);
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle}");
        }
    }
}
