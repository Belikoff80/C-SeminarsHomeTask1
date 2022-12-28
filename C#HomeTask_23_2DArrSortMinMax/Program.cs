// Задача 54: 
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Ввод данных
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Заполнение массива числами 
int[,] Gen2DArray(int row, int col, int lowRange, int upRange)
{
    Random rnd = new Random();
    int[,] arr2D = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr2D[i, j] = rnd.Next(lowRange, upRange + 1);
        }
    }

    return arr2D;
}

//Печать массива в стандартных цветах
void Print2DArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + "      |".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

//Печать массива с подкрашенной диоганалью справа налево)
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor col1 = ConsoleColor.Red;
    ConsoleColor col2 = ConsoleColor.Green;
    ConsoleColor col3 = ConsoleColor.Yellow;
    ConsoleColor col4 = ConsoleColor.Blue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i + j) == 0 || (i + j) == 4 || (i + j) == 8 || (i + j) == 12 || (i + j) == 16 || (i + j) == 20) Console.ForegroundColor = col1;
            if ((i + j) == 1 || (i + j) == 5 || (i + j) == 9 || (i + j) == 13 || (i + j) == 17 || (i + j) == 21) Console.ForegroundColor = col2;
            if ((i + j) == 2 || (i + j) == 6 || (i + j) == 10 || (i + j) == 14 || (i + j) == 18 || (i + j) == 22) Console.ForegroundColor = col3;
            if ((i + j) == 3 || (i + j) == 7 || (i + j) == 11 || (i + j) == 15 || (i + j) == 19 || (i + j) == 23) Console.ForegroundColor = col4;

            //Console.Write(matrix[i, j] + " ");
            Console.Write(matrix[i, j] + "      ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
            Console.Write("|");
        }
        Console.WriteLine();
    }
}

//Сортировка одномерного массива
int[] SortCountBubbleArrays(int[] array)
{
    int temp = 0;
    int count = 1;
    while (count != 0)
    {
        count = 0;
        for (int k = 0; k < array.Length; k++)
        {
            for (int i = 0; i + 1 < array.Length; i++)
            {

                if (array[i] > array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    i++;
                    count++;
                }
            }
        }
    }
    return array;
}

//Сортировка строк двумерного массива
int[,] SortedRow2DArray(int[,] matrix)
{
    //int[,] SortedRow2DArray = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] TempRow = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            TempRow[j] = matrix[i, j];

        }
        SortCountBubbleArrays(TempRow);

        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = TempRow[k];
        }

    }
    return matrix;
}


int row = ReadData("input rows: ");
int column = ReadData("input columns: ");
int[,] arr2D = Gen2DArray(row, column, 1, 99);
Print2DArray(arr2D);
Console.WriteLine();
Print2DArrayColor(SortedRow2DArray(arr2D));
