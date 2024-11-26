using System;

namespace upg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange hur lång låten är i minuter: ");
            int minuter = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange hur lång låten är i sekunder");
            int sekunder = int.Parse(Console.ReadLine());

            int totalTidISekunder = minuter * 60 + sekunder;

            int MinstaTid = 2 * 60 + 45;
            int HögstaTid = 4 * 60 + 20;

            if (totalTidISekunder >= MinstaTid && totalTidISekunder <= HögstaTid)
            {
                Console.WriteLine("Låten får spelas på radiostationen");
            }
            else
            {
                Console.WriteLine("Låten får inte spelas på radiostationen");
            }
        }
    }
}