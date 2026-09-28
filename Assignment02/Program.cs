/*
Student ID :1690700313
Name       :Nattawut Suwannit
Section    :129A
No.        :18
Course     :GI113 Computer Programming (GI)
*/

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Name = "DIAC";
            const double smeltRate = 0.1300;
            const double SalvageRate = 0.3300;
            const double MaxBatch = 500.00;
            var inGot = 0.0;
            var ore = 0.0;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("######################################");
            Console.WriteLine("##----------------------------------##");
            Console.Write("##---#   ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Welcome to the Forge   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("#---##\n");
            Console.WriteLine("##----------------------------------##");
            Console.WriteLine("######################################");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Name} ore Smelting 0.13 / Salvage 0.33 ");
            Console.WriteLine("Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("Key 'B' for Breakdown (Ingot -> Ore)");
            Console.Write("Choice : ");
            bool ischoise = char.TryParse(Console.ReadLine(), out char choice);

            if (!ischoise || (choice != 'S' && choice != 'B' && choice != 's' && choice != 'b'))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter 'S/s' for Smelt or 'B/b' for Breakdown.");
            }
            else if (choice == 'S' || choice == 's')
            {
                Console.Write("How much ore do you want to Smelt (1-500): ");
                bool isOreInput = double.TryParse(Console.ReadLine(), out ore);
                if (!isOreInput)
                {
                    Console.WriteLine("Please select a quantity (1-500).");
                }
                else if (ore <= 500 && ore > 0)
                {
                    inGot = ore * smeltRate;
                    Console.WriteLine($"{Name} {ore:f2} ore = {Name} {inGot:f2} ingot ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please select a quantity (1-500).");
                }
            }
            else if (choice == 'B' || choice == 'b')
            {
                Console.Write("How much ingot do you want to Breakdown (1-500): ");
                bool isIngotInput = double.TryParse(Console.ReadLine(), out inGot);
                if (!isIngotInput)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please select a quantity (1-500).");
                }
                else if (inGot <= 500 && inGot > 0)
                {
                    ore = inGot / SalvageRate;
                    Console.WriteLine($"{Name} {inGot:f2} ingot = {Name} {ore:f2} ore ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please select a quantity(1-500).");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("error : (s , b , B ,S) ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
