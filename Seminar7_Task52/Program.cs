Console.Write("Введите размер строки: ");
int rowsLenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца: ");
int columsLenght = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rowsLenght,columsLenght];

getRandomMatrix(matrix);
printMatrix(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double summ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       summ += matrix[i, j];
    }
    summ/= rowsLenght;
    Console.Write($"Ответ: {summ} ; ");
}
Console.WriteLine();

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


