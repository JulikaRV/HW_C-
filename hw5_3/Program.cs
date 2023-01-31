// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] newArray = GetArray(10, 1, 20);
System.Console.WriteLine();
System.Console.WriteLine($"[{String.Join(',', newArray)}]");
PowArray(newArray);


//function

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PowArray(int[] arr)
{
    int n = arr.Length;
    int j = arr.Length - 1;
    for (int i = 0; i < (arr.Length + 1) / 2; i++)
    {
        System.Console.Write($"{arr[i] * arr[j] + " "}");
        j--;
    }
    if (arr.Length % 2 > 0)
    {
        System.Console.Write(arr[arr.Length / 2 - 1]);
    }
}
