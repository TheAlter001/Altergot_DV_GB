Console.Write("Ввидете число");
string numderLine1 = Console.ReadLine();
Console.Write("Ввидете число");
string numderLine2 = Console.ReadLine();
if (numderLine1 != null && numderLine2 != null)
{
    int num1 = int.Parse(numderLine1);
    int num2 = int.Parse(numderLine2);
    if (num2 * num2 == num1)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}