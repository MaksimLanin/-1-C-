/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/
string vvod ="";
int count=0;
Console.WriteLine("Bводите числа");
while( (vvod=Console.ReadLine()!) !="stop")
{
   int converter =Convert.ToInt32(vvod);
    if(converter>0){
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел: {count} ");