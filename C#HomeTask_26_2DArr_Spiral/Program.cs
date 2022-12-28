
//Ввод данных
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Заполнение 2у мерного массива числами по спирали
int[,] Gen2DSpirArray(int row, int col)
{

    int[,] arr2D = new int[row, col];
    int count = 0;
    int startI = 0;
    int startJ = 0;
    int finI = row - 1;
    int finJ = col - 1;

    for (int j = startJ; j < finJ + 1; j++)
    {
        int i = startI;
        arr2D[i, j] = count;
        count++;
    }
    startI++;
    for (int i = startI; i < finI + 1; i++)
    {
        int j = finJ;
        arr2D[i, j] = count;
        count++;
    }


    finJ--;

    while (count < col * row)
    {




        for (int j = finJ; j > startJ - 1; j--)

        {
            if (count < col * row)
            {
                int i = finI;
                arr2D[i, j] = count;
                count++;
            }
            else
            {
                break;
            }
        }

        finI--;


        for (int i = finI; i > startI - 1; i--)
        {
            if (count < col * row)
            {
                int j = startJ;
                arr2D[i, j] = count;
                count++;
            }
            else
            {
                break;
            }
        }

        startJ++;


        for (int j = startJ; j < finJ + 1; j++)
        {
            if (count < col * row)
            {
                int i = startI;
                arr2D[i, j] = count;
                count++;
            }
            else
            {
                break;
            }
        }

        startI++;
        {


            for (int i = startI; i < finI + 1; i++)
            {
                if (count < col * row)
                {
                    int j = finJ;
                    arr2D[i, j] = count;
                    count++;
                }
                else
                {
                    break;
                }
            }

            finJ--;
        }


    }
    return arr2D;
}

//Печать массива в стандартных цветах
void Print2DArray(string line, int[,] matrix)
{
    Console.WriteLine(line);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write(matrix[i, j] + "  (".Substring(matrix[i, j].ToString().Length) + i + ", " + j + ") |");


        }
        Console.WriteLine();


    }



}


int row = ReadData("Input row: ");
int col = ReadData("Input col: ");


int[,] arr1 = Gen2DSpirArray(row, col);

Print2DArray("2D matrix with spiral filling in:", arr1);