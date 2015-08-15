using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Task
{
    class Utilities
    {
        char[] charsToNumbersMap;
        char[] charsToCharsMap;

        public Utilities()
        {
            charsToNumbersMap = new char[26];
            charsToCharsMap = new char[26];
            int index = 26;
            for (int i = 0; i < index; i++)
            {
                charsToNumbersMap[i] = Convert.ToChar(i + 97);
            }
        }

        public char[] setCharsToCharsMap(string key)
        {
            for (int i = 0; i < 26; i++)
                charsToCharsMap[i] = key[i];
            return charsToCharsMap;
        }

        public char[] getCharsToNumbersMap()
        {
            return charsToNumbersMap;
        }
        public char[] getCharsToCharsMap()
        {
            return charsToCharsMap;
        }

        public string messageFilter(string message)
        {
            StringBuilder tmp = new StringBuilder(message);
            for (int i = 0; i < tmp.Length; i++)
            {
                if ((int)tmp[i] > 64 && (int)tmp[i] < 91)
                    tmp[i] += (char)32;
            }
            message = tmp.ToString();
            return message;
        }
        public string toCapitalLetters(string text)
        {
            StringBuilder tmp = new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
            {
                tmp[i] -= (char)32;
            }
            text = tmp.ToString();
            return text;
        }
        public static int[,] multiply(int[,] arr1, int[,] arr2)
        {
            int[,] arr = new int[arr1.GetLength(0), arr2.GetLength(1)];
            int sum = 0;
            for (int c = 0; c < arr1.GetLength(0); c++)
            {
                for (int d = 0; d < arr2.GetLength(1); d++)
                {
                    for (int k = 0; k < arr2.GetLength(0); k++)
                        sum = sum + arr1[c, k] * arr2[k, d];

                    arr[c, d] = sum;
                    sum = 0;
                }
            }
            return arr;
        }
        public static string removeSpaces(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    s = s.Remove(i, 1);
                    i--;
                }
            }
            return s;
        }
        public static int calculateDeterm(int[,] key, int dim)
        {
            int res = 0;
            if (dim == 1)
                return key[0, 0];
            if (dim == 2)
            {
                res = key[0, 0] * key[1, 1] - key[0, 1] * key[1, 0];
            }
            else if (dim == 3)
            {
                res += key[0, 0] * ((key[1, 1] * key[2, 2]) - (key[1, 2] * key[2, 1]));

                res -= key[0, 1] * ((key[1, 0] * key[2, 2]) - (key[1, 2] * key[2, 0]));

                res += key[0, 2] * ((key[1, 0] * key[2, 1]) - (key[1, 1] * key[2, 0]));

            }
            return res;
        }
        public static int[,] Transpose(int[,] arr)
        {
            int tmp;
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tmp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = tmp;
                }
            }
            return arr;
        }
        public static int[,] elemWiseMult(int elem, int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                    mat[i, j] = (mat[i, j] * elem) % 26;
            }
            return mat;
        }
    }
}