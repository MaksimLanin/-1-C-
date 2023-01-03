Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int length = number.Length;
if(length==5){
    if(number[0]==number[4] && number[1]==number[3]){
        Console.WriteLine(number +" "+ "Полиндром");
    }
    else
    Console.WriteLine("Число не является Полиндромом");
}
else
Console.WriteLine("Число не пятизначное");