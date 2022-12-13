Console.Write("Число: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    num = -num;
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры нету");
}
else
{
    while (num > 999)
    {
        num = num / 10;
    }
    int thierdDigit = num % 10;
    Console.WriteLine(thierdDigit);
}

