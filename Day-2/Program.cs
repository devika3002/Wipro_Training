// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] num = new int[5];

        num[0] = 20;
        num[1] = 30;
        num[2] = 40;
        num[3] = 50;
        num[4] = 60;

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine($"number at index {i} is {num[i]}");
        }

        string[] n = new string[3];
        n[0] = "hello";
        n[1] = "hi";
        n[2] = "welcome";

        for (int j = 0; j < n.Length; j++)
        {
            Console.WriteLine($"string at index {j} is {n[j]}");
        }

        Console.WriteLine($"count is {n.Length}");
    }
}
