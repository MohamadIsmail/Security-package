using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Task
{
    class Monoalphabetic
    {
        private Utilities utilityObject;
        private char[] charsToCharsObject;
        public Monoalphabetic()
        {

            utilityObject = new Utilities();
        }

        public string Encrypt(string PlainText, string key)
        {
            string output = "";
            utilityObject.setCharsToCharsMap(key);
            charsToCharsObject = utilityObject.getCharsToCharsMap();
            PlainText = utilityObject.messageFilter(PlainText);
            for (int i = 0; i < PlainText.Length; i++)
            {
                output += charsToCharsObject[(int)PlainText[i] - 97];
            }

            return output;
        }

        private char search(char c, string key)
        {
            char res = 'a';
            for (int i = 0; i < 26; i++)
            {
                if (c == key[i])
                    break;
                res++;
            }
            return res;
        }

        public string Decrypt(string cipherText, string Key)
        {
            string output = "";
            cipherText = utilityObject.messageFilter(cipherText);
            for (int i = 0; i < cipherText.Length; i++)
            {
                output += search(cipherText[i], Key);
            }

            return output;
        }
    }
}
