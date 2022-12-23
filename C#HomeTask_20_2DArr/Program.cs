
// Задача 47. 
//Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5   7    -2   -0,2
// 1    -3,3   8   -9,9
// 8     7,8  -7,1  9

//Ввод данных
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Заполнение массива вещественными числами с округлением до 2ух знаков после запятой
double[,] Gen2DDoubArray(int row, int col, int lowRange, int upRange)
{
    Random rnd = new Random();
    double[,] arr2D = new double[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr2D[i, j] = rnd.Next(lowRange, upRange + 1) + Math.Round(rnd.NextDouble(), 2);
        }
    }

    return arr2D;
}

//Печать массива
void Print2dArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write(matrix[i, j] + " ");
            Console.Write(matrix[i, j] + "      |".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}


void Print2dArrayColor(double[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow,ConsoleColor.DarkGray,
    ConsoleColor.Blue,ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.DarkBlue,
    ConsoleColor.White, ConsoleColor.DarkCyan, ConsoleColor.DarkYellow, ConsoleColor.DarkGray,
    ConsoleColor.DarkRed, ConsoleColor.DarkGreen, ConsoleColor.White, ConsoleColor.Magenta,};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            //Console.Write(matrix[i, j] + " ");
            Console.Write(matrix[i, j] + "      ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
            Console.Write("|");
        }
        Console.WriteLine();
    }
}
int row = ReadData("input rows: ");
int column = ReadData("input columns: ");
double[,] arr2D = Gen2DDoubArray(row, column, 1, 99);
Print2dArray(arr2D);
Console.WriteLine();
Print2dArrayColor(arr2D);