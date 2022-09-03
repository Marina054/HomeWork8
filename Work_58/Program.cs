// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write ("Количество строк матрицы A:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write ("Количество столбцов матрицы A:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array1 = new int [m,n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("A [{0},{1}] = ",i ,j);
                array1 [i,j] = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        Console.Write ("Количество строк матрицы B:");
        int m1 = Convert.ToInt32(Console.ReadLine());
        Console.Write ("Количество столбцов матрицы B:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int [,]array2 = new int [m1,n1];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                Console.Write("B [{0},{1}] = ",i ,j);
                array2 [i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("/");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write ("{0}" +"\t", array1[i,j]);
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine("/ ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}" +"\t",array2[i,j]);
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" /");
        int[,]work = new int [array1.GetLength(0),array2.GetLength(1)];

        for (int i = 0; i < array1.GetLength(0); ++i)
        
            for (int j = 0; j < array2.GetLength(0); ++j)
            
                for (int k = 0; k < array2.GetLength(1); ++k)
                     work[i,k] += array1[i,j] * array2[j,k];
        for (int i = 0; i < array2.GetLength(0); ++i)
        {
            for (int j = 0; j < array2.GetLength(1); ++j)
            {
                Console.Write(work[i,j] + "\t ");
            }
            Console.WriteLine();
        }             
        Console.WriteLine();
            
        

    }
    
}
