﻿/*
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
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("In the city of Neverwinter, a dwarf named Gundren Rockseeker asked you to bring a wagon load of provisions to the rough-and-tumble settlement of Phandalin, a couple of days' travel southeast of the city. Gundren was clearly excited and more than a little secretive about his reasons for the trip, saying only that he and his brothers had found 'something big', and that he'd pay you ten gold pieces for escorting his supplies safely to Barthen's Provisions, a trading post in Phandalin.He then set out ahead of you on horse, along with a warrior escort named Sildar Hallwinter, claiming he needed to arrive early to 'take care of business'.");
            Console.ReadKey();
            Console.WriteLine("You've been on the Triboar Trail for about half a day. As you come around a bend, you spot two dead horses sprawled about fifty feet ahead of you, blocking the path. Each has several black-feathered arrows sticking out of it. The woods press close to the trail here, with a steep embankment and dense thickets on either side.");
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
