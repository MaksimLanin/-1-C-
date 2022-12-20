Console.Write("Введите размер массива = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray =  Enumerable.Range(1,size).ToArray();

for(int i =0; i < myArray.Length;i++){
if(myArray[i]%2==0){
    Console.WriteLine(myArray[i]);
}
}



 