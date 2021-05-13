using System;

namespace Chess.ChessFigures
{
    internal class King : ChessFigure
    {
        public King(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool Move(string nextCoord)
        {
            if (CheckCoord(nextCoord))
            {
                return (Math.Abs(nextCoord[0] - currentCoord[0]) <= 1 
                    && Math.Abs(nextCoord[1] - currentCoord[1]) <= 1);
            }
            else
            {
                return false;
            }
        }
    }
}
