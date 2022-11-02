string[,] board = { {"_","_","_"},
                    {"_","_","_"},
                    {"_","_","_"} };

PrintBoard(board);
Console.WriteLine();
Console.WriteLine("Enter your row:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Column:");
int col = Convert.ToInt32(Console.ReadLine());


UpdateBoard(board, row, col);
PrintBoard(board);

static void PrintBoard(string[,] b)
{
    Console.WriteLine("   0 1 2");
    Console.WriteLine("   -----");
    for (int row = 0; row < 3; row++)
    {
        Console.Write("{0}| ", row);
        for (int col = 0; col < 3; col++)
        {
            Console.Write(b[row, col] + " ");
        }
        Console.WriteLine();
    }
}

static void UpdateBoard(string[,] b, int row, int col)
{
    b[row, col] = "x";
}

