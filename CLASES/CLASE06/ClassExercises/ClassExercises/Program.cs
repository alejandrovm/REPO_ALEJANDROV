using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Character type:");
            Console.WriteLine ("\t1-Wizard");
            Console.WriteLine ("\t2-Warrior");
            Console.WriteLine ("\t3-Rogue");
            string type = Console.ReadLine ();

            Console.WriteLine ("Name: ");
            string name = Console.ReadLine ();

            /*
            switch (type) {
                case "1":
                    Wizard wizard = new Wizard (name, 3);
                    break;
                case "2":
                    Warrior warrior = new Warrior (name);
                    break;
                case "3":
                    Rogue roque = new Rogue (name);
                    break;

                default:
                    break;
            }
            */

            Character myCharacter = null; //null es que ahorita no tiene nada
            switch (type) {
                case "1":
                    myCharacter = new Wizard (name, 3);
                    break;
                case "2":
                    myCharacter = new Warrior (name);
                    break;
                case "3":
                    myCharacter = new Rogue (name);
                    break;

                default:
                    break;
            }

            if (myCharacter != null)
                myCharacter.ShowActionMenu ();

            Console.ReadLine ();

        }
    }
}
