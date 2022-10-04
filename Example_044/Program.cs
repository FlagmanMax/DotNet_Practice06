// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
void FibArray(int[] Array)
{
    Array[0] = 0;
    Array[1] = 1;
    for (int i=2;i<Array.Length;i++)
    {
        Array[i] = Array[i-2] + Array[i-1];
    }
}

void PrintArray(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        Console.Write(arr[i]+"\t");
    }
     Console.WriteLine();
}


Random random = new Random();
int n = random.Next(1,16);
Console.WriteLine("n = "+n);
int[] arr = new int[n];
FibArray(arr);
PrintArray(arr);


