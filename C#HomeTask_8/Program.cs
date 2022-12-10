// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//метод делит строку на 2 равные части и сравнивает их.
void Poli_num(string digit)
{
    int length = (digit.Length);
    int count = 0;
    for (int i = 0; i < length / 2; i++)
    {
        if (digit[i] != digit[length - 1 - i]) break;
        else count++;
    }
    Console.WriteLine(count == length / 2);
}

//метод разворачивает строку и сравнивает новую строку с источником
void Poli_num2(string digit)
{
    int length = (digit.Length);
    string result = String.Empty;
    for (int i = (length - 1); i > -1; i--)
    {
        result = result + $"{digit[i]}";
    }
    Console.WriteLine(digit == result);
}


string? num = Console.ReadLine();

if (num != null)
{
    Poli_num(num);
    Poli_num2(num);
}