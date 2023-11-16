using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab10
{
    internal class BCipher : ICipher
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
                        chars[i] = (char)('Z' - (chars[i] - 'A'));
                    }
                    else
                    {
                        chars[i] = (char)('z' - (chars[i] - 'a'));
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
                        chars[i] = (char)('A' - (chars[i] - 'Z'));
                    }
                    else
                    {
                        chars[i] = (char)('a' - (chars[i] - 'z'));
                    }
                }
            }
            return new string(chars);
        }
    }
}
