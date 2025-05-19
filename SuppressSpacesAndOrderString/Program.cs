namespace SuppressSpacesAndOrderString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "Zorro est arrivé";
            string result = SuppressAndOrder(test);
            Console.WriteLine(result);
        }
        static string SuppressAndOrder(string str)
        {
            char[] arrayString = str
                    .ToLower()
                    .Where(c => !char.IsWhiteSpace(c))
                    .OrderBy(c => c)
                    .ToArray();

            return new string(arrayString);
        }
    }
}
