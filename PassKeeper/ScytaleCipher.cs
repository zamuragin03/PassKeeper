using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeper
{
    class ScytaleCipher
    {
        public string Encrypt(string text, int d)
        {
            var k = text.Length % d;
            if (k > 0)
            {
                text += new string(' ', d - k);
            }

            var column = text.Length / d;
            var result = "";

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    result += text[i + column * j].ToString();
                }
            }

            return result;
        }

        public string Decrypt(string text, int d)
        {
            var column = text.Length / d;
            var symbols = new char[text.Length];
            int index = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    symbols[i + column * j] = text[index];
                    index++;
                }
            }

            return string.Join("", symbols);
        }
    }
}
