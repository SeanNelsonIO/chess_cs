
// Board class


using System;

namespace Chess
{
    class Board {
        
        private string[,] board = new string[8,8]; // 8x8 board


        public Board() {
            // Create a new board
            Console.WriteLine("Creating a new board");

            // Initialize the board
            InitializeBoard();
        }

        private void InitializeBoard() {
            // Initialize the board
            Console.WriteLine("Initializing the board");

            // Set the board to empty
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    board[i,j] = " ";
                }
            }
        }

        public void SetBoard() {
            // Set the board
            Console.WriteLine("Setting the board");
            
            // Set the board
            board[0,0] = "R";
            board[0,1] = "N";
            board[0,2] = "B";
            board[0,3] = "Q";
            board[0,4] = "K";
            board[0,5] = "B";
            board[0,6] = "N";
            board[0,7] = "R";
            board[1,0] = "P";
            board[1,1] = "P";
            board[1,2] = "P";
            board[1,3] = "P";
            board[1,4] = "P";
            board[1,5] = "P";
            board[1,6] = "P";
            board[1,7] = "P";
            board[6,0] = "p";
            board[6,1] = "p";
            board[6,2] = "p";
            board[6,3] = "p";
            board[6,4] = "p";
            board[6,5] = "p";
            board[6,6] = "p";
            board[6,7] = "p";
            board[7,0] = "r";
            board[7,1] = "n";
            board[7,2] = "b";
            board[7,3] = "q";
            board[7,4] = "k";
            board[7,5] = "b";
            board[7,6] = "n";
            board[7,7] = "r";
        }

        public void PrintBoard() {
            // Print the board
            Console.WriteLine("Printing the board");

            // Print the board
            for (int i = 0; i < 8; i++) {
                Console.WriteLine(" | " + board[i,0] + " | " + board[i,1] + " | " + board[i,2] + " | " + board[i,3] + " | " + board[i,4] + " | " + board[i,5] + " | " + board[i,6] + " | " + board[i,7] + " | ");
            }
        }



    }
}