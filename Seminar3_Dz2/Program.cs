int x1 = ReadInt("Введите х1: ");
int y1 = ReadInt("Введите y1: ");
int z1 = ReadInt("Введите z1: ");
int x2 = ReadInt("Введите х2: ");
int y2 = ReadInt("Введите y2: ");
int z2 = ReadInt("Введите z2: ");

int A = x2-x1;
int B = y2-y1;
int C = z2-z1;

double length = Math.Sqrt(A*A + B*B + C*C);
Console.WriteLine("Расстояние= "+length);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}