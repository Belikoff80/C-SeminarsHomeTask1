// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

//Объявим 2 функции для вывода максимального и минимального числа:
int Max(int arg1, int arg2)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    return result;
}

int Min(int arg1, int arg2)
{
    int result = arg1;
    if (arg2 < result) result = arg2;
    return result;
}

//Выделяем объем памяти (под указанный тип данных) для ввода с клавиатуры

string? num1Input = Console.ReadLine();
string? num2Input = Console.ReadLine();

//Проверка на не равенство нулю

if (num1Input != null && num2Input != null)

{

    //изменяем тип данных со строковых на целые числа
    int num1 = int.Parse(num1Input);
    int num2 = int.Parse(num2Input);

    //Запускаем функции
    int max = Max(num1, num2);
    int min = Min(num1, num2);

    //выводим результ
    Console.WriteLine("a = " + num1 + " b = " + num2 + " --> max " + max);
    Console.WriteLine("a = " + num1 + " b = " + num2 + " --> min " + min);
}