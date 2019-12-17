using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Game
    {
        //variable declarations
        static string CharacterName = ""; //character name
        static int Scenarios = 3; //number of scenarios

        static string[] PartOne = {
            "You've been on the Triboar Trail for about half a day. As you come around a bend, you spot two dead horses sprawled about fifty feet ahead of you, blocking the path. Each has several black-feathered arrows sticking out of it. The woods press close to the trail here, with a steep embankment and dense thickets on either side. Do you A : approach the dead horses? or B : keep going your way?",
            "... You identify the horses as belonging to Gundren Rockseeker and Sildar Hallwinter. It's clear that arrows killed the horses. The saddlebags have been looted and nearby lies an empty leather map case. Also from when you are standing, you see a small group of GOBLINS hiding in the woods, they see you and run away inmediatly...",
            "... You keep going your way, confident that Gundren and Sildar are already waiting for you. Suddenly as you walk by, an arrow narrowly makes a small cut in your cheek, there is no time to react. From within the bushes 2 goblins jump on you, throwing you to the floor. They made a mistake, they expected the arrow to kill you but missed. Knowing they can’t overpower you they run away scared, one falls to your knife...",
            "... You follow the goblins’ trail for what feels around 5 miles to a cavern, everything seems a little too quiet to be a goblins hideout...",
            "... And you were right, As soon as you get close enough to the cave, a couple of goblins with bow and arrows attack you from the bushes at the entrance of the cave. Your quick thinking saves you from any mayor wound, but any hope for going inside the cave without being noticed is gone...",
            "... As you follow the goblins, you notice he’s trying to communicate something to someone hidden. You notice something in the bushes and fire your arrows, 2 goblins fall from behind them. Then you approach the running goblin and finish him quietly. You hope no one inside the cave has heard you, but are not sure...",
            "From the entrance of the cave you noticed the high ceilings and darkness of the passages, you can still see but not too far. You hear the sound of a stream inside. The sound of the water muffles the noise from any creature that isn’t paying attention..."
        };
        static string[] PartTwo = {
            "Just inside the cave mouth, a few uneven stone steps lead up to a small, dank chamber on the east side of the passage. The cave narrows to a steep fissure at the far end, and is filled with the stench of animals. Savage snarls and the sounds of rattling chains greet your ears where two wolves are tied up just inside the opening. Each wolf's rope leads to an iron rod driven into the base of a stalagmite. These wolves look up hungry and mistreated. Do you A: attempt to pass through the wolves? or do you B: keep walking through the steep passage in order to explore the cave?",
            "... The wolves try to attack you, luckily their barks and growls are muffled by the sound of the stream of the subterranean river. You quickly use your knife to free them, they run away from their captors. You get to end of the room, it is too narrow. You have to climb in order to get to the other side...",
            "... The main passage from the cave mouth climbs steeply upward. You notice a bridge on top of you, and a pair of goblins. They haven’t noticed you so you pass. The passage narrows so you have to climb to get to them...",
            "... You climb as quietly as possible, the sound of the stream helps you pass unnoticed. When you get to the top, you suddenly notice your next challenge...",
            "... You see an orc he is big and strong, compared to the nimble goblins, he is definitely the captor of the wolves, he hasn’t noticed you looking at him. If he notices you, you won’t be match for him, so, you jump quickly on him from behind and stab him in the heart with your knife. He fights though, he hits you with his elbow so hard you hear a cracking, but it is not enough, and he falls...",
            "... The goblins notice you, and fires his arrows and missed you, but the other one hits you hard with his club. You feel something breaking from inside. Still injured, they are no match for you. After you’ve taken them down, you descend in order to continue...",
            "Injured you noticed the path to the next room, you could have sworn you heard something, so you slowly continue your search..."
        };
        static string[] PartThree = {
            "This large cave is divided in half by a ten-foot-high escarpment. A steep natural staircase leads from the lower portion to the upper ledge. The air is hazy with the smoke of a cooking fire, and pungent from the smell of poorly cured hides and unwashed goblins. Six goblins inhabit this den, and one of them is a leader. Past them you see Sildar and Gundren, prisoners of the Goblins. They look weak, as the goblins have been beating and tormenting them. They haven’t noticed you, you could A : Charge at them or B : sneak from within the shadows and free Gundren and Sildar.",
            "... You count them. They outnumber you, but inspite of your injuries, you trust yourself to be able to overpower them. They are caught off guard, eating. They drop their food and try to grab their weapons but you are too fast. 3 of them fall quickly to your knife. Only 3 are left. You slowly approach the cage and force one of the goblins to free them...",
            "... You look at your wounds and decide it’s too risky to charge at them so you move as quietly as posible thru the dark part of the room. You get to the cage where Sildar and Gundren are, they quickly recognize you. As you 3 try to sneak your way out of the room...",
            "... One of the goblins sneak on you and grabs Sildar from behind and puts his knife on his neck. ‘If you two don’t get back in the cage he dies’ says the goblins...",
            "... Sildar tries to fight him by grabbing his hand and taking the knife from him, while you run and stab the goblin but it’s too late, Sildar falls as well. The other 2 goblins feel themselves outnumbered and run away. While Sildar dies in Gundren’s arms...",
            "... As you are leaving you can hear screams and movement from within the cave, you are safe now, they can’t catch any of you but it is clear the goblins want revenge. They could pose a problem in the future...",
            "Out in one peace, you and your company, slowly walk out of the cave and into the town of Phandalin, where they still have a lot of work to do."
        };

        public static void StartGame() //prints out game title and starts game
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string title = @"
                        ▄▄▄█████▓ ██░ ██ ▓█████                        
                        ▓  ██▒ ▓▒▓██░ ██▒▓█   ▀                        
                        ▒ ▓██░ ▒░▒██▀▀██░▒███                          
                        ░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄                        
                          ▒██▒ ░ ░▓█▒░██▓░▒████▒                       
                          ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░                       
                            ░     ▒ ░▒░ ░ ░ ░  ░                       
                          ░       ░  ░░ ░   ░                          
                                  ░  ░  ░   ░  ░                       
 ██▓     ▒█████    ██████ ▄▄▄█████▓    ███▄ ▄███▓ ██▓ ███▄    █ ▓█████ 
▓██▒    ▒██▒  ██▒▒██    ▒ ▓  ██▒ ▓▒   ▓██▒▀█▀ ██▒▓██▒ ██ ▀█   █ ▓█   ▀ 
▒██░    ▒██░  ██▒░ ▓██▄   ▒ ▓██░ ▒░   ▓██    ▓██░▒██▒▓██  ▀█ ██▒▒███   
▒██░    ▒██   ██░  ▒   ██▒░ ▓██▓ ░    ▒██    ▒██ ░██░▓██▒  ▐▌██▒▒▓█  ▄ 
░██████▒░ ████▓▒░▒██████▒▒  ▒██▒ ░    ▒██▒   ░██▒░██░▒██░   ▓██░░▒████▒
░ ▒░▓  ░░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░  ▒ ░░      ░ ▒░   ░  ░░▓  ░ ▒░   ▒ ▒ ░░ ▒░ ░
░ ░ ▒  ░  ░ ▒ ▒░ ░ ░▒  ░ ░    ░       ░  ░      ░ ▒ ░░ ░░   ░ ▒░ ░ ░  ░
  ░ ░   ░ ░ ░ ▒  ░  ░  ░    ░         ░      ░    ▒ ░   ░   ░ ░    ░   
    ░  ░    ░ ░        ░                     ░    ░           ░    ░  ░
                                                                       
                         by Alejandro Villalobos
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
        }
        static void Choice()
        {
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";
                switch (section)
                {
                    case 1: // Part 1
                        Console.WriteLine(PartOne[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(CharacterName + " Choose A or B. Write down the letter of your choice: ");
                        Console.ResetColor();
                        input = Console.ReadLine();
                        input = input.ToUpper();

                        if (input == "A")
                        {
                            Console.WriteLine(PartOne[1]);

                        }
                        else if (input == "B")
                        {
                            Console.WriteLine(PartOne[2]);
                        }

                        Console.WriteLine(PartOne[3]);

                        if (input == "A")
                        {
                            Console.WriteLine(PartOne[4]);

                        }
                        else if (input == "B")
                        {
                            Console.WriteLine(PartOne[5]);
                        }

                        Console.WriteLine(PartOne[6]);

                        break;

                    case 2: //Part Two
                        Console.WriteLine(PartTwo[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CharacterName + " Choose A or B.Write down the letter of your choice: ");
                        Console.ResetColor();
                        input = Console.ReadLine();
                        input = input.ToUpper();
                        if (input == "A")
                        {
                            Console.WriteLine(PartTwo[1]);

                        }
                        else if (input == "B")
                        {
                            Console.WriteLine(PartTwo[2]);
                        }
                        Console.WriteLine(PartTwo[3]);
                        if (input == "A")
                        {
                            Console.WriteLine(PartTwo[4]);

                        }
                        else if (input == "B")
                        {
                            Console.WriteLine(PartTwo[5]);
                        }
                        Console.WriteLine(PartTwo[6]);

                        break;

                    case 3: //Part Three
                        Console.WriteLine(PartThree[0]);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CharacterName + " Choose A or B. Write down the letter of your choice: ");
                        Console.ResetColor();
                        input = Console.ReadLine();
                        input = input.ToUpper();
                        if (input == "A")
                        {
                            Console.WriteLine(PartThree[1]);

                        }
                        else if (input == "B")
                        {
                            Console.WriteLine(PartThree[2]);
                        }
                        Console.WriteLine(PartThree[3]);
                        if (input == "A")
                        {
                            Console.WriteLine(PartThree[4]);

                        }
                        else if (input == "B")
                        {
                            Console.WriteLine(PartThree[5]);
                        }
                        Console.WriteLine(PartThree[6]);
                        break;
                }
                Console.WriteLine("Press a key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void EndGame()
        {
            //end of game text
            Console.WriteLine("Congratulations " + CharacterName + " You've reached the end of the story!");
            Console.WriteLine("Press enter to exit.");
            Console.Read();
        }
    }
}
