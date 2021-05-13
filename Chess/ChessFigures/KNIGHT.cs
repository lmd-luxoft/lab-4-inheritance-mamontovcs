using System;

namespace Chess.ChessFigures
{
    internal class Knight : ChessFigure
    {
        public Knight(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool Move(string nextCoord)
        {
            int dx, dy;
            dx = Math.Abs(nextCoord[0] - currentCoord[0]);
            dy = Math.Abs(nextCoord[1] - currentCoord[1]);

            return CheckCoord(nextCoord) ? (Math.Abs(nextCoord[0] - currentCoord[0]) == 1
                && Math.Abs(nextCoord[1] - currentCoord[1]) == 2
                || Math.Abs(nextCoord[0] - currentCoord[0]) == 2
                && Math.Abs(nextCoord[1] - currentCoord[1]) == 1) : false;
        }
    }
}
