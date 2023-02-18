System.Random numSintezator = new System.Random();              

int rndNumber = numSintezator.Next(10,100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum = rndNumber%10;

if(firstNum>secondNum)                                     // первый
{
    Console.WriteLine("первое" + firstNum);
}
else
{
    Console.WriteLine("второе" + secondNum);
}  

char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();        // второй
Console.WriteLine(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;
int resultNumber = (firstNumber>secondNumber)?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine("второе решенине" + resultNumber);