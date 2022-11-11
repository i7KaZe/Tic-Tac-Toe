using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe
    {
        public char[] tableau;
        public int nbDeTour;

        public TicTacToe()
        {
            tableau = new char[9] {
            ' ', ' ', ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' '
            };
            this.nbDeTour = 0;
        }

        public bool gagnerTicTacToe(char joueur)
        {
            bool gagne = false;

            if (this.tableau[0] == joueur && this.tableau[1] == joueur && this.tableau[2] == joueur)
            {
                gagne = true;
            }
            else if (this.tableau[0] == joueur && this.tableau[3] == joueur && this.tableau[6] == joueur)
                {
                    gagne = true;
                }
            else if (this.tableau[1] == joueur && this.tableau[4] == joueur && this.tableau[7] == joueur)
            {
                gagne = true;
            }
            else if (this.tableau[2] == joueur && this.tableau[5] == joueur && this.tableau[8] == joueur)
            {
                gagne = true;
            }
            else if (this.tableau[0] == joueur && this.tableau[4] == joueur && this.tableau[8] == joueur)
            {
                gagne = true;
            }
            else if (this.tableau[2] == joueur && this.tableau[4] == joueur && this.tableau[6] == joueur)
            {
                gagne = true;
            }
            return gagne;


        }

        public bool placerSymbole (int position)
        {
            bool placer = false;

            // quel symbole est-ce que je place ?
            

            // est-ce que je peux placer la pièce à la position ?
            // quand je place un symbole, passer au tour suivant 

            if (tableau[position] != 'X' && tableau[position] != 'O')
            {
                this.nbDeTour++;
                if (this.nbDeTour %2 == 0)
                {
                    tableau[position] = 'X';
                }
                else
                {
                    tableau[position] = 'O';
                }
                placer = true;
            }

            else
            {
                Console.WriteLine("La position est prise...");
            }

            return placer;
        }

        public bool isFini()
        {
           return this.nbDeTour >= 9;
        }

        public void afficherJeu()
        {
            Console.WriteLine("__________________");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("| {0}   | {1}   | {2}   |", this.tableau[0], this.tableau[1], this.tableau[2]);
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("| {0}   | {1}   | {2}   |", this.tableau[3], this.tableau[4], this.tableau[5]);
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("| {0}   | {1}   |  {2}  |", this.tableau[6], this.tableau[7], this.tableau[8]);
            Console.WriteLine("|_____|_____|_____|");
        }
    }
}
