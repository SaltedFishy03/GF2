namespace FB_opg_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("skriv hvor mange rækker du vil have: ");

            int rows = Convert.ToInt32(Console.ReadLine());

            bool printNumber = true;

            int numbersInRow = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int b = 0; b < numbersInRow; b++)
                {
                    Console.Write(Convert.ToInt32(printNumber));
                    printNumber = (printNumber);
                }
                Console.WriteLine();
                numbersInRow++;
            }

        }
    }
}