using System;

namespace CSharpLearn.Loops;

public class WhileMe
{
    public static void While()
    {
        int i = 0;

        while (true)
        {
            i++;
            Console.WriteLine(i + " The iteration that is ongoing");
            if (i == 5)
            {
                break;
            }
        }
        Console.WriteLine(i + " The result of the break");

    }
}
