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
        //Setter private för att jag inte vill att användarens ka kunna komma åt variablerna direkt
        private string name     = "unnamed";
        private int health      = -1;
        private int stregnth    = -1;

        private static string[] randomNames = { "Angry boy", "Lil man", "Monster", "Stitch", "Sir Marmelade", "Mister Mister" }; // Static efter som att alla monster kommer ha tillgång till random namn


        //------------
        // Konstruktor
        //------------

        private Monster(string name, int health, int stregnth)
        {
            this.name = name;
            this.health = health;
            this.stregnth = stregnth;
        }


        //----------------
        // Instans Methods
        //----------------

        //"Get" methods
        public int GetHealth()
        {
            return this.health;
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
            this.name = name;
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


        //------------------------
        // Static "fabric" Methods
        //------------------------

        //"Create" methods
        public static Monster CreateRandomMonster()
        {
            int random = new Random().Next(0, randomNames.Length - 1);
            string randomName = randomNames[random];

            int randomHealth = new Random().Next(5, 21);    // 5 - 20
            int randomStregnth = new Random().Next(1, 11);  // 1 - 10

            Console.WriteLine("A monster named " + randomName + " with " + randomHealth + " health and " + randomStregnth + " stregnth entered the battle field");

            return new Monster(randomName, randomHealth, randomStregnth); //Retunerar en monster instans
        }

        public static Monster CreateSpecificMonster(string name, int health, int stregnth)
        {
            Console.WriteLine("A monster named " + name + " with " + health + " health and " + stregnth + " stregnth entered the battle field");
            return new Monster(name, health, stregnth); //Retunerar en monster instans
        }
    }
}
