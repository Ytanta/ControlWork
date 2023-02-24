
Console.WriteLine("Введите количество строк:");
int Line = Convert.ToInt32(Console.ReadLine());
string[] UserArray = CreateArraeString(Line);
const string quote = "\"";
PrintArray(UserArray);



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

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{quote} {arr[i]} {quote}, ");
        else Console.Write($"{quote} {arr[i]} {quote}");
    }
    Console.Write("]");
}




