using MyUtilities;
class Maze { 
    int startX;
    int startY;
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
    }
    void printBoard(char[,] board)
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

    int patrol(int startX, int startY)
    {
        Console.WriteLine(startY);
        Console.WriteLine(startX);
        return 0;
    } 
    static void Main(string[] args)
    {
        
    }
}
printBoard(board);
Console.WriteLine(patrol(startX, startY));