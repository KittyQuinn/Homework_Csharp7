// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Clear();


 Console.WriteLine("Type the number of rows: ");
 int row = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Type the number of columns: ");
 int col = Convert.ToInt32(Console.ReadLine());

  int[,] matrix = new int[row, col];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
         matrix[i,j] = new Random().Next(20);
         Console.Write(matrix[i,j]+"\t"); 
     }
     Console.WriteLine();

  }

  Console.WriteLine("Type index 1: ");
  int index1 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Type index 2: ");
  int index2 = Convert.ToInt32(Console.ReadLine());

  int find = matrix[index1, index2];

 Console.WriteLine(find);