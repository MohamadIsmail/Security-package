using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Task
{
    class Hill_cipher
    {
        int[,] changeStrToVec(string str)
        {
            int[,] res = new int[str.Length, 1];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    res[i, 0] = str[i] - 'A';

                }
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    res[i, 0] = str[i] - 'a';
                }
            }
            return res;
        }
        string changeVecToStr(int[,] cipher)
        {
            string res ="";
            for (int i = 0; i < cipher.GetLength(0); i++)
            {
                cipher[i, 0] += 65;
               // char c= (char)cipher[i, 0];
                res = res + (char)cipher[i, 0];
               // res.Insert(i,Convert.ToString(c));
            }
            return res;
        }

        public int[,] CalculateCoFactorMat(int[,] key)
        {
            int n=key.GetLength(0),det;
            int [,]temp,res;
            res = new int[n, n];
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    temp = new int[n, n];
                    int i1 = 0;
                    for (int ii = 0; ii < n; ii++)
                    {
                        if (ii == i)
                            continue;
                        int j1 = 0;
                        for (int jj = 0; jj < n; jj++)
                        {
                            if (jj == j)
                                continue;
                            temp[i1,j1] = key[ii,jj];
                            j1++;
                        }
                        i1++;
                    }

                    /* Calculate the determinant */
                    det = Utilities.calculateDeterm(temp,n-1);

                    /* Fill in the elements of the cofactor */
                    double p=Convert.ToDouble( i+j+2.0f);
                    res[i,j] = Convert.ToInt32( Math.Pow(1.0f, p)) * det;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    res[i, j] = ((res[i, j] % 26)+26)%26;
            }
            return res;
        }
        public string encrypt(string PT, int[,] key)
        {
            PT = Utilities.removeSpaces(PT);
            int temp = key.GetLength(0);
            string EncRes = "";
            for (int i = 0; i < PT.Length; i += temp)
            {
                int[,] PTconverted = changeStrToVec(PT.Substring(i, temp));
                int[,] cipher = Utilities.multiply(key, PTconverted);
                for (int j = 0; j < cipher.GetLength(0); j++)
                {
                    cipher[j, 0] = ((cipher[j, 0] % 26)+26)%26;
                }
                EncRes = string.Concat(EncRes, changeVecToStr(cipher));
            }
            return EncRes;
        }

        public string decrypt(string CipherTxt, int[,] key)
        {
            string DecRes="";
            CipherTxt = Utilities.removeSpaces(CipherTxt);
            int det=Utilities.calculateDeterm(key,key.GetLength(0));
            int temp = key.GetLength(0);
            det = ((det % 26)+26)%26;
            /*if (27 % (26 - det) != 0)
            {
                return "";
            }*/
            int[,] InversedMat = CalculateCoFactorMat(key);

            InversedMat = Utilities.Transpose(InversedMat);
            int b = 26 - (27 / (26 - det));
            InversedMat = Utilities.elemWiseMult(b, InversedMat);
            for (int i = 0; i < CipherTxt.Length; i += temp)
            {
                int[,] CiConverted = changeStrToVec(CipherTxt.Substring(i, temp));
                int[,] PlainText = Utilities.multiply(InversedMat, CiConverted);
                for (int j = 0; j < PlainText.GetLength(0); j++)
                {
                    PlainText[j, 0] = ((PlainText[j, 0] % 26)+26)%26;
                }
                DecRes = string.Concat(DecRes, changeVecToStr(PlainText));
            }
            return DecRes;
        }
    }
}
