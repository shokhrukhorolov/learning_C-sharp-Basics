using System;

namespace CSharpLearn.Arrays;

public class Sorting_arrays
{
    public static void sort()
    {
    string[] cars = { "vitmanika", "plov", "triatlon", "Amphitomin" };
    Array.Sort(cars);
    foreach (string i in cars) 
    {
        Console.WriteLine(i);
    }
    }
}
