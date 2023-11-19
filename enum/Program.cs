using System;

public static class ArrayExtensions
{
    public static T[] Add<T>(this T[] array, T newItem)
    {
        T[] newArray = new T[array.Length + 1];
        array.CopyTo(newArray, 0);
        newArray[array.Length] = newItem;
        return newArray;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = new int[0];
        arr = arr.Add(1);
        arr = arr.Add(2);
        arr = arr.Add(3);
        arr = arr.Add(4);
        int sum = 0;
        foreach (var item in arr)
        {
            sum += item;
        }
        Console.WriteLine(sum);
    }
}