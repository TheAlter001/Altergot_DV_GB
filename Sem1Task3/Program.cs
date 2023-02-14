// ищем день недели сходя из даты

Console.Write("Ввидете число");
string? lineDay = Console.ReadLine();
if (lineDay != null)
{
    int day = int.Parse(lineDay);
    string[] dayweek = new string[7];
    dayweek[0] = "Пн";
    dayweek[1] = "Вт";
    dayweek[2] = "СР";
    dayweek[3] = "ЧТ";
    dayweek[4] = "Пт";
    dayweek[5] = "СБ";
    dayweek[6] = "Вс";
    Console.WriteLine(dayweek[day -1]);

}