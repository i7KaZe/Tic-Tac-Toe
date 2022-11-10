namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe jeu = new TicTacToe();
            bool xGagne = false;
            bool oGagne = false;

            xGagne = jeu.gagnerTicTacToe('X');

            if (xGagne == true)

            {
                Console.WriteLine("X gagne");
            }
        }
    }
}