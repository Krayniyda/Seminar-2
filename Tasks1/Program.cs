Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. ");
Console.Write("Введите трехзначное число:");
string s = Console.ReadLine();
    while (s.Length !=3)
{
    Console.Write("Вы ввели не трехзначное число, введите заного трехзначное число: ");
    s = Console.ReadLine();
}
    Console.WriteLine(s[1]);

    