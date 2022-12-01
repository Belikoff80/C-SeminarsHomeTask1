﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

//Объявим функцию для определения четности не четности числа:
string EvenNum(int arg)
{
    string result = "_";
    if (arg % 2 == 0) result = "Число четное";
    if (arg % 2 != 0) result = "Число не четное";
    return result;
}

//Выделяем объем памяти (под указанный тип данных) 
//для ввода с клавиатуры

string? numInput = Console.ReadLine();

//Проверка на не равенство нулю

if (numInput != null)
{
    //изменяем тип данных со строковых на целые числа
    int num = int.Parse(numInput);

    //Запускаем функцию
    string Even = EvenNum(num);

    //выводим результа
    Console.WriteLine(numInput + "-->" + Even);
}