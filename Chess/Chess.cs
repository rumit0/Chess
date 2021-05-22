﻿using System;

namespace Chess
{
    public class Chess
    {
        public string fen { get; private set; }
        Board board;
        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        
        {
            this.fen = fen;
            board = new Board(fen);
        }

        Chess(Board board)
        {
            this.board = board;
        }
        public Chess Move(string move)
        {
            FigureMoving fm = new FigureMoving(move);
            Board nextBoard = board.Move(fm);
            Chess nextChess = new Chess(nextBoard);
            return nextChess;
        }

        public char GetFigureAt(int x, int y)
        {
            Square square = new Square(x,y);
            Figure f = board.GetFigureAt(square);
            return f == Figure.none ? '.' : (char)f;
        }
    }
}
