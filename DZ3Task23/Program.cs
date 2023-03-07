// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string LineBuilder(int end, int pow)
{
    string res = String.Empty;
    for (int i = 1; i <= end; i++)
    {
        res = res + Math.Pow(i, pow) + "\t";
    }
    return res;
}

int N = ReadData("Введите число");
Console.WriteLine(LineBuilder(N, 1));
Console.WriteLine(LineBuilder(N, 3));