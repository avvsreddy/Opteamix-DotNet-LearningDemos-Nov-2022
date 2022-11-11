namespace MySimpleCalculatorConsoleApp
{
    internal class Program //PL
    {
        static void Main(string[] args) // SRP - PL
        {
            // Accept two ints and find the sum then display
            int a;
            int b;
            int sum;

            Console.Write("Enter First Number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            b = int.Parse(Console.ReadLine());

            //sum = a + b;
            sum = SimpleCalculatorLibrary.Calculator.FindSum(a, b);

            Console.WriteLine($"The sum of {a} and {b} is {sum}");
        }


    }


}