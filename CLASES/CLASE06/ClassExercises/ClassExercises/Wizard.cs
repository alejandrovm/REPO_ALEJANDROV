﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Wizard : Character
    {
        public int mp;

        public Wizard (string name, int mp) : base (name)
        {
            this.mp = mp;
        }

        public void Cast () {
            Console.WriteLine ("Cast");
        }

        public override void ShowActionMenu ()
        {
            base.ShowActionMenu ();
            Console.WriteLine ("4 - cast");

            string action = Console.ReadLine ();
            switch (action) {
                case "1":
                    Walk ();
                    break;
                case "2":
                    Jump ();
                    break;
                case "3":
                    Attack ();
                    break;
                case "4":
                    Cast ();
                    break;

                default:
                    break;
            }
        }
    }
}
