Console .Clear();
Console.WriteLine("Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива."); 

int rows, columns;
rows = columns = int.MaxValue; 
Random rnd = new Random();
rows = rnd.Next(2, 10);                      
columns = rnd.Next(2, 10);
Console.WriteLine($"Случайные параметры массива: rows = {rows}, columns = {columns}\n");


double[,] array = new double[rows, columns];
FillArray2(array);
PrintArray2(array); Console.WriteLine(new string('_', 5 * columns)); Console.WriteLine("");
SortArray2(array);
Console.WriteLine("Массив со строками, упорядоченными в порядке убывания:\n"); 
PrintArray2(array); 



void FillArray2(double[,] matrix2)
{   for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            matrix2[i, j] = Math.Round((rnd.NextDouble() * 50 - 10), 2); 
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

void SortArray2(double[,] matrix2)
{for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1) - 1; j++)
            for (int k = 0; k < matrix2.GetLength(1) - 1; k++)
                if (matrix2[i, k] < matrix2[i, k + 1]) 
                    (matrix2[i, k], matrix2[i, k + 1]) = (matrix2[i, k + 1], matrix2[i, k]);
}



    