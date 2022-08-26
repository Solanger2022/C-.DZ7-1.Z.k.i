Console.Write("Введите количество строк: "); 

int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");  

int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns]; 

for (int i = 0; i < matrix.GetLength(0); i++) 
{

for (int j = 0; j < matrix.GetLength(1); j++) ;
}

double[,] array = new double[rows, columns];

Random random = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.NextDouble() * 100; 

        Console.Write( array[i, j]);
    }
    Console.WriteLine();
}
