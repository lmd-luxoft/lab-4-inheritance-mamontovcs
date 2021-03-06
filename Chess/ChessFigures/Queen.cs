using System;

namespace Chess.ChessFigures
{
    internal class Queen : ChessFigure
    {
        public Queen(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool Move(string nextCoord)
        {
            return CheckCoord(nextCoord) ? (Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1])
                || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1]) : false;
        }
    }
}
