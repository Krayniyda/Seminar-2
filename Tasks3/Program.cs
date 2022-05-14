Console.Clear();
Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. ");
Console.Write("Введите трёхзначное число: ");
 string a = Convert.ToString(Console.ReadLine());
ThirdDigit(a);

void ThirdDigit(string number)
{
    if (number.Length >= 3)
    {
        Console.WriteLine(number[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет! ");
    }
}

