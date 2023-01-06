using MagicTools;
namespace Abracadabra
{
    public class Sample
    {
        public static void Main()
        {
            (var x, var y) = "Hello World".Split(' ');
            Console.WriteLine(x);
            Console.Write(y);
        }

    }
}
