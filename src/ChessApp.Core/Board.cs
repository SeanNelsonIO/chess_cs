
// Board class


using System;

namespace Chess
{
    class Board : IPlayerObserver {
        
        private Piece[,] board = new Piece[8,8]; // 8x8 board of Pieces

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
                    board[i,j] = null;
                }
            }
        }

        public void SetBoard() {
            // Set the board
            Console.WriteLine("Setting the board");

            // Create a chess piece factory
            ChessPieceFactory pieceFactory = new ChessPieceFactory();
            
            // Set the board
            board[0,0] = pieceFactory.CreatePiece("Rook");
            board[0,1] = pieceFactory.CreatePiece("Knight");
            board[0,2] = pieceFactory.CreatePiece("Bishop");
            board[0,3] = pieceFactory.CreatePiece("Queen");
            board[0,4] = pieceFactory.CreatePiece("King");
            board[0,5] = pieceFactory.CreatePiece("Bishop");
            board[0,6] = pieceFactory.CreatePiece("Knight");
            board[0,7] = pieceFactory.CreatePiece("Rook");
            board[1,0] = pieceFactory.CreatePiece("Pawn");
            board[1,1] = pieceFactory.CreatePiece("Pawn");
            board[1,2] = pieceFactory.CreatePiece("Pawn");
            board[1,3] = pieceFactory.CreatePiece("Pawn");
            board[1,4] = pieceFactory.CreatePiece("Pawn");
            board[1,5] = pieceFactory.CreatePiece("Pawn");
            board[1,6] = pieceFactory.CreatePiece("Pawn");
            board[1,7] = pieceFactory.CreatePiece("Pawn");
            board[6,0] = pieceFactory.CreatePiece("Pawn");
            board[6,1] = pieceFactory.CreatePiece("Pawn");
            board[6,2] = pieceFactory.CreatePiece("Pawn");
            board[6,3] = pieceFactory.CreatePiece("Pawn");
            board[6,4] = pieceFactory.CreatePiece("Pawn");
            board[6,5] = pieceFactory.CreatePiece("Pawn");
            board[6,6] = pieceFactory.CreatePiece("Pawn");
            board[6,7] = pieceFactory.CreatePiece("Pawn");
            board[7,0] = pieceFactory.CreatePiece("Rook");
            board[7,1] = pieceFactory.CreatePiece("Knight");
            board[7,2] = pieceFactory.CreatePiece("Bishop");
            board[7,3] = pieceFactory.CreatePiece("Queen");
            board[7,4] = pieceFactory.CreatePiece("King");
            board[7,5] = pieceFactory.CreatePiece("Bishop");
            board[7,6] = pieceFactory.CreatePiece("Knight");
            board[7,7] = pieceFactory.CreatePiece("Rook");
        }

        public void PrintBoard() {
            // Print the board
            Console.WriteLine("Printing the board");

            // Print the board
            for (int i = 0; i < 8; i++) {
                Console.WriteLine(" | " + board[i,0] + " | " + board[i,1] + " | " + board[i,2] + " | " + board[i,3] + " | " + board[i,4] + " | " + board[i,5] + " | " + board[i,6] + " | " + board[i,7] + " | ");
            }
        }

        public void OnPlayerMove(Player player, Piece piece, int startX, int startY, int endX, int endY) {
            // Update the chessboard state based on the player's move
            Console.WriteLine("Updating the chessboard state based on the player's move");
        }
       
    }
}