using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Task
{
    class Multiplicative_Inverse
    {
        public List<List<int>> multi_table;
        public bool ok;
        public int calculate_inverse(int number, int Base){
            multi_table = new List<List<int>>();
            ok = true;
            AddToList(0, 1, 0,Base,0,1,number);
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
                    return multi_table[i-1][5];
                }
                int Q = multi_table[i - 1][3] / multi_table[i - 1][6];
                int A1 = multi_table[i - 1][4];
                int A2 = multi_table[i - 1][5];
                int A3 = multi_table[i - 1][6];
                int B1 = multi_table[i - 1][1] - Q * multi_table[i - 1][4];
                int B2 = multi_table[i - 1][2] - Q * multi_table[i - 1][5];
                int B3 = multi_table[i - 1][3] % multi_table[i - 1][6];
                AddToList(Q, A1, A2, A3, B1, B2, B3);
            }
            return 0;
        }
        void AddToList(params int[] list)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < list.Length; i++)
            {
                temp.Add(list[i]);
            }
            multi_table.Add(temp);
        }
    }
}
