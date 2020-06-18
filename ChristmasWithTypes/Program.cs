using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //var xmas = new Christmas();

            //var xmasDay = Christmas.Day.Thursday;

            ////TODO set Santa's name to Kris Kringle
            //xmas.Santa = "Kris Kringle";

            ////TODO Insert 3 presents you would like for xmas.  They must be strings
            //xmas.Presents = new string[3] { "Xbox", "Playstation", "Nintendo Switch" };

            ////TODO Set the TreeHeight to 10
            //xmas.TreeHeight = 10;

            //Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            //Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            //Console.WriteLine("Here are the presents we would like:");

            //foreach (var present in xmas.Presents)
            //{
            //    Console.WriteLine($"    {present}");
            //}

            //Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
            //Console.WriteLine("Press enter to continue:");




            string name;
            int age;
            bool isABoy;
            char letter;
            float damage;
            double balance;
            decimal hp;
            letter = 'B';
            damage = 222.2f;
            balance = 337.35;
            hp = 120500.35m;
            name = "matt";
            age = 31;
            isABoy = true;

            Console.WriteLine($"Hello I am {name}, I am {age} and i try to stay {isABoy}! In the game remnant i have a weapon that can deal {damage} points, but usually the boss health is about {hp}, so my weapon leaves {letter} class damage in its wake and when the mod powers up it deals {balance} additional damage!");

        }
    }
}
