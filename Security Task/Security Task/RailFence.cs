using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Task
{
    class RailFence
    {
        

        char[,] makeArrayEncryption(string s, int depth)
        {
            int numCols = (s.Length / depth);
            if (s.Length % depth != 0)
                numCols++;
            char[,] arr = new char[depth, numCols];
            int index = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (index == s.Length)
                        break;
                    else
                        arr[i, j] = s[index++];
                }
                if (index == s.Length)
                    break;
            }
            return arr;
        }

        char[,] makeArrayDecryption(string s, int depth)
        {
            int numCols = (s.Length / depth);
            if (s.Length % depth != 0)
                numCols++;
            char[,] arr = new char[depth, numCols];
            int index = 0;
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    if (index == s.Length)
                        break;
                    else
                        arr[j, i] = s[index++];
                }
                if (index == s.Length)
                    break;
            }
            return arr;
        }


        string railFenceEncryption(char[,] arr)
        {
            string enc = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != '\0')
                        enc += arr[i, j];
                }
            }
            return enc;
        }

        string railFenceDecryption(char[,] arr)
        {
            string enc = "";
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[j, i] != '\0')
                        enc += arr[j, i];
                }
            }
            return enc;
        }

        public string encrypt(string PT, int depth)
        {
            PT = Utilities.removeSpaces(PT);
            char[,] arr = makeArrayEncryption(PT, depth);
            string CT = railFenceEncryption(arr);
            return CT;
        }

        public string decrypt(string CT, int depth)
        {
            CT = Utilities.removeSpaces(CT);
            char[,] arr = makeArrayDecryption(CT, depth);
            string PT = railFenceDecryption(arr);
            return PT;
        }
    }
}
