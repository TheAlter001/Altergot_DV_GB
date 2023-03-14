// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.


// int ReadData(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int Pow(int a, int b)
// {
//     int res = 0;
//     while (b > 0)
//     {
//         res = res * a;
//         b = b - 1;
//     }
//     return res;
// }

// int numberA = ReadData("Введите число А: ");
// int numberB = ReadData("Введите число B: ");

// int res1 = Pow(numberA, numberB);
// Pow("Степень чисел: " + res1);



Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int res = a;

for (int i = 1; i < b; i++)
{
res = res * a;
}
Console.WriteLine("A в степени B равно: " + res);