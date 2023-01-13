Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int res=0;
for(int i = 1; i <= A; i++)
{
    res+=i;
}
Console.WriteLine("Ответ: "+res);

