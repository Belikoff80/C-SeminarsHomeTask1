// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Считывание данных
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

//Выод данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Расчет с использованием Math.Pow
double numInPow1(int num, int deg)
{
    double res = Math.Pow(num, deg);
    return res;
}

//Расчет с использованием FOR
int numInPow2(int num, int deg)
{
    int res = 1;
    for (int i = 0; i < deg; i++)
    {
        res *= num;
    }
    return res;

}

int digit = ReadData("input number for calculation: ");
int numPow = ReadData("input digit of degree: ");

//Расчет времени с использованием Math.Pow
DateTime d1 = DateTime.Now;
double digitInPow1 = numInPow1(digit, numPow);
Console.WriteLine(DateTime.Now - d1);

//Расчет времени с использованием FOR
DateTime d2 = DateTime.Now;
int digitInPow2 = numInPow2(digit, numPow);
Console.WriteLine(DateTime.Now - d2);

PrintResult("AnswerPow: " + digitInPow1);
PrintResult("Answer_Cyc: " + digitInPow2);

//в данной задаче использование цикла FOR увеличивает скорость операции в 40 раз

