﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
//  и выводит их на экран. (числа берете любые)

int[] newArray = GetArray(8);
System.Console.WriteLine();
System.Console.WriteLine($"[{String.Join(',', newArray)}]");

//function

int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random rand = new Random();
        arr[i] = rand.Next(0, 9);
    }
    return arr;
}
