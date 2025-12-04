using System;
class Program
{
    static void Main(string[] args)
    {
        string separator = ", ";
        for (char letter = 0 ; letter <= 99 ; letter++)
        {
            if (letter < 99)
            {
                Console.Write($"{letter.ToString("00")}{separator}");
            }
            else
            {
                Console.Write($"{letter.ToString("00")}\n");
            }
        }
    }
}
