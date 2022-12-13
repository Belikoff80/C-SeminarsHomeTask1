// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Считывание данных формате String
string ReadData(string line)
{
    Console.Write(line);
    string numberStr = (Console.ReadLine() ?? "0");
    return numberStr;
}

//Перевод введенных данных в формат Int
int ReadDataStrToDig(string inputInString)
{
    int outputInDig = int.Parse(inputInString);
    return outputInDig;
}

//Вывод данных
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Расчет с использованием цикла WHILE
int numDigSum(int num)
{
    int res = 0;
    while (num > 0)
    {
        int last_digit = num % 10;
        res += last_digit;
        num /= 10;
    }
    return res;
}

//Расчет с использованием ToCharArray
int numDigSum2(string digit)
{
    char[] digArr = digit.ToCharArray();
    int len = digArr.Length;
    int res = 0;
    for (int i = 0; i < len; i++)
    {
        int digArrD = digArr[i] - '0';
        res += digArrD;
    }
    return res;
}

//Ввод данных пользователем
string num = ReadData("input number for calculation: ");
int number = ReadDataStrToDig(num);

//Расчет времени с использованием While
DateTime d1 = DateTime.Now;
int digSumWhile = numDigSum(number);
Console.WriteLine("Время с использование цикла While: " + (DateTime.Now - d1));

//Расчет времени с использованием ToCharArray
DateTime d2 = DateTime.Now;
int digSumToCharArr = numDigSum2(num);
Console.WriteLine("Время с использование ToCharArray: " + (DateTime.Now - d2));

//вывод ответа
PrintResult("Answer for digit sum method While: " + numDigSum(number));
PrintResult("Answer for digit sum method TOCharArray: " + numDigSum2(num));

//Вывод: в данных условиях метод с циклом While работает в 40 раз медленнее