using System.ComponentModel.Design;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 0;

            if (lives <= 0) // ด้านในวงเล็บ ต้องค่าเป็น boolean 
            {
                Console.WriteLine("Game over"); // โค้ดจะรันเมื่อโค้ดเป็นจิง
            }

            Console.WriteLine("Continue Running");

            //2
            int coins = 80;
            int price = 100;

            if (coins >= price)
            {
                Console.WriteLine("Purchase"); // รันเมื่อเป็นจิง
            }
            else
            {
                Console.WriteLine("Not enough coins"); // รันเมื่อเป็นเท็จ
            }

            //3
            int score = 75;

            if (score >= 90) // ลำดับ1เช็ค = เท็จ
            {
                Console.WriteLine("Rank S"); // โค้ดไม่รันไม่อ่าน
            }
            else if (score >= 60) // ลำดับ2เช็ค = จิง
            {
                Console.WriteLine("Rank A"); // โค้ดรัน
            }
            else // เปนกรณีที่ไม่ต้องทั้ง2 ลำดับด้านบน มีเป็นจิงแล้ว ส่วนนี้ไม่รัน
            {
                Console.WriteLine("Rank B");
            }

            //4
            Console.WriteLine("your level (1-99): ");
            bool ok = int.TryParse(Console.ReadLine(), out int level);

            if (!ok || level < 1 || level > 99) // เช็กกรณี user ใส่ผิด
            {
                Console.WriteLine("Invalid Level, please try again.");
            }
            else if (level >= 10)
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5)
            {
                Console.WriteLine("The door is open.");
            }
            else
            {
                Console.WriteLine("The door stay closed.");
            }

        }
    }
}
