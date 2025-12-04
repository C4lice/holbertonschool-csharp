using System;
class Program
{
    static void Main(string[] args)
    {
        for (int letter = 0 ; letter <= 98 ; letter++)
        {
            Console.WriteLine($"{letter} = 0x{letter.ToString("x")}");
        }
    }
}
