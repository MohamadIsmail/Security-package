using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Task
{
    class Columnar
    {

        
        char[,] makeArrayDecryption(string s, int[] key)
        {
            int numRows = (s.Length / key.Length);
            if (s.Length % key.Length != 0)
                numRows++;
            int count=0;
            int index = 0;
            string[] cols=new string[key.Length];
            for (int i = 0; i < s.Length; i++)
            {
                cols[index] += s[i];
                count++;
                if (count % numRows == 0)
                {
                    index++;
                    count = 0;
                }
            }
            char[,] arr = new char[numRows, key.Length];
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    arr[i, j] = cols[key[j] - 1][i];
                }
            }
            return arr;
        }

        char[,] makeArrayEncryption(string s,int keyLength)
        {
            int numRows = (s.Length / keyLength);
            if (s.Length % keyLength != 0)
                numRows++;
            char[,] arr = new char[numRows, keyLength];
            int index = 0;
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    if (index == s.Length)
                     arr[j, i] = 'q';
                    else
                        arr[j, i] = s[index++];
                }
                //if (index == s.Length)
                //    break;
            }
            return arr;
        }

        string columnarDecryption(char[,] arr)
        {
           
            string encryption="";
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    encryption += arr[j, i];
                }
            }
            for (int i = encryption.Length - 1; i >= 0; i--)
            {
                if (encryption[i] == 'q')
                {
                    encryption = encryption.Remove(i);
                }
                else
                    break;
            }
                return encryption;
        }

        string columnarEncryption(char[,] arr, int[] key)
        {
            string[] encryptionArr = new string[key.Length];

            for (int j = 0; j < key.Length; j++)
            {
                //encryptionArr[key[j] - 1] = "";
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    //if (arr[i, j] != '\0')
                        encryptionArr[key[j] - 1] += arr[i, j];
                }
            }

            string encryption = "";
            for (int i = 0; i < key.Length; i++)
            {
                encryption += encryptionArr[i];
            }
            return encryption;
        }


        public string encrypt(string PT, int[] key)
        {
            PT =Utilities. removeSpaces(PT);
            char[,] arr = makeArrayEncryption(PT,key.Length);
            string CT= columnarEncryption(arr, key);
            return CT;

        }

        public string decrypt(string CT, int[] key)
        {
            CT = Utilities.removeSpaces(CT);
            char[,] arr = makeArrayDecryption(CT, key);
            string PT = columnarDecryption(arr);
            return PT;

        }

    }
}
