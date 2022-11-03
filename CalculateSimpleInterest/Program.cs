namespace CalculateSimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Interest Calculator");
            Console.WriteLine("============================");
            Console.Write("Enter Principle Amount: ");
            int principleAmount = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate of Interest: ");
            int interestRate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time/Duration: ");
            int time = int.Parse(Console.ReadLine());

            // calculate the simple interest
            // 
            float simpleInterest = principleAmount * time * interestRate / 100;
            Console.WriteLine($"The Simple Interest is {simpleInterest}");
        }
    }
}