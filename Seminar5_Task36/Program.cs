/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/
int [] GetRandomArray(int size, int LeftRange, int RightRange)
{
int[] array = new int [size];
for(int i=0; i < size;i++){
    array[i]=new Random().Next(LeftRange,RightRange+1);
}
return array;
}
int[] massive=GetRandomArray(5,0,10);
Console.WriteLine(string.Join(", ",massive));
int sum=0;
 for(int i = 0; i < massive.Length; i+=2){
    sum=sum + massive[i]; 
 }
Console.WriteLine(sum);
