namespace FB_opg_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo esc;
            do
            {
                Console.Clear();
                Console.Write("tal 1: ");
                double tal1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("tal2: ");
                double tal2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("her er dit tal2: " + tal2);
                Console.WriteLine("her er dit tal1: " + tal1);

                Console.WriteLine("tryk på esc for at afslutte");

                esc = Console.ReadKey();
            } while (esc.Key != ConsoleKey.Escape);
        }
    }
}