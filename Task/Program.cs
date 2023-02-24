
Console.WriteLine("Введите количество строк:");
int Line = Convert.ToInt32(Console.ReadLine());
string[] UserArray = CreateArraeString(Line);



string[] CreateArraeString(int line)
{
    string[] arr = new string [line];
    for (int i = 0; i < line; i++)
    {
        Console.WriteLine("Введите строку: ");
        arr[i] = Console.ReadLine()!;
        

    }
    return arr;
}

