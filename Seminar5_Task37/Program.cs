/*
Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/


int [] GetRandomArray(int size, int LeftRange, int RightRange)
{
int[] array = new int [size];
for(int i=0; i < size;i++){
    array[i]=new Random().Next(LeftRange,RightRange+1);
}
return array;
}
int[] massive=GetRandomArray(10,0,100);
Console.WriteLine(string.Join(", ",massive));

int sum=0;
int min=int.MaxValue;
int max=int.MinValue;
 for(int i = 0; i < massive.Length; i++){
    if(massive[i]>max){
        max=massive[i];
    }
    if (massive[i] < min)
    {
        min=massive[i];
    }
    sum=max-min;
     
 }
Console.WriteLine(@$"Максимальное число: {max}
 Минимальное число: {min} 
 Разность: {sum}");