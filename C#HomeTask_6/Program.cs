// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

//Объявим функцию с 2мя аргументами(число, цифра от начала в числе) для определения любого числа в цифре:
int Digit_Num(string number, string DigitOfNum)
{
    int num_length = number.Length; //вычеслим строковую длину значения переменной
    int number_d = int.Parse(number); //переведем формат переменной в числовой
    int DigitOfNum_d = int.Parse(DigitOfNum);////переведем формат переменной в числовой

    int result = 0;

    if (num_length < DigitOfNum_d) result = (num_length - DigitOfNum_d);
    if (num_length >= DigitOfNum_d) result = (number_d / (int)Math.Pow(10, num_length - DigitOfNum_d)) % 10; //формула для вычисления конкретной цифры числа

    return result;
}
//Выделяем объем памяти (под указанный тип данных) 
//для ввода с клавиатуры
Console.Write("Input a number: ");
string? numInput = Console.ReadLine();
Console.Write("Input the index of digit you wonna get: ");
string? digitInput = Console.ReadLine();
//Проверка на не равенство нулю
if (numInput != null && digitInput != null)
{
    //Вывод цифры если индекс есть в числе
    if (Digit_Num(numInput, digitInput) >= 0) Console.WriteLine(numInput + " -> " + Digit_Num(numInput, digitInput));
    //Вывод результата если индекс отсутствует в числе
    if (Digit_Num(numInput, digitInput) < 0) Console.WriteLine("The " + digitInput + "-th digit is absent");
}