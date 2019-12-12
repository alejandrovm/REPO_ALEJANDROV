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
        //variable declarations
        static string CharacterName = ""; //character name

        public static void StartGame() //prints out game title and starts game
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string title = @"
+-------------------------------------------------------------------------------------+
|                                                                                     |
|                            XXXXXXXXX  XXX   XXX  XXXXXXXXX                          |
|                            XXXXXXXXX  XXX   XXX  XXXXXXXXX                          |
|                               XXX     XXX   XXX  XXX                                |
|                               XXX     XXXXXXXXX  XXXXXX                             |
|                               XXX     XXXXXXXXX  XXXXXX                             |
|                               XXX     XXX   XXX  XXX                                |
|                               XXX     XXX   XXX  XXXXXXXXX                          |
|                               XXX     XXX   XXX  XXXXXXXXX                          |
|                                                                                     |
|                                                                                     |
|   XXX      XXXXXXXXX  XXXXXXXXX  XXXXXXXXX   XX     XX  XXX  XX     XX  XXXXXXXXX   |
|   XXX      XXXXXXXXX  XXXXXXXXX  XXXXXXXXX   XXX   XXX  XXX  XXX    XX  XXXXXXXXX   |
|   XXX      XXXXXXXXX  XXX           XXX      XXXX XXXX  XXX  XXXX   XX  XXX         |
|   XXX      XXX   XXX  XXXXXXXXX     XXX      XX XXX XX  XXX  XX XX  XX  XXXXXX      |
|   XXX      XXX   XXX  XXXXXXXXX     XXX      XX  X  XX  XXX  XX  XX XX  XXXXXX      |
|   XXXXXXX  XXXXXXXXX        XXX     XXX      XX     XX  XXX  XX   XXXX  XXX         |
|   XXXXXXX  XXXXXXXXX  XXXXXXXXX     XXX      XX     XX  XXX  XX    XXX  XXXXXXXXX   |
|   XXXXXXX  XXXXXXXXX  XXXXXXXXX     XXX      XX     XX  XXX  XX     XX  XXXXXXXXX   |
|                                                                                     |
|                                                                                     |
|                                By Alejandro Villalobos                              |
|                                                                                     |
+-------------------------------------------------------------------------------------+
";
            Console.WriteLine(title);
            Console.WriteLine("A Text Adventure Game");
            Console.ResetColor();
            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            NameCharacter();
            MainStory();
            Choice();
            EndGame();
        }


        static void NameCharacter() //asks the player for a name for his character, and saves it
        {
            Console.WriteLine("Name your character:");

            CharacterName = Console.ReadLine();
            Console.WriteLine("Alright then, your character's name is: " + CharacterName + ". Good Luck " + CharacterName + "! (you'll need it)");
            Console.WriteLine("Press any key to begin");
            Console.ReadKey();
            Console.Clear();
        }
        static void MainStory()
        {
            Console.WriteLine("In the city of Neverwinter, a dwarf named Gundren Rockseeker asked you to bring a wagon load of provisions to the rough-and-tumble settlement of Phandalin, a couple of days' travel southeast of the city. Gundren was clearly excited and more than a little secretive about his reasons for the trip, saying only that he and his brothers had found 'something big', and that he'd pay you ten gold pieces for escorting his supplies safely to Barthen's Provisions, a trading post in Phandalin.He then set out ahead of you on horse, along with a warrior escort named Sildar Hallwinter, claiming he needed to arrive early to 'take care of business'.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("You've been on the Triboar Trail for about half a day. As you come around a bend, you spot two dead horses sprawled about fifty feet ahead of you, blocking the path. Each has several black-feathered arrows sticking out of it. The woods press close to the trail here, with a steep embankment and dense thickets on either side.");
        }
        static void Choice()
        {
            string input = "";
            Console.WriteLine(CharacterName + " Do you A : approach the dead horses? or B : keep going your way? Write down the letter of your choice");
            input = Console.ReadLine();
            if (input == "A")
            {
                Console.WriteLine("You've chosen path A!");
            }
            else
            {
                Console.WriteLine("You've chosen path B!");
            }
        }

        public static void EndGame()
        {
            //end of game text
            Console.WriteLine("End of story text here.....");

            Console.WriteLine("Press enter to exit.");
            Console.Read();
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
        }
    }
}
