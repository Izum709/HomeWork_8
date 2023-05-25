// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintMultyArray(int[,]firstMassive, int[,] secondMassive)
{
    Console.WriteLine();
    int[,] resultMulty = new int[firstMassive.GetLength(0),  secondMassive.GetLength(1)];
    for (int i = 0; i < firstMassive.GetLength(0); i++)
    {
        for (int j = 0; j < secondMassive.GetLength(1); j++)
        {
            resultMulty[i,j] = 0;
            for (int l = 0; l < firstMassive.GetLength(1); l++)
            {
                resultMulty[i, j] += firstMassive[i, l] * secondMassive[l, j];
            }
            Console.Write($"[{resultMulty[i, j]}]");
        }
        Console.WriteLine();
    }
}

void PrintMassive(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array [i, j]}]");
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}

int[,] FillMassive(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (Convert.ToInt32(Console.ReadLine()));
}

int m =EnterData("Введите количество строк: ");
int n =EnterData("Введите количество столбцов : ");
int[,] firstArray = FillMassive(m, n);
int[,] secondArray = FillMassive(m, n);
PrintMassive(firstArray);
PrintMassive(secondArray); 
Console.WriteLine(" Результирующая матрица будет: ");
PrintMultyArray(firstArray, secondArray);