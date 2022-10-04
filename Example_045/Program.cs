// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 

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

void Copy(int[] arr1, int[] arr2)
{
    for (int i=0;i<arr1.Length;i++)
    {
        arr2[i] = arr1[i];
    }
}

Random random = new Random();
int length = random.Next(3,11);

int[] array1 = new int[length];

FillArray(array1);
PrintArray(array1);

int[] array2 = new int[length];
Copy(array1, array2);
PrintArray(array2);