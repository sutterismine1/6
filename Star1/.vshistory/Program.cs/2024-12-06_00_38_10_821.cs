﻿using MyUtilities;
class Maze { 
    int startX;
    int startY;
    int xLowerBound;
    int yLowerBound;
    int xUpperBound;
    int yUpperBound;
    char[] directions = ['u', 'r', 'd', 'l'];
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
            return 0;
        }
        if (board[y,x] == '#')
        {
            int nextDirection = Array.IndexOf(directions, direction) + 1;
            if (nextDirection > 3)
            {
                nextDirection = 0;
            }
            direction = ;
        }
        if (direction == 'u')
        {
            return patrolRec(x, y - 1, direction) + 1;
        }
        else if (direction == 'r')
        {
            return patrolRec(x, y)
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
    }
}