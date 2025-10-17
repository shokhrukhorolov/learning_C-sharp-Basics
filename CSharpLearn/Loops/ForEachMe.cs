using System;

namespace CSharpLearn.Loops;

public class ForEachMe
{
    public static void ForEach()
    {
        string[] names = { "zander", "shokhrukh", "shoxsurx", "shaki" };

        foreach (string i in names)
        {
            Console.WriteLine(i);
        }
    }
}
