using System.Runtime.Intrinsics.Arm;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            //Output ค่าตัวแปร
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"\nName: {bossName}\nRank: {rank}\nLevel: {level} / {MaxLevel}\nHp: {currentHp} / {maxHp} " +
                $"\nAttack Power: {attackPower}\nCrit Multiplier: {critMultiplier}\nIs Boss: {isBoss}");

            //ทำ Implicit int ไป Double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; //Int-->Double แปลงแบบไม่ cast ใส่ค่าเลย
            Console.WriteLine($"Hp (double): {currentHpDouble}");

            //ทำ Implicit หลักการคำนวณเปอเซน ที่ผลลัพมีทศนิยม
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = currentHpDouble * 100 / maxHp; // int หาร int จากนั้นแปลงผลลัพการคำนวณเป็น double เพื่อเก็บทศนิยม
            Console.WriteLine($"HP Percent (exact): {hpPercent}%");

            //ทำ Explicit โดยการ Casting (float) AttackPower -> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower; // แปลงข้อมูลโดยการ Cast Syntax : (ชนิดที่ต้องการแปลง)ชื่อตัวแปรที่อยากแปลง
            Console.WriteLine($"Attack Power (int cast): {attackInt}");

            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}
