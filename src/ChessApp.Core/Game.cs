using System;

namespace Chess {
    
    //Singleton design pattern
    public class Game {

        private static Game instance;

        public bool IsGameOver { get; private set; }

        private Board board;

        // Private constructor to prevent direct instantiation
        private Game(){
            // Create a new chess board
            board = new Board();

            board.SetBoard();

            board.PrintBoard();

            Player player1 = new Player("Player 1", "White");
            Player player2 = new Player("Player 2", "Black");
        }

         // Public static method to get the singleton instance
        public static Game GetInstance()
        {
            if (instance == null)
            {
                instance = new Game();
            }
            return instance;
        }

        //Cli version
        public void Update()
        {
            //get user input
            Console.WriteLine("Get next state? y/n");
            string answer = Console.ReadLine();
            
            while(answer == "n") {
                Console.WriteLine("Get next state? y/n");
                answer = Console.ReadLine();
            }
            // Process player input
            // Update the game state (e.g., move pieces, check for checkmate)
            // Check if the game is over based on the game rules
            // Set the IsGameOver flag accordingly
        }

        public void Render()
        {
            // Render the current game state on the console or UI
            board.PrintBoard();
        }

        // public void DisplayResult()
        // {
        //     // Display the result of the game (e.g., winner, draw)
        // }

    }
}
