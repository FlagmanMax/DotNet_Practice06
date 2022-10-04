// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int CountPositiveNumbers(int[] arr)
{
    int count = 0;

    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]>0)
        {
            count++;
        }
    }
    return count;
}

void InputArray(int[] arr)
{
    Console.WriteLine("Введите " + arr.Length + " чисел:");
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Введите количество чисел m:");
int m = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[m];

InputArray(arr);

int count = CountPositiveNumbers(arr);
Console.WriteLine("Введено " + count + " положительных чисел");
