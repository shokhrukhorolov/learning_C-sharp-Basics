using System;

namespace CSharpLearn.Arrays;

public class multidimensialarrays
{
    public static void TwoDeArray()
    {
        int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
        Console.WriteLine(numbers[1, 0]);  // [x, y] x - column, y - element index
    }
}
