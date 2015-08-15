using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HelloNetworks
{
    class RSA
    {
        private List<List<Int64>> multi_table;
        private bool ok;

        Int64 gcd(Int64 a, Int64 b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }

        Int64 bigmod(Int64 b, Int64 p, Int64 m)
        {
            if (p == 0)
                return 1;
            else if (p % 2 == 0)
                return (Int64)Math.Pow(bigmod(b, p / 2, m), 2.0) % m;
            else
                return ((b % m) * bigmod(b, p - 1, m)) % m;
        }

        public Int64 encrypt(Int64 PT, Int64 p, Int64 q)
        {
            Int64 n = p * q;
            Int64 phai = (p - 1) * (q - 1);
            Int64 e = 1;
            for (Int64 i = 2; i < phai - 1; i++)
            {
                Int64 temp = gcd(phai, i);
                if (temp == 1)
                {
                    e = i;
                    break;
                }
            }
            return bigmod(PT, e, n);
        }
    }
}