// Задача 64: 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//Ввод данных 
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);

}

//Вывод натуральных чисел от N до 1 с использованием рекурсии
string LineGenRec(int num)
{
    if (num == 0) return string.Empty;
    else
    {
        string outLine = num + " " + LineGenRec(num - 1);
        return outLine;
    }

}

int num = ReadData("input: ");
PrintResult(LineGenRec(num));