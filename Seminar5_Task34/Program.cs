/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/
int [] GetRandomArray(int size, int LeftRange, int RightRange)
{
int[] array = new int [size];
for(int i=0; i < size;i++){
    array[i]=new Random().Next(LeftRange,RightRange+1);
}
return array;
}
int[] massive=GetRandomArray(4,99,999);
Console.WriteLine(string.Join(", ",massive));

int count = 0;

for (int i = 0; i < massive.Length; i++)
{
if (massive[i] % 2 == 0)
count++;
}
Console.WriteLine($"из {massive.Length} чисел, {count} четных");
