﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class FigureOnSquare
    {
        public Figure figure { get; private set; }
        public Square square { get; private set; }

        public FigureOnSquare(Figure figure, Square square)
        {
            this.square = square;
            this.figure = figure;
        }

            
    }
}
