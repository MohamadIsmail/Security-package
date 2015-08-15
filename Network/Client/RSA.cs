using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Client
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


        public Int64 decrypt(Int64 CT, Int64 p, Int64 q)
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
            Int64 d = calculate_table(e, phai);

            return bigmod(CT, d, n);
        }
        public Int64 calculate_table(Int64 number, Int64 Base)
        {
            multi_table = new List<List<Int64>>();
            ok = true;
            AddToList(0, 1, 0, Base, 0, 1, number);
            for (int i = 1; ; i++)
            {
                if (multi_table[i - 1][6] == 0)
                {
                    ok = false;
                    return 0;
                }
                if (multi_table[i - 1][6] == 1)
                {
                    multi_table[i - 1][5] %= 26;
                    if (multi_table[i - 1][5] < 0)
                        multi_table[i - 1][5] += 26;
                    return multi_table[i - 1][5];
                }
                Int64 Q = multi_table[i - 1][3] / multi_table[i - 1][6];
                Int64 A1 = multi_table[i - 1][4];
                Int64 A2 = multi_table[i - 1][5];
                Int64 A3 = multi_table[i - 1][6];
                Int64 B1 = multi_table[i - 1][1] - Q * multi_table[i - 1][4];
                Int64 B2 = multi_table[i - 1][2] - Q * multi_table[i - 1][5];
                Int64 B3 = multi_table[i - 1][3] % multi_table[i - 1][6];
                AddToList(Q, A1, A2, A3, B1, B2, B3);
            }
        }
        void AddToList(params Int64[] list)
        {
            List<Int64> temp = new List<Int64>();
            for (int i = 0; i < list.Length; i++)
            {
                temp.Add(list[i]);
            }
            multi_table.Add(temp);
        }
    }
}