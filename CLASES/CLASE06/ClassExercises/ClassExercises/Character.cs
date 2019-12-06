﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    abstract class Character
    {
        public string name;
        public int HP;
        public Stats stats;

        public Character (string name)
        {
            this.name = name;
            this.HP = 20;
            this.stats = new Stats();
        }

        public void Attack () {
            Console.WriteLine ("Attack");
        }

        public void Jump ()
        {
            Console.WriteLine ("Jump");
        }

        public void Walk ()
        {
            Console.WriteLine ("Walk");
        }

        public virtual  void ShowActionMenu () {
            Console.WriteLine ("ACTIONS");
            Console.WriteLine ("=======");
            Console.WriteLine ("1 - walk");
            Console.WriteLine ("2 - jump");
            Console.WriteLine ("3 - attack");

            /*
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
            }
            
            ShowActionMenu ();
            */
        }

    }
}
