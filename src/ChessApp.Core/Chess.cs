// Chess Application


using System;

namespace Chess
{
    class Chess
    {
        static void Main(string[] args)
        {
            // Create a new chess board
            Board board = new Board();

            board.SetBoard();

            board.PrintBoard();

            // Create a new game
            // Game game = new Game(board);

            // // Start the game
            // game.Start();
        }
    }
}