namespace MagicTools
{
    public static class ArrayExtensions
    {
        public static void Deconstruct<T>(this T[] array, out T first, out T second) 
        {
            if (array.Length != 2)
                throw new Exception("MagicTool: Array length isn't 2. Can't deconstruct to 2 variablres ");
            first = array[0];
            second = array[1];
        }
    }
}
