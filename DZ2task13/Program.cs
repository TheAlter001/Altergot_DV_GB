// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string
Console.WriteLine("число: ");

string num = Console.ReadLine();


char[] mas = num.ToCharArray();
    
if (num.Length <= 3)                                // Делаем проверку
{    
    Console.WriteLine("третьей цифры нет");    
}   
else
{
    Console.WriteLine("число" + mas[2]);

}