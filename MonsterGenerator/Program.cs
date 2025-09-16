namespace MonsterGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster m1 = Monster.CreateRandomMonster();
            Monster m2 = Monster.CreateSpecificMonster("Big Boy", 100, 30);

            // m2.takeDamage() tar in en int som subtraheras från objektets health. 
            // Efter som att m1.Attack() retunerar en int baserad på objektets stregnth variabel kan jag stoppa in den direkt i m2.takeDamage
            m2.takeDamage(m1.Attack());
        }
    }
}
