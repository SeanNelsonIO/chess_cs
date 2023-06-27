

using System;

namespace Chess
{
    public interface Piece {
        bool IsValidMove(int newX, int newY);
    }

    public class King : Piece {
        private int x;
        private int y;


        public bool IsValidMove(int newX, int newY)
        {
            // Check if the move is valid for a king
            if (newX > x + 1 || newX < x - 1 || newY > y + 1 || newY < y - 1)
            {
                return false;
            }

            return true;
        }
    }

    public class Queen : Piece {
        private int x;
        private int y;

        public bool IsValidMove(int newX, int newY)
        {
            // Check if the move is valid for a queen
            if (newX != x && newY != y)
            {
                return false;
            }

            return true;
        }
    }
    
    public class Rook : Piece {
        private int x;
        private int y;

        public bool IsValidMove(int newX, int newY)
        {
            // Check if the move is valid for a rooke
            if (newX != x && newY != y)
            {
                return false;
            }
            return true;
        }
    }

    public class Bishop : Piece {
        private int x;
        private int y;

        public bool IsValidMove(int newX, int newY)
        {
            // Check if the move is valid for a bishop
            if (Math.Abs(newX - x) != Math.Abs(newY - y))
            {
                return false;
            }

            return true;
        }
    }

    public class Knight : Piece {
        private int x;
        private int y;

        public bool IsValidMove(int newX, int newY)
        {
            // Check if the move is valid for a knight
            if (Math.Abs(newX - x) == 2 && Math.Abs(newY - y) == 1)
            {
                return true;
            }

            if (Math.Abs(newX - x) == 1 && Math.Abs(newY - y) == 2)
            {
                return true;
            }

            return false;
        }
    }

    public class Pawn : Piece {
        private int x;
        private int y;

        public bool IsValidMove(int newX, int newY)
        {
            // Check if the move is valid for a pawn
            if (newX != x)
            {
                return false;
            }

            if (newY > y + 1 || newY < y - 1)
            {
                return false;
            }

            return true;
        }
    }

}