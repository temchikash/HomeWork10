using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class BCipher : ICipher
    {
        public string decode()
        {
            Console.WriteLine("Введите строку которую надо зашифровать:");
            string text = Console.ReadLine();
            StringBuilder list = new StringBuilder();
            foreach (char symbol in text)
            {
                if (Char.IsUpper(symbol))
                {
                    list.Append((char)(155 - symbol));
                }
                else
                {
                    list.Append((char)(219 - symbol));
                }
            }
            return list.ToString();
        }

        public string encode()
        {
            return decode();
        }
    }
}
