namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NEW HERO");

            Console.WriteLine("Name your hero:"); // writeline พิมบรรทัดใหม่ wrie พิมยาวต่อเดิม

            string playerName = Console.ReadLine(); //

            Console.WriteLine($"\n\"Welcome, {playerName}. Your journey begins...\"");

            Console.WriteLine("***************");
            Console.WriteLine("Choose difficulty (1-3):");

            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Difficulty set to {difficulty}.");

            

            Console.WriteLine("*********RATE THIS LEVEL*********");
            Console.WriteLine("Rate this level (1-5):");
            bool isValid1 = double.TryParse(Console.ReadLine(), out double rating);
            Console.WriteLine($"Valid input: {isValid1}");
            Console.WriteLine($"Rating: {rating}");

            Console.WriteLine("*********CHARACTER CREATION*********");
            Console.WriteLine("Name your character:");
            string charName = Console.ReadLine();
            Console.WriteLine($"Choose a class (1-3): ");
            bool class0k = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luck0k = double .TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"\n{charName} The Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine();
            Console.WriteLine("********ITEM SHOP********");
            Console.Write("How many potions? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine();

            Console.WriteLine("*********SET VOLUME*********");
            Console.Write("Volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");
            Console.WriteLine();

            Console.WriteLine("********NEW SAVE FILE*******");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");

        }
    }
}
