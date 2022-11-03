namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            // accept two ints and find the max and display
            int fno;
            int sno;
            int max;
            Console.Write("Enter First Number: ");
            fno = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            sno = int.Parse(Console.ReadLine());

            // find the max
            if (fno > sno)
            {
                max = fno;
            }
            else
            {
                max = sno;
            }



            // display the result
            Console.WriteLine($"The maximum of {fno} and {sno} is {max}");
            Console.WriteLine("The maxumum is " + max);
            Console.WriteLine("The maximum of {0} and {1} is {2}", fno, sno, max);

        }
    }
}