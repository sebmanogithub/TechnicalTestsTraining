using System.Text;

namespace Revisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            bool IsOk = HasStringAllUniqueCharacters("ferdzste");
            bool IsOk2 = HasStringAllUniqueCharacters("ferdzst");

            string reverseString = ReverseString("ferdzst");
            string newStr = SuppressAndOrder("jdemleo ekel kie");
        }

        static bool HasStringAllUniqueCharacters(string str)
        {
            HashSet<char> chars = new HashSet<char>();
            foreach (char c in str)
            {
                if (!chars.Add(c))
                {
                    return false;
                }
            }
            return true;

            //return str.Distinct().Count() == str.Length;
        }

        static string SuppressAndOrder(string str)
        {
            var chars = str
                        .ToLower()
                        .Where(c => !char.IsWhiteSpace(c))
                        .OrderBy(c => c)
                        .ToArray();

            return new string (chars);
        }

        static string ReverseString(string str)
        {
            char[] charStr = str.ToCharArray();
            charStr.Reverse();

            //return new string (charStr);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(str[str.Length - i - 1]);
            }

            //return sb.ToString();
            int j = str.Length;

            while (j > 0)
            {
                sb.Append(str[--j]);
            }
            s
            return sb.ToString();
        }
    }
}
