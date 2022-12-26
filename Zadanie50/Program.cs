//Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

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
int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool nalichie = false;
int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (num == matrix[i, j])
        {
            nalichie = true;
            count++;
            Console.WriteLine($"Соответствие найдено в пересечении {i} {j}");
        }
    }
}

if (nalichie)
{
    Console.WriteLine($"В массиве число найдено в колличестве {count} шт.");
}
else
{
    Console.WriteLine("Такого числа в массиве нет.");
}