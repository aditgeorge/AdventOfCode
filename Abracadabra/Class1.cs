using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abracadabra
{
    using System;
    using System.Linq;

    public class Class1
    {
        public static void Main()
        {
            Console.WriteLine("Class1");
            Console.Write("Input y to continue:");
            while (Console.ReadLine().Equals("y"))
            {
                int arrLen = int.Parse(Console.ReadLine());
                string binaryString = Console.ReadLine();
                Func(arrLen, binaryString);
                Console.Write("Input y to continue:");
            }
        }
        public static void Func(int arrLen, string binaryString)
        {
            arrLen -= 2;
            if (arrLen == 0)
            {
                Console.WriteLine(1);
                return;
            }
            int count = 0;
            int i = 0;
            int slope;
            if (binaryString[i].Equals('1'))
            {
                count++;
                i++;
                slope = 1;
            }
            else
            {
                i++;
                slope = 0;
            }

            while(i<arrLen)
            {
                while (binaryString[i].Equals(slope.ToString()[0]) && i < arrLen)
                    i++;
                //peak
                if (slope == 0 && i<arrLen)
                    count++;
                //invert slope
                slope = (slope + 1) % 2;
            }
            if (binaryString[i].Equals('0'))
                count++;
            if (binaryString[i].Equals('1') && binaryString[i - 1].Equals('0'))
                count++;

            Console.WriteLine(count);
        }

    }

}
