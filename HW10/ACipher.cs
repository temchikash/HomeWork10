using HW10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{

    internal class ACipher : ICipher
    {
        public string encode()
        {
            Console.WriteLine("Введите строку которую надо зашифровать:");
            string text = Console.ReadLine();
            StringBuilder list = new StringBuilder();
            foreach (char symbol in text)
            {
                if (symbol != 'z' && symbol != 'Z')
                    list.Append((char)(symbol + 1));
                else if (symbol == 'z')
                    list.Append('a');
                else list.Append('A');
            }
            return list.ToString();
        }
        public string decode()
        {
            Console.WriteLine("Введите строку которую надо расшифровать:");
            string text = Console.ReadLine();
            StringBuilder list = new StringBuilder();
            foreach (char symbol in text)
            {
                if (symbol != 'a' && symbol != 'A')
                    list.Append((char)(symbol - 1));
                else if (symbol == 'a')
                    list.Append('z');
                else list.Append('Z');
            }
            return list.ToString();
        }
    }
}
