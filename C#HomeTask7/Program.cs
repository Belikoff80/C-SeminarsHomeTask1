// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


//Считываем данные с консоли
Console.Write("Input index of the day: ");
string? inputLine = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine != null)

{
    //Создаем массив с днями недели
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "понедельник";
    dayOfWeek[1] = "вторник";
    dayOfWeek[2] = "среда";
    dayOfWeek[3] = "четверг";
    dayOfWeek[4] = "пятница";
    dayOfWeek[5] = "суббота";
    dayOfWeek[6] = "воскресенье";
    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    if (inputNumber - 1 < 5) Console.WriteLine(dayOfWeek[inputNumber - 1] + "-> Work day");
    if (inputNumber - 1 > 4) Console.WriteLine(dayOfWeek[inputNumber - 1] + "-> Week end");
}