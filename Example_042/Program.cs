// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void PrintArray(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        Console.Write(arr[i]+" ");
    }
     Console.WriteLine();
}

Random random = new Random();
int a = random.Next(1,101);
Console.WriteLine("a_10 = "+a);

int maxlen = Convert.ToInt32(Math.Floor(Math.Log(a)/Math.Log(2))) + 1;

int temp = a;
int[] arr = new int[maxlen];
for (int i=0;i<maxlen;i++)
{
    arr[maxlen-1-i] = temp%2;
    temp /= 2;
}

Console.Write("a_2  = ");
PrintArray(arr);