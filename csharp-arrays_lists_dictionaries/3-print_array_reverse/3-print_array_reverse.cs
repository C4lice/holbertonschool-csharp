using System;

class Array
{
    public static void Reverse(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i != 0)
            {
                Console.Write(" ");
            }   
        }
    }
}
