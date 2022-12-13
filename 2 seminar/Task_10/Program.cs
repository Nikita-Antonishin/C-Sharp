int num = int.Parse(Console.ReadLine()!);
if (num < 0 )
{
    num = -num;
}
int secondDigit = num / 10 % 10;
Console.WriteLine(secondDigit);