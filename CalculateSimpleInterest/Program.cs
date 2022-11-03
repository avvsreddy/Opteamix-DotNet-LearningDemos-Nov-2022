namespace CalculateSimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Interest Calculator");
            Console.WriteLine("============================");
            Console.Write("Enter Principle Amount: ");
            double principleAmount = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate of Interest: ");
            double interestRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time/Duration: ");
            double time = double.Parse(Console.ReadLine());

            // calculate the simple interest
            // 
            double simpleInterest = principleAmount * time * interestRate / 100;
            Console.WriteLine($"The Simple Interest is {simpleInterest}");
        }
    }
}