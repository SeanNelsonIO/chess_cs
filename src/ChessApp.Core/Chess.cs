// Chess Application


using System;

namespace Chess
{
    class Chess
    {
        static void Main(string[] args)
        {
            
            Game game = Game.GetInstance();

            // Display menu
            // game.DisplayMenu();
            
            // Start the game loop
            while (!game.IsGameOver)
            {
                // Process player input, update game state, and handle game logic
                game.Update();

                // Render the current game state
                game.Render();

                // Delay to control the frame rate (optional)
                // You can use Thread.Sleep() or other mechanisms for this purpose

                // Clear the console or UI (optional)
                // You may want to clear the screen or update the UI between frames
                
            }

            // Game over, display the result
            // game.DisplayResult();

        }
    }
}