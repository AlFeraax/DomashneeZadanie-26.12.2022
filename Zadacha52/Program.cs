//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 3];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int average = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        average += matrix[j, i];
    }
    Console.WriteLine($"Среднее арифметическое элементов столбца {i + 1} = {(float)average / matrix.GetLength(1)}");
}