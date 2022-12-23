// №50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.  
// Например, задан массив:  
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет 
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру 


//Ввод данных
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Заполнение массива числами Фабиначи
int[,] Gen2DArrayFabin(int row, int col)
{

    int first = 0;
    int last = 1;

    int[,] arr2D = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (i == 0 && j == 0) arr2D[i, j] = 0;
            else
            {
                arr2D[i, j] = first + last;
                first = last;
                last = arr2D[i, j];
            }
        }
    }

    return arr2D;
}

//Печать массива стандартным цветом
void Print2dArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write(matrix[i, j] + " ");
            Console.Write(matrix[i, j] + "     |".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

//Печать массива не стандартными цветами с выделением искомого числа
void Print2dArrayColor(int[,] matrix, int Num)
{
    ConsoleColor col1 = ConsoleColor.DarkRed;
    ConsoleColor col2 = ConsoleColor.DarkBlue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != Num)
            {
                Console.ForegroundColor = col1;
                //Console.Write(matrix[i, j] + " ");
                Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
                Console.ResetColor();
                Console.Write("|");
            }
            else
            {
                Console.ForegroundColor = col2;
                //Console.Write(matrix[i, j] + " ");
                Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
                Console.ResetColor();
                Console.Write("|");
            }
        }
        Console.WriteLine();
    }
}

//Тест на нахождение в массиве заданного числа
string Test2DArrFabinNum(int[,] matrix, int Num)
{
    string Answer = "Нет такого числа в матрице: ";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == Num)
            {
                Answer = "Есть такое число в матрице: ";
                break;
            }

        }
    }
    return Answer;
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int FabNum = ReadData("Введите искомое число: ");
int[,] arr2D = Gen2DArrayFabin(row, column);
Console.WriteLine("Матрица чисел Фабиначи: ");
Print2dArray(arr2D);
Console.WriteLine();
Console.WriteLine(Test2DArrFabinNum(arr2D, FabNum));
Print2dArrayColor(arr2D, FabNum);