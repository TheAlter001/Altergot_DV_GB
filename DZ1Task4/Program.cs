// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел

Console.Write("Ввидете число");
string numderLine1 = Console.ReadLine();
Console.Write("Ввидете число");
string numderLine2 = Console.ReadLine();
Console.Write("Ввидете число");
string numderLine3 = Console.ReadLine();

if (numderLine1 != null && numderLine2 != null && numderLine3 != null)
{
    int num1 = int.Parse(numderLine1);
    int num2 = int.Parse(numderLine2);
    int num3 = int.Parse(numderLine3);
    int max = num1;
    if ( num1 > max ) max = num1;
    if ( num2 > max ) max = num2;
    if ( num3 > max ) max = num3;
        
    Console.WriteLine("Больше"+max);
    
}