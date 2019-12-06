using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    class Character
    {
        public string name;
        public int HP;
        public Stats stats;

        public Character (string name)
        {
            this.name = name;
            this.HP = 20;
        }
    }
}
