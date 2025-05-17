namespace AreStringsPermutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reverseStr = ReverseString2("Hello Brandon");
        }

        static string ReverseString(string str)
        {
            char[] strArray = str.Reverse().ToArray();
            return new string(strArray);
        }

        static string ReverseString2(string str)
        {
            char[] strChars = str.ToCharArray();
            char[] arrayResult = new char[strChars.Length];

            for (int j = 0; j < strChars.Length; j++)
            {
                arrayResult[j] = strChars[strChars.Length - j - 1];
            }

            return new string(arrayResult);
        }
    }
}
