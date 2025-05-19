namespace AreStringsPermutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPerm = IsStringAPermutation("freref");
            bool isPerm2 = IsStringAPermutation2("laval");
            bool isPerm3 = IsStringAPermutation3("laval");
        }

        static bool IsStringAPermutation(string str)
        {
            char[] strArray = str.ToCharArray();
            char temp;

            int lenght = str.Length;

            for (int i = 0; i < strArray.Length / 2; i++)
            {
                temp = strArray[i];
                strArray[i] = str[lenght - 1 - i];
                strArray[lenght - 1 - i] = temp;
            }

            return str == new string(strArray);
        }

        static bool IsStringAPermutation2(string str)
        {
            char[] reversed = str.ToCharArray();
            int start = 0;
            int end = reversed.Length - 1;

            while (start < end)
            {
                char temp = reversed[start];
                reversed[start] = reversed[end];
                reversed[end] = temp;

                start++;
                end--;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != reversed[i])
                    return false;
            }

            return true;
        }

        static bool IsStringAPermutation3(string str)
        {
            return str == new string(str.Reverse().ToArray());
        }
    }
}
