using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string inputString = ")";
        char actualSign = ' ';
        char signOpen = '(';
        char signClose = ')';
        int deep = 0;
        int maxDeed = 0;

        for (int i = 0; i < inputString.Length; i++)
        {
            actualSign = inputString[i];

            if (actualSign == signOpen)
            {
                deep++;

                if (deep > maxDeed)
                    maxDeed = deep;
            }
            else if (actualSign == signClose)
            {
                deep--;

                if (deep < 0)
                    break;
            }
        }

        if (deep != 0)
            Console.WriteLine("Строка не верна");
        else
            Console.WriteLine($"Строка верна, глубина вложения {maxDeed}");
    }
}