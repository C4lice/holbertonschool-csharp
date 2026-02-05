using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
<<<<<<< HEAD
        if (length <= 0)
        {
            Console.WriteLine("");
            return;
        }

        for (int i = 0; i < length; i++)
=======
        if (length > 0)
>>>>>>> ca18ba5d1b7e9b7b7fcfce28f431764956ac312c
        {
            for (int i = 0 ; i < length ; i++)
            {
                for (int Y = 0 ; Y < i ; Y++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\"); 
            }
        }
        Console.WriteLine("");
    }
}
