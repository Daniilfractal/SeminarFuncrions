// Принимает на вход трёхзначное число и на выходе показать вторую цифру этого числа. 
// Через строку решать нельзя.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");

int number = int.Parse(Console.ReadLine()!);

int firstdigit = (number/100);
int seconddigit = (number - firstdigit*100) / 10;

Console.WriteLine(seconddigit);



