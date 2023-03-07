// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PulineTest(int num)
{
    if ((num / 10000 == num % 10) && ((num / 1000) % 10 == ((num/10) % 10)))
    {
        Console.WriteLine("полидром");
    }
    else
    {
        Console.WriteLine("yt полидром");
    }
}

int N = ReadData("введите число");
PulineTest(N);


