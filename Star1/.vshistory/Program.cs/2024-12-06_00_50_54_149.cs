using MyUtilities;
class Maze { 
    int startX;
    int startY;
    int xLowerBound;
    int yLowerBound;
    int xUpperBound;
    int yUpperBound;
    string cwd = "../../../../";
    string[] contents;
    char[,] board;
    public Maze()
    {
        contents = File.ReadAllLines(cwd + "sample.txt");
        board = new char[contents.Length, contents[0].Length];
        foreach (var (index, value) in contents.Enumerate())
        {
            for (int i = 0; i < value.Length; i++)
            {
                char symbol = value.ToCharArray()[i];
                board[index, i] = symbol;
                if (symbol == '^')
                {
                    this.startX = i;
                    this.startY = index;
                }
            }
        }
        xLowerBound = 0; yLowerBound = 0;
        xUpperBound = board.GetLength(1)-1; yUpperBound = board.GetLength(0) - 1;
    }
    void printBoard()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[i, j]);
            }
            Console.WriteLine();
        }
    }

    int patrolRec(int x, int y, char direction)
    {
        if (x > xUpperBound || x < xLowerBound || y < yLowerBound || y > yUpperBound)
        {
            return -1;
        }
        if (direction == 'u')
        {
            if (board[y - 1, x] == '#')
            {
                direction = 'r';
                return patrolRec(x+1, y, direction) + 1;
            }
            else
            {
                board[y, x] = '^';
                return patrolRec(x, y - 1, direction) + 1;
            }
        }
        else if (direction == 'r')
        {
            if (board[y, x + 1] == '#')
            {
                direction = 'd';
                return patrolRec(x, y + 1, direction) + 1;
            }
            else
            {
                board[y, x] = '>';
                return patrolRec(x + 1, y, direction) + 1;
            }
        }
        else if (direction == 'd')
        {
            char next;
            try
            {
                next = board[y+1, x];
            } catch (Exception e)
            {
                return patrolRec(x, y + 1, direction) + 1;
            }
            if (next == '#')
            {
                direction = 'l';
                return patrolRec(x - 1, y, direction) + 1;
            }
            else
            {
                board[y, x] = 'V';
                return patrolRec(x, y + 1, direction) + 1;
            }
        }
        else
        {
            if (board[y, x - 1] == '#')
            {
                direction = 'u';
                return patrolRec(x, y - 1, direction) + 1;
            }
            else
            {
                board[y, x] = '<';
                return patrolRec(x - 1, y, direction) + 1;
            }
        }
    }

    int patrol()
    {
        int result = patrolRec(startX, startY, 'u');
        return result;
    } 
    static void Main(string[] args)
    {
        Maze maze = new Maze();
        maze.printBoard();
        Console.WriteLine(maze.patrol());
        maze.printBoard();
    }
}
