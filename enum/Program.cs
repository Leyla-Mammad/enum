using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        int sum = 0;
        foreach (var item in list)
        {
            sum += item;
        }

        Console.WriteLine(sum);
    }
}