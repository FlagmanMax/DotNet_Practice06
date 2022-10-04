// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


void FillArray(int[] arr)
{
    Random random = new Random();

    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = random.Next(-100,101);
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

void Remake(int[] arr)
{
    int temp = 0;
    for (int i=0;i<arr.Length/2;i++)
    {
        // temp = arr[i];
        // arr[i] = arr[arr.Length-1-i];
        // arr[arr.Length-1-i] = temp;

        (arr[i],arr[arr.Length-1-i]) = (arr[arr.Length-1-i],arr[i]);
    }
}

Random random = new Random();
int length = random.Next(3,11);

int[] array = new int[length];

FillArray(array);
PrintArray(array);

Remake(array);
PrintArray(array);
