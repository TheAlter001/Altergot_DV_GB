//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine(" Массив: ");
PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)                //ищем колличеством четных
if (numbers[a] % 2 == 0)
count++;

Console.WriteLine($"Четных {count}");

void FillArrayRandomNumbers(int[] numbers)                     //Создаем масив
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)                              //Пишем масив
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}