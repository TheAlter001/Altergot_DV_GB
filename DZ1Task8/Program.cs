// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Ввидете число");
// int number = Convert.ToInt32(Console.ReadLine());
// int i= 2;
// Console.Write("Ввидете число");
// string number = Console.ReadLine();

// if (number != null)
// {
//     int number = int.Parse (inputLine);
//     int i = 2;
//     for (i <=number; i=i+2;)
//     {
//     WriteLine(i);
//     }
// }
//_______________________________________________________________________-    10 пыпыток и ошибка
// Console.Write("Ввидете число");
// int number = Convert.ToInt32(Console.ReadLine());

// for ( int i = 2; i <=number; i=i+2)
// {
//     Console.WriteLine("числа", i);                           10 попыток и ошибка
// }

Console.Write("Ввидете число");                                    
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
while ( i <= N )
{
    Console.WriteLine( i);
    i=i+1;
}