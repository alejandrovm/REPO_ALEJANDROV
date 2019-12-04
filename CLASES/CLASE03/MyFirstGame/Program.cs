using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class Program
    {
        static void Main (string[] args)
        {
            int x = 5; // int = numero entero
            float y = 4.5f; // float = numero decimal
            string str = "lorem ipsum"; // string = cadena de caracteres
            bool myBool = false; // bool = verdadero o falso

            float result;

            result = 5 + 7;
            Console.WriteLine ("suma: " + result);

            result = 5 - 7;
            Console.WriteLine ("res: " + result);

            result = 5 * 7;
            Console.WriteLine ("mult: " + result);

            result = 5f / 7f;
            Console.WriteLine ("div: " + result);

            result = 5 % 7;
            Console.WriteLine ("modulo: " + result);

            Console.ReadLine ();
        }
    }
}
