﻿using MyUtilities;
string cwd = "../../../../"; 
string[] contents = File.ReadAllLines(cwd + "sample.txt");
char[,] board = new char[contents.Length,contents[0].Length];
foreach (var (index, value) in contents.Enumerate())
{
    for (int i = 0; i < value.Length; i++) { 
        board[index,i] = char.Parse(value[i]); 
    }
}