//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
bool lessthen100(int number)
{
    return number < 100;
}

if (lessthen100(number))
{
    Console.WriteLine("Третьей цифры нет");
}

else
{
    while (number > 999)
    {
        number = number/10;
    }

    int firstdigit = (number / 100);
    int seconddigit = (number - firstdigit * 100) / 10;
    int number2 = (number - firstdigit * 100);
    int thirddigit = (number2 - seconddigit * 10);
    Console.WriteLine(thirddigit);
}

