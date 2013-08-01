using System;

namespace Problem_5_Subset_Sums
{
    class Problem_5_Subset_Sums
    {
        static void Main(string[] args)
        {
            long S = long.Parse(Console.ReadLine());
            byte N = byte.Parse(Console.ReadLine());

            long[] Values = new long[N];

            for (int i = 0; i < N; i++) 
            {
                Values[i] = long.Parse(Console.ReadLine());

            }

            
            int MaxSubsets = (int)Math.Pow(2, N) - 1;
            int count = (Convert.ToString(MaxSubsets, 2)).Length;
            long[] ValuesSubSets = new long[MaxSubsets];
            
            for (int i = 1; i <= MaxSubsets; i++)
            {

                for (int bitIndex = 0; bitIndex < count; bitIndex++)
                {
                    if ((i & (1 << bitIndex)) == (int)Math.Pow(2, bitIndex))
                    {
                        ValuesSubSets[i-1] += Values[bitIndex];
                    }
                }
     
                
            }

            ushort answer = 0;

            for (int i = 0; i < MaxSubsets; i++)
            {
                if (ValuesSubSets[i] == S)
                {
                    answer += 1;
                }
            }

            Console.WriteLine(answer);
     
            
        }
    }
}
