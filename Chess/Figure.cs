﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    enum Figure
    {
        none,


        whiteKing = 'K',
        whiteQueen = 'Q',
        whiteRook = 'R',
        whiteBishop = 'B',
        whiteKnight = 'N',
        whitePanw = 'P',

        blackKing = 'k',
        blackQueen = 'q',
        blackRook = 'r',
        blackBishop = 'b',
        blackKnight = 'n',
        blackPanw = 'p'
    }

    static class FigureMethods
    {
        public static Color GetColor(this Figure figure)
        {
            if (figure == Figure.none)
                return Color.none;
            return (figure == Figure.whiteKing ||
                    figure == Figure.whiteQueen ||
                    figure == Figure.whiteRook ||
                    figure == Figure.whiteBishop ||
                    figure == Figure.whiteKnight ||
                    figure == Figure.whitePanw) 
                    ? Color.white
                    : Color.black;
        }
    }
}
