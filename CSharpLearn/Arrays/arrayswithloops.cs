using System;

namespace CSharpLearn.Arrays;

public class arrayswithloops
{
    public static void loopswith()
    {
        //        string[] cars = { "yachmen", "kiril", "dengi" };
        //        for (int i = 0; i < cars.Length; i++)
        //        {
        //            Console.WriteLine(cars[i]);
        string[] cars = { "yachmen", "kiril", "dengi" };
        foreach (String i in cars)
        {
            Console.WriteLine(i);
        }

    }
}
