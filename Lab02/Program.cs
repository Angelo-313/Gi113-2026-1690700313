/*
 * Student ID :1690700313
 * Name       :Nattawut Suwannit
 * Section    :129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */



namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"level: {level}");
            Console.WriteLine($"HP {currentHp} / {maxHp}");

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"Hp Percent: 47%");
        }
    }
}
