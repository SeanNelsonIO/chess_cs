

using System;

namespace Chess
{
    public interface ChessPieceFactory {

        Piece CreatePiece(string pieceType);
    }

    
}