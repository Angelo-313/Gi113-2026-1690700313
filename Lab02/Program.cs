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
            Console.WriteLine();
            //Part B
            Console.WriteLine("######  BOSS SPAWN!! ######");
            string bossName1 = "Kingkairos";
            char rank1 = 'S';
            int level1 = 80;
            int maxHp1 = 120;
            int Speed1= 50;
            float attackPower1 = 25.00f;
            double critMultiplier1 = 1.34;
            bool Boss1 = true;

            Console.WriteLine($"Name: {bossName1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"HP: {maxHp1}");
            Console.WriteLine($"Attack Power: {attackPower1}");
            Console.WriteLine($"Speed: {Speed1}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier1}");
            Console.WriteLine($"Is Boss: {Boss1}");
            Console.WriteLine();

            Console.WriteLine("######  MINI BOSS SPAWN!! ######");
            string bossName2 = "Shadow Wolf";
            char rank2 = 'A';
            int level2 = 50;
            int maxHp2 = 80;
            int Speed2 = 40;
            float attackPower2 = 20.00f;
            double critMultiplier2 = 1.30;
            bool Boss2 = true;

            Console.WriteLine($"Name: {bossName2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"HP: {maxHp2}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Speed: {Speed2}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier2}");
            Console.WriteLine($"Is Mini Boss: {Boss2}");
            Console.WriteLine();

            Console.WriteLine("######  MONSTER SPAWN!! ######");
            string MonsterName3 = "Gimjaw";
            char rank3 = 'B';
            int level3 = 30;
            int maxHp3 = 50;
            int Speed3 = 55;
            float attackPower3 = 12.00f;
            double critMultiplier3 = 1.20;
            bool Monster3 = true;

            Console.WriteLine($"Name: {MonsterName3}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"HP: {maxHp3}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Speed: {Speed3}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier3}");
            Console.WriteLine($"Is Monster: {Monster3}");
            Console.WriteLine();

            Console.WriteLine("######  MONSTER SPAWN!! ######");
            string MonsterName4 = "Vex";
            char rank4 = 'F';
            int level4 = 10;
            int maxHp4 = 25;
            int Speed4 = 15;
            float attackPower4 = 8.00f;
            double critMultiplier4 = 1.11;
            bool Monster4 = true;

            Console.WriteLine($"Name: {MonsterName4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"HP: {maxHp4}");
            Console.WriteLine($"Attack Power: {attackPower4}");
            Console.WriteLine($"Speed: {Speed4}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier4}");
            Console.WriteLine($"Is Monster: {Monster4}");
            Console.WriteLine();

        }
    }
}
