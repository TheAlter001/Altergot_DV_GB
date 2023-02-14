Console.WriteLine("ВВедите число");

string? inputNum = Console.ReadLine();

if(inputNum != null)
{
    int number = int.Parse(inputNum);

    //int outNum = number*number;
    int outNum = (int)Math.Pow(number,2);


    Console.WriteLine("квадтрат" +outNum);
}
