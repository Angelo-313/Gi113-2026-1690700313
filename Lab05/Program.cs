namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====BATTLE MAGE====");
            Console.WriteLine("hero vs. Monsters -- Fight Calculator");

            // User input of Hero ststs
            Console.WriteLine("Hero Health: ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defence: ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            // User input of Monster ststs
            Console.WriteLine("Monster Health: ");
            bool isMonHp = int.TryParse(Console.ReadLine(), out int MonsterHp);
            Console.WriteLine("Monster Attack: ");
            bool isMonAtk = int.TryParse(Console.ReadLine(), out int MonsterAtk);
            Console.WriteLine("Monster Defence: ");
            bool isMonDef = int.TryParse(Console.ReadLine(), out int MonsterDef);

            // Check if player input is valid
            bool allHeroValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonsterValid = isMonHp && isMonAtk && isMonDef;
            Console.WriteLine($"Stats Validation: HERO: {allHeroValid}, MONSTER: {allMonsterValid}");
            Console.WriteLine($"[HERO]     HP: {heroHp}  ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]  HP: {MonsterHp}  ATK: {MonsterAtk} DEF: {MonsterDef}");

            // Before fighting : hero drink a potion (Compound Assignment: +-)
            int potionHeal = 8;
            // 1.  herohp+potionheal
            /*2.*/ heroHp += potionHeal; // แนะนำแบบนี้ คำนวนเหมือนกัน 1+1+2
            Console.WriteLine(@"\n=> Hero drink a potion, Healing {potionheal}. healh is now {herohp}.");

            // คำนวน damege normal attack (Arithmetic+Math)
            int normalDamage = Math.Max(0, heroAtk - MonsterDef); // ATK 10 Dff 5 คำนวนหลังคำนวน atk จะไม่ลดเหลือ5
            Console.WriteLine($"Normal Attack deal : {normalDamage}");

            // คำนวน power attack (Predence ลำดับการคำนวน คูณก่อนลบ)
            int powerDamage = Math.Max(0, heroAtk * 2 - MonsterDef ); // เรียงลำดับ * มาก่อน - ไม่จำเป็นต้องมี()
            Console.WriteLine($"power Attack deal: {powerDamage} DMG");

            // คำนวน Monster Attack 
            int counterDamage = Math.Max(0, MonsterAtk - heroDef);
            Console.WriteLine($"Normal Attack deal : {normalDamage} DMG");

            // คำนวน Cri Chance
            Random rng = new Random();
            int roll = rng.Next(1, 101); // สุ่มคริ 1-100
            bool isCrit = roll <= 10; //10%
            int criDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // โอกาส 10% ติดคริ เลขได้ 1 ไม่ติดได้ 0
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical: {criDamage}");

        }
    }
}
