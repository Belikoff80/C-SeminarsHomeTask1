// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,

// метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//вводим данные 
int xh = ReadData("Введите xh: ");
int xv = ReadData("Введите xv: ");
int yh = ReadData("Введите yh: ");
int yv = ReadData("Введите yv: ");
int zh = ReadData("Введите zh: ");
int zv = ReadData("Введите zv: ");

//метод расчета длины в 3D
double CalculateLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return Math.Round(res, 2);
}

//метод вывода данных
void PrintData(string msg, double result)
{
    Console.WriteLine(msg + result);
}

//вывод данных
PrintData("Расстояние между точками ", CalculateLength(xh, yh, zh, xv, yv, zv));