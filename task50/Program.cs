/*Задача 50. Напишите программу, которая на 
вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)*/


Console.Write("Введите строку:");

int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец:");

int columns = Convert.ToInt32(Console.ReadLine());
int n = 3;

int m = 4;

Random random = new Random(); 

int[,] array = new int[n, m];

Console.WriteLine("Исходный массив:");

 for (int i = 0; i < array.GetLength(0); i++)

{
    for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(11);

         Console.Write("{0} ", array[i, j]);

        }
        Console.WriteLine();
        
         }
    if (rows < 0 | rows > array.GetLength(0) - 1 | columns < 0 | columns > array.GetLength(1) - 1)
    {
     Console.WriteLine("Элемент не существует");
    }
    else
    {
     Console.WriteLine("Значение элемента массива = {0}", array[rows, columns]);
    }
       

