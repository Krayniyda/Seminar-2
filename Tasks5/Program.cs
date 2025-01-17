﻿Console.Clear();
Console.WriteLine("Заполните спирально массив 4 на 4 числами от 1 до 16 ");

int n = 4; 
int number = 1; 

Print2(SpiralArray(n, number));

Console.WriteLine("\n"); 

static int[,] SpiralArray(int n, int number)
{
int[,]array = new int[n,n];
int count = 0; 

int row; int column; 
while (number < n*n + 1)
{
    for (column = count; column < n - count; column++) array[count, column] = number++; 
    for (row = count + 1; row < n - count; row++) array[row, n - count - 1] = number++; 
    for (column = n - count - 2; column > count; column--) array[n - count - 1, column] = number++; 
    for (row = n - count - 1; row > count; row--) array[row,count] = number++; count++;
}
return array;
}

static void Print2(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + "\t");
        }
        Console.WriteLine();
    }
}
    
    




    