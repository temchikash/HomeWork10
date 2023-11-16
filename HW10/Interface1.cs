using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal interface ICipher
    {
        string encode(string str);
        //зашифровка
        string decode(string str);
        //расшифровка
    }
}
