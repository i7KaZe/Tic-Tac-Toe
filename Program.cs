namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe jeu = new TicTacToe();
            bool xGagne = false;
            bool oGagne = false;
            int position = 0;

            while (!jeu.isFini() && !jeu.gagnerTicTacToe('X') && !jeu.gagnerTicTacToe('O'))
            {
                Console.Clear();
                jeu.afficherJeu();

                Console.WriteLine("Ou voulez vous placer votre symbole (0-8) ?");
                int.TryParse(Console.ReadLine(), out position);
                jeu.placerSymbole(position);
            }

            xGagne = jeu.gagnerTicTacToe('X');
            oGagne = jeu.gagnerTicTacToe('O');


            if (xGagne == true)

            {
                Console.WriteLine("X gagne");
            }
            else if (oGagne == true)
            {
                Console.WriteLine("O gagne");
            }

            jeu.afficherJeu();

            




            
        }
    }
}