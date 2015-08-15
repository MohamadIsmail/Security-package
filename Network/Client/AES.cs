using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Client
{
    class AES
    {

        byte[,] S_Box;
        byte[,] invS_Box;
        byte[,] roundConst; 
        Dictionary<char, int> S_boxIndex;
       public AES()
        {
            build_SBox();
            build_invSBox();
            BuildRcon();
        }

        void build_SBox()
        {
            S_boxIndex = new Dictionary<char, int>();
            S_boxIndex.Add('A', 10);
            S_boxIndex.Add('B', 11);
            S_boxIndex.Add('C', 12);
            S_boxIndex.Add('D', 13);
            S_boxIndex.Add('E', 14);
            S_boxIndex.Add('F', 15);
            S_Box=new byte[,]     /*0*/  {
           {0x63, 0x7c, 0x77, 0x7b, 0xf2, 0x6b, 0x6f, 0xc5, 0x30, 0x01, 0x67, 0x2b, 0xfe, 0xd7, 0xab, 0x76},
    /*1*/  {0xca, 0x82, 0xc9, 0x7d, 0xfa, 0x59, 0x47, 0xf0, 0xad, 0xd4, 0xa2, 0xaf, 0x9c, 0xa4, 0x72, 0xc0},
    /*2*/  {0xb7, 0xfd, 0x93, 0x26, 0x36, 0x3f, 0xf7, 0xcc, 0x34, 0xa5, 0xe5, 0xf1, 0x71, 0xd8, 0x31, 0x15},
    /*3*/  {0x04, 0xc7, 0x23, 0xc3, 0x18, 0x96, 0x05, 0x9a, 0x07, 0x12, 0x80, 0xe2, 0xeb, 0x27, 0xb2, 0x75},
    /*4*/  {0x09, 0x83, 0x2c, 0x1a, 0x1b, 0x6e, 0x5a, 0xa0, 0x52, 0x3b, 0xd6, 0xb3, 0x29, 0xe3, 0x2f, 0x84},
    /*5*/  {0x53, 0xd1, 0x00, 0xed, 0x20, 0xfc, 0xb1, 0x5b, 0x6a, 0xcb, 0xbe, 0x39, 0x4a, 0x4c, 0x58, 0xcf},
    /*6*/  {0xd0, 0xef, 0xaa, 0xfb, 0x43, 0x4d, 0x33, 0x85, 0x45, 0xf9, 0x02, 0x7f, 0x50, 0x3c, 0x9f, 0xa8},
    /*7*/  {0x51, 0xa3, 0x40, 0x8f, 0x92, 0x9d, 0x38, 0xf5, 0xbc, 0xb6, 0xda, 0x21, 0x10, 0xff, 0xf3, 0xd2},
    /*8*/  {0xcd, 0x0c, 0x13, 0xec, 0x5f, 0x97, 0x44, 0x17, 0xc4, 0xa7, 0x7e, 0x3d, 0x64, 0x5d, 0x19, 0x73},
    /*9*/  {0x60, 0x81, 0x4f, 0xdc, 0x22, 0x2a, 0x90, 0x88, 0x46, 0xee, 0xb8, 0x14, 0xde, 0x5e, 0x0b, 0xdb},
    /*a*/  {0xe0, 0x32, 0x3a, 0x0a, 0x49, 0x06, 0x24, 0x5c, 0xc2, 0xd3, 0xac, 0x62, 0x91, 0x95, 0xe4, 0x79},
    /*b*/  {0xe7, 0xc8, 0x37, 0x6d, 0x8d, 0xd5, 0x4e, 0xa9, 0x6c, 0x56, 0xf4, 0xea, 0x65, 0x7a, 0xae, 0x08},
    /*c*/  {0xba, 0x78, 0x25, 0x2e, 0x1c, 0xa6, 0xb4, 0xc6, 0xe8, 0xdd, 0x74, 0x1f, 0x4b, 0xbd, 0x8b, 0x8a},
    /*d*/  {0x70, 0x3e, 0xb5, 0x66, 0x48, 0x03, 0xf6, 0x0e, 0x61, 0x35, 0x57, 0xb9, 0x86, 0xc1, 0x1d, 0x9e},
    /*e*/  {0xe1, 0xf8, 0x98, 0x11, 0x69, 0xd9, 0x8e, 0x94, 0x9b, 0x1e, 0x87, 0xe9, 0xce, 0x55, 0x28, 0xdf},
    /*f*/  {0x8c, 0xa1, 0x89, 0x0d, 0xbf, 0xe6, 0x42, 0x68, 0x41, 0x99, 0x2d, 0x0f, 0xb0, 0x54, 0xbb, 0x16} };
        }

        void build_invSBox()
        {

            invS_Box = new byte[,]   {
           {0x52, 0x09, 0x6a, 0xd5, 0x30, 0x36, 0xa5, 0x38, 0xbf, 0x40, 0xa3, 0x9e, 0x81, 0xf3, 0xd7, 0xfb},
    /*1*/  {0x7c, 0xe3, 0x39, 0x82, 0x9b, 0x2f, 0xff, 0x87, 0x34, 0x8e, 0x43, 0x44, 0xc4, 0xde, 0xe9, 0xcb},
    /*2*/  {0x54, 0x7b, 0x94, 0x32, 0xa6, 0xc2, 0x23, 0x3d, 0xee, 0x4c, 0x95, 0x0b, 0x42, 0xfa, 0xc3, 0x4e},
    /*3*/  {0x08, 0x2e, 0xa1, 0x66, 0x28, 0xd9, 0x24, 0xb2, 0x76, 0x5b, 0xa2, 0x49, 0x6d, 0x8b, 0xd1, 0x25},
    /*4*/  {0x72, 0xf8, 0xf6, 0x64, 0x86, 0x68, 0x98, 0x16, 0xd4, 0xa4, 0x5c, 0xcc, 0x5d, 0x65, 0xb6, 0x92},
    /*5*/  {0x6c, 0x70, 0x48, 0x50, 0xfd, 0xed, 0xb9, 0xda, 0x5e, 0x15, 0x46, 0x57, 0xa7, 0x8d, 0x9d, 0x84},
    /*6*/  {0x90, 0xd8, 0xab, 0x00, 0x8c, 0xbc, 0xd3, 0x0a, 0xf7, 0xe4, 0x58, 0x05, 0xb8, 0xb3, 0x45, 0x06},
    /*7*/  {0xd0, 0x2c, 0x1e, 0x8f, 0xca, 0x3f, 0x0f, 0x02, 0xc1, 0xaf, 0xbd, 0x03, 0x01, 0x13, 0x8a, 0x6b},
    /*8*/  {0x3a, 0x91, 0x11, 0x41, 0x4f, 0x67, 0xdc, 0xea, 0x97, 0xf2, 0xcf, 0xce, 0xf0, 0xb4, 0xe6, 0x73},
    /*9*/  {0x96, 0xac, 0x74, 0x22, 0xe7, 0xad, 0x35, 0x85, 0xe2, 0xf9, 0x37, 0xe8, 0x1c, 0x75, 0xdf, 0x6e},
    /*a*/  {0x47, 0xf1, 0x1a, 0x71, 0x1d, 0x29, 0xc5, 0x89, 0x6f, 0xb7, 0x62, 0x0e, 0xaa, 0x18, 0xbe, 0x1b},
    /*b*/  {0xfc, 0x56, 0x3e, 0x4b, 0xc6, 0xd2, 0x79, 0x20, 0x9a, 0xdb, 0xc0, 0xfe, 0x78, 0xcd, 0x5a, 0xf4},
    /*c*/  {0x1f, 0xdd, 0xa8, 0x33, 0x88, 0x07, 0xc7, 0x31, 0xb1, 0x12, 0x10, 0x59, 0x27, 0x80, 0xec, 0x5f},
    /*d*/  {0x60, 0x51, 0x7f, 0xa9, 0x19, 0xb5, 0x4a, 0x0d, 0x2d, 0xe5, 0x7a, 0x9f, 0x93, 0xc9, 0x9c, 0xef},
    /*e*/  {0xa0, 0xe0, 0x3b, 0x4d, 0xae, 0x2a, 0xf5, 0xb0, 0xc8, 0xeb, 0xbb, 0x3c, 0x83, 0x53, 0x99, 0x61},
    /*f*/  {0x17, 0x2b, 0x04, 0x7e, 0xba, 0x77, 0xd6, 0x26, 0xe1, 0x69, 0x14, 0x63, 0x55, 0x21, 0x0c, 0x7d} };
        }

        void BuildRcon()
        {
            roundConst = new byte[10, 4] {  
                                   {0x01, 0x00, 0x00, 0x00},
                                   {0x02, 0x00, 0x00, 0x00},
                                   {0x04, 0x00, 0x00, 0x00},
                                   {0x08, 0x00, 0x00, 0x00},
                                   {0x10, 0x00, 0x00, 0x00},
                                   {0x20, 0x00, 0x00, 0x00},
                                   {0x40, 0x00, 0x00, 0x00},
                                   {0x80, 0x00, 0x00, 0x00},
                                   {0x1b, 0x00, 0x00, 0x00},
                                   {0x36, 0x00, 0x00, 0x00} };
        } 

        void circularLeftShift(ref string[,] PTarr,int row)
        {
            string val = PTarr[row,0];
            for (int i = 1; i < 4; i++)
            {
                PTarr[row, i - 1] = PTarr[row, i];
            }
            PTarr[row, 3] = val;
        }

        void circularRightShift(ref string[,] PTarr, int row)
        {
            string val = PTarr[row, 3];
            for (int i = 2; i >= 0; i--)
            {
                PTarr[row, i + 1] = PTarr[row, i];
            }
            PTarr[row, 0] = val;
        }

        void circularUpShift(ref string[,] PTarr, int col)
        {
            string val = PTarr[0, col];
            for (int i = 1; i < 4; i++)
            {
                PTarr[i - 1,col] = PTarr[i, col];
            }
            PTarr[3, col] = val;
        }

        string[,] generateNewKey(string[,] key,int round)
        {
            string[,] originalKey = new string[4, 4];
            string[,] tempKey = new string[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    originalKey[i, j] = key[i, j];
                    tempKey[i, j] = key[i, j];
                }
            }
            string[,] newKey = new string[4, 4];
            circularUpShift(ref tempKey, 3);
            int row, col;
            for (int i = 0; i < 4; i++)
            {
                if (Char.IsLetter(tempKey[i, 3][0]))
                    row = S_boxIndex[Char.ToUpper(tempKey[i, 3][0])];
                else
                    row = tempKey[i, 3][0] - '0';
                if (Char.IsLetter(tempKey[i, 3][1]))
                    col = S_boxIndex[Char.ToUpper(tempKey[i, 3][1])];
                else
                    col = tempKey[i, 3][1] - '0';
                tempKey[i, 3] = String.Format("{0:X}", S_Box[row, col]^roundConst[round,i]);
                if (tempKey[i, 3].Length == 1)
                    tempKey[i, 3] = tempKey[i, 3].Insert(0, "0");
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0)
                        newKey[j, i] = String.Format("{0:X}", (Convert.ToByte(tempKey[j, 3], 16) ^ Convert.ToByte(originalKey[j, i], 16)));
                    else
                        newKey[j, i] = String.Format("{0:X}", (Convert.ToByte(originalKey[j, i], 16) ^ Convert.ToByte(newKey[j, i-1], 16)));
                    if (newKey[j, i].Length == 1)
                        newKey[j, i] = newKey[j, i].Insert(0, "0");
                }
            }
                    return newKey;
        }


        string[,] makeTable(string byteArr)
        {
            string[,] arr=new string[4,4];
            int index=0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //if (Char.IsLetter(byteArr[index]))
                    //    byteArr = Char.ToUpper(byteArr[index]);
                    arr[j, i] += byteArr[index++];
                    arr[j, i] += byteArr[index++];
                }
            }
            return arr;
        }

        void addRoundKey(ref string[,] arr, string[,] cipherKeyarr)
        {
            //string[,] round = new string[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int value = Convert.ToByte(arr[i, j], 16) ^ Convert.ToByte(cipherKeyarr[i, j], 16);
                    arr[i, j] = String.Format("{0:X}", value);
                    if (arr[i, j].Length == 1)
                        arr[i, j] = arr[i, j].Insert(0, "0");
                }
            }
        }

        void subBytes(ref string[,] PTarr)
        {
           // string[,] arr=new string[4,4];
            int row,col;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Char.IsLetter(PTarr[i, j][0]))
                        row = S_boxIndex[Char.ToUpper(PTarr[i, j][0])];
                    else
                        row = PTarr[i, j][0] - '0';
                    if (Char.IsLetter(PTarr[i, j][1]))
                        col = S_boxIndex[Char.ToUpper(PTarr[i, j][1])];
                    else
                        col = PTarr[i, j][1] - '0';
                    PTarr[i, j] = String.Format("{0:X}", S_Box[row, col]);
                    if (PTarr[i, j].Length == 1)
                        PTarr[i, j] = PTarr[i, j].Insert(0, "0");
                }
            }
        }

        void invSubBytes(ref string[,] CTarr)
        {
            // string[,] arr=new string[4,4];
            int row, col;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Char.IsLetter(CTarr[i, j][0]))
                        row = S_boxIndex[Char.ToUpper(CTarr[i, j][0])];
                    else
                        row = CTarr[i, j][0] - '0';
                    if (Char.IsLetter(CTarr[i, j][1]))
                        col = S_boxIndex[Char.ToUpper(CTarr[i, j][1])];
                    else
                        col = CTarr[i, j][1] - '0';
                    CTarr[i, j] = String.Format("{0:X}", invS_Box[row, col]);
                    if (CTarr[i, j].Length == 1)
                        CTarr[i, j] = CTarr[i, j].Insert(0, "0");
                }
            }
        }

        void shiftRows(ref string[,] PTarr)
        {
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    circularLeftShift(ref PTarr, i);
                }
            }
        }

        void invShiftRows(ref string[,] CTarr)
        {
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    circularRightShift(ref CTarr, i);
                }
            }
        }

        Byte GMul(Byte a, Byte b)
        { 
            Byte p = 0;
            Byte counter;
            Byte hi_bit_set;
            for (counter = 0; counter < 8; counter++)
            {
                if ((b & 1) != 0)
                {
                    p ^= a;
                }
                hi_bit_set = (Byte)(a & 0x80);
                a <<= 1;
                if (hi_bit_set != 0)
                {
                    a ^= 0x1b; /* x^8 + x^4 + x^3 + x + 1 */
                }
                b >>= 1;
            }
            return p;
        }

       void mixColumns(ref string[,] PTarr)
        {
            byte[,] byteArr = new byte[4, 4];
           // byte[,] temp = new byte[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    byteArr[i, j] = Convert.ToByte(PTarr[i, j], 16);
                }
            }

            for (int c = 0; c < 4; c++)
            {
                PTarr[0, c] = String.Format("{0:X}",(Byte)(GMul(0x02, byteArr[0, c]) ^ GMul(0x03, byteArr[1, c]) ^ byteArr[2, c] ^ byteArr[3, c]));
                if (PTarr[0, c].Length == 1)
                    PTarr[0, c] = PTarr[0, c].Insert(0, "0");
                PTarr[1, c] = String.Format("{0:X}", (Byte)(byteArr[0, c] ^ GMul(0x02, byteArr[1, c]) ^ GMul(0x03, byteArr[2, c]) ^ byteArr[3, c]));
                if (PTarr[1, c].Length == 1)
                    PTarr[1, c] = PTarr[1, c].Insert(0, "0");
                PTarr[2, c] = String.Format("{0:X}", (Byte)(byteArr[0, c] ^ byteArr[1, c] ^ GMul(0x02, byteArr[2, c]) ^ GMul(0x03, byteArr[3, c])));
                if (PTarr[2, c].Length == 1)
                    PTarr[2, c] = PTarr[2, c].Insert(0, "0");
                PTarr[3, c] = String.Format("{0:X}", (Byte)(GMul(0x03, byteArr[0, c]) ^ byteArr[1, c] ^ byteArr[2, c] ^ GMul(0x02, byteArr[3, c])));
                if (PTarr[3, c].Length == 1)
                    PTarr[3, c] = PTarr[3, c].Insert(0, "0");
            }
        }

       void invMixColumns(ref string[,] CTarr)
       {
           byte[,] byteArr = new byte[4, 4];
           for (int i = 0; i < 4; i++)
           {
               for (int j = 0; j < 4; j++)
               {
                   byteArr[i, j] = Convert.ToByte(CTarr[i, j], 16);
               }
           }

           for (int c = 0; c < 4; c++)
           {
               CTarr[0, c] = String.Format("{0:X}", (Byte)(GMul(0x0e, byteArr[0, c]) ^ GMul(0x0b, byteArr[1, c]) ^ GMul(0x0d, byteArr[2, c]) ^ GMul(0x09, byteArr[3, c])));
               if (CTarr[0, c].Length == 1)
                   CTarr[0, c] = CTarr[0, c].Insert(0, "0");
               CTarr[1, c] = String.Format("{0:X}", (Byte)(GMul(0x09, byteArr[0, c]) ^ GMul(0x0e, byteArr[1, c]) ^ GMul(0x0b, byteArr[2, c]) ^ GMul(0x0d, byteArr[3, c])));
               if (CTarr[1, c].Length == 1)
                   CTarr[1, c] = CTarr[1, c].Insert(0, "0");
               CTarr[2, c] = String.Format("{0:X}", (Byte)(GMul(0x0d, byteArr[0, c]) ^ GMul(0x09, byteArr[1, c]) ^ GMul(0x0e, byteArr[2, c]) ^ GMul(0x0b, byteArr[3, c])));
               if (CTarr[2, c].Length == 1)
                   CTarr[2, c] = CTarr[2, c].Insert(0, "0");
               CTarr[3, c] = String.Format("{0:X}", (Byte)(GMul(0x0b, byteArr[0, c]) ^ GMul(0x0d, byteArr[1, c]) ^ GMul(0x09, byteArr[2, c]) ^ GMul(0x0e, byteArr[3, c])));
               if (CTarr[3, c].Length == 1)
                   CTarr[3, c] = CTarr[3, c].Insert(0, "0");
           }
       }

       string tableToString(string[,] arr)
       {
           string s = "";
           for (int i = 0; i < 4; i++)
           {
               for (int j = 0; j < 4; j++)
               {
                   s += arr[j, i];
               }
           }
           return s;
       }

        public string encrypt(string PT,string cipherKey)
        {
            if(PT.Length!=cipherKey.Length&&PT.Length!=32)
                return null;
            string[,] PTarr = makeTable(PT);
            string[,] cipherKeyarr = makeTable(cipherKey);
            addRoundKey(ref PTarr, cipherKeyarr);
            for (int i = 0; i < 9; i++)
            {
                subBytes(ref PTarr);
                shiftRows(ref PTarr);
                mixColumns(ref PTarr);
                cipherKeyarr = generateNewKey(cipherKeyarr, i);
                addRoundKey(ref PTarr, cipherKeyarr);
            }
            subBytes(ref PTarr);
            shiftRows(ref PTarr);
            cipherKeyarr = generateNewKey(cipherKeyarr, 9);
            addRoundKey(ref PTarr, cipherKeyarr);
            string CT = tableToString(PTarr);
            return CT;
        }

        public string decrypt(string CT, string cipherKey)
        {
            if (CT.Length != cipherKey.Length && CT.Length != 32)
                return null;
            string[,] CTarr = makeTable(CT);
            List<string[,]> expandedKeys = new List<string[,]>();
            string[,] cipherKeyArr = makeTable(cipherKey);
            expandedKeys.Add(cipherKeyArr);
            for (int i = 0; i < 10; i++)
            {
                cipherKeyArr = generateNewKey(cipherKeyArr, i);
                expandedKeys.Add(cipherKeyArr);
            }
            addRoundKey(ref CTarr, expandedKeys[10]);
            invShiftRows(ref CTarr);
            invSubBytes(ref CTarr);
            for (int i = 9; i > 0; i--)
            {
                addRoundKey(ref CTarr, expandedKeys[i]);
                invMixColumns(ref CTarr);
                invShiftRows(ref CTarr);
                invSubBytes(ref CTarr);  
            }

            addRoundKey(ref CTarr, expandedKeys[0]);
            string PT = tableToString(CTarr);
            return PT;
        }

    }
}
