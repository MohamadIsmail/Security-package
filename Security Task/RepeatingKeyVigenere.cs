using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Security_Task
{
    class RepeatingKeyVigenere
    {
        string keyStream;


        public string encrypt(string keyword, string plainText)
        {
            keyStream = keyword;
            string cypherText = "";
            if (plainText.Length > keyword.Length)
            {
                int index = 0;
                for (int i = 0; i < plainText.Length - keyword.Length; i++)
                {
                    keyStream += keyword[index++];
                    if (index >= keyword.Length)
                        index = 0;
                }
            }

            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] + keyStream[i] - 97 >= 97 + 26)
                    cypherText += ((char)(plainText[i] + keyStream[i] - 97 - 26));
                else
                    cypherText += ((char)(plainText[i] + keyStream[i] - 97));
            }

            return cypherText;
        }

        public string decrypt(string key, string cypherText)
        {
            string plainText = "";
            char b;
            for (int i = 0; i < cypherText.Length; i++)
            {
                if (cypherText[i] - keyStream[i] <= 0)
                {
                    b = ((char)(cypherText[i] - keyStream[i] + 97 + 26));
                    if (b > 'z')
                        b = (char)(b - 26);
                    plainText += b;
                }
                else
                    plainText += ((char)(cypherText[i] - keyStream[i] + 97));
            }

            return plainText;
        }


    }
}
