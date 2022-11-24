// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


 Console.WriteLine("Type the number of rows: ");
 int row = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Type the number of columns: ");
 int col = Convert.ToInt32(Console.ReadLine());

  int[,] matrix = new int[row, col]; 
  int[] column = new int[row];
  
 

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
         matrix[i,j] = new Random().Next(11);
         Console.Write(matrix[i,j]+"\t"); 
     }
     Console.WriteLine();

  }


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0;j < matrix.GetLength(1); j++)
        column[i]+=matrix[j,i];
    Console.Write(column[i]+" ");
}