// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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

//Вычисление координаты X точки пересечения двух прямых 
double CrossPointX(double K1, double B1, double K2, double B2)
{
    double X = (B2 - B1) / (K1 - K2);
    return X;
}

//Вычисление координаты Y точки пересечения двух прямых 
double CrossPointY(double K, double B, double X)
{
    double Y = K * X + B;
    return Y;
}

//Расчет площади треугольника
double TriangleSquars(double X1, double Y1, double X2, double Y2, double X3, double Y3)
{
    double SideLength1 = Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2));
    double SideLength2 = Math.Sqrt(Math.Pow((X3 - X2), 2) + Math.Pow((Y3 - Y2), 2));
    double SideLength3 = Math.Sqrt(Math.Pow((X3 - X1), 2) + Math.Pow((Y3 - Y1), 2));
    double p = (SideLength1 + SideLength2 + SideLength3) / 2;
    double Square = Math.Sqrt(p * (p - SideLength1) * (p - SideLength2) * (p - SideLength3));
    return Square;
}

double K1 = ReadData("input K1:");
double B1 = ReadData("input B1:");
double K2 = ReadData("input K2:");
double B2 = ReadData("input B2:");
double K3 = ReadData("input K3:");
double B3 = ReadData("input B3:");

double X1 = CrossPointX(K1, B1, K2, B2);
double Y1 = CrossPointY(K1, B1, X1);

double X2 = CrossPointX(K2, B2, K3, B3);
double Y2 = CrossPointY(K2, B2, X2);

double X3 = CrossPointX(K1, B1, K3, B3);
double Y3 = CrossPointY(K1, B1, X3);


PrintResult("Answer: " + TriangleSquars(X1, Y1, X2, Y2, X3, Y3));