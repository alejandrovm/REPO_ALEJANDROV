using System;

namespace TextAdventure
{
    class MainClass
    {
        static void Main()
        {
            string CharacterName = "";

            Console.WriteLine("A Text Adventure Game");
            Console.WriteLine("by Alejandro Villalobos");
            Console.WriteLine("THE LOST MINE");
            Console.WriteLine("Name your character:");

            CharacterName = Console.ReadLine();
            Console.WriteLine("Alright then, your character's name is: " + CharacterName);

            Console.ReadKey();
        }
    }
}
