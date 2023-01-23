/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/
string vvod ="";
int count=0;

while( (vvod=Console.ReadLine()) !="stop")
{
   int chislo=Convert.ToInt32(vvod);
    if(chislo>0){
        count++;
    }
}
Console.WriteLine($"Вы ввели {count} положительых чисел");







// Console.Write("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int a = 0;
//     int[] array = new int[size];
//     for(int i = 0;i< size;i++){
//         Console.Write("Вводите: ");
//         a=Convert.ToInt32(Console.ReadLine());
//         array[i]=a;
        
//     }
//     Console.WriteLine(string.Join(", ",array));
    
