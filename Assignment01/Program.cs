/*
 * Student ID :1690700313
 * Name       :Nattawut Suwannit
 * Section    :129A
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "FINAL FANTASY XV - Noctis Stat Card";

            var characterName = "Noctis Lucis Caelum";
            var characterRank = 'S';
            int characterLevel = 99;
            float magicPower = 82.5f;
            double healthPoint = 4576.75;
            bool isRoyalGuard = true;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" ______ __  __   __  ______  __                                             \r\n/\\  ___/\\ \\/\\ \"-.\\ \\/\\  __ \\/\\ \\                                            \r\n\\ \\  __\\ \\ \\ \\ \\-.  \\ \\  __ \\ \\ \\____                                       \r\n \\ \\_\\  \\ \\_\\ \\_\\\\\"\\_\\ \\_\\ \\_\\ \\_____\\                                      \r\n ______ ______/___\\/___/_______/______  ______  __  __      __  __  __   __ \r\n/\\  ___/\\  __ \\/\\ \"-.\\ \\/\\__  _/\\  __ \\/\\  ___\\/\\ \\_\\ \\    /\\_\\_\\_\\/\\ \\ / / \r\n\\ \\  __\\ \\  __ \\ \\ \\-.  \\/_/\\ \\\\ \\  __ \\ \\___  \\ \\____ \\   \\/_/\\_\\/\\ \\ \\'/  \r\n \\ \\_\\  \\ \\_\\ \\_\\ \\_\\\\\"\\_\\ \\ \\_\\\\ \\_\\ \\_\\/\\_____\\/\\_____\\    /\\_\\/\\_\\ \\__|  \r\n  \\/_/   \\/_/\\/_/\\/_/ \\/_/  \\/_/ \\/_/\\/_/\\/_____/\\/_____/    \\/_/\\/_/\\/_/   ");
            Console.WriteLine($"╔══════════════════════════════════════════════╗");
            Console.WriteLine($"║==============================================║");
            Console.WriteLine($"║   #{GameTitle}#      ║");
            Console.WriteLine($"║==============================================║");
            Console.WriteLine($"╠══════════════════════════════════════════════╣");
            Console.WriteLine($"║ Name          :{characterName}           ║");
            Console.WriteLine($"║ Rank          :{characterRank}                             ║");
            Console.WriteLine($"║ Level         :{characterLevel}                            ║");
            Console.WriteLine($"║ MagicPower    :{magicPower}                          ║");
            Console.WriteLine($"║ Health Point  :{healthPoint}                       ║");
            Console.WriteLine($"║ Royal Guard   :{isRoyalGuard}                          ║");
            Console.WriteLine($"║                                              ║");
            Console.WriteLine($"╠══════════════════════════════════════════════╣");
            Console.WriteLine($"║             CONVERSION RESULT                ║");
            Console.WriteLine($"╠══════════════════════════════════════════════╣");
            double levelAsDouble = characterLevel;

            Console.WriteLine($"║ Level as double (implicit conversion: {levelAsDouble})    ║");
            Console.WriteLine($"║                                              ║");

            int healthCast = (int)healthPoint;
            int healthConvert = Convert.ToInt32(healthPoint);

            Console.WriteLine($"║ Health Point with explicit cast   : {healthCast}     ║");
            Console.WriteLine($"║ Health Point with Convert         : {healthConvert}     ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");

        }
    }
}
