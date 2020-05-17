using System;

namespace acmicpc5622
{
    class Program
    {
        static void Main(string[] args)
        {
            // numbers for the alphabets
            int[] num = 
            {
                2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5,
                6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 9, 9, 9, 9
            };
            char[] alpha =
            {
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N'
                ,'O','P','Q','R','S','T','U','V','W','X','Y','Z'
            }; 

            int times = 0;      // total times for call_number
            int basic_time = 2; // to dial "1" need 2 seconds
            int index = 0;          // index for the alphabet

            // input call number
            string call_number = Console.ReadLine();

            // for all alphabet(call number)
            for(int i=0;i<call_number.Length;i++)
            {
                // find index for the alphabet
                for (int j = 0; j < alpha.Length; j++)
                    if (alpha[j] == call_number[i])
                        index = j;

                // "1" -> 2 sec + (call_alphabet-"1")
                times += basic_time + (num[index] - 1);
            }

            Console.WriteLine(times);
        }
    }
}
