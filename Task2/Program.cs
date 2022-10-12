//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
 
Console.Write("Введите индекс строки: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int n = int.Parse(Console.ReadLine()!);

 
int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);

if(IsIndexExists(array, m, n))
{
   Console.WriteLine(array[m, n]); 
}
else
{
    Console.WriteLine("Такого элемента нет");
}

 
 
 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        
            {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        
    }
}
 
 
 
void FillArray(int[,] array)
{
    Random generator = new Random();
 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        
            {
                array[i, j] = generator.Next(-10,10);
            }
    }
}

bool IsIndexExists(int[,] array, int m, int n)

{
    if(m < array.GetLength(0) &&
    n < array.GetLength(1) &&
    m >= 0 && n >=0)
    {
        return true;
    }
    else
    {
        return false;
    }
}