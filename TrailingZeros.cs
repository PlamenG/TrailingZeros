using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class TrailingZeros
    {
    // * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
    // N = 10  N! = 3628800  2
	// N = 20  N! = 2432902008176640000  4
	// Does your program work for N = 50 000?
	// Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

        static void Main(string[] args)
        {
            Console.Write("Please, enter a value for N: "); 
            int N = int.Parse(Console.ReadLine());
            // The solution with the hint from the textbook:

            int result1 = 0;
            for (int i = 5; i <= N; i *= 5)
            {
                result1 = result1 + (N / i);
            }
            Console.WriteLine("Trailing zeroes of {0}! are {1}.", N, result1);



            // My solution:
            // Try with 50000 and have patiance - the calculation takes time (half a hour by PC). Answer is 12 499 - if you have the patiance wait and see for yourself.
            
            BigInteger Nfactorial = 1;
            for (int i = 1; i <= N; i++)
			{
			    Nfactorial *= i; 
			}
            // Nfactorial will converted to string so we can count how many numbers we have:

            Console.WriteLine("\n{0}! was calculated.\n", N);

            string NfactorialString = Convert.ToString(Nfactorial);

            BigInteger Count = NfactorialString.Count();

            // Nfactorial will be devided by zero - if there is no remainder the result be increase, else there is no need to continue hte loop.
            BigInteger result = 0;
            for (BigInteger i = 10; i < Nfactorial; i *= 10)
            {
                if ((Nfactorial % i) == 0)
                {
                    result += 1;
                }
                else
                {
                    break;
                }
               
            }

            Console.WriteLine("The trailing zeros of {0}! are {1}.\n", N, result);
        }
    }

