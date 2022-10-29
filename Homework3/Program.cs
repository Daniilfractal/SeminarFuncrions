//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Напишите цифру, соответствующую дню недели!");

int number = int.Parse(Console.ReadLine()!);

if (weekend(number))
{
    Console.WriteLine("Да, Выходной");
}
else
{
    Console.WriteLine("Нет");
}

bool weekend (int number)
{
    return number == 6 || number == 7;
}