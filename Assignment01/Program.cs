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

            Console.WriteLine($"===========================================");
            Console.WriteLine($"   #{GameTitle}#");
            Console.WriteLine($"===========================================");
            Console.WriteLine($"Name          :{characterName}");
            Console.WriteLine($"Rank          :{characterRank}");
            Console.WriteLine($"Level         :{characterLevel}");
            Console.WriteLine($"MagicPower    :{magicPower}");
            Console.WriteLine($"Health Point  :{healthPoint}");
            Console.WriteLine($"Royal Guard   :{isRoyalGuard}");
            Console.WriteLine();

            double levelAsDouble = characterLevel;

            Console.WriteLine($"Level as double (implicit conversion: {levelAsDouble})");
            Console.WriteLine();

            int healthCast = (int)healthPoint;
            int healthConvert = Convert.ToInt32(healthPoint);

            Console.WriteLine($"Health Point with explicit cast   : {healthCast}");
            Console.WriteLine($"Health Point with Convert         : {healthConvert}");


        }
    }
}
