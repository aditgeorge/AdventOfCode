using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abracadabra
{
    public class Play
    {
        public static void Main()
        {
            string s = " abc ";
            List<char> l = new List<char>();
            foreach (char x in s)
            {
                l.Add(x);
            }
            foreach (char i in l)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("After emptying");
            l.RemoveAll(i => true);
            foreach(char i in l)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Remove over");
        }
    }
}
