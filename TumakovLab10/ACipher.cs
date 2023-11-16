using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab10
{
    internal class ACipher : ICipher
    {
        public string encode(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (char.IsUpper(chars[i]))
                    {
                        chars[i] = (char)(((chars[i] - 'A' + 1) % 26) + 'A');
                    }
                    else
                    {
                        chars[i] = (char)(((chars[i] - 'a' + 1) % 26) + 'a');
                    }
                }
            }
            return new string(chars);
        }
        public string decode(string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (char.IsUpper(chars[i]))
                    {
                        chars[i] = (char)(((chars[i] - 'A' - 1) % 26) + 'A');
                    }
                    else
                    {
                        chars[i] = (char)(((chars[i] - 'a' - 1) % 26) + 'a');
                    }
                }
            }
            return new string(chars);
        }
    }
}
