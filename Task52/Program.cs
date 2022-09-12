// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Write("Введите количество строк - ");
int rows = Convert.ToInt32(Console. ReadLine());
Console.Write("Введите количество столбцов - ");
int columns = Convert.ToInt32(Console. ReadLine());

int[,] matrix = new int [rows,columns];
int sum = 0;



for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+ "\t");


    }

    Console.WriteLine();

}

Console.WriteLine("Среднее арифметическое каждого столбца: ");

double temp = 0;

for(int m = 0; m < matrix.GetLength(1); m++)
{
    for(int n = 0; n < matrix.GetLength(0); n++)
    {
        temp += matrix[n,m];
    }
    temp /= rows;

    Console.Write(Math.Round(temp,1) + "\t");
}