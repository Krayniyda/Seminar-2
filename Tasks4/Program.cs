Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
string IsWeekend (int namber)
{
    if ((namber == 6) | (namber == 7))
    {
        return namber + " -> ура выходной! ";
    }
    if ((namber >= 1) & ( namber <= 5))
    {
        return namber + " ->  на работу   ";
    }
    else
    {
        return "дня недели стаким номером не существует " ;
    }
}
try
{
        Console.Write("Введите номер недели: ");
        int namber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsWeekend(namber));
}
catch(Exception ex)
{
        Console.WriteLine(ex.Message);
}