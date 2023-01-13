int numberA = ReadInt("Введите число A: ");
            int numberB = ReadInt("Введите число B: ");
            ToDegree(numberA, numberB);
            
            void ToDegree(int a, int b)
            {
                int result = 1;
                for (int i = 1; i <= b; i++)
                {
                    result = result * a;
                }
                Console.WriteLine($"Возведение числа {a} в степень {b} = {result}");
            }

            int ReadInt(string message)
            {
                Console.Write( message);
                return Convert.ToInt32(Console.ReadLine());
            }