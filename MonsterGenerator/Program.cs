namespace MonsterGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster m1 = Monster.CreateRandomMonster();
            Monster m2 = Monster.CreateSpecificMonster("Big Boy", 100, 30);



            m2.takeDamage(m1.Attack());
        }
    }
}
