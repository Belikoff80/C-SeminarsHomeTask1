// Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//Объявим функцию для вывода максимального числа:
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//Выделяем объем памяти (под указанный тип данных) для ввода с клавиатуры

string? num1Input = Console.ReadLine();
string? num2Input = Console.ReadLine();
string? num3Input = Console.ReadLine();

//Проверка на не равенство нулю

if (num1Input != null && num2Input != null && num3Input != null)

{

    //изменяем тип данных со строковых на целые числа
    int num1 = int.Parse(num1Input);
    int num2 = int.Parse(num2Input);
    int num3 = int.Parse(num3Input);

    //Запускаем функции
    int max = Max(num1, num2, num3);


    //выводим результа
    Console.WriteLine(num1Input + ", " + num2Input + ", " + num3Input + " --> " + "Максимальное число =" + " " + max);

}
