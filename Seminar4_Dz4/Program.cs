Console.Write("Введите размер массивa: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,2);
}
Console.WriteLine(string.Join(", ", arr));