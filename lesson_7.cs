/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

void NewTask()
{
    Console.Write("Для перехода к следующей задаче нажмите enter...");
    Console.ReadLine();
    Console.Clear();
}

Console.Clear();

double[,] CreateMatrix()
{
    int m, n, i, j;
    Console.Write("Введите количество строк: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    n = int.Parse(Console.ReadLine());

    double[,] matrix = new double[m, n];
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            matrix[i,j] =  Convert.ToDouble(new Random().Next(-1000, 1000)) / 10;
        }
    }
    return matrix;
}

void OutputMatrix(double[,] matrix)
{
    int i, j, m, n;
    m = matrix.GetLength(0);
    n = matrix.GetLength(1);
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
 
double[,] myMatrix = CreateMatrix();
OutputMatrix(myMatrix);
NewTask();

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

int[,] CreateArray()
{
    int m, n, i, j;
    Console.Write("Введите количество строк: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    n = int.Parse(Console.ReadLine());

    int[,] array = new int[m, n];
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            array[i,j] =  new Random().Next(-100, 100)/10;
        }
    }
    return array;
}

void CheckValue(int[,] array)
{
    Console.Write("введите номер строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите номер столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if  (m > array.GetLength(0) || n > array.GetLength(1))
    {
        Console.WriteLine($"элемент [{m},{n}] отсутствует");
        return;
    }
    Console.WriteLine($"элемент {m},{n} -> {array[m-1,n-1]}");        
}

void OutputArray(int[,] array)
{
    int i, j, m, n;
    m = array.GetLength(0);
    n = array.GetLength(1);
    Console.WriteLine("Исходная матрица:");
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateArray();
OutputArray(array);
CheckValue(array);
NewTask();

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

void Average(int[,] td_array)
{
    int i, j, m, n;
    m = td_array.GetLength(0);
    n = td_array.GetLength(1);
    Console.WriteLine($"m = {m}, n = {n}");
    for (j = 0; j < n; j++)
    {
        double avrg = 0;
        for (i = 0; i < m; i++)
        {
            avrg += td_array[i,j];
        }
        avrg /= n;
        Console.WriteLine($"Среднее арифметическое для {j+1} столбца: {avrg}");
    }
}

int[,] td_array  = CreateArray();
OutputArray(td_array);
Average(td_array);
