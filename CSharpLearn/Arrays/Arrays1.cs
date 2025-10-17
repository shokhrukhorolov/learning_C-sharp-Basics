using System;

namespace CSharpLearn.Arrays;

public class Arrays1
{
    public static void Strings()
    {

        string[] cars = { "Volvo", "BMW", "Mazda" };
        Console.WriteLine(cars);

        int[] nums = { 1, 2, 3, 4 };

        Console.WriteLine(nums + "basic list");

        nums = new int[5];

        Console.WriteLine(nums + "declaring the expected amount of new items");

        int[] numerics = new int[5] { 11, 12, 13, 14, 15 };

        Console.WriteLine(numerics + "getting expected amount of new items");

        int[] additional;

        additional = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine(additional + "added numbers");
    }
}
