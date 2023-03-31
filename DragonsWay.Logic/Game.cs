namespace DragonsWay.Logic
{
    public class Game
    {
        private char [,] _deathscavern;

        public int N { get;}
        public String Way { get;}
        public Game(int n, string way)
        {
            N= n;
            Way = way;
            _deathscavern = new char[N,N*2];
        }
    }
}