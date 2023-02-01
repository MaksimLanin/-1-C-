Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
FromLessToMore(number,count);

void FromLessToMore(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        FromLessToMore(n, count + 1);
        Console.Write(count + " ");
    }
}