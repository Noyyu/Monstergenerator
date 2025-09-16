using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGenerator
{
    internal class Monster
    {
        //Setter private för att jag inte vill att användaren ska kunna komma åt variablernas "rå-data" direkt
        private string name     = "unnamed";
        private int health      = -1;
        private int stregnth    = -1;

        private static string[] randomNames = { "Angry boy", "Lil man", "Monster", "Stitch", "Sir Marmelade", "Mister Mister" }; // Static efter som att alla monster kommer ha tillgång till random namn


        //----------------------------------------------------------------------------------------------------------------------------------------
        // Konstruktor-
        //
        // Detta är default-värden ett Monster objekt får när den skapas. 
        // Jag har gjort den privat för att jag vill att användaren ska använda någon utav mina "Factory medoder" för att skapa ett Monster objekt
        //----------------------------------------------------------------------------------------------------------------------------------------

        private Monster(string name, int health, int stregnth)
        {
            this.name = name;
            this.health = health;
            this.stregnth = stregnth;
        }

        //------------------------------------------------------------------------------------------------------------
        // Static "factory" Methods
        // Dessa metoder skapar och retunerar ett monster. 
        // Dessa är statiska metoder, vilket betyder att dem tillhör KLASSEN Monster.
        // Det innebär att dem enbart kan bli kallade på direkt från variabeln Monster och inte en isntans av klassen.
        // Exempel: Monster myMonster =  Monster.CreateRandomMonster();
        //------------------------------------------------------------------------------------------------------------

        //"Create" methods
        public static Monster CreateRandomMonster()
        {
            int random = new Random().Next(0, randomNames.Length - 1);
            string randomName = randomNames[random];

            int randomHealth = new Random().Next(5, 21);    // 5 - 20
            int randomStregnth = new Random().Next(1, 11);  // 1 - 10

            Console.WriteLine("A monster named " + randomName + " with " + randomHealth + " health and " + randomStregnth + " stregnth entered the battle field");

            return new Monster(randomName, randomHealth, randomStregnth); //Retunerar en monster INSTANS
        }

        public static Monster CreateSpecificMonster(string name, int health, int stregnth)
        {
            Console.WriteLine("A monster named " + name + " with " + health + " health and " + stregnth + " stregnth entered the battle field");
            return new Monster(name, health, stregnth); //Retunerar en monster INSTANS
        }

        //----------------
        // Instansmetoder
        //
        // Dessa metoder retunerar data specefikt till objektet du frågar om. 
        // Exempel: 
        // Monster myMonster = Monster.CreateSpecificMonster("lil boy", 10, 10);
        // Monster mySecondMonster = Monster.CreateSpecifikMonster("bug boy", 15, 15);
        // int health = myMonster.getHealth();
        // health är nu 10
        // int health = mySecondMonster.getHealth();
        // Samma health variabel är nu 15
        //----------------

        //"Get" methods
        public int GetHealth()
        {
            return this.health; //"this" refererar egentligen bara till att den specefikt ska retunera DETTA objektets värden. Egentligen onödigt nu men bra practice
        }
        public int GetStregnth()
        {
            return this.stregnth;
        }
        public string GetName()
        {
            return this.name;
        }


        //"Set" Methods
        public void SetName(string name)
        {
            this.name = name; //"Hör är "this" lite viktigare då båda objektets variabel och den inmatade variabeln har samma namn. Man kan även ba namnge dom anorlunda men jag är van vid detta. "
        }

        public void SetHealth(int health)
        {
            this.health = health;
        }

        public void SetStregnth(int stregnth)
        {
            this.stregnth = stregnth;
        }

        //"Action" methods
        public int Attack()
        { 
            Console.WriteLine(this.name + " attacked!"); 
            return this.stregnth;
        }
        public void takeDamage(int damage)
        {
            this.health -= damage;
            Console.WriteLine(this.name + " took " + damage + " damage!");
            Console.WriteLine(this.name + " now has " + this.health + " health");
        }
    }
}
