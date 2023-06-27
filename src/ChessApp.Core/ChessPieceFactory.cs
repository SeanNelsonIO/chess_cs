

using System;

namespace Chess
{
    public interface IChessPieceFactory {

        Piece CreatePiece(string pieceType);
    }

    public class ChessPieceFactory : IChessPieceFactory {

        public Piece CreatePiece(string pieceType)
        {
            // Create a new piece
            Piece piece = null;

            // Create a new piece based on the piece type
            switch (pieceType)
            {
                case "King":
                    piece = new King();
                    break;
                case "Queen":
                    piece = new Queen();
                    break;
                case "Rook":
                    piece = new Rook();
                    break;
                case "Bishop":
                    piece = new Bishop();
                    break;
                case "Knight":
                    piece = new Knight();
                    break;
                case "Pawn":
                    piece = new Pawn();
                    break;
                default:
                    throw new Exception($"Invalid piece type: {pieceType}");
                    break;
            }

            return piece;
        }
    }
}