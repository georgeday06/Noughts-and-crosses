string[,] board = { {"_","_","_"},
                    {"_","_","_"},
                    {"_","_","_"} };

bool Turn = true;
string symbol = "a";
char Finished = CheckRow(board, symbol);
char Finished1 = CheckDiag(board, symbol);
PrintBoard(board);


while (Finished != 'y' && Finished1 != 'y')
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
    Console.Clear();
    PrintBoard(board);
    CheckRow(board, symbol);
    CheckDiag(board, symbol);
    CheckColumn(board, symbol);

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

static char CheckRow(string[,] b, string symbol)
{
    char complete = 'n';
    if (b[0,0] == "x" && b[0,1] == "x" && b[0,2] == "x")
	{
        Console.WriteLine("Player X wins!");
        Console.ReadLine();
    }
    else if (b[0,0] == "0" && b[0,1] == "0" && b[0,2] == "0")
	{
        Console.WriteLine("Player 0 wins");
        Console.ReadLine();
    }
    else
	{
        Console.Write("");
	}

    if (b[1, 0] == "x" && b[1, 1] == "x" && b[1, 2] == "x")
    {
        Console.WriteLine("Player X wins!");
        Console.ReadLine();
    }
    else if (b[1, 0] == "0" && b[1, 1] == "0" && b[1, 2] == "0")
    {
        Console.WriteLine("Player 0 wins");
        Console.ReadLine();
    }
    else
    {
        Console.Write("");
    }

    if (b[2, 0] == "x" && b[2, 1] == "x" && b[2, 2] == "x")
    {
        Console.WriteLine("Player X wins!");
        Console.ReadLine();
    }
    else if (b[2, 0] == "0" && b[2, 1] == "0" && b[2, 2] == "0")
    {
        Console.WriteLine("Player 0 wins");
        Console.ReadLine();
    }
    else
    {
        Console.Write("");
    }

    return complete;
}

static char CheckDiag(string[,] b, string symbol)
{
    char complete = 'n';
    if (b[0, 0] == "x" && b[1, 1] == "x" && b[2, 2] == "x")
    {
        Console.WriteLine("Player X wins!");
        Console.ReadLine();
    }
    else if (b[0, 0] == "0" && b[1, 1] == "0" && b[2, 2] == "0")
    {
        Console.WriteLine("Player 0 wins");
        Console.ReadLine();
    }
    else
    {
        Console.Write("");
    }

    if (b[2, 0] == "x" && b[1, 1] == "x" && b[0, 2] == "x")
    {
        Console.WriteLine("Player X wins!");
        Console.ReadLine();
    }
    else if (b[2, 0] == "0" && b[1, 1] == "0" && b[0, 2] == "0")
    {
        Console.WriteLine("Player 0 wins");
        Console.ReadLine();
    }
    else
    {
        Console.Write("");
    }

    if (b[2, 2] == "x" && b[1, 1] == "x" && b[0, 0] == "x")
    {
        Console.WriteLine("Player X wins!");
        Console.ReadLine();
    }
    else if (b[2, 0] == "0" && b[1, 1] == "0" && b[0, 2] == "0")
    {
        Console.WriteLine("Player 0 wins");
        Console.ReadLine();
    }
    else
    {
        Console.Write("");
    }

    return complete;

}

static char CheckColumn(string[,] b, string symbol)
{
    char complete = 'n';
    if (b[0, 0] == "x" && b[1, 0] == "x" && b[2, 0] == "x")
    {
        Console.WriteLine("Player X wins!");
        Console.ReadLine();
    }
    else if (b[0, 0] == "0" && b[1, 0] == "0" && b[2, 0] == "0")
    {
        Console.WriteLine("Player 0 wins");
        Console.ReadLine();
    }
    else
    {
        Console.Write("");
    }

    if (b[0, 1] == "x" && b[1, 1] == "x" && b[2, 1] == "x")
    {
        Console.WriteLine("Player X wins!");
        Console.ReadLine();
    }
    else if (b[0, 2] == "0" && b[1, 2] == "0" && b[2, 2] == "0")
    {
        Console.WriteLine("Player 0 wins");
        Console.ReadLine();
    }
    else
    {
        Console.Write("");
    }

    return complete;

}