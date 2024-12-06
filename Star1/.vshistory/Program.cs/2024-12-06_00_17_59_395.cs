using MyUtilities;
string cwd = "../../../../"; 
string[] contents = File.ReadAllLines(cwd + "sample.txt");
char[,] board = new char[contents.Length,contents[0].Length];
int startX;
int startY;
foreach (var (index, value) in contents.Enumerate())
{
    for (int i = 0; i < value.Length; i++) {
        char symbol = value.ToCharArray()[i];
        board[index, i] = symbol;
        if(symbol == '^') { 
            startX = i;
            startY = index;
        }
    }
}
static void printBoard(char[,] board)
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

static int patrol()
{

    return 0;
} 

printBoard(board);
Console.WriteLine(patrol());