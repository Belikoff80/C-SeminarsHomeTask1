// Задача 34: 
// 1.Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// 3.Написать метод сортировки пузырьком

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

//вычисление количества четных элементов массива
int EvenTest(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
            i++;
        }
        else
        {
            i++;
        }
    }
    return count;
}

//вывод на печать результатов вычисления 
void PrintResult(int res)
{
    Console.WriteLine(res);
}

//сортировка массива пузырьком
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
// не могу понять, почему функция работает не правильно. В Python все четко отрабатывает. 

int[] array = GenArray(120, 100, 999);

PrintArray(array);
Console.WriteLine("Количество четных элементов в массиве: ");
PrintResult(EvenTest(array));
Console.WriteLine("Сортированный массив: ");
PrintArray(SortCountBubbleArrays(array));



