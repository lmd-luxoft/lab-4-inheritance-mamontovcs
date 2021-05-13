namespace Chess.ChessFigures
{
    internal class Pawn : ChessFigure
    {
        public Pawn(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool Move(string nextCoord)
        {
            if (CheckCoord(nextCoord))
            {
                return !(nextCoord[0] != currentCoord[0] 
                    || nextCoord[1] <= currentCoord[1] 
                    || (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != '2' 
                    || nextCoord[1] != '4')));
            }
            else
            {
                return false;
            }
        }
    }
}
