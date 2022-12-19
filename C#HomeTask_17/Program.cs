// Задача 38: 
// 1.Задайте массив вещественных чисел. 
// 2.Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//заполнение массива вещественными числами с округлением до 2ух знаков после запятой
double[] GenArray(int num, int lowRange, int upRange)
{
    Random rnd = new Random();
    double[] arr = new double[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(lowRange, upRange) + Math.Round(rnd.NextDouble(), 2);
    }

    return arr;
}
//заполнение массива целыми числами для исследования методов сортировки
int[] GenArray2(int num, int lowRange, int upRange)
{
    Random rnd = new Random();
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(lowRange, upRange);
    }

    return arr;
}

//вывод на печать массива с вещественными числами
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",  ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
//вывод на печать массива с целыми числами
void PrintArray2(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",  ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//вычисление разности максимального и минимального значения в массиве. Округление до 2ух знаков после запятой
double MinMaxDif(double min, double max, double[] arr)
{
    for (int i = 0; i < arr.Length; i += 1)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return Math.Round((max - min), 2);
}

//вывод на печать результатов вычисления 
void PrintResult(double res)
{
    Console.WriteLine(res);
}

//3 метода сортировки:

//1. сортировка массива методом перебора
int[] SelectionSort(int[] array)  //method for sorting of Array
{
    for (int i = 0; i < array.Length - 1; i++) // so as we count cycle j=i+1, therefore cycle will be less than length
    {
        int minPosition = i;
        //futher we are looking for min elements:
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        //ad we replace found elements
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}
//2. сортировка массива пузырьком
int[] SortCountBubbleArrays(int[] array)
{
    int temp = 0;
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
            }
            else
            {
                i++;
            }
        }
    }
    return array;
}
//3. Сортировка методом подсчета
string SortCountMethod(int[] array)
{
    string arrayCount = string.Empty;
    int MaxValue = array[0];
    int MinValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (MaxValue <= array[i]) MaxValue = array[i];
        if (MinValue > array[i]) MinValue = array[i];
    }


    for (int i = MinValue; i < MaxValue + 1; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {

            if (i == array[j])
            {
                arrayCount = arrayCount + (array[j] + " ");
            }
        }
    }
    return arrayCount;
}

//Вычисление разницы между Min и Max выщественными значениями элементов массива
double MaxValue = 0;
double MinValue = 10;
double[] array = GenArray(10, 1, 10);
Console.WriteLine("заполненный массив: ");
PrintArray(array);
Console.WriteLine("Разность максимального и минимального значения массива: ");
PrintResult(MinMaxDif(MinValue, MaxValue, array));


//расчет времени сортировки 3 способами:

//Создаем целочисленный массив 
int[] array2 = GenArray2(5, 1, 10);
PrintArray2(array2);


Console.WriteLine("Сортировка массива методом перебора: ");
DateTime d = DateTime.Now;
PrintArray2(SelectionSort(array2));
Console.WriteLine("Время с использованием ПЕРЕБОРА: " + (DateTime.Now - d));
Console.WriteLine("Сортировка массива методом пузырька: ");
DateTime d1 = DateTime.Now;
PrintArray2(SortCountBubbleArrays(array2));
Console.WriteLine("Время с использованием ПЕРЕБОРА: " + (DateTime.Now - d1));
Console.WriteLine("Сортировка массива методом подсчета: ");
DateTime d2 = DateTime.Now;
Console.WriteLine(SortCountMethod(array2));
Console.WriteLine("Время с использованием ПЕРЕБОРА: " + (DateTime.Now - d2));








// array[i] = rand.Next(minValue, maxValue) + rand.NextDouble();
// От Olga Kuzmina всем 08:45 PM
// rnd.Next(minValue, maxValue) + rnd.NextDouble()

// array[i] =
// От Olga Kuzmina всем 08:45 PM
// rnd.Next(minValue, maxValue) +rnd.NextDouble()
// От 1 Пят Вит 1 всем 08:46 PM
// нашел в инете
// От Никита всем 08:46 PM
// //Метод генерации массива
// double[] GenArray(int len)
// {
//     double[] arr = new double[len];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-100, 100) + new Random().NextDouble();
//     }
//     return arr;
// }
// От oksanaalhimovic всем 08:46 PM
// outArray[i] = new Random().Next(minValue, maxValue) / 10.0;
