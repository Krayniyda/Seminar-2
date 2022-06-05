Console .Clear();
Console.WriteLine("Задайте прямоугольный двумерный массив. \n" + "Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

Random rnd = new Random();
int rows = rnd.Next(2, 10);                      
int columns = rnd.Next(2, 10);
Console.WriteLine($"Случайные параметры массива: rows = {rows}, columns = {columns}\n");

// Begin
double[,] array = new double[rows, columns];

FillArray2(array);
int numberRoW = RowArray2(array, out numberRoW); 

PrintArray2(array); Console.WriteLine(new string('_', 5 * columns)); 
Console.WriteLine("Ряд " + numberRoW + "имеет наименьшую сумму:\n");
PrintRowArray2(array, numberRoW);


void FillArray2(double[,] matrix2)
{   for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            matrix2[i, j] = Math.Round((rnd.NextDouble() * 10 - 5), 2); 
}

void PrintArray2(double[,] matrix2)
{for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            Console.Write("{0, 10}", (array[i, j]).ToString("0.00"));
            Console.WriteLine("\n");
        } 
    Console.WriteLine();
}

int RowArray2(double[,] matrix2, out int numberRoW)
{   int j; numberRoW = int.MinValue;
    double sum = 0; double minSum = double.MaxValue;
    for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (j = 0; j < matrix2.GetLength(1); j++) 
                sum += matrix2[i, j]; 
            if (sum < minSum) 
            {
                minSum = sum;
                numberRoW = i;
            }
        } 
    Console.WriteLine(); return numberRoW;
}

void PrintRowArray2(double[,] matrix2, int row)
{   
    for (int j = 0; j < matrix2.GetLength(1); j++)
        Console.Write("{0, 10}", (matrix2[row, j]).ToString("0.00"));
    Console.WriteLine("\n");
}



