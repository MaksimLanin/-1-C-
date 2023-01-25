Console.Write("Введите размер строки: ");
int rowsLenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца: ");
int columsLenght = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rowsLenght,columsLenght];

getRandomMatrix(matrix);
printMatrix(matrix);

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

if(rows > 0 && colums > 0 )
{
    if (rows > matrix.GetLength(0) || colums > matrix.GetLength(1))
    {
        Console.WriteLine("Введите другое значение, такого элемента нет");
    }
    else
    {
        Console.WriteLine($" {matrix[rows-1,colums-1]}");
    }
}
else
{
    Console.WriteLine("Введите другое значение, такого элемента нет");
}



void getRandomMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(0,100);
        }   
    }
}

void printMatrix(int[,] matrix){
    for(int i = 0; i< matrix.GetLength(0);i++)
    {
        for(int j = 0; j<matrix.GetLength(1);j++)
        {
           Console.Write(matrix[i,j] + " ");
        }
        
        Console.WriteLine();
    }
}


