/*
THE LOST MINE
by Alejandro Villalobos

This is a very loose adaptation of the 1st part of The Lost Mine of Phandelver,
titled Goblin Arrows, a Wizards of the Coast module for D&D 5e Begginers
 */

using System;

namespace TextAdventure
{
    class Game
    {
    }
    class Item
    {
    }
    class Program
    {
        static void Main()
        {
            string CharacterName = "";

            Console.WriteLine("A Text Adventure Game");
            Console.WriteLine("by Alejandro Villalobos");
            Console.WriteLine("THE LOST MINE");
            Console.WriteLine("Name your character:");

            CharacterName = Console.ReadLine();
            Console.WriteLine("Alright then, your character's name is: " + CharacterName + ". Good Luck " + CharacterName + "! (you'll need it)");

            Console.ReadKey();
        }
    }
}
