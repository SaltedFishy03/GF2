namespace Fra_Bunden_opg
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            double sumClaus = 0;
            int i = 0;
            string numbersClaus = "";

            while (true)
            {

                Console.Write("Skriv et tal: ");
                string inputClaus = Console.ReadLine();

                if (inputClaus == "#")
                {
                    break;
                }

                sumClaus += Convert.ToDouble(inputClaus);
                i++;

                if (numbersClaus == "")
                {
                    numbersClaus = inputClaus;
                }
                else
                {
                    numbersClaus = numbersClaus + " " + inputClaus;
                }
            }

            Console.WriteLine("Gennemsnitet af " + numbersClaus + " er: " + (sumClaus / i));
        }
    }
}