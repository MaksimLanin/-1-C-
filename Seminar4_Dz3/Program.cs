Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int res=1;
for(int i = 1; i <= A; i++)
{
    res=res* i;
}
Console.WriteLine("Ответ: "+res);


