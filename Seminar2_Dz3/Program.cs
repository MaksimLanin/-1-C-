Console.Write("Введите число = ");
int num = Convert.ToInt16(Console.ReadLine());
switch(num){
    case 1 : Console.Write("Понедельник-нужно работать");break;
    case 2 : Console.Write("Вторник-нужно работать");break;
    case 3 : Console.Write("Среда-нужно работать");break;
    case 4 : Console.Write("Четверг-нужно работать");break;
    case 5 : Console.Write("Пятница-нужно работать");break;
    case 6 : Console.Write("Суббота-выходной");break;
    case 7 : Console.Write("Воскресенье-выходной");break;
    default:Console.Write("Ошибка");break;
}
Console.ReadKey();
