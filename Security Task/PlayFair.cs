using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Task
{
    class PlayFair
    {

        //key stuff

        private static string removeDuplicates(string key)
        {
            return new string(key.ToCharArray().Distinct().ToArray());
        }

        private char[,] matrixFilling(string key, char[] charsToNumbers)
        {
            char[,] matrix = new char[5, 5];
            string localKey = key;
            int count = 0;

            // appending the rest of alphabetes to the end of the localkey
            for (int x = 0; x < 26; x++)
            {
                if (!localKey.Contains(charsToNumbers[x]))
                {
                    localKey += charsToNumbers[x];
                }
            }

            localKey = localKey.Replace("j", "");
            //localKey += "koko";
            //Console.WriteLine(localKey);

            // generating the matrix
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = localKey[(i * 5) + j];
                    count++;
                }

            return matrix;
        }

        // message stuff 

        private string plainTextHandling(string message)
        {
            string localMessage = message;
            localMessage = localMessage.Replace('j', 'i');
            for (int i = 0; i < localMessage.Length - 1; i += 2)
            {
                if (localMessage[i] == localMessage[i + 1])
                    localMessage = localMessage.Insert(i + 1, "x");
            }

            if (localMessage.Length % 2 == 1)
                localMessage += "x";

            return localMessage;
        }

        private string[] toDiagrams(string plainText)
        {
            string[] diagrams = new string[plainText.Length / 2];
            for (int i = 0; i < plainText.Length / 2; i++)
            {
                diagrams[i] += plainText[i * 2];
                diagrams[i] += plainText[(i * 2) + 1];
            }
            return diagrams;
        }

        private string diagramsMapping(string[] digrams, char[,] matrix)
        {
            string cipher = "";
            int xi = 0, xj = 0, zi = 0, zj = 0;
            for (int x = 0; x < digrams.Length; x++)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] == digrams[x][0])
                        {
                            xi = i;
                            xj = j;
                        }
                        if (matrix[i, j] == digrams[x][1])
                        {
                            zi = i;
                            zj = j;
                        }

                    }

                // 1-same row 
                if (xi == zi)
                {
                    if (xj == 4 && zj < 4)
                    {
                        cipher += matrix[xi, 0];
                        cipher += matrix[zi, zj + 1];
                    }
                    else if (zj == 4 && xj < 4)
                    {
                        cipher += matrix[xi, xj + 1];
                        cipher += matrix[zi, 0];
                    }
                    else
                    {
                        cipher += matrix[xi, xj + 1];
                        cipher += matrix[zi, zj + 1];
                    }

                }
                // 2- same colum
                else if (xj == zj)
                {
                    if (xi == 4 && zi < 4)
                    {
                        cipher += matrix[0, xj];
                        cipher += matrix[zi + 1, zj];
                    }
                    else if (zi == 4 && xi < 4)
                    {
                        cipher += matrix[xi + 1, xj];
                        cipher += matrix[0, zj];
                    }
                    else
                    {
                        cipher += matrix[xi + 1, xj];
                        cipher += matrix[zi + 1, zj];
                    }


                }
                // 3- nor
                else
                {
                    cipher += matrix[xi, zj];
                    cipher += matrix[zi, xj];
                }
            }

            return cipher;
        }



        private string diagramsMappingDec(string[] digrams, char[,] matrix)
        {
            string cipher = "";
            int xi = 0, xj = 0, zi = 0, zj = 0;
            for (int x = 0; x < digrams.Length; x++)
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] == digrams[x][0])
                        {
                            xi = i;
                            xj = j;
                        }
                        if (matrix[i, j] == digrams[x][1])
                        {
                            zi = i;
                            zj = j;
                        }

                    }

                // 1-same row 
                if (xi == zi)
                {
                    if (xj == 0 && zj >0)
                    {
                        cipher += matrix[xi, 4];
                        cipher += matrix[zi, zj - 1];
                    }
                    else if (zj == 0 && xj >0)
                    {
                        cipher += matrix[xi, xj - 1];
                        cipher += matrix[zi, 4];
                    }
                    else
                    {
                        cipher += matrix[xi, xj - 1];
                        cipher += matrix[zi, zj - 1];
                    }

                }
                // 2- same colum
                else if (xj == zj)
                {
                    if (xi == 0 && zi >0)
                    {
                        cipher += matrix[4, xj];
                        cipher += matrix[zi - 1, zj];
                    }
                    else if (zi == 0 && xi >0)
                    {
                        cipher += matrix[xi - 1, xj];
                        cipher += matrix[4, zj];
                    }
                    else
                    {
                        cipher += matrix[xi - 1, xj];
                        cipher += matrix[zi - 1, zj];
                    }


                }
                // 3- nor
                else
                {
                    cipher += matrix[xi, zj];
                    cipher += matrix[zi, xj];
                }
            }

            return cipher;
        }

        // final function
        public string Encrypt(string plainText, string key)
        {
            string localMessage;
            string localKey;
            char[,] localMatrix;
            string[] localDiagrams;
            string localCipher;
            Utilities utilityObject = new Utilities();
            char[] charsToNumbersObject = utilityObject.getCharsToNumbersMap();


            //filter message and key
            localMessage = utilityObject.messageFilter(plainText);
            localKey = utilityObject.messageFilter(key);

            // working on key >>

            // remove key duplication
            localKey = removeDuplicates(localKey);
            // matrix generation
            localMatrix = matrixFilling(localKey, charsToNumbersObject);

            // working on message >>

            // message handling
            localMessage = plainTextHandling(localMessage);
            // convert message to diagrams
            localDiagrams = toDiagrams(localMessage);
            // generating Cipher
            localCipher = diagramsMapping(localDiagrams, localMatrix);
            // to Capital Letters
            localCipher = utilityObject.toCapitalLetters(localCipher);

            return localCipher;
        }

        public string Decrypt(string CipherText, string key)
        {
            string localMessage;
            string localKey;
            char[,] localMatrix;
            string[] localDiagrams;
            string localCipher;
            Utilities utilityObject = new Utilities();
            char[] charsToNumbersObject = utilityObject.getCharsToNumbersMap();


            //filter message and key
            localMessage = utilityObject.messageFilter(CipherText);
            localKey = utilityObject.messageFilter(key);

            // working on key >>

            // remove key duplication
            localKey = removeDuplicates(localKey);
            // matrix generation
            localMatrix = matrixFilling(localKey, charsToNumbersObject);

            // working on message >>

            // message handling
            localMessage = plainTextHandling(localMessage);
            // convert message to diagrams
            localDiagrams = toDiagrams(localMessage);
            // generating Cipher
            localCipher = diagramsMappingDec(localDiagrams, localMatrix);
           // localCipher = diagramsMapping(localDiagrams, localMatrix);
            // to Capital Letters
            localCipher = utilityObject.toCapitalLetters(localCipher);

            return localCipher;
        }

    }
}
