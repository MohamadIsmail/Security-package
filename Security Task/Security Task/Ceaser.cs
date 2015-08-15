using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_Task
{
    public class Ceaser
    {
        
        static Utilities utilityObject = new Utilities();
        char[] charsToNumbersObject = utilityObject.getCharsToNumbersMap();

        public string Encrypt(string message , string key)
        {
            int tmp;
            string output="";
            message = utilityObject.messageFilter(message);
            for (int i = 0; i < message.Length; i++)
            {
                tmp = ((int)charsToNumbersObject[(int)message[i]-97] + Convert.ToInt32(key) - 97)%26 ;
                output += charsToNumbersObject[tmp];
            }
            output = utilityObject.toCapitalLetters(output);

                return output;
        }
        public string Decrypt(string message, string key)
        {
            int tmp;
            string output = "";
            message = utilityObject.messageFilter(message);
            for (int i = 0; i < message.Length; i++)
            {
                tmp = ((int)charsToNumbersObject[(int)message[i] - 97] - Convert.ToInt32(key) - 97) % 26;
                output += charsToNumbersObject[tmp];
            }
            output = utilityObject.toCapitalLetters(output);

            return output;
        }
    }
}
