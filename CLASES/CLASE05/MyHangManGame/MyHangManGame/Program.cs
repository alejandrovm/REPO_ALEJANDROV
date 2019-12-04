using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame
{
    class Program
    {
        static void Main (string[] args)
        {
            /*
            string secretWord = "zapato";
            string publicWord = "";
            string tempWord = "";
            string letter = "";
            int hp = 3;

            for (int i = 0; i < secretWord.Length; i++) {   //para... contador va incrementando
                tempWord += "*";
            }
            publicWord = tempWord;
            Console.WriteLine (publicWord);

            while (hp > 0) {
                Console.WriteLine ("HP = " + hp);
                Console.WriteLine ("Ingrese una letra");
                letter = Console.ReadLine ();
                Console.Clear ();
                // Console.WriteLine (">" + letter);

                tempWord = "";
             // foreach (char c in secretWord) {
             //     if (letter == "" + c) {
             //         tempWord += c; // tempWord = tempWord + c;
             //     } else {
             //         tempWord += "*";
             //     }
                
            // buscar la letra ingresada
                for (int i = 0; i < secretWord.Length; i++) {
                    if (letter == "" + secretWord[i]) {
                        tempWord += letter; //tempWord += secretWord[i];
                    } else {
                        tempWord += publicWord[i];
                    }

                }
                    // si no encontro letra ingresada pierdes 1 de hp
                if (publicWord == tempWord) {
                    hp--;
                }

                if (secretWord == tempWord) {
                    Console.WriteLine ("YOU WIN");
                    break;
                }

                // muestra el estado
                publicWord = tempWord;
                Console.WriteLine (publicWord);
            }
            if (hp <= 0) {
                Console.WriteLine ("GAME OVER");
            }
            
            // esto es para evitar que se cierre al terminar el programa (hay q poner enter)
            Console.ReadLine();
            */

            GameManager gameManager = new GameManager ();
            Player player = new Player ();
            Board board = new Board ();

            gameManager.SetSecretWord ("laptop");

            while (gameManager.isPlaying) {
                board.Clear ();
                board.Draw (player.Life ());

                // OPTION 2
                if (player.IsDead ()) {
                    board.Draw ("GAME OVER");
                    break;
                }

                board.Draw (gameManager.publicWord);

                string letter = player.EnterWord ();
                if (gameManager.CheckLetter (letter))
                    gameManager.UpdatePublicWord (letter);
                else
                    player.Damage ();

                // OPTION 1
                // if (player.IsDead ())
                //  gameManager.isPlaying = false;

                if (gameManager.IsWin ())
                    gameManager.isPlaying = false;

            }
            //  board.Clear ();
            //  board.Draw (player.Life ());
            //  board.Draw ("GAME OVER");

            if (gameManager.IsWin ())
                board.Draw ("YOU WIN");

            board.Close ();

        }
    }
}
