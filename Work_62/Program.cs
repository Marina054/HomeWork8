// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Количество строк матрицы :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write ("Количество столбцов матрицы :");
            int n = Convert.ToInt32(Console.ReadLine());
         
            int[,] mymatrix = new int[n, m];
 
            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int dirChanges = 0;
            int transition = m;
 
            for (int i = 0; i < mymatrix.Length; i++)
            {
                mymatrix[row, col] = i + 1;
              if (--transition == 0) 
              {
                transition = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
                int temp = dx;
                dx = -dy;
                dy = temp;
                dirChanges++;
              }
 
              col += dx;
              row += dy;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mymatrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }    
