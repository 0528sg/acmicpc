using System;

namespace acmicpc2941
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] croatia= { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

            // change croatia alphabets to one alphabet.
            for (int i = 0; i < croatia.Length; i++)
            {
                input = input.Replace(croatia[i], "a");
            }

            Console.WriteLine(input.Length);
        } 
    }
}
