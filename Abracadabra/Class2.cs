using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abracadabra
{
    public class Class2
    {
        public static void Main()
        {
            int i = 4, n = 5;
            Console.WriteLine((new string('#', i)).PadLeft(n, ' '));
        }
    }
}
