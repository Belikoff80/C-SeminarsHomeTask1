// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


//Ввод данных
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Заполнение массива числами 
double[,] Gen2DArray(int row, int col, int lowRange, int upRange)
{
    Random rnd = new Random();

    double[,] arr2D = new double[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr2D[i, j] = rnd.Next(lowRange, upRange + 1) + Math.Round(rnd.NextDouble(), 0);
        }
    }

    return arr2D;
}

//Печать массива в стандартных цветах
void Print2DArray(string line, double[,] matrix)
{
    Console.WriteLine(line);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write(matrix[i, j] + " |");

            Console.Write(matrix[i, j] + "    |".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }


}

// Метод перемножения матриц с условием (число столбцов 1ой матрицы равно числу строк 2ой матрицы)
double[,] MatrixMultiply(double[,] matrix1, double[,] matrix2)
{
    // кэшируем размеры матриц для лучшей производительности 
    var matrix1Rows = matrix1.GetLength(0);
    var matrix1Cols = matrix1.GetLength(1);
    var matrix2Rows = matrix2.GetLength(0);
    var matrix2Cols = matrix2.GetLength(1);

    // проверяем, совместимы ли матрицы
    if (matrix1Cols != matrix2Rows)
        throw new InvalidOperationException
          ("Матрицы не совместимы. Число столбцов первой матрицы должно быть равно числу строк второй матрицы");

    // создаем пустую результирующую матрицу нужного размера
    double[,] product = new double[matrix1Rows, matrix2Cols];

    // заполняем результирующую матрицу
    // цикл по каждому ряду первой матрицы
    for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++)
    {
        // цикл по каждому столбцу второй матрицы  
        for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++)
        {
            // вычисляем скалярное произведение двух векторов  
            for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++)
            {
                product[matrix1_row, matrix2_col] +=
                  matrix1[matrix1_row, matrix1_col] *
                  matrix2[matrix1_col, matrix2_col];
            }
        }
    }

    return product;
}

int row = ReadData("Input row: ");
int col = ReadData("Input column: ");

double[,] arr1 = Gen2DArray(row, col, 1, 10);

double[,] arr2 = Gen2DArray(row, col, 1, 10);

double[,] ResultMatrix = MatrixMultiply(arr1, arr2);

Print2DArray("1st matrix:", arr1);

Print2DArray("2nd matrix:", arr2);

Print2DArray("Result of matrix muliplication:", ResultMatrix);