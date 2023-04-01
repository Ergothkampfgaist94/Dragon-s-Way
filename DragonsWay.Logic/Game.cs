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
            Bilddeathscavern();
        }

        private void Bilddeathscavern()
        {
            {
                for (int i = 0; i < M; i++)
                {
                    _deathscavern[0, i] = '█';//FIRST ROW
                }
                for (int i = 0; i < M; i++)
                {
                    _deathscavern[N-1, i] = '█';//lAST ROW
                }                
                for (int j = 1; j < N; j++)// first column
                {
                    _deathscavern[j, 0] = '█';
                }
                _deathscavern[2, 0] = ' ';//gap second row
                for (int j = 1; j < N-3; j++)// LAST COLUMN
                {
                    _deathscavern[j, M-1] = '█';
                }
                _deathscavern[N-2, M-1] = '█';
                for (int i = 1; i < N-1; i++)
                {
                    for (int j = 1; j < M-1; j++)
                    {
                        _deathscavern[i,j] = ' ';
                    }
                }
            }
        }
        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < N; i++)//rows
            {
                output += $"{i}";
                for (int j = 0; j < M; j++)//
                {
                    output += $"{j}";
                    output += $"{_deathscavern[i, j]}";
                }
                output += $"\n";
            }
            return output;
        }
    }
}