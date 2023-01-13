Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int count =0;
while(A>0){
    A/=10;
    count++;
}
Console.WriteLine($"Цифр в числе: {count}");
