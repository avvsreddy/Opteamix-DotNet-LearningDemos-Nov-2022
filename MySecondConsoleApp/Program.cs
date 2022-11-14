namespace MySecondConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 345, 53, 2, 45, 64, 6, 7, 45, 34, 57, 53 };

            int max = 0;
            foreach (int n in numbers)
            {
                if (n >= max)
                    max = n;
            }

            Console.WriteLine(max);
        }
    }
}