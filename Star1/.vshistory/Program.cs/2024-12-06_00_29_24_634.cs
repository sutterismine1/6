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
        xUpperBound = board.GetLength(1)-1;
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

    int patrolRec(int x, int y)
    {
        if (x )
    }

    int patrol()
    {
        int result = patrolRec(startX, startY);
        return result;
    } 
    static void Main(string[] args)
    {
        Maze maze = new Maze();
        maze.printBoard();
        Console.WriteLine(maze.patrol());
    }
}
