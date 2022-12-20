Console.Write("Введите а=" );
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b=" );
int b = Convert.ToInt32(Console.ReadLine());
if(a!=b){
if(a>b)
{
    Console.WriteLine("max= "+a);
    Console.WriteLine("min="+b);
}
 else
{
    Console.WriteLine("max= "+b);
    Console.WriteLine("min= "+a);
}
}
else{
   Console.WriteLine("a и b равны, введите разные по значению числа"); 
}
