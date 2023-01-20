﻿/*
Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/

int [] GetRandomArray(int size, int LeftRange, int RightRange)
{
int[] array = new int [size];
for(int i=0; i < size;i++){
    array[i]=new Random().Next(LeftRange,RightRange+1);
}
return array;
}
int[] massive=GetRandomArray(123,0,150);


int count = 0;

for (int i = 0; i < massive.Length; i++)
{
if (i>=10 && i<=99)
count++;
}
Console.WriteLine($"В массиве из {massive.Length} чисел, в диапазоне от 10 до 99 включительно находится {count} чисел");
