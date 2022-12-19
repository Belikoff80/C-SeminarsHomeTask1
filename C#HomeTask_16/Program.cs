// Задача 36: 
// 1.Задайте одномерный массив, заполненный случайными числами. 
// 2.Найдите сумму элементов, стоящих на нечётных позициях.
// 3.Вывести все пары массива
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//заполнение массива
int[] GenArray(int num, int lowRange, int upRange)
{
    Random rnd = new Random();
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(lowRange, upRange + 1);
    }

    return arr;
}

//вывод на печать массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//вычисление суммы элементов с нечетным индексом 
int OddIndexSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}

//вывод на печать результатов вычисления 
void PrintResult(int res)
{
    Console.WriteLine(res);
}

//сортировка массива
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

//поиск пар элеметов
string PairCollection(int[] array)
{
    int count = 0;
    string pair = String.Empty;
    for (int i = 0; (i + 1) < (array.Length); i++)
    {
        if (array[i] == array[i + 1])
        {
            count += 1;
            pair = pair + (count + ". " + array[i] + "--" + array[i + 1] + "||");
            i += 2;
        }
        else
        {
            i += 1;
        }


    }
    return pair;
}


int[] array = GenArray(10, 1, 10);

Console.WriteLine("заполненный массив: ");
PrintArray(array);
Console.WriteLine("Сумма элементов массива с нечетным индексом: ");
PrintResult(OddIndexSum(array));

Console.WriteLine("сортированный массив: ");
PrintArray(SelectionSort(array));
int[] SortedArray = SelectionSort(array);

Console.WriteLine("пары элементов: ");
Console.WriteLine(PairCollection(SortedArray));

