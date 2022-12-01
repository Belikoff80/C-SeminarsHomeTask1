// Задача 8: Напишите программу, которая на вход принимает число 
// (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

string? inputLine = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine != null)
{
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    int startNumber = 1;
    //Выходное значение как строковое значение
    string outLine = string.Empty;
    //запуск цикла с увеличением заданного диапазона +1 
    while (startNumber < inputNumber + 1)
    {
        //условие для вывода четных чисел с запятой
        if (startNumber % 2 == 0 && startNumber < inputNumber)
        {
            outLine = outLine + startNumber + ", ";
        }
        //условие вывода последего четного числа с точкой
        if (startNumber % 2 == 0 && startNumber == inputNumber)
        {
            outLine = outLine + startNumber + ".";
        }

        startNumber++;

    }
    // Выводим данные в консоль
    Console.Write(inputNumber + "-->" + outLine);
}


