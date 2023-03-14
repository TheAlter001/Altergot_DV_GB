int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int lenArray = ReadInt("Введите длинну массива: ");
int MinN = ReadInt("Введите мин значение массива : ");
int MaxN = ReadInt("Введите макс значение массива : ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(MinN,MaxN);
    Console.Write(randomArray[i] + " ");
}


