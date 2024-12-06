using MyUtilities;
class Maze { 
    int startX;
    int startY;
    string cwd = "../../../../";
    string[] contents;
    char[,] board;
    public Maze()
    {

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