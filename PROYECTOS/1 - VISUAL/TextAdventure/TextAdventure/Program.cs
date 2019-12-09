/*
THE LOST MINE
by Alejandro Villalobos

The following is a very loose adaptation of the 1st part of 'The Lost Mine of Phandelver',
entitled 'Goblin Arrows', a 'Wizards of the Coast' module for D&D 5e.
 */

using System;

namespace TextAdventure
{
    public static class Game
    {
        //character name
        static string CharacterName = "";

        //print out game title and overview
        public static void StartGame()
        {
            Console.WriteLine("A Text Adventure Game");
            Console.WriteLine("by Alejandro Villalobos");
            Console.WriteLine("THE LOST MINE");
            NameCharacter();
        }
        //ask player for a name, and save it
        static void NameCharacter()
        {
            Console.WriteLine("Name your character:");

            CharacterName = Console.ReadLine();
            Console.WriteLine("Alright then, your character's name is: " + CharacterName + ". Good Luck " + CharacterName + "! (you'll need it)");
        }
    }
    class Item
    {
    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}
