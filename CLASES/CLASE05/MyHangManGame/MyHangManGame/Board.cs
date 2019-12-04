using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame
{
    class Board
    {
        public void Clear ()
        {
            Console.Clear ();
        }

        public void Draw (string line) {
            Console.WriteLine(line);
        }

        public void Close () {
            Console.WriteLine ("Press Enter to close");
            Console.ReadLine ();
        }   
    }
}
