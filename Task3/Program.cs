// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

 
int[,] matrix = new int[5, 5];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
PrintArray(Arithmeticmean(matrix));


 
 
 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        
            {
                Console.Write(matrix[i, j] + " ");
            }
        Console.WriteLine();
    }
}
 
 
 
void FillMatrix(int[,] matrix)
{
    Random generator = new Random();
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        
            {
                matrix[i, j] = generator.Next(0,10);
            }
    }
}

void PrintArray(double[] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write(array[i] + " ");
  }  
}

double[] Arithmeticmean (int[,] matrix)
{   double[] result = new double[matrix.GetLength(1)];
    double sum;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        result[i] = sum / matrix.GetLength(0);
    }
    return result;
}
