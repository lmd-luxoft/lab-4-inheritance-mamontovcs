namespace Chess
{
    internal abstract class ChessFigure
    {
        public string currentCoord;

        public ChessFigure(string currentCoord)
        {
            this.currentCoord = currentCoord;
        }

        internal abstract bool Move(string nextCoord);
   
        protected bool CheckCoord(string nextCoord)
        {
            return nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8';
        }
    }
}