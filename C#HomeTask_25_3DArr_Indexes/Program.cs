// Задача 60. 
// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)


//Ввод данных
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Заполнение 3ёх мерного массива числами 
double[,,] Gen3DArray(int row, int col, int wid, int lowRange, int upRange)
{
    Random rnd = new Random();

    double[,,] arr3D = new double[row, col, wid];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < wid; k++)
            {
                arr3D[i, j, k] = rnd.Next(lowRange, upRange + 1) + Math.Round(rnd.NextDouble(), 0);
            }

        }
    }

    return arr3D;
}

//Печать массива в стандартных цветах
void Print3DArray(string line, double[,,] matrix)
{
    Console.WriteLine(line); int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.WriteLine("Depth = " + count);
        count++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + "  (".Substring(matrix[i, j, k].ToString().Length) + i + ", " + j + ", " + k + ")  |");
            }

            Console.WriteLine();
        }


    }



}


int row = ReadData("Input depth: ");
int col = ReadData("Input row: ");
int wid = ReadData("Input col: ");

double[,,] arr1 = Gen3DArray(row, col, wid, 1, 10);

Print3DArray("3D matrix:", arr1);





