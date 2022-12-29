// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


//Ввод данных 
int ReadData(string line)
{
    //output msg 
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}
//Вывод результата
void PrintResult(string line, int N)
{
    Console.WriteLine(line + N);


}
//Вывод суммы натуральных чисел в диапозоне от N до M с использованием рекурсии
int RecAccerman(int N, int M)
{
    if (N == 0)
        return M + 1;
    else
      if ((N != 0) && (M == 0))
        return RecAccerman(N - 1, 1);
    else
        return RecAccerman(N - 1, RecAccerman(N, M - 1));
}

int N = ReadData("input N: ");
int M = ReadData("input M: ");
int result = RecAccerman(N, M);
PrintResult("RESULT: ", result);

