// Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.

// Console.Write("Ввидете число ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввидете число ");
// int numberB = Convert.ToInt32(Console.ReadLine());


// if ( numberA > numberB )
// {
//     Console.WriteLine ("Больше: number1", numberA);
// }
// else (Console.WriteLine ("Больше: number1", numberB));


Console.Write("Ввидете число");
string numderLine1 = Console.ReadLine();
Console.Write("Ввидете число");
string numderLine2 = Console.ReadLine();
if (numderLine1 != null && numderLine2 != null)
{
    int num1 = int.Parse(numderLine1);
    int num2 = int.Parse(numderLine2);
    if ( num1 > num2 )
    {
        Console.WriteLine("Больше"+num1);
    }
    else
    {
        Console.WriteLine("Больше"+num2);
    }
}