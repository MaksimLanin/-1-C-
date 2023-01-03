int x = ReadInt("Введите число: ");
for(int i=1; i<=x ;i++){

    Console.Write($"{i*i*i}, ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}