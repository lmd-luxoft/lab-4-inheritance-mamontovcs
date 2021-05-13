using System;

namespace Chess.ChessFigures
{
    internal class Bishop : ChessFigure
    {
        public Bishop(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool Move(string nextCoord)
        {
            return CheckCoord(nextCoord) 
                ? (Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1])) : false;
        }
    }
}
