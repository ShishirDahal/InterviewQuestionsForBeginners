using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProj
{
    class PrimeNumber
    {
        public bool isPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                int rem = n % i;
                if (rem == 0)
                    return true;
            }
            return false;
        }

        public int countPrime(int n)
        {
            int c = 2;
            int last = n;
            for (int i = 3; i <= n/2+2; i++)
            {
                if (last != i)
                {
                    if (isPrime(i) == true)
                        c++;
                    if (isPrime(last) == true)
                    {
                        c++;
                        last--;
                    }
                }
                else
                {
                    if (isPrime(i) == true)
                        c++;
                }
            }
            return c;
        }
    }
}
