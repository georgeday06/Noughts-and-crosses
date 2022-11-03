string[,] board = { {"-","-","-"},
                    {"-","-","-"},
                    {"-","-","-"} };

bool Turn = true;
bool gamerunning = true;
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
        bool okaygame = UpdateBoard(board, row, col, symbol);
        while (Turn == true)
        {
            if (okaygame == true)
            {
                Turn = false;
            }
            else if (okaygame == false)
            {
                Turn = true;
                Console.WriteLine();
                Console.WriteLine("Enter your row:");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Column:");
                col = Convert.ToInt32(Console.ReadLine());
                symbol = "x";
                okaygame = UpdateBoard(board, row, col, symbol);
            }
        }
    }
    else if (Turn == false)
    {
        symbol = "0";
        bool okaygame = UpdateBoard(board, row, col, symbol);
        while (Turn == false)
        {
            if (okaygame == true)
            {
                Turn = true;
            }
            else
            {
                Turn = false;
                Console.WriteLine();
                Console.WriteLine("Enter your row:");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Column:");
                col = Convert.ToInt32(Console.ReadLine());
                symbol = "0";
                okaygame = UpdateBoard(board, row, col, symbol);
            }
        }
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

static bool UpdateBoard(string[,] b, int row, int col, string symbol)
{
    bool okaygame = true;
    if (b[row, col] == "x")
    {
        Console.Clear();
        PrintBoard(b);
        Console.WriteLine("Please play a slot that is not taken.");
        okaygame = false;
        
    }
    else if (b[row, col] == "0")
    {
        Console.Clear();
        PrintBoard(b);
        Console.WriteLine("Please play a slot that is not taken.");
        okaygame = false;
    }
    else
    {
        b[row, col] = symbol;
    }
    return okaygame;
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