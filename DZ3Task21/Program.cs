// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// читаем данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


// Вводим данные
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}

// Находим расстояние
double CalcLen2D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)+(z1-z2)*(z1-z2));
}

int x1 = ReadData("Введиси х точка А");
int y1 = ReadData("Введиси y точка А");
int x2 = ReadData("Введиси х точка B");
int y2 = ReadData("Введиси y точка B");
int z1 = ReadData("Введиси y точка C");
int z2 = ReadData("Введиси y точка C");

double res = CalcLen2D(x1, x2, y1, y2, z1, z2);

PrintData("Растояние между точками A и В и С", res);