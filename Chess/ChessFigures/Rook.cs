namespace Chess.ChessFigures
{
    internal class Rook : ChessFigure
    {
        public Rook(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool Move(string nextCoord)
        {
            return CheckCoord(nextCoord) ? !((nextCoord[0] != currentCoord[0]) &&
                (nextCoord[1] != currentCoord[1]) || ((nextCoord[0] == currentCoord[0])
                && (nextCoord[1] == currentCoord[1]))) : false;
        }
    }
}
