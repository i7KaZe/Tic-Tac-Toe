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

            xGagne = jeu.gagnerTicTacToe('X');

            if (xGagne == true)

            {
                Console.WriteLine("X gagne");
            }

            while (!jeu.isFini())
            {
                jeu.afficherJeu();

                Console.WriteLine("Ou voulez vous placer votre symbole ?");
                int.TryParse(Console.ReadLine(), out position);
                jeu.placerSymbole(position);
            }




            
        }
    }
}