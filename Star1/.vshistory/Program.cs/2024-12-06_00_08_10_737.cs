using MyUtilities;
string cwd = "../../../../"; 
string[] contents = File.ReadAllLines(cwd + "input.txt");
char[,] board = new char[contents.Length,contents[0].Length];
foreach (var (index, value) in contents.Enumerate())
{
    Console.WriteLine($"Index: {index}, Value: {value}");
}