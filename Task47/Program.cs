// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Type the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

 double[,] matrix = new double[row, col];
 Random random = new Random();

 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [i,j] = Convert.ToDouble(random.Next(-100,100)/10.0);
         Console.Write("{0,6:F2}", matrix[i,j]); 
    }
    Console.WriteLine();

 }