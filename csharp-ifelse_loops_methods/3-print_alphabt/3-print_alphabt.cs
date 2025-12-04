using System;
class Program
{
    static void Main(string[] args)
    {
        for (int letter = 97 ; letter <= 122 ; letter++)
        {
            if (letter == 101 || letter == 113)
            {
        Console.Write((char)letter);
            }
        }
    }
}
