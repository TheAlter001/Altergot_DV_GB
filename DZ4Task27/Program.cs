// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.



int ReadData(string line)
{
    Console.Write(line);
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int NumberLen(int a)
{
 int index = 0;
 while (a > 0)
    {
 a /= 10;
 index++;
    }
 return index;
}

void Summer(int numA, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += numA % 10;
        numA /= 10;
    }
    Console.WriteLine(sum);
}

int numberA = ReadData("Введите число : ");


int len = NumberLen(numberA);

Summer(numberA, len);




