// Задача 38: 
// 1.Задайте массив вещественных чисел. 
// 2.Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//заполнение массива
double[] GenArray(int num, double lowRange, double upRange)
{
    Random rnd = new Random();
    double[] arr = new double[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble();
    }

    return arr;
}

//вывод на печать массива
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//вычисление разности максимального и минимального значения
double MinMaxDif(double min, double max, double[] arr)
{
    for (int i = 0; i < arr.Length; i += 1)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return (max - min);
}

//вывод на печать результатов вычисления 
void PrintResult(double res)
{
    Console.WriteLine(res);
}

double MaxValue = 0;
double MinValue = 10;
double[] array = GenArray(10, 1, 10);
Console.WriteLine("заполненный массив: ");
PrintArray(array);
Console.WriteLine("Разность максимального и минимального значения массива: ");
PrintResult(MinMaxDif(MinValue, MaxValue, array));


