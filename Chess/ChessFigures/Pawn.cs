namespace Chess.ChessFigures
{
    internal class Pawn : ChessFigure
    {
        private const char OneMove = '2';
        private const char TwoMoves = '4';

        public Pawn(string currentCoord) : base(currentCoord)
        {
        }

        internal override bool Move(string nextCoord)
        {
            return CheckCoord(nextCoord) ? !(nextCoord[0] != currentCoord[0]
                || nextCoord[1] <= currentCoord[1]
                || (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != OneMove
                || nextCoord[1] != TwoMoves))) : false;
        }
    }
}
