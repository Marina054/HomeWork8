using System;
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите количество строк m:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество элементов массива в строке n:");
        int n = Convert.ToInt32 (Console.ReadLine());
        int [,]array = new int [m,n];
        Random myRandom = new Random();
        Console.WriteLine(" ");
        for (int i = 0; i < m ; i++)  
        {
            for (int j = 0; j < n; j++)
            {
                array[i,j] = myRandom.Next (0,10 + n);
                Console. Write("{0}\t",array[i,j]);
            }
            Console.WriteLine();

        }
        int index;
        for (int k = 0; k < m; k++)
        {
            for (int i = 0; i < n; i++)
            {
                index=i;
                for (int j = 0; j < n; j++)
                {
                    if (array[k,j]> array[k,index])
                    {
                        index = j;
                    }
                }
                if (array[k, index]== array[k,i])
                    continue;
                int temp = array[k,i];
                array [k,i] = array[k,index];
                array [k,index] = temp;    
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine(" Отсортированный массив:");
        Console.WriteLine(" ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}\t", array[i,j]);
            }
            
        }
        Console.WriteLine(" ");
    }
}

