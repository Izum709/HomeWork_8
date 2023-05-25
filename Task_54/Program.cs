
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] SortedMassive(int[,] array)
{
    int[,] sortedArray = new int[array.GetLength(0),array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sortedArray[i, j] = array[i, j];
            for (int k = 0; k < array.GetLength(1) - 1;  k++)
            {
                for (int l = k + 1; l < array.GetLength(1); l++)
                {
                   if (sortedArray[i, k] < sortedArray[i, l])
                    {
                        int buffer = sortedArray[i, l];
                        sortedArray[i, l] = sortedArray[i, k];
                        sortedArray[i, k] = buffer;
                    }

                }
            }
        }
    }
    return sortedArray;
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
int[,] array = FillMassive(m, n);
PrintMassive(array);
Console.WriteLine("В итоге получается вот такой массив: ");
int[,] sortedArray = SortedMassive(array);
PrintMassive(sortedArray);
