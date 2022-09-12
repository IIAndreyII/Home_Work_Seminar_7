// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//17 -> такого числа в массиве нет



Console.Write("Введите количество строк -  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -  ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int [rows,columns];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+ "\t");
    }
    Console.WriteLine();

}


Console.Write("Введите номер строки элемента ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента ");
int columns1 = Convert.ToInt32(Console.ReadLine());

rows1 -= 1;
columns1 -= 1;

if ((rows1<rows && rows1>0) || (columns1<columns && columns1>0))
{
    
    Console.WriteLine("Число - " + matrix[rows1,columns1]);
   
}

else 
{
    
    Console.WriteLine("Такого элемента нет.");
}


