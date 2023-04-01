namespace DragonsWay.Logic
{
    public class Game
    {
        private char [,] _deathscavern;

        public int N { get;}
        public int M { get;}
        public String Way { get;}
        public Game(int n, string way)
        {
            N = n;
            M = n * 2;
            Way = way;
            _deathscavern = new char[N,M];//row,columns
            bilddeathscavern();
        }

        private void bilddeathscavern()
        {
            {
                for (int i = 0; i < M; i++)
                {
                    _deathscavern[0, i] = '█';//FIRST ROW
                }
                for (int i = 0; i < M; i++)
                {
                    _deathscavern[1, i] = '█';//second row
                }
                for (int i = 0; i < M-1; i++)
                {
                    _deathscavern[1, i] = ' ';//gap second row
                }
                for (int i = 2; i < N; i++)
                {
                    _deathscavern[i, 0] = '█';//FIRST COLUMN
                    for (int j = 1; j < N; j++)
                    {
                        _deathscavern[1, i] = ' ';
                    }
                    _deathscavern[i, M-1] = '█';
                }
            }
        }
        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < N; i++)//rows
            {
                for (int j = 0; j < M; j++)//columns
                {
                    output += $"{_deathscavern[i, j]}";
                }
                output += "\n";
            }
            return output;
        }
    }
}