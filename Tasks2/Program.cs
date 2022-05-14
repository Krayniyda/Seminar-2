Console.Clear();
Console.WriteLine("Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");
Console.Write("Введите трёхзначное число: ");
int n;
while (true)
{
    n = int.Parse(Console.ReadLine());
    if (n < 100 || n > 999)
    {
        Console.WriteLine("Введено не трёхзначное число!");
        Console.Write("Повторите ввод: ");
    }
    else
    {
        break;
    }
}
int n1 = n / 100;
int n2 = n % 10;
Console.WriteLine(n1 * 10 + n2);



