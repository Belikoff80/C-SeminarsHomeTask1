// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// // ввод данных
// string ReadData(string line)
// {
//     Console.Write(line);
//     string name = (Console.ReadLine() ?? "0");
//     return name;
// }

// перевод введенных данных в целочисленные
int ReadDataStrToDig(string line)
{
    Console.Write(line);
    string name = (Console.ReadLine() ?? "0");
    int outputInDig = int.Parse(name);
    return outputInDig;
}

//Подсчет положительных введенных с клавиатуры цифр
int CountPossitiveNum(int num)
{

    int res = 0;

    while (num >= 1)
    {
        if (ReadDataStrToDig("Input digit: ") > 0) res++;
        num = num - 1;
    }
    return res;
}

//вывод результатов
void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Извините,устал переделывать код из питона в с#.
// Если так можно, то задачу '*' выполнил в питоне 
// void CountPossitiveNum2(string line)
// {
//     string InputUserString = ReadData("Input text: ");
//     string StringOfDigits = string.Empty;
//     string[] Result = new string[InputUserString.Length];
//     string[] Nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
//     for (int i = 0; i < InputUserString.Length; i++)
//     {
//         if (InputUserString[i] in Nums) StringOfDigits += InputUserString[i];

//         if (InputUserString[i] == '-') StringOfDigits += ',' + InputUserString[i];

//         else:
//         {
//             StringOfDigits += ',';
// }
//     StringClearing = list(((i) for i in StringOfDigits.split(',') ))
//         }
//     }
//     for i in range(len(StringClearing)):
//         if StringClearing[i] == '':
//             i += 1
//         elif StringClearing[i] == '-':
//             i += 1
//         else:
//             StringClearing[i] = int(StringClearing[i])
//             Result.append(StringClearing[i])

//     return (Result)
// }

int Num = ReadDataStrToDig("Input number of digits:");
PrintResult("Answer:" + CountPossitiveNum(Num));