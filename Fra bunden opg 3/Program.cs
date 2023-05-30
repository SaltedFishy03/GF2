namespace Fra_bunden_opg_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            string test = Convert.ToString(Console.ReadLine());

            Console.Write("skriv et tal: ");
            double uff = Convert.ToDouble(Console.ReadLine());

            Console.Write("skriv et nyt tal: ");
            double stuff = Convert.ToDouble(Console.ReadLine());

            double plus = uff + stuff;

            double minus = uff - stuff;

            double gange = uff * stuff;

            double division = uff / stuff;

            Console.WriteLine("her er dine resultalter i plus, minus, ganget og divideret");

            Console.WriteLine(plus);
            Console.WriteLine(minus);
            Console.WriteLine(gange);
            Console.WriteLine($"her er dit tal divideret: {division}");
        }
    }
}