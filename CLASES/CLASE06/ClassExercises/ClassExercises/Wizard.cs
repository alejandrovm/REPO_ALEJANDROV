using System;
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
    }
}
