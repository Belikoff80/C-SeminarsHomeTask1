//list of names, separate, choose some randomly

//ввод строковых данных
string ReadData(string line)
{
    Console.Write(line);
    string name = (Console.ReadLine() ?? "0");
    return name;
}
// перевод введенных данных в целочисленные
int ReadDataStrToDig(string line)
{
    Console.Write(line);
    string name = (Console.ReadLine() ?? "0");
    int outputInDig = int.Parse(name);
    return outputInDig;
}
//заполнение массива
string[] FillArray(string[] arr)
{

    int i = 0;
    int length = arr.Length;
    while (i < (length))
    {
        string? userName = ReadData("Input name: ");
        arr[i] = new(userName);
        i++;
    }
    return arr.ToArray();
}
//выбор случайной позиции в массиве
string ChooseRandName(string[] arr, int range)
{
    int randName = new Random().Next(0, (range));
    return (arr[randName]);
}
//вывод результатов
void PrintResult(string line)
{
    Console.WriteLine(line);
}
//определеие длины списка
int lenList = ReadDataStrToDig("Input length of the name list: ");
//создание пустого массива
string[] userName = new string[lenList];
//заполнение массива 
string[] choiseName = FillArray(userName);
//результат
PrintResult("Random name output = " + ChooseRandName(choiseName, lenList));

