// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


void cub_pow(int number)
{
    double result = 1;
    string cub_arrow = String.Empty;
    for (int i = 1; i < number + 1; i++)
    {
        if (i < number)
        {
            result = (Math.Pow(i, 3));
            cub_arrow = cub_arrow + result + ",";
        }
        else
        {
            result = (Math.Pow(i, 3));
            cub_arrow = cub_arrow + result + ".";
        }
    }
    Console.Write(cub_arrow);
}

int num = ReadData("Введите заданое число:");

//PrintData(cub_pow(num));
cub_pow(num);