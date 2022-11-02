string[,] board = { {"_","_","_"},
                    {"_","_","_"},
                    {"_","_","_"} };

bool Finished = false;
bool Turn = true;
string symbol = "a";
PrintBoard(board);


while (Finished == false)
{
    Console.WriteLine();
    Console.WriteLine("Enter your row:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your Column:");
    int col = Convert.ToInt32(Console.ReadLine());
    if (Turn == true)
    {
        symbol = "x";
        UpdateBoard(board, row, col, symbol);
        Turn = false;
    }
    else if (Turn == false)
    {
        symbol = "0";
        UpdateBoard(board, row, col, symbol);
        Turn = true;
    }
    PrintBoard(board);
}
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

static void UpdateBoard(string[,] b, int row, int col, string symbol)
{
    b[row, col] = symbol;
}

