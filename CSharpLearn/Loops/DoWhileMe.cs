using System;

namespace CSharpLearn.Loops;

public class DoWhileMe
{
 public static void DoWhile()
    {
        int i = 0;

        do
        {
            Console.WriteLine(i);
            i++;
            if (i == 10)
            {
                break;
            }
        } while (true);
    }   
}
