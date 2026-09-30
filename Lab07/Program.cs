/*
* Student ID :1690700313
* Name       :Nattawut Suwannit
* Section    :129A
* No.        :18
* Course     :GI113 Computer Programming (GI)
*/


namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // plan A
            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");

            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.Write("Choose (1-4): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;

            }

            int power = command switch
            {
                1 => 12,
                2 => 18,
                _ => 0
            };
            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");

            string rating = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");

            string monsterStatus = damage >= MonsterHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus}");

            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }
            Console.WriteLine();


            // plan B
            Console.ForegroundColor = ConsoleColor.Red;
            const int MonsterHp2 = 100;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense2);
            Console.WriteLine($"A Shadow wolf appears! HP {MonsterHp2}, DEF {monsterDefense2}");
            
            Console.WriteLine("##+===> COMBAT MENU <===+##");
            
            Console.WriteLine("1) Double Attack");
            Console.WriteLine("2) Venom Splasher");
            Console.WriteLine("3) Sonic Blow");
            Console.WriteLine("4) Steal");
            Console.WriteLine("5) Improve Dodge");
            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command2);

            switch (command2)
            {
                case 1:
                    Console.WriteLine("You use Double Attack!");
                    break;
                case 2:
                    Console.WriteLine("You cast a Venom Splasher!");
                    break;
                case 3:
                    Console.WriteLine("You use Sonic Blow!");
                    break;
                case 4:
                    Console.WriteLine("You use Steal!");
                    break;
                case 5:
                    Console.WriteLine("You improve your dodge!");
                    break;
                default:
                    Console.WriteLine("You hesitate. Invalid command!");
                    break;
            }

            int power2 = command2 switch
            {
                1 => 20,
                2 => 30,
                3 => 25,
                4 => 0,
                5 => 0,
                _ => 0
            };
            int damage2 = Math.Max(0, power2 - monsterDefense2);
            Console.WriteLine($"Damage: {damage2}");

            string rating2 = damage2 switch
            {
                >= 18 => "Critical hit!",
                >= 10 => "Solid hit.",
                >= 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating2}");

            Console.Write("Do you want to run away? (y/n): ");
            string answer2 = Console.ReadLine();

            switch (answer2)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped from the fight!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }

        }
    }
}
