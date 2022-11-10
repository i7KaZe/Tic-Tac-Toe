using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe
    {
        char[] tableau;
        int tour;

        public TicTacToe()
        {
            tableau = new char[9] {
            'X', ' ', ' ',
            ' ', 'X', ' ',
            ' ', ' ', 'X'
            };
            this.tour = 0;
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
            int.TryParse(Console.ReadLine(), out position);

            // est-ce que je peux placer la pièce à la position ?
            // quand je place un symbole, passer au tour suivant 

            if (tableau[position] != 'X' && tableau[position] != 'O')
            {
                if (this.tour %2 == 0)
                {
                    tableau[position] = 'X';
                    tour++;
                }
                else
                {
                    tableau[position] = 'O';
                    tour++;
                }
            }

            else
            {
                Console.WriteLine("La position est prise...");
            }

            return placer;
        }

        public bool isFini()
        {
            return this.tour >= 9;
        }

        public void afficherJeu()
        {
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}   |  {1}     |  {2}     |", this.tableau[0], this.tableau[1], this.tableau[2]);
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {3}   |  {4}     |  {5}     |", this.tableau[3], this.tableau[4], this.tableau[5]);
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {6}   |  {7}     |  {8}     |", this.tableau[6], this.tableau[7], this.tableau[8]);
            Console.WriteLine("|     |     |     |");

        }
    }
}
